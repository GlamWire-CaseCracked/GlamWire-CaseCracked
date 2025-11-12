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

    public List<NPC> RetrieveAllNPCs(int npcId)
    {
        List<NPC> npcs = new List<NPC>();

        // placeholder to retrieve all NPCs from the database to populate and move them.
        // // "hey program, try using the connection string to connect to the database"
        try
        { 
            using SqlConnection connection = new SqlConnection (connectionString);
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
                    IsLocked = (bool)reader["IsLocked"],
                    IsGuilty = (bool)reader["IsGuilty"],
                });
            }
        }

        catch (Exception ex){

            // I think copying the generic exception handler is fine for now.
            Console.WriteLine($"An error occurred while connecting to the database: {ex.Message}");
        }
        return npcs;
    }


    public Case RetrieveActiveCase(int caseId) {

        // placeholder to retrieve all cases from the database to populate and move them. 

        // null return (CHANGES NEEDED) 
        return null;
    }

}
