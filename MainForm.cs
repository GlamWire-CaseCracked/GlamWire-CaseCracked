using GlamWire_Case_Cracked.Models;

namespace GlamWire_Case_Cracked;

public partial class MainForm : Form
{
    private int currentCaseId;
    private int unlockedNPCId;
    private string conn;
    public MainForm(int caseId, int npcId, string connectionString)
    {
        currentCaseId = caseId;
        unlockedNPCId = npcId;
        conn = connectionString;
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {
        // accidentally created by designer, no code needed here
    }

    private void NewGame_bttn_Click_1(object sender, EventArgs e)
    {
        // create a new PlayerNameForm each time NewGame_bttn is clicked
        var PlayerNameForm = new PlayerNameForm(currentCaseId, unlockedNPCId, conn);
        // shows the new PlayerNameForm (pop up window)
        PlayerNameForm.Show();
        // hides the previous MainForm
        this.Hide();
    }
    private void LoadGame_bttn_Click(object sender, EventArgs e) // create a delay on load? 
    {
        // create a new SaveFileForm each time LoadGame_bttn is clicked
        var SaveFileForm = new SaveFileForm(currentCaseId, unlockedNPCId, conn);
        // show the SaveFile form for loading
        // then create a new GameForm with loaded data...
        SaveFileForm.Show();
        // this :) hides the previous MainForm
        this.Hide();
    }
    private void Exit_bttn_Click(object sender, EventArgs e)
    {
        Close();
    }
}
