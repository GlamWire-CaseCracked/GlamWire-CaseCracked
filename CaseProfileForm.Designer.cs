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
            pictureBox1 = new PictureBox();
            NPC_CaseProfilegp = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            Verdict_gp = new GroupBox();
            button1 = new Button();
            radioButton3 = new RadioButton();
            comboBox1 = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            NPC_CaseProfilegp.SuspendLayout();
            Verdict_gp.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 177);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // NPC_CaseProfilegp
            // 
            NPC_CaseProfilegp.Controls.Add(label5);
            NPC_CaseProfilegp.Controls.Add(label4);
            NPC_CaseProfilegp.Controls.Add(label3);
            NPC_CaseProfilegp.Controls.Add(label2);
            NPC_CaseProfilegp.Controls.Add(label1);
            NPC_CaseProfilegp.Controls.Add(textBox5);
            NPC_CaseProfilegp.Controls.Add(textBox4);
            NPC_CaseProfilegp.Controls.Add(textBox3);
            NPC_CaseProfilegp.Controls.Add(textBox2);
            NPC_CaseProfilegp.Controls.Add(textBox1);
            NPC_CaseProfilegp.Controls.Add(pictureBox1);
            NPC_CaseProfilegp.Location = new Point(94, 22);
            NPC_CaseProfilegp.Name = "NPC_CaseProfilegp";
            NPC_CaseProfilegp.Size = new Size(477, 480);
            NPC_CaseProfilegp.TabIndex = 1;
            NPC_CaseProfilegp.TabStop = false;
            NPC_CaseProfilegp.Text = "NPC_CaseProfile";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(293, 39);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(293, 90);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(293, 147);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 3;
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(293, 208);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 4;
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(40, 325);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(403, 139);
            textBox5.TabIndex = 5;
            textBox5.Visible = false;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 93);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 7;
            label2.Text = "Last Name";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 214);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 9;
            label4.Text = "Role";
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 41);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(149, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Mark as Guilty";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(16, 98);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(173, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mark as Innocent";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Verdict_gp
            // 
            Verdict_gp.Controls.Add(radioButton3);
            Verdict_gp.Controls.Add(radioButton1);
            Verdict_gp.Controls.Add(radioButton2);
            Verdict_gp.Location = new Point(592, 157);
            Verdict_gp.Name = "Verdict_gp";
            Verdict_gp.Size = new Size(205, 207);
            Verdict_gp.TabIndex = 7;
            Verdict_gp.TabStop = false;
            Verdict_gp.Text = "Verdict";
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
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(16, 148);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(183, 29);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Mark as Cold Case";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(592, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 33);
            comboBox1.TabIndex = 9;
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
            // CaseProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 174, 200);
            ClientSize = new Size(819, 535);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(Verdict_gp);
            Controls.Add(NPC_CaseProfilegp);
            Name = "CaseProfile";
            Text = "Case Folder";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            NPC_CaseProfilegp.ResumeLayout(false);
            NPC_CaseProfilegp.PerformLayout();
            Verdict_gp.ResumeLayout(false);
            Verdict_gp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox NPC_CaseProfilegp;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox Verdict_gp;
        private Button button1;
        private RadioButton radioButton3;
        private ComboBox comboBox1;
        private Label label6;
    }
}