using GlamWire_Case_Cracked.Models;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlamWire_Case_Cracked
{
    public partial class SaveFileForm : Form
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
        public SaveFileForm(int caseId, int npcId, int saveId)
        {
            _caseId = caseId;
            _npcId = npcId;
            _saveId = saveId;
            InitializeComponent();
            LoadSaves();
        }

        public void LoadSaves()
        {
            var db = new GlamwireDb();
            var saves = db.RetrieveSaveFiles(_saveId + 1);

            // Clear the Save File box first before populating 
            SaveLog_ListBx.Items.Clear();

            if (saves == null)
            {
                MessageBox.Show("You have no saves");
                return;
            }

            foreach (var save in saves)
            {
                if (save != null)
                {
                    // populates save files and formats them like so :
                    SaveLog_ListBx.Items.Add($"{save.PlayerName} | " +
                        $"Last Save: {save.LastPlayed} Wallet: {save.Wallet}" +
                        $"\n Solved Cases: {save.SolvedCases}");
                }
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
            // select the Case NPC using the Selected Items NPC Id num from CaseNPC
            var selectedCaseNpc = SaveLog_ListBx.SelectedItem as SaveFile;

            // as long as there is a selected item, the textboxes will be populated
            if (selectedCaseNpc != null)
            {
                
            }
        }
    }
}
