namespace AdvancedProject1._0
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.btnBack = new System.Windows.Forms.Button();
            this.panelReport = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbReply = new System.Windows.Forms.RichTextBox();
            this.tbReport = new System.Windows.Forms.RichTextBox();
            this.btnReply = new System.Windows.Forms.Button();
            this.lblReporterName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelReport
            // 
            this.panelReport.AutoScroll = true;
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReport.Location = new System.Drawing.Point(0, 41);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(175, 397);
            this.panelReport.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.tbReply);
            this.panel1.Controls.Add(this.tbReport);
            this.panel1.Controls.Add(this.btnReply);
            this.panel1.Controls.Add(this.lblReporterName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(175, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 438);
            this.panel1.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(342, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 75);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbReply
            // 
            this.tbReply.Location = new System.Drawing.Point(19, 273);
            this.tbReply.Name = "tbReply";
            this.tbReply.Size = new System.Drawing.Size(317, 153);
            this.tbReply.TabIndex = 7;
            this.tbReply.Text = "";
            // 
            // tbReport
            // 
            this.tbReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReport.Location = new System.Drawing.Point(18, 52);
            this.tbReport.Name = "tbReport";
            this.tbReport.ReadOnly = true;
            this.tbReport.Size = new System.Drawing.Size(399, 215);
            this.tbReport.TabIndex = 6;
            this.tbReport.Text = "";
            // 
            // btnReply
            // 
            this.btnReply.Location = new System.Drawing.Point(342, 273);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(75, 75);
            this.btnReply.TabIndex = 4;
            this.btnReply.Text = "Reply";
            this.btnReply.UseVisualStyleBackColor = true;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // lblReporterName
            // 
            this.lblReporterName.AutoSize = true;
            this.lblReporterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblReporterName.Location = new System.Drawing.Point(15, 12);
            this.lblReporterName.Name = "lblReporterName";
            this.lblReporterName.Size = new System.Drawing.Size(0, 20);
            this.lblReporterName.TabIndex = 1;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 826);
            this.ClientSize = new System.Drawing.Size(603, 438);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reports_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.FlowLayoutPanel panelReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox tbReply;
        private System.Windows.Forms.RichTextBox tbReport;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Label lblReporterName;
    }
}