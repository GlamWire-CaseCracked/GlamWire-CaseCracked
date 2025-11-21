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
    public partial class GameStartupForm : Form
    {
        private int currentCaseId;
        private int unlockedNPCId;
        private string conn;
        public GameStartupForm(int caseId, int npcId, string connectionString)
        {
            currentCaseId = caseId;
            unlockedNPCId = npcId;
            conn = connectionString;
            InitializeComponent();
        }

        private void Glamwire_picBox_Click(object sender, EventArgs e)
        {
            var ChatRoomForm = new ChatRoomForm(currentCaseId, unlockedNPCId, conn); 
            // shows the chatroom as a modal popup instead of just
            // hiding the whole "Desktop"/ GameStartupForm
            ChatRoomForm.ShowDialog();
        }
    }
}
