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
    public partial class ChatRoomForm : Form
    {
        public ChatRoomForm(int caseId, int npcId ,string connectionString)
        {
            // create and initialize a method that will go here
            LoadGameNPCs(GameContext.CurrentCaseId, connectionString);
            InitializeComponent();
        }

        public void LoadGameNPCs(int currentCaseId, string connectionString) { 
            List<NPC> npcs = GlamwireDb.GetNPCsForCase(GameContext.CurrentCaseId, connectionString);

        }
    }
}
