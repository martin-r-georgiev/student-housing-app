namespace AdvancedProject1._0
{
    partial class Social
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
            this.lbChat = new System.Windows.Forms.ListBox();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.btnSendChat = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tcChats = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.lbGeneralChat = new System.Windows.Forms.ListBox();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.tcChats.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 16;
            this.lbChat.Location = new System.Drawing.Point(-5, 0);
            this.lbChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(455, 404);
            this.lbChat.TabIndex = 0;
            this.lbChat.SelectedIndexChanged += new System.EventHandler(this.LbChat_SelectedIndexChanged);
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(16, 500);
            this.tbChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(371, 22);
            this.tbChat.TabIndex = 1;
            // 
            // btnSendChat
            // 
            this.btnSendChat.Location = new System.Drawing.Point(396, 500);
            this.btnSendChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Size = new System.Drawing.Size(89, 25);
            this.btnSendChat.TabIndex = 2;
            this.btnSendChat.Text = "Send";
            this.btnSendChat.UseVisualStyleBackColor = true;
            this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(505, 11);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(117, 70);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 44);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tcChats
            // 
            this.tcChats.Controls.Add(this.tp1);
            this.tcChats.Controls.Add(this.tp2);
            this.tcChats.Location = new System.Drawing.Point(16, 63);
            this.tcChats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcChats.Name = "tcChats";
            this.tcChats.SelectedIndex = 0;
            this.tcChats.Size = new System.Drawing.Size(469, 430);
            this.tcChats.TabIndex = 5;
            this.tcChats.SelectedIndexChanged += new System.EventHandler(this.tcChats_SelectedIndexChanged);
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.lbGeneralChat);
            this.tp1.Location = new System.Drawing.Point(4, 25);
            this.tp1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp1.Size = new System.Drawing.Size(461, 401);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "General";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // lbGeneralChat
            // 
            this.lbGeneralChat.FormattingEnabled = true;
            this.lbGeneralChat.ItemHeight = 16;
            this.lbGeneralChat.Location = new System.Drawing.Point(-5, -2);
            this.lbGeneralChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbGeneralChat.Name = "lbGeneralChat";
            this.lbGeneralChat.Size = new System.Drawing.Size(468, 404);
            this.lbGeneralChat.TabIndex = 6;
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.lbChat);
            this.tp2.Location = new System.Drawing.Point(4, 25);
            this.tp2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp2.Size = new System.Drawing.Size(461, 401);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "House Unit";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // Social
            // 
            this.AcceptButton = this.btnSendChat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 539);
            this.Controls.Add(this.tcChats);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSendChat);
            this.Controls.Add(this.tbChat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Social";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Social";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Social_FormClosing);
            this.Load += new System.EventHandler(this.Social_Load);
            this.tcChats.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.Button btnSendChat;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tcChats;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.ListBox lbGeneralChat;
    }
}