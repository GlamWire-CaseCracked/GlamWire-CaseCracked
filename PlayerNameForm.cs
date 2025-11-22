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

namespace GlamWire_Case_Cracked
{
    public partial class PlayerNameForm : Form
    {

        public PlayerNameForm(int caseId, int npcId, string connectionString)
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the back button for this form, it should redirect users to 
        /// the previous form they are on. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // this is just going to redirect to the main form 
            // copy this to all back buttons.
            this.Hide(); // this hides the current form 
            var MainForm = new MainForm(GameContext.CurrentCaseId.CaseID,
                          GameContext.UnlockedNPCId.NPCId, GameContext.ConnectionString); // create a new MainForm instance
            MainForm.Show();// show the Mainform again. 
        }

        private void StartNewGame_btn_Click(object sender, EventArgs e)
        {

            // declare a variable for playername -- retrieve the player input/name from
            // PlayerName_txtbox -- trim the whitespace.
            string playerName = PlayerName_txtbox.Text.Trim();

            // if the string above^^ (playername) is null 
            if (string.IsNullOrWhiteSpace(playerName))
            {
                // show that the name is invalid
                MessageBox.Show("Please enter your name to start.", "Missing Name",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // checks to for a certain length for the string/playername. Making simple names like: 
            // "Ron" vaild. 
            if (playerName.Length < 3)
            {
                MessageBox.Show("That is not a valid name, please try again. " +
                            "Your name must be 3 characters or greater", "Invalid Input",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            // Proceed to startup game 
            this.Hide();
            // have the GameStarrupForm load a new Save as well. 
            var GameStartupForm = new GameStartupForm(GameContext.CurrentCaseId.CaseID,
                          GameContext.UnlockedNPCId.NPCId, GameContext.ConnectionString);
            GameStartupForm.Show();
        }
    }
}
