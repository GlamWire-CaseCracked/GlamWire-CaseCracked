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


        private readonly int _saveId;
        /// <summary>
        /// readonly int that retreives the caseId from the DB referenced
        /// </summary>
        private readonly int _caseId;
        /// <summary>
        /// readonly int that retreives the npcId from the DB referenced
        /// </summary>
        private readonly int _npcId;

        public GameStartupForm(int caseId, int npcId)
        {   // using the underscore so that I know it's from the GlamwireDbContext
            _caseId = caseId;
            _npcId = npcId;
            InitializeComponent();
        }

        private void Glamwire_picBox_Click(object sender, EventArgs e)
        {
            var ChatRoomForm = new ChatRoomForm(_caseId, _npcId);
            // shows the chatroom as a modal popup instead of just
            // hiding the whole "Desktop"/ GameStartupForm
            ChatRoomForm.ShowDialog();
        }

        private void saveGame_picBox_Click(object sender, EventArgs e)
        {
            var saveFileForm = new SaveFileForm(_caseId, _npcId, _saveId);
            saveFileForm.ShowDialog();
        }

        private void Cases_picBox_Click(object sender, EventArgs e)
        {
            var caseProfile = new CaseProfileForm(_caseId, _npcId);
            caseProfile.ShowDialog();
        }
    }
}
