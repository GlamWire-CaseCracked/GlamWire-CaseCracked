using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlamWire_Case_Cracked.Models;

public class CaseNPC
{
    public int CaseId { get; set; }
    public required Case Case { get; set; }

    public int NPCId { get; set; }
    public required NPC NPC { get; set; }

    /// <summary>
    /// CaseNPC ToString() Override allows the usernames to show as strings within the 
    /// dropdown on the CaseProfileForm.  
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return NPC?.NPCUsername ?? "Unknown NPC";
    }
}

