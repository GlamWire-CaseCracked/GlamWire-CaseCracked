using GlamWire_Case_Cracked;
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
        /// <summary>
        /// 
        /// </summary>
        public static string SavedPlayerName;

        /// <summary>
        /// PlayerNameForm initializes the PlayerNameForm and has 3 parameters
        /// passed through
        /// </summary>
        /// 
        public PlayerNameForm()
        {   // using the underscore so that I know it's from the GlamwireDbContext
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
            var MainForm = new MainForm(); // create a new MainForm instance
            MainForm.Show();// show the Mainform again. 
        }

        /// <summary>
        /// This is the Start Button on the PlayerNameForm, 
        /// After it has validated that the user has in fact entered a name 
        /// of 3 characters or greater, it will redirect the user to the 
        /// GameStartupForm aka Glamwire.exe. It will then completely hide the 
        /// previous form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void StartNewGame_btn_Click(object sender, EventArgs e)
        {
            string playerName = PlayerName_txtbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            if (playerName.Length < 3)
            {
                MessageBox.Show("Name must be at least 3 characters.");
                return;
            }

            // Create a save
            var db = new GlamwireDb();

            var newSave = new SaveFile
            {
                PlayerName = playerName,
                Wallet = 350,
                SolvedCases = 0,
                LastPlayed = DateTime.Now
            };

            db.CreateSaveFile(newSave);

            // Load starting case and NPCs
            int caseId = 1; // or whatever your "first case" is
            int npcId = 2;

            // Open the game
            var startup = new GameStartupForm(
                caseId,
                npcId,
                newSave.PlayerName,
                newSave.Wallet,
                newSave.SolvedCases,
                newSave.SaveFileID
            );

            startup.Show();
            this.Hide();
        }
    }
}
