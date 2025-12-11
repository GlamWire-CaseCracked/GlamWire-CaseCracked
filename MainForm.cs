using GlamWire_Case_Cracked.Models;

namespace GlamWire_Case_Cracked;

public partial class MainForm : Form
{
    /// <summary>
    /// 
    /// </summary>
    public MainForm()
    {
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
        var saveForm = new SaveFileForm();
        if (saveForm.ShowDialog() == DialogResult.OK)
        {
            var selected = saveForm.LoadedSave;
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
        Application.Exit();
    }
}
