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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleaningSchedule));
            this.btnBack = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.CalendarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnGenerateSchedule = new System.Windows.Forms.Button();
            this.pbEventImage = new System.Windows.Forms.PictureBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.pbGarbage = new System.Windows.Forms.ProgressBar();
            this.lblGarbageStatus = new System.Windows.Forms.Label();
            this.lblGarbageName = new System.Windows.Forms.Label();
            this.cbArduino = new System.Windows.Forms.ComboBox();
            this.timerArduino = new System.Windows.Forms.Timer(this.components);
            this.spArduino = new System.IO.Ports.SerialPort(this.components);
            this.rtbTitle = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1513, 25);
            this.btnBack.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label42.Location = new System.Drawing.Point(567, 16);
            this.label42.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(197, 51);
            this.label42.TabIndex = 3;
            this.label42.Text = "Calendar";
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.AutoScroll = true;
            this.CalendarPanel.Location = new System.Drawing.Point(31, 85);
            this.CalendarPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new System.Drawing.Size(1228, 714);
            this.CalendarPanel.TabIndex = 4;
            this.CalendarPanel.SizeChanged += new System.EventHandler(this.CalendarPanel_SizeChanged);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(1293, 313);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 20, 4);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(281, 294);
            this.rtbDescription.TabIndex = 5;
            this.rtbDescription.Text = "";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(1317, 615);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(235, 49);
            this.btnAddEvent.TabIndex = 6;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnGenerateSchedule
            // 
            this.btnGenerateSchedule.Location = new System.Drawing.Point(1317, 674);
            this.btnGenerateSchedule.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGenerateSchedule.Name = "btnGenerateSchedule";
            this.btnGenerateSchedule.Size = new System.Drawing.Size(235, 52);
            this.btnGenerateSchedule.TabIndex = 9;
            this.btnGenerateSchedule.Text = "Cleaning Schedule Settings";
            this.btnGenerateSchedule.UseVisualStyleBackColor = true;
            this.btnGenerateSchedule.Click += new System.EventHandler(this.btnGenerateSchedule_Click);
            // 
            // pbEventImage
            // 
            this.pbEventImage.Location = new System.Drawing.Point(1345, 116);
            this.pbEventImage.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pbEventImage.Name = "pbEventImage";
            this.pbEventImage.Size = new System.Drawing.Size(173, 146);
            this.pbEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEventImage.TabIndex = 8;
            this.pbEventImage.TabStop = false;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMonth.Location = new System.Drawing.Point(27, 7);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(173, 51);
            this.lblMonth.TabIndex = 10;
            this.lblMonth.Text = "[Month]";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblYear.Location = new System.Drawing.Point(229, 7);
            this.lblYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(137, 51);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "[Year]";
            // 
            // pbGarbage
            // 
            this.pbGarbage.Location = new System.Drawing.Point(23, 826);
            this.pbGarbage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbGarbage.Name = "pbGarbage";
            this.pbGarbage.Size = new System.Drawing.Size(1228, 28);
            this.pbGarbage.TabIndex = 12;
            this.pbGarbage.Visible = false;
            // 
            // lblGarbageStatus
            // 
            this.lblGarbageStatus.AutoSize = true;
            this.lblGarbageStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblGarbageStatus.Location = new System.Drawing.Point(523, 798);
            this.lblGarbageStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGarbageStatus.Name = "lblGarbageStatus";
            this.lblGarbageStatus.Size = new System.Drawing.Size(162, 25);
            this.lblGarbageStatus.TabIndex = 13;
            this.lblGarbageStatus.Text = "Garbage Status";
            this.lblGarbageStatus.Visible = false;
            // 
            // lblGarbageName
            // 
            this.lblGarbageName.AutoSize = true;
            this.lblGarbageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarbageName.Location = new System.Drawing.Point(1289, 827);
            this.lblGarbageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGarbageName.Name = "lblGarbageName";
            this.lblGarbageName.Size = new System.Drawing.Size(203, 24);
            this.lblGarbageName.TabIndex = 14;
            this.lblGarbageName.Text = "Garbage Disposal: Ivan";
            this.lblGarbageName.Visible = false;
            // 
            // cbArduino
            // 
            this.cbArduino.FormattingEnabled = true;
            this.cbArduino.Location = new System.Drawing.Point(529, 828);
            this.cbArduino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbArduino.Name = "cbArduino";
            this.cbArduino.Size = new System.Drawing.Size(160, 24);
            this.cbArduino.TabIndex = 15;
            this.cbArduino.DropDown += new System.EventHandler(this.cbArduino_DropDown);
            this.cbArduino.SelectedIndexChanged += new System.EventHandler(this.cbArduino_SelectedIndexChanged);
            // 
            // timerArduino
            // 
            this.timerArduino.Tick += new System.EventHandler(this.timerArduino_Tick);
            // 
            // rtbTitle
            // 
            this.rtbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbTitle.Location = new System.Drawing.Point(1295, 275);
            this.rtbTitle.Name = "rtbTitle";
            this.rtbTitle.ReadOnly = true;
            this.rtbTitle.Size = new System.Drawing.Size(279, 24);
            this.rtbTitle.TabIndex = 16;
            this.rtbTitle.Text = "";
            // 
            // CleaningSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1901, 988);
            this.Controls.Add(this.rtbTitle);
            this.Controls.Add(this.cbArduino);
            this.Controls.Add(this.lblGarbageName);
            this.Controls.Add(this.lblGarbageStatus);
            this.Controls.Add(this.pbGarbage);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btnGenerateSchedule);
            this.Controls.Add(this.pbEventImage);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.CalendarPanel);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(1917, 1025);
            this.Name = "CleaningSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CleaningSchedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CleaningSchedule_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.FlowLayoutPanel CalendarPanel;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.PictureBox pbEventImage;
        private System.Windows.Forms.Button btnGenerateSchedule;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ProgressBar pbGarbage;
        private System.Windows.Forms.Label lblGarbageStatus;
        private System.Windows.Forms.Label lblGarbageName;
        private System.Windows.Forms.ComboBox cbArduino;
        private System.Windows.Forms.Timer timerArduino;
        private System.IO.Ports.SerialPort spArduino;
        private System.Windows.Forms.RichTextBox rtbTitle;
    }
}