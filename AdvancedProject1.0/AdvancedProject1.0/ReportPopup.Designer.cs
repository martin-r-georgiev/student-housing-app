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
            this.btnSendReport = new System.Windows.Forms.Button();
            this.tbHouseNr = new System.Windows.Forms.TextBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.lblHouse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendReport
            // 
            this.btnSendReport.Location = new System.Drawing.Point(176, 135);
            this.btnSendReport.Name = "btnSendReport";
            this.btnSendReport.Size = new System.Drawing.Size(75, 23);
            this.btnSendReport.TabIndex = 0;
            this.btnSendReport.Text = "Send";
            this.btnSendReport.UseVisualStyleBackColor = true;
            this.btnSendReport.Click += new System.EventHandler(this.btnSendReport_Click);
            // 
            // tbHouseNr
            // 
            this.tbHouseNr.Location = new System.Drawing.Point(12, 25);
            this.tbHouseNr.Name = "tbHouseNr";
            this.tbHouseNr.Size = new System.Drawing.Size(100, 20);
            this.tbHouseNr.TabIndex = 1;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(12, 50);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(239, 79);
            this.tbReport.TabIndex = 2;
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.Location = new System.Drawing.Point(12, 9);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(55, 13);
            this.lblHouse.TabIndex = 3;
            this.lblHouse.Text = "House Nr.";
            // 
            // ReportPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 170);
            this.Controls.Add(this.lblHouse);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.tbHouseNr);
            this.Controls.Add(this.btnSendReport);
            this.Name = "ReportPopup";
            this.Text = "ReportPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendReport;
        private System.Windows.Forms.TextBox tbHouseNr;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Label lblHouse;
    }
}