using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlamWire_Case_Cracked.Models;
/// <summary>
/// Represents a case with specific attributes such as title, summary,
/// difficulty, reward, and status.
/// </summary>
/// <remarks>This class is used to encapsulate the details of a case, including its
/// identification, description,
/// difficulty level, reward, and whether it has been solved. It also maintains a 
/// list of involved NPCs and is
/// associated with a specific save file.</remarks>
public class Case
{
    public required int CaseID { get; set; }

    // The title of the case
    public required string CaseTitle { get; set; }
    // The summary/description of the case
    public required string CaseSummary { get; set; }
    // The difficulty level of the case (1-5)
    public required int Difficulty { get; set; }
    // The reward in an integer amount to keep it simple. 
    public required int Reward { get; set; }
    // Indicates if the case has been solved in that save file 
    public required bool IsSolved { get; set; }

    /// <summary>
    /// Gets or sets the list of NPCs involved in the current context.
    /// From the database, this would be relationship mapping.
    /// </summary>
    public required List<NPC> InvolvedNPCs { get; set; } = new();

    // retreives the save file associated with this case
    public required int SaveFile { get; set; }

}
