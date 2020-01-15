namespace AdvancedProject1._0
{
    partial class ReportPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(46, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 10);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReportPanel_MouseClick);
            this.panel1.MouseEnter += new System.EventHandler(this.ReportPanel_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.ReportPanel_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 74);
            this.panel2.TabIndex = 0;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReportPanel_MouseClick);
            this.panel2.MouseEnter += new System.EventHandler(this.ReportPanel_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.ReportPanel_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(45, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Kiril 110";
            this.lblName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReportPanel_MouseClick);
            this.lblName.MouseEnter += new System.EventHandler(this.ReportPanel_MouseEnter);
            this.lblName.MouseLeave += new System.EventHandler(this.ReportPanel_MouseLeave);
            // 
            // lblReport
            // 
            this.lblReport.Location = new System.Drawing.Point(45, 37);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(86, 22);
            this.lblReport.TabIndex = 2;
            this.lblReport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReportPanel_MouseClick);
            this.lblReport.MouseEnter += new System.EventHandler(this.ReportPanel_MouseEnter);
            this.lblReport.MouseLeave += new System.EventHandler(this.ReportPanel_MouseLeave);
            // 
            // ReportPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportPanel";
            this.Size = new System.Drawing.Size(149, 74);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReportPanel_MouseClick);
            this.MouseEnter += new System.EventHandler(this.ReportPanel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ReportPanel_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReport;
    }
}
