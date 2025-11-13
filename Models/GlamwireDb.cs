using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace GlamWire_Case_Cracked.Models;

public class GlamwireDb
{
    // string connection to the Glamwire database 
    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GlamwireDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    /// <summary>
    /// initializes a new instance of the GlamwireDb, 
    /// retrieves data from the database and populates it into the application
    /// </summary>
    public GlamwireDb()
    {
        try
        {
            // Code to connect to the database and retrieve data goes here
            using SqlConnection connection = new SqlConnection(connectionString);
        }
        catch (Exception ex)
        {
            // Handle exceptions related to database connection and data retrieval
            Console.WriteLine($"An error occurred while connecting to the database: {ex.Message}");
        }
    }


    // retrieve all NPCs from the database
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
                    NPCId = npcId,
                    NPCFirstName = reader["NPCFirstName"].ToString(),
                    NPCLastName = reader["NPCLastName"].ToString(),
                    NPCUsername = reader["NPCUsername"].ToString(),
                    NPCRole = reader["NPCRole"].ToString(),
                    PersonalityType = reader["PersonalityType"].ToString(),
                    IsLocked = Convert.ToBoolean(reader["IsLocked"]),
                    IsGuilty = Convert.ToBoolean(reader["isGuilty"]),
                });
            }
        }

        catch (Exception ex) {

            // I think copying the generic exception handler is fine for now.
            Console.WriteLine($"An error occurred while connecting to the database: {ex.Message}");
        }
        return npcs;
    }

    // retrieve NPCs, case by case. The rest will remain locked/unpopulated, 
    // if they are not involved in the case.
    // add method here (GetNPCsForCase()) to retrieve NPCs for a specific case.

    // retrieve all cases from the database, then we can filter them later active or locked.
    public List<Case> RetrieveActiveCase(int caseId) {
        
        // placeholder to retrieve all cases from the database to populate and move them. 
        List<Case> cases = new();
        try
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            // open the connection (a bridge to the database)
            connection.Open();

            // create the query to reference the Case table, just for readability.
            string query = @"SELECT * FROM Cases";
            using SqlCommand cmd = new SqlCommand(query, connection);
            // use the reader to execute the command and read it from the database.
            using SqlDataReader reader = cmd.ExecuteReader();

            // use a while loop to read each row of data. 
            // while there is data to read, keep reading it. 
            // if not, exit the loop.
            // apparently, ID is all caps.. my mistake

            // go through each column of the NPC table
            // and read the data (if any) into the npc object properties.
            while (reader.Read())
            {
                cases.Add(new Case
                {
                    CaseID = Convert.ToInt32(reader["CaseID"]),
                    CaseTitle = reader["CaseTitle"].ToString(),
                    CaseSummary = reader["CaseSummary"].ToString(),
                    Difficulty = Convert.ToInt32(reader["Difficulty"]),
                    Reward = Convert.ToInt32(reader["Reward"]),
                    IsSolved = Convert.ToBoolean(reader["IsSolved"]),
                    SaveFile = Convert.ToInt32(reader["SaveFile"]),
                    InvolvedNPCs = GetNPCsForCase(caseId, connectionString) // populate the list
                });
            }
        }

        catch (Exception ex)
        {
            // I think copying the generic exception handler is fine for now.
            Console.WriteLine($"An error occurred while connecting to the database: {ex.Message}");
        }
        // null return (CHANGES NEEDED) 
        return cases;
    }
}

