using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GlamWire_Case_Cracked.Models;

public class SaveFile
{ // trying to keep the properties the same as the database table

    // properties for the savefile needed to load a game
    public int SaveFileID { get; set; }
    
    public required string PlayerName { get; set; }
    public string? SaveFileName { get; set; } = string.Empty; 
    public int Wallet { get; set; }
    public DateTime LastPlayed { get; set; }
    public int SolvedCases { get; set; }


    // override the ToString method for easy display, 
    // and so that when we load the save files we can see relevant info
    public override string ToString()
    {

        // this is how the save file will be displayed and structred 
        // I may need to remove this because it is already formatted in the 
        // database???..
        return $"{PlayerName} | Coins: {Wallet} | Save Name: {SaveFileName} " +
                             $"| Cases Solved: {SolvedCases}";
    }

}
