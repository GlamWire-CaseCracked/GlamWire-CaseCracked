using GlamWire_Case_Cracked.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GlamWire_Case_Cracked;

public partial class SaveFileForm : Form
{
    public SaveFile LoadedSave { get; private set; }
    public Case CurrentCase { get; private set; }

    public SaveFileForm()
    {
        InitializeComponent();
        LoadSaves();
    }

    public void LoadSaves()
    {
        var db = new GlamwireDb();
        var saves = db.RetrieveSaveFiles(); 

        SaveLog_ListBx.Items.Clear();

        foreach (var save in saves)
        {
            SaveLog_ListBx.Items.Add(save);
        }
    }
    private void SaveScreen_Load(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// This is the Back Button for the SaveFileForm, it redirects to the MainForm currently, 
    /// however, it needs to be a little bit more dynamic. In that, it just returns to the previous 
    /// form that was up.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Back_bttn_Click(object sender, EventArgs e)
    {
        // copy this to all back buttons.
        this.Hide(); // this hides the current form 
        var MainForm = new MainForm(); // create a new MainForm instance
        MainForm.Show();// show the Mainform again. 

    }

    private void Quit_bttn_Click(object sender, EventArgs e)
    {
        string unsavedChangesMessage = "Are you sure you want to quit without saving?" +
                                        " Any unsaved changes will be lost.";
        var dialogResult = MessageBox.Show(unsavedChangesMessage, "Unsaved Changes!", MessageBoxButtons.YesNo);
        // if the user chooses No, the program WILL NOT close
        if (dialogResult == DialogResult.Yes)
        {
            // closes the whole program if the user wants to just quit
            Application.Exit();
        }
    }

    private void SaveLog_ListBx_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    // This loads the save I need to change the button name
    private void button1_Click(object sender, EventArgs e)
    {
        if (SaveLog_ListBx.SelectedItem is SaveFile save)
        {
            var startup = new GameStartupForm(
                caseId: 1,
                npcId: 2,
                playerName: save.PlayerName,
                wallet: save.Wallet,
                solvedCases: save.SolvedCases,
                saveId: save.SaveFileID
            );

            startup.Show();
            this.Hide();
        }
    }

    private void Overwrite_btn_Click(object sender, EventArgs e)
    {
        if (SaveLog_ListBx.SelectedItem is SaveFile save)
        {
            save.PlayerName = save.PlayerName;
            save.Wallet = save.Wallet;
            save.SolvedCases = save.SolvedCases;
            save.LastPlayed = DateTime.Now;

            var db = new GlamwireDb();
            db.OverwriteSaveFile(save);

            LoadSaves();
        }
    }

    private void DeleteSave_bttn_Click(object sender, EventArgs e)
    {
        if (SaveLog_ListBx.SelectedItem is SaveFile save)
        {
            var db = new GlamwireDb();
            db.DeleteSaveFile(save);

            LoadSaves();
        }

    }

    private void SaveQuit_bttn_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This Button is under construction!");
    }
}
