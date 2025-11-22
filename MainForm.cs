using GlamWire_Case_Cracked.Models;
using Microsoft.EntityFrameworkCore;

namespace GlamWire_Case_Cracked;

public partial class MainForm : Form
{   

    /// <summary>
    /// readonly int that retreives the caseId from the DBContext referenced
    /// </summary>
    private readonly int _caseId;
    /// <summary>
    /// readonly int that retreives the npcId from the DBContext referenced
    /// </summary>
    private readonly int _npcId;
    /// <summary>
    /// readonly int that retreives the connectionString from the Database referenced
    /// </summary>
    private readonly string _connectionString;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="caseId"></param>
    /// <param name="npcId"></param>
    /// <param name="connectionString"></param>
    public MainForm(int caseId, int npcId, string connectionString)
    {
        // using the underscore so that I know it's from the GlamwireDbContext
        _caseId = caseId;
        _npcId = npcId;
        _connectionString = connectionString;
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {
        // accidentally created by designer, no code needed here...yet?
    }

    /// <summary>
    /// This is the New Game button on the Main/Title Form. 
    /// Upon clicking it, it allows us to load a fresh game file, and should load 
    /// CASE #1 and all the NPC's, Prompts, Clues etc associated with them. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NewGame_bttn_Click_1(object sender, EventArgs e)
    {
        using (var db = new GlamwireDbContext())
        {
            var currentCase = db.Case.FirstOrDefault(c => c.CaseID == _caseId);
            var unlockedNpc = db.NPC.FirstOrDefault(n => n.NPCId == _npcId);

            var playerNameForm = new PlayerNameForm(
                currentCase.CaseID,
                unlockedNpc.NPCId,
                db.Database.GetConnectionString());

            playerNameForm.Show();
            this.Hide();
        }

    }

    /// <summary>
    /// This is the Load Game Button, 
    /// upon clicking it the SaveScreen form will load and from there the user can select 
    /// any one of their previous saves-- if any. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LoadGame_bttn_Click(object sender, EventArgs e) // create a delay on load? 
    {
        using (var db = new GlamwireDbContext())
        {
            var currentCase = db.Case.FirstOrDefault(c => c.CaseID == _caseId);
            var unlockedNpc = db.NPC.FirstOrDefault(n => n.NPCId == _npcId);

            var saveFileForm = new SaveFileForm(
                currentCase.CaseID,
                unlockedNpc.NPCId,
                _connectionString);

            saveFileForm.Show();
            this.Hide();
        }
    }

    /// <summary>
    /// This is the Exit Button, 
    /// upon clicking this button the program will close since it is the Main/Title Form. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Exit_bttn_Click(object sender, EventArgs e)
    {
        Close();
    }
}
