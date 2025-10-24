namespace GlamWire_Case_Cracked
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
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
            // 
            // LoadGame_bttn
            // 
            LoadGame_bttn.Location = new Point(270, 265);
            LoadGame_bttn.Name = "LoadGame_bttn";
            LoadGame_bttn.Size = new Size(253, 60);
            LoadGame_bttn.TabIndex = 1;
            LoadGame_bttn.Text = "Load Game";
            LoadGame_bttn.UseVisualStyleBackColor = true;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Stout", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(113, 35);
            label1.Name = "label1";
            label1.Size = new Size(588, 71);
            label1.TabIndex = 3;
            label1.Text = "GlamWire";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(220, 106);
            label2.Name = "label2";
            label2.Size = new Size(365, 57);
            label2.TabIndex = 4;
            label2.Text = "Case Cracked";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Exit_bttn);
            Controls.Add(LoadGame_bttn);
            Controls.Add(NewGame_bttn);
            Name = "Form1";
            Text = "GlamWire : Case Cracked";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewGame_bttn;
        private Button LoadGame_bttn;
        private Button Exit_bttn;
        private Label label1;
        private Label label2;
    }
}
