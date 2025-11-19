namespace GlamWire_Case_Cracked
{
    partial class PlayerNameForm
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
            Credentials_lbl = new Label();
            PlayerName_txtbox = new TextBox();
            StartNewGame_btn = new Button();
            Back_bttn2 = new Button();
            SuspendLayout();
            // 
            // Credentials_lbl
            // 
            Credentials_lbl.AutoSize = true;
            Credentials_lbl.Location = new Point(204, 137);
            Credentials_lbl.Name = "Credentials_lbl";
            Credentials_lbl.Size = new Size(411, 25);
            Credentials_lbl.TabIndex = 0;
            Credentials_lbl.Text = "*ph* Hello Detective, please enter your credentials:";
            // 
            // PlayerName_txtbox
            // 
            PlayerName_txtbox.Location = new Point(252, 183);
            PlayerName_txtbox.Multiline = true;
            PlayerName_txtbox.Name = "PlayerName_txtbox";
            PlayerName_txtbox.Size = new Size(298, 46);
            PlayerName_txtbox.TabIndex = 1;
            PlayerName_txtbox.Text = "Enter your name:";
            // 
            // StartNewGame_btn
            // 
            StartNewGame_btn.Location = new Point(338, 255);
            StartNewGame_btn.Name = "StartNewGame_btn";
            StartNewGame_btn.Size = new Size(112, 34);
            StartNewGame_btn.TabIndex = 2;
            StartNewGame_btn.Text = "Start";
            StartNewGame_btn.UseVisualStyleBackColor = true;
            // 
            // Back_bttn2
            // 
            Back_bttn2.Location = new Point(35, 33);
            Back_bttn2.Name = "Back_bttn2";
            Back_bttn2.Size = new Size(112, 34);
            Back_bttn2.TabIndex = 3;
            Back_bttn2.Text = "Back";
            Back_bttn2.UseVisualStyleBackColor = true;
            Back_bttn2.Click += button2_Click;
            // 
            // PlayerNameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(800, 450);
            Controls.Add(Back_bttn2);
            Controls.Add(StartNewGame_btn);
            Controls.Add(PlayerName_txtbox);
            Controls.Add(Credentials_lbl);
            Name = "PlayerNameForm";
            Text = "New Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Credentials_lbl;
        private TextBox PlayerName_txtbox;
        private Button StartNewGame_btn;
        private Button Back_bttn2;
    }
}