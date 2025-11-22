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
            LoadGameNPCs();
            InitializeComponent();
        }

        /// <summary>
        /// LoadGameNPCs() method will populate and produce the NPCs of the active case, 
        /// in addition to that if the case is closed, the friends will still remain there. 
        /// just hidden or offline. 
        /// </summary>
        /// <param name="caseId"></param>
        /// <param name="connectionString"></param>
        public void LoadGameNPCs() {

            List<NPC> npcs = GlamwireDb.GetNPCsForCase(
                GameContext.CurrentCaseId.CaseID
            );

            int caseId = GameContext.CurrentCaseId.CaseID;
            // loop thought each ACTIVE npc and populate
            foreach (var npc in GameContext.CurrentCaseId.InvolvedNPCs)
            {
                // if there is an npc populate it into the NPCLog_box
                if (npc != null)
                {
                    NPCLog_box.Items.Add(npc.NPCUsername);
                }
                if (npcs.Count == 0)
                {
                    MessageBox.Show("No NPCs found for CaseId=" + GameContext.CurrentCaseId);
                }
            }
        }
    }
}
