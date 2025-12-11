using GlamWire_Case_Cracked.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
    private readonly string _conn;

    public GlamwireDb()
    {
        // Read connection string from App.config
        _conn = ConfigurationManager.ConnectionStrings["GlamwireDb"].ConnectionString;
    }

    // -------------------- SAVEFILE TABLE ------------------------------

    /// <summary>
    /// This method creates a new save file in the database when the 
    /// player clicks start on the player name screen after selecting new game
    /// on the main form
    /// </summary>
    /// <param name="saveFile"></param>
    public void CreateSaveFile (SaveFile saveFile)
    {
        try
        {
            GlamwireDb db = new GlamwireDb();
            using SqlConnection connection = new SqlConnection(_conn);
            // open the connection to the dataase
            connection.Open();
            //String Query 
            string query = @"INSERT INTO SaveFile (PlayerName, LastPlayed, SolvedCases)
                             VALUES (@playerName, @lastPlayed, @solvedCases)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@SaveId", saveFile.SaveFileID);
            cmd.Parameters.AddWithValue("@playerName", saveFile.PlayerName);
            cmd.Parameters.AddWithValue("@lastPlayed", saveFile.LastPlayed);
            cmd.Parameters.AddWithValue("@solvedCases", saveFile.SolvedCases);

            cmd.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            MessageBox.Show($"An Error has occurred while trying to create a new save file. , {ex.Message} ");
        }
    }

    /// <summary>
    /// Deletes the actively selected save file
    /// </summary>
    /// <param name="saveFile"></param>
    public void DeleteSaveFile(SaveFile saveFile)
    {
        try
        {
            GlamwireDb db = new GlamwireDb();
            using SqlConnection connection = new SqlConnection(_conn);
            connection.Open();

            string query = "DELETE FROM SaveFile WHERE SaveId = @saveId";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@SaveId", saveFile.SaveFileID);
            cmd.Parameters.AddWithValue("@playerName", saveFile.PlayerName);
            cmd.Parameters.AddWithValue("@lastPlayed", saveFile.LastPlayed);
            cmd.Parameters.AddWithValue("@solvedCases", saveFile.SolvedCases);

            cmd.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            MessageBox.Show($"An Error has occurred while trying to delete a save file. , {ex.Message} ");
        }
    }


    /// <summary>
    /// This methods Overwrites/updates an existing save file in the database. 
    /// </summary>
    /// <param name="saveFile"></param>
    public void OverwriteSaveFile (SaveFile saveFile)
    {
        try
        {
            GlamwireDb db = new GlamwireDb();
            using SqlConnection connection = new SqlConnection(_conn);
            // open the connection to the dataase
            connection.Open();
            //String Query
            string query = @"UPDATE SaveFile
                             SET PlayerName = @playerName,
                                 LastPlayed = @lastPlayed,
                                 SolvedCases = @solvedCases
                           WHERE SaveId = @saveId";
            using SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@SaveId", saveFile.SaveFileID);
            cmd.Parameters.AddWithValue("@Name", saveFile.PlayerName);
            cmd.Parameters.AddWithValue("@Wallet", saveFile.Wallet);
            cmd.Parameters.AddWithValue("@LastPlayed", saveFile.LastPlayed);
            cmd.Parameters.AddWithValue("@SolvedCases", saveFile.SolvedCases);
        }
        catch (SqlException ex)
        {
            MessageBox.Show($"An Error has occurred while trying to update your save file., {ex.Message} ");
        }
    }

    /// <summary>
    /// This retrieves ALL save files for the save file form
    /// </summary>
    /// <param name="saveId"></param>
    /// <returns></returns>
    public List<SaveFile> RetrieveSaveFiles ()
    {
        var saves = new List<SaveFile>();

        try
        {
            GlamwireDb db = new GlamwireDb();

            using SqlConnection connection = new SqlConnection(_conn);
            // open the connection to the dataase
            connection.Open();
            //String Query 
            string query = @"SELECT * FROM SaveFile";
            using SqlCommand cmd = new SqlCommand(query, connection);
            // use the reader to execute the command and read it from the database.
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                saves.Add(new SaveFile
                {
                    SaveFileID = Convert.ToInt32(reader["SaveId"]),
                    PlayerName = Convert.ToString(reader["PlayerName"]),
                    LastPlayed = Convert.ToDateTime(reader["LastPlayed"]),
                    SolvedCases = Convert.ToInt32(reader["SolvedCases"])
                });
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show($"An Error has occurred while trying to load ALL your saves., {ex.Message}");
        }
        return saves;
    }

    // -------------------- CASENPC/NPC TABLE ------------------------------

    /// <summary>
    /// Retrieve all NPCs from the database
    /// </summary>
    /// <param name="npcId"></param>
    /// <returns></returns>
    public List<NPC> RetrieveAllNPCs(int npcId)
    {
        var npcs = new List<NPC>();

        // placeholder to retrieve all NPCs from the database to populate and move them.
        // // "hey program, try using the connection string to connect to the database"
        try
        {
            GlamwireDb db = new GlamwireDb();

            using SqlConnection connection = new SqlConnection(_conn);
            // open the connection (a bridge to the database)
            connection.Open();

            // create the query to reference the NPC table, just for readability. 
            string query = @"SELECT * FROM NPC";
            using SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@npcId", npcId);
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
                    Role = Convert.ToString(reader["Role"]),
                    PersonalityType = Convert.ToString(reader["PersonalityType"]),
                    AvatarURL = Convert.ToString(reader["AvatarURL"]),
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
    /// <returns>A list of <see cref="NPC"/> objects involved in the specified case. Returns an empty list if no NPCs are
    /// associated with the case.</returns>
    public List<CaseNPC> GetNPCsForCase(int caseId)
    {
        var caseNPCs = new List<CaseNPC>();

        try
        {
            using SqlConnection connection = new SqlConnection(_conn);
            connection.Open();

            // the query is formatted in a way i feel all three tables are 
            // seen (to know the difference)
            string query = @"SELECT cn.CaseId, 
                    c.CaseTitle, 
                    c.CaseSummary,
                    c.Difficulty,
                    c.Reward, 
                    c.IsSolved,
                    n.NPCId, 
                    n.NPCFirstName, 
                    n.NPCLastName, 
                    n.NPCUsername, 
                    n.PersonalityType, 
                    n.CriminalHistory, 
                    n.Role,
                    n.AvatarURL,
                    n.IsLocked,
                    n.IsGuilty
                FROM CaseNPC cn
                INNER JOIN NPC n ON n.NPCId = cn.NPCId
                INNER JOIN Cases AS c ON c.CaseId = cn.CaseId
                WHERE cn.CaseId = @caseId";

            using SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@caseId", caseId);

            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var npc = new NPC
                {
                    NPCId = Convert.ToInt32(reader["NPCId"]),
                    NPCFirstName = Convert.ToString(reader["NPCFirstName"]),
                    NPCLastName = Convert.ToString(reader["NPCLastName"]),
                    NPCUsername = Convert.ToString(reader["NPCUsername"]),
                    PersonalityType = Convert.ToString(reader["PersonalityType"]),
                    CriminalHistory = Convert.ToString(reader["CriminalHistory"]),
                    Role = Convert.ToString(reader["Role"]),
                    AvatarURL = Convert.ToString(reader["AvatarURL"]),
                    IsLocked = Convert.ToBoolean(reader["IsLocked"]),
                    IsGuilty = Convert.ToBoolean(reader["IsGuilty"]),
                };

                var cases = new Case
                {
                    CaseID = Convert.ToInt32(reader["CaseID"]),
                    CaseTitle = reader["CaseTitle"].ToString(),
                    CaseSummary = reader["CaseSummary"].ToString(),
                    Difficulty = Convert.ToInt32(reader["Difficulty"]),
                    Reward = Convert.ToInt32(reader["Reward"]),
                    IsSolved = Convert.ToBoolean(reader["IsSolved"])
                };

                var caseNpc = new CaseNPC
                {
                    CaseId = cases.CaseID,
                    NPCId = npc.NPCId,
                    Case = cases,
                    NPC = npc,
                };

                caseNPCs.Add(caseNpc);
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("The Error is Occuring in the GetNPCSForCase()!"
                + $" Database error: {ex.Message}");
        }

        return caseNPCs;
    }

    // -------------------- CASES TABLE ------------------------------

    /// <summary>
    /// Retrieves a list of active cases from the database.
    /// </summary>
    /// <remarks>This method connects to the database to retrieve all cases and filters them based on their
    /// active status. It populates each case with its associated non-player characters (NPCs) using the
    /// <c>GetNPCsForCase</c> method.</remarks>
    /// <param name="caseId">The unique identifier of the case to retrieve.</param>
    /// <returns>A list of <see cref="Case"/> objects representing the active cases. The list will be empty if no active cases
    /// are found.</returns>
    public Case RetrieveActiveCase(int caseId)
    {
        Case caseObj = null;        
        using SqlConnection connection = new SqlConnection(_conn);
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
            };

            // query through npcs ?? to retrieve the curent case npcs
        }
        return caseObj;
    }
}

