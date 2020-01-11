﻿namespace AdvancedProject1._0
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
            this.tp2 = new System.Windows.Forms.TabPage();
            this.lbGeneralChat = new System.Windows.Forms.ListBox();
            this.tcChats.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.Location = new System.Drawing.Point(-4, 0);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(342, 329);
            this.lbChat.TabIndex = 0;
            this.lbChat.SelectedIndexChanged += new System.EventHandler(this.LbChat_SelectedIndexChanged);
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(12, 406);
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(279, 20);
            this.tbChat.TabIndex = 1;
            // 
            // btnSendChat
            // 
            this.btnSendChat.Location = new System.Drawing.Point(297, 406);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Size = new System.Drawing.Size(67, 20);
            this.btnSendChat.TabIndex = 2;
            this.btnSendChat.Text = "Send";
            this.btnSendChat.UseVisualStyleBackColor = true;
            this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(379, 9);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(88, 57);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 36);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tcChats
            // 
            this.tcChats.Controls.Add(this.tp1);
            this.tcChats.Controls.Add(this.tp2);
            this.tcChats.Location = new System.Drawing.Point(12, 51);
            this.tcChats.Name = "tcChats";
            this.tcChats.SelectedIndex = 0;
            this.tcChats.Size = new System.Drawing.Size(352, 349);
            this.tcChats.TabIndex = 5;
            this.tcChats.SelectedIndexChanged += new System.EventHandler(this.tcChats_SelectedIndexChanged);
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.lbGeneralChat);
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(344, 323);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "General";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.lbChat);
            this.tp2.Location = new System.Drawing.Point(4, 22);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(344, 323);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "House Unit";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // lbGeneralChat
            // 
            this.lbGeneralChat.FormattingEnabled = true;
            this.lbGeneralChat.Location = new System.Drawing.Point(-4, -2);
            this.lbGeneralChat.Name = "lbGeneralChat";
            this.lbGeneralChat.Size = new System.Drawing.Size(352, 329);
            this.lbGeneralChat.TabIndex = 6;
            // 
            // Social
            // 
            this.AcceptButton = this.btnSendChat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 438);
            this.Controls.Add(this.tcChats);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSendChat);
            this.Controls.Add(this.tbChat);
            this.Name = "Social";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Social";
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