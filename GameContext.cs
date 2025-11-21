using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlamWire_Case_Cracked
{
    /// <summary>
    /// GameContext represents the parameters needed to be passed through each form 
    /// so that I can populate data. DO NOT DELETE!!
    /// </summary>
    public static class GameContext
    {
        public static int CurrentCaseId { get; set; }
        public static int UnlockedNPCId { get; set; }
        public static string ConnectionString { get; set; } = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GlamwireDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

    }
}
