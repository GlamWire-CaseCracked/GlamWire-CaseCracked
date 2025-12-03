using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GlamWire_Case_Cracked.Models;

/// <summary>
/// Represents a non-player character (NPC) in the game, including their identity, 
/// role, and status.
/// </summary>
/// <remarks>This class provides properties to define the NPC's identity, 
/// role in the game, and other attributes
/// such as personality type and criminal record. It also indicates whether the NPC 
/// is currently locked or guilty, which
/// can affect gameplay.</remarks>

public class NPC
{
    // primary key for the NPC
    public required int NPCId { get; set; } 

    // navigation property for the NPC Class => CASENPC
    public ICollection<CaseNPC> CaseNPCs { get; set; }

    public required string NPCFirstName { get; set; }
    public required string NPCLastName { get; set; }

    // username or handle of the NPC -- for the Chat Room features
    public required string NPCUsername { get; set; }

    // role of the NPC in the game (e.g., witness, suspect, client)
    public required string Role { get; set; }

    // the personality type of the NPC, sometimes reading dialog can cause a 
    // misunderstanding of how they come across so maybe this can help.
    public string? PersonalityType { get; set; }

    // tells us if the NPC has a criminal record
    // this can be null if they have no record or if they do 
    // then that may be able to help the player in their investigation
    public string? CriminalHistory { get; set; } 
    // indicates if the NPC is currently locked or unlocked
    // no default currently because I already have them set in the database
    public required bool IsLocked { get; set; }

    // I have this here to indicate guilt or not, I may have to make 
    // a viewmodel later to avoid spoiling the game
    // this marks true guilt. /* So if the user falsely accuses someone
    // then that would mean a failed/cold case.*/
    public required bool IsGuilty { get; set; } 
    // retreives the save file associated with the NPC
    // so that if they start a new game or load a different save file
    public SaveFile? SaveFile { get; set; }
}
