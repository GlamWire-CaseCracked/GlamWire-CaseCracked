namespace GlamWire_Case_Cracked
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NewGame_bttn = new Button();
            LoadGame_bttn = new Button();
            Exit_bttn = new Button();
            Title_lbl = new Label();
            SubTitle_lbl = new Label();
            SuspendLayout();
            // 
            // NewGame_bttn
            // 
            NewGame_bttn.Location = new Point(270, 180);
            NewGame_bttn.Name = "NewGame_bttn";
            NewGame_bttn.Size = new Size(253, 60);
            NewGame_bttn.TabIndex = 0;
            NewGame_bttn.Text = "New Game";
            NewGame_bttn.UseVisualStyleBackColor = true;
            NewGame_bttn.Click += NewGame_bttn_Click_1;
            // 
            // LoadGame_bttn
            // 
            LoadGame_bttn.Location = new Point(270, 265);
            LoadGame_bttn.Name = "LoadGame_bttn";
            LoadGame_bttn.Size = new Size(253, 60);
            LoadGame_bttn.TabIndex = 1;
            LoadGame_bttn.Text = "Load Game";
            LoadGame_bttn.UseVisualStyleBackColor = true;
            LoadGame_bttn.Click += this.LoadGame_bttn_Click;
            // 
            // Exit_bttn
            // 
            Exit_bttn.Location = new Point(270, 347);
            Exit_bttn.Name = "Exit_bttn";
            Exit_bttn.Size = new Size(253, 60);
            Exit_bttn.TabIndex = 2;
            Exit_bttn.Text = "Exit";
            Exit_bttn.UseVisualStyleBackColor = true;
            Exit_bttn.Click += Exit_bttn_Click;
            // 
            // Title_lbl
            // 
            Title_lbl.AutoSize = true;
            Title_lbl.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title_lbl.ForeColor = Color.Lavender;
            Title_lbl.Location = new Point(230, 24);
            Title_lbl.Name = "Title_lbl";
            Title_lbl.Size = new Size(340, 82);
            Title_lbl.TabIndex = 3;
            Title_lbl.Text = "GlamWire";
            Title_lbl.TextAlign = ContentAlignment.TopCenter;
            Title_lbl.Click += label1_Click;
            // 
            // SubTitle_lbl
            // 
            SubTitle_lbl.AutoSize = true;
            SubTitle_lbl.Font = new Font("Century Gothic", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SubTitle_lbl.ForeColor = Color.Azure;
            SubTitle_lbl.Location = new Point(220, 106);
            SubTitle_lbl.Name = "SubTitle_lbl";
            SubTitle_lbl.Size = new Size(365, 57);
            SubTitle_lbl.TabIndex = 4;
            SubTitle_lbl.Text = "Case Cracked";
            SubTitle_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(800, 450);
            Controls.Add(SubTitle_lbl);
            Controls.Add(Title_lbl);
            Controls.Add(Exit_bttn);
            Controls.Add(LoadGame_bttn);
            Controls.Add(NewGame_bttn);
            Name = "MainForm";
            Text = "GlamWire : Case Cracked";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewGame_bttn;
        private Button LoadGame_bttn;
        private Button Exit_bttn;
        private Label Title_lbl;
        private Label SubTitle_lbl;
    }
}
