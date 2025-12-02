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
    public partial class CaseProfileForm : Form
    {        
        /// <summary>
        /// readonly int that retreives the caseId from the DB referenced
        /// </summary>
        private readonly int _caseId;
        /// <summary>
        /// readonly int that retreives the npcId from the DB referenced
        /// </summary>
        private readonly int _npcId;
        public CaseProfileForm(int caseId, int npcId)
        {
            // using the underscore so that I know it's from the GlamwireDb
            _caseId = caseId;
            _npcId = npcId;
            InitializeComponent();
        }
    }
}
