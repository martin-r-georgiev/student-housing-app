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
            this.SuspendLayout();
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 16;
            this.lbChat.Location = new System.Drawing.Point(16, 63);
            this.lbChat.Margin = new System.Windows.Forms.Padding(4);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(468, 372);
            this.lbChat.TabIndex = 0;
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(16, 453);
            this.tbChat.Margin = new System.Windows.Forms.Padding(4);
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(371, 22);
            this.tbChat.TabIndex = 1;
            // 
            // btnSendChat
            // 
            this.btnSendChat.Location = new System.Drawing.Point(396, 453);
            this.btnSendChat.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Size = new System.Drawing.Size(89, 25);
            this.btnSendChat.TabIndex = 2;
            this.btnSendChat.Text = "Send";
            this.btnSendChat.UseVisualStyleBackColor = true;
            this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(505, 47);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 44);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Social
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 513);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSendChat);
            this.Controls.Add(this.tbChat);
            this.Controls.Add(this.lbChat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Social";
            this.Text = "Social";
            this.Load += new System.EventHandler(this.Social_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.Button btnSendChat;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBack;
    }
}