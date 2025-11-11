using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GlamWire_Case_Cracked;

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

}
