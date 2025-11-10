using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GlamWire_Case_Cracked.Models;

public class NPC
{
    // primary key for the NPC
    public required string NPCId { get; set; } 
    public required string NPCFirstName { get; set; }
    public required string NPCLastName { get; set; }

    // username or handle of the NPC -- for the Chat Room features
    public required string NPCUsername { get; set; }

    // role of the NPC in the game (e.g., witness, suspect, client)
    public required string NPCRole { get; set; }

    // the personality type of the NPC, sometimes reading dialog can cause a 
    // misunderstanding of how they come across so maybe this can help.
    public required string PersonalityType { get; set; }

    // tells us if the NPC has a criminal record
    // this can be null if they have no record or if they do 
    // then that may be able to help the player in their investigation
    public string? CriminalRecord { get; set; } 
    // indicates if the NPC is currently locked or unlocked
    // no default currently because I already have them set in the database
    public required bool IsLocked { get; set; }

    // I have this here to indicate guilt or not, I may have to make 
    // a viewmodel later to avoid spoiling the game
    // this marks true guilt. /* So if the user falsely accuses someone
    // then that would mean a failed/cold case.*/
    public required bool IsGuilty { get; set; } 
    }
