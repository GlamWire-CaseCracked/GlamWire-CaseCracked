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
using GlamWire_Case_Cracked.Models;

namespace GlamWire_Case_Cracked
{
    public partial class SaveFileForm : Form
    {

        /// <summary>
        /// readonly int that retreives the caseId from the DB referenced
        /// </summary>
        private readonly int _caseId;
        /// <summary>
        /// readonly int that retreives the npcId from the DB referenced
        /// </summary>
        private readonly int _npcId;
        public SaveFileForm(int caseId, int npcId)
        {
            InitializeComponent();
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
    }
}
