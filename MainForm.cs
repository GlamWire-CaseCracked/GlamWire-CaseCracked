using GlamWire_Case_Cracked.Models;

namespace GlamWire_Case_Cracked;

public partial class MainForm : Form
{


    private readonly int _saveId;
    /// <summary>
    /// readonly int that retreives the caseId from the DB referenced
    /// </summary>
    private readonly int _caseId;
    /// <summary>
    /// readonly int that retreives the npcId from the DB referenced
    /// </summary>
    private readonly int _npcId;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="caseId"></param>
    /// <param name="npcId"></param>
    public MainForm()
    {
        // using the underscore so that I know it's from the GlamwireDbContext
       //_caseId = caseId,
       //_npcId = npcId;
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
        var playerNameForm = new PlayerNameForm();
        playerNameForm.Show();
        this.Hide();
    }

    /// <summary>
    /// This is the Load Game Button, 
    /// upon clicking it the SaveScreen form will load and from there the user can select 
    /// any one of their previous saves-- if any. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LoadGame_bttn_Click(object sender, EventArgs e)
    {
        var db = new GlamwireDb();

        var currentSave = db.RetrieveSaveFiles(_saveId);
        var currentCase = db.RetrieveActiveCase(_caseId);
        var unlockedNpc = db.RetrieveAllNPCs(_npcId).FirstOrDefault();

        var saveFileForm = new SaveFileForm(
            currentCase?.CaseID ?? 1,
            unlockedNpc?.NPCId ?? 0),
            currentSave?.SaveID ?? 1;
        saveFileForm.Show();
        this.Hide();
        }
    };
    

    /// <summary>
    /// This is the Exit Button, 
    /// upon clicking this button the program will close since it is the Main/Title Form. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Exit_bttn_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
