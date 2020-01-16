namespace AdvancedProject1._0
{
    partial class ReportPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPopup));
            this.btnSendReport = new System.Windows.Forms.Button();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendReport
            // 
            this.btnSendReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendReport.BackgroundImage")));
            this.btnSendReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendReport.FlatAppearance.BorderSize = 0;
            this.btnSendReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendReport.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSendReport.Location = new System.Drawing.Point(364, 182);
            this.btnSendReport.Name = "btnSendReport";
            this.btnSendReport.Size = new System.Drawing.Size(102, 36);
            this.btnSendReport.TabIndex = 0;
            this.btnSendReport.Text = "Send";
            this.btnSendReport.UseVisualStyleBackColor = true;
            this.btnSendReport.Click += new System.EventHandler(this.btnSendReport_Click);
            // 
            // tbReport
            // 
            this.tbReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReport.Location = new System.Drawing.Point(3, 3);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(448, 166);
            this.tbReport.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.tbReport);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 172);
            this.panel1.TabIndex = 3;
            // 
            // ReportPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(480, 228);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSendReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(496, 267);
            this.Name = "ReportPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportPopup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendReport;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Panel panel1;
    }
}