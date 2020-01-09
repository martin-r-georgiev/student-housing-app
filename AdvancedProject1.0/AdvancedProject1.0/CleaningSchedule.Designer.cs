namespace AdvancedProject1._0
{
    partial class CleaningSchedule
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.CalendarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 41);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label41.Location = new System.Drawing.Point(810, 99);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(134, 39);
            this.label41.TabIndex = 2;
            this.label41.Text = "TRASH";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label42.Location = new System.Drawing.Point(255, 20);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(305, 39);
            this.label42.TabIndex = 3;
            this.label42.Text = "Cleaning Schedule";
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.AutoScroll = true;
            this.CalendarPanel.Location = new System.Drawing.Point(13, 99);
            this.CalendarPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new System.Drawing.Size(792, 425);
            this.CalendarPanel.TabIndex = 4;
            // 
            // CleaningSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 535);
            this.Controls.Add(this.CalendarPanel);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.btnBack);
            this.Name = "CleaningSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CleaningSchedule";
            this.Load += new System.EventHandler(this.CleaningSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.FlowLayoutPanel CalendarPanel;
    }
}