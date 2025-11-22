using GlamWire_Case_Cracked.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GlamWire_Case_Cracked;

/// <summary>
/// GlamwireDb class extracts information/data from the database and helps distribute it 
/// throughout the program with the help of the GlamwireDbContext.
/// <see cref="GlamwireDbContext"/>
/// </summary>
public class GlamwireDb
{
    /// <summary>
    /// initializes a new instance of the GlamwireDb, 
    /// retrieves data from the database and populates it into the application
    /// </summary>
    public GlamwireDb()
    {
        try
        {
            // Code to connect to the database and retrieve data goes here
            using SqlConnection connection = new SqlConnection(ConnectionString);
        }
        catch (SqlException ex)
        {
            // Handle exceptions related to database connection and data retrieval
            MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}");
        }
    }


    /// <summary>
    /// Retrieve all NPCs from the database
    /// </summary>
    /// <param name="npcId"></param>
    /// <returns></returns>
    public List<NPC> RetrieveAllNPCs(int npcId)
    {
        List<NPC> npcs = new List<NPC>();

        // placeholder to retrieve all NPCs from the database to populate and move them.
        // // "hey program, try using the connection string to connect to the database"
        try
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            // open the connection (a bridge to the database)
            connection.Open();

            // create the query to reference the NPC table, just for readability. 
            string query = @"SELECT * FROM NPC";
            using SqlCommand cmd = new SqlCommand(query, connection);
            // use the reader to execute the command and read it from the database.
            using SqlDataReader reader = cmd.ExecuteReader();

            // use a while loop to read each row of data. 
            // while there is data to read, keep reading it. 
            // if not, exit the loop.
            while (reader.Read())
            {
                // adding a new npc object to the npc list. 
                npcs.Add(new NPC {
                    // go through each column of the NPC table
                    // and read the data (if any) into the npc object properties.
                    NPCId = Convert.ToInt32(reader["NPCId"]),
                    NPCFirstName = Convert.ToString(reader["NPCFirstName"]),
                    NPCLastName = Convert.ToString(reader["NPCLastName"]),
                    NPCUsername = Convert.ToString(reader["NPCUsername"]),
                    NPCRole = Convert.ToString(reader["NPCRole"]),
                    PersonalityType = Convert.ToString(reader["PersonalityType"]),
                    IsLocked = Convert.ToBoolean(reader["IsLocked"]),
                    IsGuilty = Convert.ToBoolean(reader["isGuilty"]),
                });
            }
        }

        catch (SqlException ex) {

            // I think copying the generic exception handler is fine for now.
            MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}");
        }
        return npcs;
    }


    /// <summary>
    /// Retrieves a list of NPCs associated with a specific case.
    /// Typically, an active case. 
    /// </summary>
    /// <param name="caseId">The identifier of the case for which to retrieve NPCs.</param>
    /// <param name="connectionString">The connection string used to access the database.</param>
    /// <returns>A list of <see cref="NPC"/> objects involved in the specified case. Returns an empty list if no NPCs are
    /// associated with the case.</returns>
    public static List<NPC> GetNPCsForCase(int caseId)
    { 
        List<NPC> caseNPCS = new List<NPC>();

        try
        {
            using SqlConnection connection = new SqlConnection(GameContext.ConnectionString);
            // open the connection (a bridge to the database)
            connection.Open();

            // create a string query that selects from NPC WHERE the caseid and that NPC match
            // combine both the Case and the NPC table to make CaseNPC
            string query = @"SELECT n.* FROM NPC n
                              INNER JOIN CaseNPC cn ON n.NPCId = cn.NPCId
                             WHERE cn.CaseId = @caseId";
            // create command line w/ params (to the caseId)
            using SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue(@"caseId", caseId);
        }
        catch (SqlException ex)
        {
            MessageBox.Show($"An error occurred while trying to JOIN NPC/Cases from database: {ex.Message}");
        }
            return caseNPCS;
    }

    /// <summary>
    /// Retrieves a list of active cases from the database.
    /// </summary>
    /// <remarks>This method connects to the database to retrieve all cases and filters them based on their
    /// active status. It populates each case with its associated non-player characters (NPCs) using the
    /// <c>GetNPCsForCase</c> method.</remarks>
    /// <param name="caseId">The unique identifier of the case to retrieve.</param>
    /// <returns>A list of <see cref="Case"/> objects representing the active cases. The list will be empty if no active cases
    /// are found.</returns>
    public static Case RetrieveActiveCase(int caseId)
    {
        Case caseObj = null;

        using SqlConnection connection = new SqlConnection(GameContext.ConnectionString);
        connection.Open();

        string query = @"SELECT * FROM Cases WHERE CaseID = @CaseId";
        using SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@CaseId", caseId);

        using SqlDataReader reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            caseObj = new Case
            {
                CaseID = Convert.ToInt32(reader["CaseID"]),
                CaseTitle = reader["CaseTitle"].ToString(),
                CaseSummary = reader["CaseSummary"].ToString(),
                Difficulty = Convert.ToInt32(reader["Difficulty"]),
                Reward = Convert.ToInt32(reader["Reward"]),
                IsSolved = Convert.ToBoolean(reader["IsSolved"]),
                InvolvedNPCs = GetNPCsForCase(caseId)
            };
        }

        return caseObj;
    }
}

