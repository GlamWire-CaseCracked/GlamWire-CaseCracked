using GlamWire_Case_Cracked.Models;
using System;
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
        public SaveFileForm(int caseId, int npcId, string connectionString)
        {
            InitializeComponent();
        }

        private void SaveScreen_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_bttn_Click(object sender, EventArgs e)
        { // this is just going to redirect to the main form 
            // copy this to all back buttons.
            this.Hide(); // this hides the current form 
            var MainForm = new MainForm(GameContext.CurrentCaseId, GameContext.UnlockedNPCId, GameContext.ConnectionString); // create a new MainForm instance
            MainForm.Show();// show the Mainform again. 

        }
    }
}
