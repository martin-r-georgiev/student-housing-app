namespace AdvancedProject1._0
{
    partial class AdminCalendar
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
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.pbEventImage = new System.Windows.Forms.PictureBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.CalendarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label42 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.rtbTitle = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblYear.Location = new System.Drawing.Point(156, 7);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(106, 39);
            this.lblYear.TabIndex = 19;
            this.lblYear.Text = "[Year]";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMonth.Location = new System.Drawing.Point(19, 7);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(136, 39);
            this.lblMonth.TabIndex = 18;
            this.lblMonth.Text = "[Month]";
            // 
            // pbEventImage
            // 
            this.pbEventImage.Location = new System.Drawing.Point(1018, 63);
            this.pbEventImage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pbEventImage.Name = "pbEventImage";
            this.pbEventImage.Size = new System.Drawing.Size(130, 119);
            this.pbEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEventImage.TabIndex = 17;
            this.pbEventImage.TabStop = false;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(997, 468);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(176, 40);
            this.btnAddEvent.TabIndex = 16;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(979, 223);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(212, 240);
            this.rtbDescription.TabIndex = 15;
            this.rtbDescription.Text = "";
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.AutoScroll = true;
            this.CalendarPanel.Location = new System.Drawing.Point(26, 55);
            this.CalendarPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new System.Drawing.Size(921, 580);
            this.CalendarPanel.TabIndex = 14;
            this.CalendarPanel.SizeChanged += new System.EventHandler(this.CalendarPanel_SizeChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label42.Location = new System.Drawing.Point(476, 10);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(156, 39);
            this.label42.TabIndex = 13;
            this.label42.Text = "Calendar";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1236, 32);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 41);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbUnits
            // 
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(736, 19);
            this.cmbUnits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(212, 21);
            this.cmbUnits.TabIndex = 20;
            this.cmbUnits.DropDown += new System.EventHandler(this.cmbUnits_DropDown);
            this.cmbUnits.SelectedIndexChanged += new System.EventHandler(this.cmbUnits_SelectedIndexChanged);
            // 
            // rtbTitle
            // 
            this.rtbTitle.BackColor = System.Drawing.SystemColors.Control;
            this.rtbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbTitle.Location = new System.Drawing.Point(1305, 232);
            this.rtbTitle.Name = "rtbTitle";
            this.rtbTitle.ReadOnly = true;
            this.rtbTitle.Size = new System.Drawing.Size(279, 24);
            this.rtbTitle.TabIndex = 21;
            this.rtbTitle.Text = "";
            // 
            // AdminCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1733, 815);
            this.Controls.Add(this.rtbTitle);
            this.Controls.Add(this.cmbUnits);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.pbEventImage);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.CalendarPanel);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1317, 708);
            this.Name = "AdminCalendar";
            this.Text = "AdminCalendar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminCalendar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.PictureBox pbEventImage;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.FlowLayoutPanel CalendarPanel;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.RichTextBox rtbTitle;
    }
}