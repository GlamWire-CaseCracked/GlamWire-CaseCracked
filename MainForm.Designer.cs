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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnNewGame = new Button();
            btnLoadGame = new Button();
            btnExit = new Button();
            lblTitle = new Label();
            lblSubTitle = new Label();
            btnContinue = new Button();
            btnSettings = new Button();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(270, 180);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(253, 60);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += NewGame_bttn_Click_1;
            // 
            // btnLoadGame
            // 
            btnLoadGame.Location = new Point(270, 265);
            btnLoadGame.Name = "btnLoadGame";
            btnLoadGame.Size = new Size(253, 60);
            btnLoadGame.TabIndex = 1;
            btnLoadGame.Text = "Load Game";
            btnLoadGame.UseVisualStyleBackColor = true;
            btnLoadGame.Click += LoadGame_bttn_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(270, 347);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(253, 60);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += Exit_bttn_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Elephant", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.HotPink;
            lblTitle.Location = new Point(186, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(444, 93);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "GlamWire:";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            lblTitle.Click += label1_Click;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Broadway", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitle.ForeColor = Color.Azure;
            lblSubTitle.Location = new Point(218, 122);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(376, 55);
            lblSubTitle.TabIndex = 4;
            lblSubTitle.Text = "Case Cracked";
            lblSubTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(0, 0);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(75, 23);
            btnContinue.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(0, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(75, 23);
            btnSettings.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 174, 200);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSubTitle);
            Controls.Add(lblTitle);
            Controls.Add(btnExit);
            Controls.Add(btnLoadGame);
            Controls.Add(btnNewGame);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
