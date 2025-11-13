using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GlamWire_Case_Cracked.Models;

/// <summary>
/// Represents a save file for a game, containing player information and game progress.
/// </summary>
/// <remarks>This class is designed to mirror the structure of the corresponding database table for save files. It
/// includes properties for player identification, game progress, and metadata about the save file.</remarks>

public class SaveFile
{ // trying to keep the properties the same as the database table

    // properties for the savefile needed to load a game
    public int SaveFileID { get; set; }

    /// <summary>
    /// The inserted player name for the save file.
    /// </summary>
    public required string PlayerName { get; set; }
    public string? SaveFileName { get; set; } = string.Empty; 
    public int Wallet { get; set; }

    // LastPlayed = Last time the user played/saved the game
    public DateTime LastPlayed { get; set; }
    public int SolvedCases { get; set; }


    /// <summary>
    /// This overrides the ToString method to provide a formatted string
    /// representation of the SaveFile object,
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {

        // this is how the save file will be displayed and structred 
        // I may need to remove this because it is already formatted in the 
        // database???..
        return $"{PlayerName} | Coins: {Wallet} | Save Name: {SaveFileName} " +
                             $"| Cases Solved: {SolvedCases}";
    }

}
