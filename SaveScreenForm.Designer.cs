namespace GlamWire_Case_Cracked
{
    partial class SaveFileForm
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
            LoadSave_bttn = new Button();
            DeleteSave_bttn = new Button();
            Back_bttn = new Button();
            SaveLog_ListBx = new ListBox();
            Quit_bttn = new Button();
            SaveQuit_bttn = new Button();
            Overwrite_btn = new Button();
            SuspendLayout();
            // 
            // LoadSave_bttn
            // 
            LoadSave_bttn.Location = new Point(549, 134);
            LoadSave_bttn.Name = "LoadSave_bttn";
            LoadSave_bttn.Size = new Size(112, 34);
            LoadSave_bttn.TabIndex = 1;
            LoadSave_bttn.Text = "Load Save";
            LoadSave_bttn.UseVisualStyleBackColor = true;
            LoadSave_bttn.Click += button1_Click;
            // 
            // DeleteSave_bttn
            // 
            DeleteSave_bttn.Location = new Point(549, 193);
            DeleteSave_bttn.Name = "DeleteSave_bttn";
            DeleteSave_bttn.Size = new Size(112, 34);
            DeleteSave_bttn.TabIndex = 2;
            DeleteSave_bttn.Text = "Delete Save";
            DeleteSave_bttn.UseVisualStyleBackColor = true;
            DeleteSave_bttn.Click += DeleteSave_bttn_Click;
            // 
            // Back_bttn
            // 
            Back_bttn.Location = new Point(35, 25);
            Back_bttn.Name = "Back_bttn";
            Back_bttn.Size = new Size(112, 34);
            Back_bttn.TabIndex = 3;
            Back_bttn.Text = "Back";
            Back_bttn.UseVisualStyleBackColor = true;
            Back_bttn.Click += Back_bttn_Click;
            // 
            // SaveLog_ListBx
            // 
            SaveLog_ListBx.FormattingEnabled = true;
            SaveLog_ListBx.Location = new Point(12, 74);
            SaveLog_ListBx.Name = "SaveLog_ListBx";
            SaveLog_ListBx.Size = new Size(510, 354);
            SaveLog_ListBx.Sorted = true;
            SaveLog_ListBx.TabIndex = 4;
            SaveLog_ListBx.SelectedIndexChanged += SaveLog_ListBx_SelectedIndexChanged;
            // 
            // Quit_bttn
            // 
            Quit_bttn.Location = new Point(549, 363);
            Quit_bttn.Name = "Quit_bttn";
            Quit_bttn.Size = new Size(112, 34);
            Quit_bttn.TabIndex = 5;
            Quit_bttn.Text = "Quit Game";
            Quit_bttn.UseVisualStyleBackColor = true;
            Quit_bttn.Click += Quit_bttn_Click;
            // 
            // SaveQuit_bttn
            // 
            SaveQuit_bttn.Location = new Point(537, 301);
            SaveQuit_bttn.Name = "SaveQuit_bttn";
            SaveQuit_bttn.Size = new Size(143, 34);
            SaveQuit_bttn.TabIndex = 6;
            SaveQuit_bttn.Text = "Save and Quit";
            SaveQuit_bttn.UseVisualStyleBackColor = true;
            SaveQuit_bttn.Click += SaveQuit_bttn_Click;
            // 
            // Overwrite_btn
            // 
            Overwrite_btn.Location = new Point(549, 74);
            Overwrite_btn.Name = "Overwrite_btn";
            Overwrite_btn.Size = new Size(112, 34);
            Overwrite_btn.TabIndex = 7;
            Overwrite_btn.Text = "Overwrite";
            Overwrite_btn.UseVisualStyleBackColor = true;
            Overwrite_btn.Click += Overwrite_btn_Click;
            // 
            // SaveFileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 174, 200);
            ClientSize = new Size(692, 450);
            Controls.Add(Overwrite_btn);
            Controls.Add(SaveQuit_bttn);
            Controls.Add(Quit_bttn);
            Controls.Add(SaveLog_ListBx);
            Controls.Add(Back_bttn);
            Controls.Add(DeleteSave_bttn);
            Controls.Add(LoadSave_bttn);
            Name = "SaveFileForm";
            Text = "Save Files";
            Load += SaveScreen_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button LoadSave_bttn;
        private Button DeleteSave_bttn;
        private Button Back_bttn;
        private ListBox SaveLog_ListBx;
        private Button Quit_bttn;
        private Button SaveQuit_bttn;
        private Button Overwrite_btn;
    }
}