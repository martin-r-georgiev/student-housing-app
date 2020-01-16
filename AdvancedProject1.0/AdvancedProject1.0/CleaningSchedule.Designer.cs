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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitleEvent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDescriptionEvent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.pbGarbageIcon = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblSelectPort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGarbageIcon)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(122)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(122)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(14, 16);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.AutoScroll = true;
            this.CalendarPanel.Location = new System.Drawing.Point(26, 131);
            this.CalendarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new System.Drawing.Size(921, 580);
            this.CalendarPanel.TabIndex = 4;
            this.CalendarPanel.SizeChanged += new System.EventHandler(this.CalendarPanel_SizeChanged);
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDescription.Location = new System.Drawing.Point(2, 2);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(226, 236);
            this.rtbDescription.TabIndex = 5;
            this.rtbDescription.Text = "";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddEvent.BackgroundImage")));
            this.btnAddEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEvent.FlatAppearance.BorderSize = 0;
            this.btnAddEvent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAddEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEvent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddEvent.Location = new System.Drawing.Point(970, 620);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(230, 40);
            this.btnAddEvent.TabIndex = 6;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnGenerateSchedule
            // 
            this.btnGenerateSchedule.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateSchedule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerateSchedule.BackgroundImage")));
            this.btnGenerateSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerateSchedule.FlatAppearance.BorderSize = 0;
            this.btnGenerateSchedule.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnGenerateSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGenerateSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateSchedule.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerateSchedule.Location = new System.Drawing.Point(970, 669);
            this.btnGenerateSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateSchedule.Name = "btnGenerateSchedule";
            this.btnGenerateSchedule.Size = new System.Drawing.Size(230, 42);
            this.btnGenerateSchedule.TabIndex = 9;
            this.btnGenerateSchedule.Text = "Cleaning Schedule Settings";
            this.btnGenerateSchedule.UseVisualStyleBackColor = false;
            this.btnGenerateSchedule.Click += new System.EventHandler(this.btnGenerateSchedule_Click);
            // 
            // pbEventImage
            // 
            this.pbEventImage.Location = new System.Drawing.Point(1021, 131);
            this.pbEventImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbEventImage.Name = "pbEventImage";
            this.pbEventImage.Size = new System.Drawing.Size(125, 125);
            this.pbEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEventImage.TabIndex = 8;
            this.pbEventImage.TabStop = false;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.lblMonth.Location = new System.Drawing.Point(358, 81);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(136, 39);
            this.lblMonth.TabIndex = 10;
            this.lblMonth.Text = "[Month]";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.lblYear.Location = new System.Drawing.Point(495, 81);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(106, 39);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "[Year]";
            // 
            // pbGarbage
            // 
            this.pbGarbage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbGarbage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.pbGarbage.Location = new System.Drawing.Point(26, 743);
            this.pbGarbage.Name = "pbGarbage";
            this.pbGarbage.Size = new System.Drawing.Size(921, 34);
            this.pbGarbage.TabIndex = 12;
            this.pbGarbage.Visible = false;
            // 
            // lblGarbageStatus
            // 
            this.lblGarbageStatus.AutoSize = true;
            this.lblGarbageStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGarbageStatus.Location = new System.Drawing.Point(416, 715);
            this.lblGarbageStatus.Name = "lblGarbageStatus";
            this.lblGarbageStatus.Size = new System.Drawing.Size(139, 25);
            this.lblGarbageStatus.TabIndex = 13;
            this.lblGarbageStatus.Text = "Garbage Status";
            this.lblGarbageStatus.Visible = false;
            // 
            // lblGarbageName
            // 
            this.lblGarbageName.AutoSize = true;
            this.lblGarbageName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGarbageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.lblGarbageName.Location = new System.Drawing.Point(1054, 743);
            this.lblGarbageName.Name = "lblGarbageName";
            this.lblGarbageName.Size = new System.Drawing.Size(107, 25);
            this.lblGarbageName.TabIndex = 14;
            this.lblGarbageName.Text = "Aleksandar";
            this.lblGarbageName.Visible = false;
            // 
            // cbArduino
            // 
            this.cbArduino.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbArduino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbArduino.FormattingEnabled = true;
            this.cbArduino.Location = new System.Drawing.Point(2, 2);
            this.cbArduino.Name = "cbArduino";
            this.cbArduino.Size = new System.Drawing.Size(121, 21);
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
            this.rtbTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rtbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbTitle.Location = new System.Drawing.Point(2, 2);
            this.rtbTitle.Margin = new System.Windows.Forms.Padding(2);
            this.rtbTitle.Name = "rtbTitle";
            this.rtbTitle.ReadOnly = true;
            this.rtbTitle.Size = new System.Drawing.Size(226, 26);
            this.rtbTitle.TabIndex = 16;
            this.rtbTitle.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel3.Controls.Add(this.rtbTitle);
            this.panel3.Location = new System.Drawing.Point(970, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 30);
            this.panel3.TabIndex = 29;
            // 
            // lblTitleEvent
            // 
            this.lblTitleEvent.AutoSize = true;
            this.lblTitleEvent.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleEvent.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleEvent.Location = new System.Drawing.Point(966, 273);
            this.lblTitleEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleEvent.Name = "lblTitleEvent";
            this.lblTitleEvent.Size = new System.Drawing.Size(113, 23);
            this.lblTitleEvent.TabIndex = 30;
            this.lblTitleEvent.Text = "Title of event:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.rtbDescription);
            this.panel2.Location = new System.Drawing.Point(970, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 240);
            this.panel2.TabIndex = 31;
            // 
            // lblDescriptionEvent
            // 
            this.lblDescriptionEvent.AutoSize = true;
            this.lblDescriptionEvent.BackColor = System.Drawing.Color.Transparent;
            this.lblDescriptionEvent.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescriptionEvent.Location = new System.Drawing.Point(966, 335);
            this.lblDescriptionEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescriptionEvent.Name = "lblDescriptionEvent";
            this.lblDescriptionEvent.Size = new System.Drawing.Size(141, 23);
            this.lblDescriptionEvent.TabIndex = 25;
            this.lblDescriptionEvent.Text = "Info about event:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblCalendar);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 67);
            this.panel1.TabIndex = 32;
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.BackColor = System.Drawing.Color.Transparent;
            this.lblCalendar.Font = new System.Drawing.Font("Segoe UI Semibold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalendar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCalendar.Location = new System.Drawing.Point(59, 4);
            this.lblCalendar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(197, 59);
            this.lblCalendar.TabIndex = 13;
            this.lblCalendar.Text = "Calendar";
            // 
            // pbGarbageIcon
            // 
            this.pbGarbageIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbGarbageIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGarbageIcon.BackgroundImage")));
            this.pbGarbageIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGarbageIcon.Location = new System.Drawing.Point(970, 721);
            this.pbGarbageIcon.Name = "pbGarbageIcon";
            this.pbGarbageIcon.Size = new System.Drawing.Size(65, 65);
            this.pbGarbageIcon.TabIndex = 33;
            this.pbGarbageIcon.TabStop = false;
            this.pbGarbageIcon.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel6.Controls.Add(this.cbArduino);
            this.panel6.Location = new System.Drawing.Point(813, 747);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(125, 25);
            this.panel6.TabIndex = 34;
            // 
            // lblSelectPort
            // 
            this.lblSelectPort.AutoSize = true;
            this.lblSelectPort.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectPort.Location = new System.Drawing.Point(546, 715);
            this.lblSelectPort.Name = "lblSelectPort";
            this.lblSelectPort.Size = new System.Drawing.Size(392, 25);
            this.lblSelectPort.TabIndex = 35;
            this.lblSelectPort.Text = "Select Arduino port for live Garbage tracking:";
            // 
            // CleaningSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1224, 792);
            this.Controls.Add(this.lblSelectPort);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pbGarbageIcon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDescriptionEvent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTitleEvent);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblGarbageName);
            this.Controls.Add(this.lblGarbageStatus);
            this.Controls.Add(this.pbGarbage);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btnGenerateSchedule);
            this.Controls.Add(this.pbEventImage);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.CalendarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1240, 831);
            this.Name = "CleaningSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CleaningSchedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CleaningSchedule_FormClosing);
            this.Load += new System.EventHandler(this.CleaningSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGarbageIcon)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitleEvent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDescriptionEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.PictureBox pbGarbageIcon;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSelectPort;
    }
}