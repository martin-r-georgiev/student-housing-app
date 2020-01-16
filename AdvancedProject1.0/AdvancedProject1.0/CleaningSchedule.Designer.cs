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
            this.btnBack.Location = new System.Drawing.Point(19, 20);
            this.btnBack.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 44);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.AutoScroll = true;
            this.CalendarPanel.Location = new System.Drawing.Point(35, 161);
            this.CalendarPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new System.Drawing.Size(1228, 714);
            this.CalendarPanel.TabIndex = 4;
            this.CalendarPanel.SizeChanged += new System.EventHandler(this.CalendarPanel_SizeChanged);
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDescription.Location = new System.Drawing.Point(3, 2);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 20, 4);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(301, 290);
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
            this.btnAddEvent.Location = new System.Drawing.Point(1293, 763);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(307, 49);
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
            this.btnGenerateSchedule.Location = new System.Drawing.Point(1293, 823);
            this.btnGenerateSchedule.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGenerateSchedule.Name = "btnGenerateSchedule";
            this.btnGenerateSchedule.Size = new System.Drawing.Size(307, 52);
            this.btnGenerateSchedule.TabIndex = 9;
            this.btnGenerateSchedule.Text = "Cleaning Schedule Settings";
            this.btnGenerateSchedule.UseVisualStyleBackColor = false;
            this.btnGenerateSchedule.Click += new System.EventHandler(this.btnGenerateSchedule_Click);
            // 
            // pbEventImage
            // 
            this.pbEventImage.Location = new System.Drawing.Point(1361, 161);
            this.pbEventImage.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pbEventImage.Name = "pbEventImage";
            this.pbEventImage.Size = new System.Drawing.Size(167, 154);
            this.pbEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEventImage.TabIndex = 8;
            this.pbEventImage.TabStop = false;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.lblMonth.Location = new System.Drawing.Point(477, 100);
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
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.lblYear.Location = new System.Drawing.Point(660, 100);
            this.lblYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(137, 51);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "[Year]";
            // 
            // pbGarbage
            // 
            this.pbGarbage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbGarbage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.pbGarbage.Location = new System.Drawing.Point(35, 914);
            this.pbGarbage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbGarbage.Name = "pbGarbage";
            this.pbGarbage.Size = new System.Drawing.Size(1228, 42);
            this.pbGarbage.TabIndex = 12;
            this.pbGarbage.Visible = false;
            // 
            // lblGarbageStatus
            // 
            this.lblGarbageStatus.AutoSize = true;
            this.lblGarbageStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGarbageStatus.Location = new System.Drawing.Point(555, 880);
            this.lblGarbageStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGarbageStatus.Name = "lblGarbageStatus";
            this.lblGarbageStatus.Size = new System.Drawing.Size(175, 32);
            this.lblGarbageStatus.TabIndex = 13;
            this.lblGarbageStatus.Text = "Garbage Status";
            this.lblGarbageStatus.Visible = false;
            // 
            // lblGarbageName
            // 
            this.lblGarbageName.AutoSize = true;
            this.lblGarbageName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGarbageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.lblGarbageName.Location = new System.Drawing.Point(1405, 914);
            this.lblGarbageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGarbageName.Name = "lblGarbageName";
            this.lblGarbageName.Size = new System.Drawing.Size(136, 32);
            this.lblGarbageName.TabIndex = 14;
            this.lblGarbageName.Text = "Aleksandar";
            this.lblGarbageName.Visible = false;
            // 
            // cbArduino
            // 
            this.cbArduino.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbArduino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArduino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbArduino.FormattingEnabled = true;
            this.cbArduino.Location = new System.Drawing.Point(3, 2);
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
            this.rtbTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rtbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbTitle.Location = new System.Drawing.Point(3, 2);
            this.rtbTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbTitle.Name = "rtbTitle";
            this.rtbTitle.ReadOnly = true;
            this.rtbTitle.Size = new System.Drawing.Size(301, 32);
            this.rtbTitle.TabIndex = 16;
            this.rtbTitle.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel3.Controls.Add(this.rtbTitle);
            this.panel3.Location = new System.Drawing.Point(1293, 368);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 37);
            this.panel3.TabIndex = 29;
            // 
            // lblTitleEvent
            // 
            this.lblTitleEvent.AutoSize = true;
            this.lblTitleEvent.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleEvent.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleEvent.Location = new System.Drawing.Point(1288, 336);
            this.lblTitleEvent.Name = "lblTitleEvent";
            this.lblTitleEvent.Size = new System.Drawing.Size(145, 30);
            this.lblTitleEvent.TabIndex = 30;
            this.lblTitleEvent.Text = "Title of event:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.rtbDescription);
            this.panel2.Location = new System.Drawing.Point(1293, 444);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 295);
            this.panel2.TabIndex = 31;
            // 
            // lblDescriptionEvent
            // 
            this.lblDescriptionEvent.AutoSize = true;
            this.lblDescriptionEvent.BackColor = System.Drawing.Color.Transparent;
            this.lblDescriptionEvent.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescriptionEvent.Location = new System.Drawing.Point(1288, 412);
            this.lblDescriptionEvent.Name = "lblDescriptionEvent";
            this.lblDescriptionEvent.Size = new System.Drawing.Size(178, 30);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1632, 82);
            this.panel1.TabIndex = 32;
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.BackColor = System.Drawing.Color.Transparent;
            this.lblCalendar.Font = new System.Drawing.Font("Segoe UI Semibold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalendar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCalendar.Location = new System.Drawing.Point(79, 5);
            this.lblCalendar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(248, 72);
            this.lblCalendar.TabIndex = 13;
            this.lblCalendar.Text = "Calendar";
            // 
            // pbGarbageIcon
            // 
            this.pbGarbageIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbGarbageIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGarbageIcon.BackgroundImage")));
            this.pbGarbageIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGarbageIcon.Location = new System.Drawing.Point(1293, 887);
            this.pbGarbageIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbGarbageIcon.Name = "pbGarbageIcon";
            this.pbGarbageIcon.Size = new System.Drawing.Size(87, 80);
            this.pbGarbageIcon.TabIndex = 33;
            this.pbGarbageIcon.TabStop = false;
            this.pbGarbageIcon.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel6.Controls.Add(this.cbArduino);
            this.panel6.Location = new System.Drawing.Point(1084, 919);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 31);
            this.panel6.TabIndex = 34;
            // 
            // lblSelectPort
            // 
            this.lblSelectPort.AutoSize = true;
            this.lblSelectPort.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectPort.Location = new System.Drawing.Point(728, 880);
            this.lblSelectPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectPort.Name = "lblSelectPort";
            this.lblSelectPort.Size = new System.Drawing.Size(496, 32);
            this.lblSelectPort.TabIndex = 35;
            this.lblSelectPort.Text = "Select Arduino port for live Garbage tracking:";
            // 
            // CleaningSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1632, 975);
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(1647, 1012);
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