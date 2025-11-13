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
            btnNewGame = new Button();
            btnLoadGame = new Button();
            btnExit = new Button();
            lblTitle = new Label();
            lblSubTitle = new Label();
            btnContinue = new Button();
            btnSettings = new Button();
            SuspendLayout();
            // 
            // NewGame_bttn
            // 
            btnNewGame.Location = new Point(270, 180);
            btnNewGame.Name = "NewGame_bttn";
            btnNewGame.Size = new Size(253, 60);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += NewGame_bttn_Click_1;
            // 
            // LoadGame_bttn
            // 
            btnLoadGame.Location = new Point(270, 265);
            btnLoadGame.Name = "LoadGame_bttn";
            btnLoadGame.Size = new Size(253, 60);
            btnLoadGame.TabIndex = 1;
            btnLoadGame.Text = "Load Game";
            btnLoadGame.UseVisualStyleBackColor = true;
            btnLoadGame.Click += this.LoadGame_bttn_Click;
            // 
            // Exit_bttn
            // 
            btnExit.Location = new Point(270, 347);
            btnExit.Name = "Exit_bttn";
            btnExit.Size = new Size(253, 60);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += Exit_bttn_Click;
            // 
            // Title_lbl
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Lavender;
            lblTitle.Location = new Point(230, 24);
            lblTitle.Name = "Title_lbl";
            lblTitle.Size = new Size(340, 82);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "GlamWire";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            lblTitle.Click += label1_Click;
            // 
            // SubTitle_lbl
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Century Gothic", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSubTitle.ForeColor = Color.Azure;
            lblSubTitle.Location = new Point(220, 106);
            lblSubTitle.Name = "SubTitle_lbl";
            lblSubTitle.Size = new Size(365, 57);
            lblSubTitle.TabIndex = 4;
            lblSubTitle.Text = "Case Cracked";
            lblSubTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 174, 200);
            ClientSize = new Size(800, 450);
            Controls.Add(lblSubTitle);
            Controls.Add(lblTitle);
            Controls.Add(btnExit);
            Controls.Add(btnLoadGame);
            Controls.Add(btnNewGame);
            Name = "MainForm";
            Text = "GlamWire : Case Cracked";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewGame;
        private Button btnLoadGame;
        private Button btnExit;
        private Label lblTitle;
        private Label lblSubTitle;
        private Button btnContinue;
        private Button btnSettings;
    }
}
