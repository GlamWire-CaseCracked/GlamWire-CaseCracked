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

namespace GlamWire_Case_Cracked;

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
        LoadCase_Profile();
    }

    public void LoadCase_Profile()
    {
        //create a new instance of the database to retrieve data
        var db = new GlamwireDb();
        // I don't know why, but the NPCId starts at Index 3 (aka 2)
        var caseProfile = db.GetNPCsForCase(_caseId + 1);

        // if the caseProfile is null then we will show a
        // file corruption error
        string loadingError = "File Corrupted, Please Try Again Later." +
              "Error Loading Case Profile";
        string errorTag = "File Corruption Error";

        // load file corruption error if the form isn't loading
        if (caseProfile == null)
        {
            MessageBox.Show(loadingError, errorTag, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            this.Hide();
        }
        // retrive all necessary data from the Case Profile
        Search_dropBx.DataSource = caseProfile;
        // select Index 0 from the start
        Search_dropBx.SelectedIndex = 0;

    }
    private void Search_dropBx_SelectedIndexChanged(object sender, EventArgs e)
    {
        // select the Case NPC using the Selected Items NPC Id num from CaseNPC
        var selectedCaseNpc = Search_dropBx.SelectedItem as CaseNPC;

        // as long as there is a selected item, the textboxes will be populated
        if (selectedCaseNpc != null)
        {
            NPC_name1txt.Text = selectedCaseNpc.NPC.NPCFirstName;
            NPC_name2txt.Text = selectedCaseNpc.NPC.NPCLastName;
            NPCUsertxt.Text = selectedCaseNpc.NPC.NPCUsername;
            Roletxt.Text = selectedCaseNpc.NPC.Role;
            CrimHist_txt.Text = selectedCaseNpc.NPC.CriminalHistory;
        }
    }
}
