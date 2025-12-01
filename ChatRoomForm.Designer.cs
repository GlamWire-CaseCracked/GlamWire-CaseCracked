namespace GlamWire_Case_Cracked
{
    partial class ChatRoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatRoomForm));
            textBox1 = new TextBox();
            Send_bttn = new Button();
            label1 = new Label();
            label2 = new Label();
            ChatLog_box = new ListBox();
            NPCLog_box = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 495);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(436, 79);
            textBox1.TabIndex = 0;
            textBox1.Text = "Choose Prompt to Reply:";
            // 
            // Send_bttn
            // 
            Send_bttn.Location = new Point(454, 505);
            Send_bttn.Name = "Send_bttn";
            Send_bttn.Size = new Size(148, 59);
            Send_bttn.TabIndex = 2;
            Send_bttn.Text = "Send";
            Send_bttn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 46);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 3;
            label1.Text = "Unread Messages";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 46);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 4;
            label2.Text = "Player Name *ph*";
            // 
            // ChatLog_box
            // 
            ChatLog_box.FormattingEnabled = true;
            ChatLog_box.Location = new Point(12, 89);
            ChatLog_box.Name = "ChatLog_box";
            ChatLog_box.Size = new Size(416, 379);
            ChatLog_box.TabIndex = 1;
            // 
            // NPCLog_box
            // 
            NPCLog_box.FormattingEnabled = true;
            NPCLog_box.Location = new Point(443, 89);
            NPCLog_box.Name = "NPCLog_box";
            NPCLog_box.Size = new Size(168, 379);
            NPCLog_box.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 46);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 7;
            label4.Text = "Friends";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 618);
            label5.Name = "label5";
            label5.Size = new Size(254, 25);
            label5.TabIndex = 8;
            label5.Text = "placeholder* PROMPTS HERE1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(310, 618);
            label6.Name = "label6";
            label6.Size = new Size(254, 25);
            label6.TabIndex = 9;
            label6.Text = "placeholder* PROMPTS HERE2";
            // 
            // ChatRoomForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 174, 200);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(621, 677);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(NPCLog_box);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Send_bttn);
            Controls.Add(ChatLog_box);
            Controls.Add(textBox1);
            Name = "ChatRoomForm";
            Text = "Chatroom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Send_bttn;
        private Label label1;
        private Label label2;
        private ListBox ChatLog_box;
        private ListBox NPCLog_box;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}