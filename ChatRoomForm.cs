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

        /// <summary>
        /// readonly int that retreives the caseId from the DB referenced
        /// </summary>
        private readonly int _caseId;
        /// <summary>
        /// readonly int that retreives the npcId from the DB referenced
        /// </summary>
        private readonly int _npcId;

        /// <summary>
        ///  The ChatRoomForm Initializes the form and loads in the games 
        ///  active npcs for the current case that the user is investigating.
        /// </summary>
        /// <param name="caseId"></param>
        /// <param name="npcId"></param>
        public ChatRoomForm(int caseId, int npcId)
        {
            // using the underscore so that I know it's from the GlamwireDbContext
            _caseId = caseId;
            _npcId = npcId;
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

            var db = new GlamwireDb();
            var npcs = db.GetNPCsForCase(_caseId);

            // loop thought each ACTIVE npc and populate
            foreach (var npc in npcs)
            {
                // if there is an npc populate it into the NPCLog_box
                if (npc != null)
                {
                    NPCLog_box.Items.Add(npc.NPCUsername);
                }
                if (npcs.Count == 0)
                {
                    MessageBox.Show("No NPCs found for CaseId=" + _caseId);
                }
            }
        }
    }
}
