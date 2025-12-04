namespace GlamWire_Case_Cracked
{
    partial class CaseProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Pfp_picBx = new PictureBox();
            NPC_CaseProfilegp = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CrimHist_txt = new TextBox();
            Roletxt = new TextBox();
            NPCUsertxt = new TextBox();
            NPC_name2txt = new TextBox();
            NPC_name1txt = new TextBox();
            Guilty_rBtn = new RadioButton();
            Innocent_rBtn = new RadioButton();
            Verdict_gp = new GroupBox();
            CCase_rBtn = new RadioButton();
            button1 = new Button();
            Search_dropBx = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)Pfp_picBx).BeginInit();
            NPC_CaseProfilegp.SuspendLayout();
            Verdict_gp.SuspendLayout();
            SuspendLayout();
            // 
            // Pfp_picBx
            // 
            Pfp_picBx.Location = new Point(24, 28);
            Pfp_picBx.Name = "Pfp_picBx";
            Pfp_picBx.Size = new Size(154, 177);
            Pfp_picBx.SizeMode = PictureBoxSizeMode.AutoSize;
            Pfp_picBx.TabIndex = 0;
            Pfp_picBx.TabStop = false;
            // 
            // NPC_CaseProfilegp
            // 
            NPC_CaseProfilegp.Controls.Add(label5);
            NPC_CaseProfilegp.Controls.Add(label4);
            NPC_CaseProfilegp.Controls.Add(label3);
            NPC_CaseProfilegp.Controls.Add(label2);
            NPC_CaseProfilegp.Controls.Add(label1);
            NPC_CaseProfilegp.Controls.Add(CrimHist_txt);
            NPC_CaseProfilegp.Controls.Add(Roletxt);
            NPC_CaseProfilegp.Controls.Add(NPCUsertxt);
            NPC_CaseProfilegp.Controls.Add(NPC_name2txt);
            NPC_CaseProfilegp.Controls.Add(NPC_name1txt);
            NPC_CaseProfilegp.Controls.Add(Pfp_picBx);
            NPC_CaseProfilegp.Location = new Point(94, 22);
            NPC_CaseProfilegp.Name = "NPC_CaseProfilegp";
            NPC_CaseProfilegp.Size = new Size(477, 480);
            NPC_CaseProfilegp.TabIndex = 1;
            NPC_CaseProfilegp.TabStop = false;
            NPC_CaseProfilegp.Text = "NPC_CaseProfile";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 297);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 10;
            label5.Text = "Criminal History:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 214);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 9;
            label4.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 150);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 8;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 93);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 7;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 39);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 6;
            label1.Text = "First Name";
            // 
            // CrimHist_txt
            // 
            CrimHist_txt.Location = new Point(40, 325);
            CrimHist_txt.Multiline = true;
            CrimHist_txt.Name = "CrimHist_txt";
            CrimHist_txt.ReadOnly = true;
            CrimHist_txt.Size = new Size(403, 139);
            CrimHist_txt.TabIndex = 5;
            CrimHist_txt.TabStop = false;
            // 
            // Roletxt
            // 
            Roletxt.Location = new Point(293, 208);
            Roletxt.Name = "Roletxt";
            Roletxt.ReadOnly = true;
            Roletxt.Size = new Size(150, 31);
            Roletxt.TabIndex = 4;
            Roletxt.TabStop = false;
            // 
            // NPCUsertxt
            // 
            NPCUsertxt.Location = new Point(293, 147);
            NPCUsertxt.Name = "NPCUsertxt";
            NPCUsertxt.ReadOnly = true;
            NPCUsertxt.Size = new Size(150, 31);
            NPCUsertxt.TabIndex = 3;
            NPCUsertxt.TabStop = false;
            // 
            // NPC_name2txt
            // 
            NPC_name2txt.Location = new Point(293, 90);
            NPC_name2txt.Name = "NPC_name2txt";
            NPC_name2txt.ReadOnly = true;
            NPC_name2txt.Size = new Size(150, 31);
            NPC_name2txt.TabIndex = 2;
            NPC_name2txt.TabStop = false;
            // 
            // NPC_name1txt
            // 
            NPC_name1txt.Location = new Point(293, 39);
            NPC_name1txt.Name = "NPC_name1txt";
            NPC_name1txt.ReadOnly = true;
            NPC_name1txt.Size = new Size(150, 31);
            NPC_name1txt.TabIndex = 1;
            NPC_name1txt.TabStop = false;
            NPC_name1txt.VisibleChanged += Search_dropBx_SelectedIndexChanged;
            // 
            // Guilty_rBtn
            // 
            Guilty_rBtn.AutoSize = true;
            Guilty_rBtn.Location = new Point(16, 41);
            Guilty_rBtn.Name = "Guilty_rBtn";
            Guilty_rBtn.Size = new Size(149, 29);
            Guilty_rBtn.TabIndex = 0;
            Guilty_rBtn.TabStop = true;
            Guilty_rBtn.Text = "Mark as Guilty";
            Guilty_rBtn.UseVisualStyleBackColor = true;
            // 
            // Innocent_rBtn
            // 
            Innocent_rBtn.AutoSize = true;
            Innocent_rBtn.Location = new Point(16, 98);
            Innocent_rBtn.Name = "Innocent_rBtn";
            Innocent_rBtn.Size = new Size(173, 29);
            Innocent_rBtn.TabIndex = 1;
            Innocent_rBtn.TabStop = true;
            Innocent_rBtn.Text = "Mark as Innocent";
            Innocent_rBtn.UseVisualStyleBackColor = true;
            // 
            // Verdict_gp
            // 
            Verdict_gp.Controls.Add(CCase_rBtn);
            Verdict_gp.Controls.Add(Guilty_rBtn);
            Verdict_gp.Controls.Add(Innocent_rBtn);
            Verdict_gp.Location = new Point(592, 157);
            Verdict_gp.Name = "Verdict_gp";
            Verdict_gp.Size = new Size(205, 207);
            Verdict_gp.TabIndex = 7;
            Verdict_gp.TabStop = false;
            Verdict_gp.Text = "Verdict";
            // 
            // CCase_rBtn
            // 
            CCase_rBtn.AutoSize = true;
            CCase_rBtn.Location = new Point(16, 148);
            CCase_rBtn.Name = "CCase_rBtn";
            CCase_rBtn.Size = new Size(183, 29);
            CCase_rBtn.TabIndex = 2;
            CCase_rBtn.TabStop = true;
            CCase_rBtn.Text = "Mark as Cold Case";
            CCase_rBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(626, 384);
            button1.Name = "button1";
            button1.Size = new Size(141, 34);
            button1.TabIndex = 8;
            button1.Text = "Submit Case";
            button1.UseVisualStyleBackColor = true;
            // 
            // Search_dropBx
            // 
            Search_dropBx.FormattingEnabled = true;
            Search_dropBx.Location = new Point(592, 89);
            Search_dropBx.Name = "Search_dropBx";
            Search_dropBx.Size = new Size(215, 33);
            Search_dropBx.TabIndex = 9;
            Search_dropBx.SelectedIndexChanged += Search_dropBx_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(600, 52);
            label6.Name = "label6";
            label6.Size = new Size(191, 25);
            label6.TabIndex = 10;
            label6.Text = "Search By (Username) :";
            // 
            // CaseProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 174, 200);
            ClientSize = new Size(819, 535);
            Controls.Add(label6);
            Controls.Add(Search_dropBx);
            Controls.Add(button1);
            Controls.Add(Verdict_gp);
            Controls.Add(NPC_CaseProfilegp);
            Name = "CaseProfileForm";
            Text = "Case Folder";
            ((System.ComponentModel.ISupportInitialize)Pfp_picBx).EndInit();
            NPC_CaseProfilegp.ResumeLayout(false);
            NPC_CaseProfilegp.PerformLayout();
            Verdict_gp.ResumeLayout(false);
            Verdict_gp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Pfp_picBx;
        private GroupBox NPC_CaseProfilegp;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox CrimHist_txt;
        private TextBox Roletxt;
        private TextBox NPCUsertxt;
        private TextBox NPC_name2txt;
        private TextBox NPC_name1txt;
        private RadioButton Guilty_rBtn;
        private RadioButton Innocent_rBtn;
        private GroupBox Verdict_gp;
        private Button button1;
        private RadioButton CCase_rBtn;
        private ComboBox Search_dropBx;
        private Label label6;
    }
}