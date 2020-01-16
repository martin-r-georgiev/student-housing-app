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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCalendar));
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.pbEventImage = new System.Windows.Forms.PictureBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.CalendarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.rtbTitle = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleEvent = new System.Windows.Forms.Label();
            this.lblDescriptionEvent = new System.Windows.Forms.Label();
            this.lblCreateNewEvent = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.lblYear.TabIndex = 19;
            this.lblYear.Text = "[Year]";
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
            this.lblMonth.TabIndex = 18;
            this.lblMonth.Text = "[Month]";
            // 
            // pbEventImage
            // 
            this.pbEventImage.Location = new System.Drawing.Point(1021, 131);
            this.pbEventImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbEventImage.Name = "pbEventImage";
            this.pbEventImage.Size = new System.Drawing.Size(125, 125);
            this.pbEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEventImage.TabIndex = 17;
            this.pbEventImage.TabStop = false;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddEvent.BackgroundImage")));
            this.btnAddEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEvent.FlatAppearance.BorderSize = 0;
            this.btnAddEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEvent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddEvent.Location = new System.Drawing.Point(970, 671);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(230, 40);
            this.btnAddEvent.TabIndex = 16;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
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
            this.rtbDescription.TabIndex = 15;
            this.rtbDescription.Text = "";
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.AutoScroll = true;
            this.CalendarPanel.Location = new System.Drawing.Point(26, 131);
            this.CalendarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new System.Drawing.Size(921, 580);
            this.CalendarPanel.TabIndex = 14;
            this.CalendarPanel.SizeChanged += new System.EventHandler(this.CalendarPanel_SizeChanged);
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
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbUnits
            // 
            this.cmbUnits.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(2, 2);
            this.cmbUnits.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(150, 21);
            this.cmbUnits.TabIndex = 20;
            this.cmbUnits.DropDown += new System.EventHandler(this.cmbUnits_DropDown);
            this.cmbUnits.SelectedIndexChanged += new System.EventHandler(this.cmbUnits_SelectedIndexChanged);
            // 
            // rtbTitle
            // 
            this.rtbTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rtbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbTitle.Location = new System.Drawing.Point(2, 2);
            this.rtbTitle.Name = "rtbTitle";
            this.rtbTitle.ReadOnly = true;
            this.rtbTitle.Size = new System.Drawing.Size(226, 26);
            this.rtbTitle.TabIndex = 21;
            this.rtbTitle.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblCalendar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 67);
            this.panel1.TabIndex = 22;
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
            this.lblTitleEvent.TabIndex = 23;
            this.lblTitleEvent.Text = "Title of event:";
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
            this.lblDescriptionEvent.TabIndex = 24;
            this.lblDescriptionEvent.Text = "Info about event:";
            // 
            // lblCreateNewEvent
            // 
            this.lblCreateNewEvent.AutoSize = true;
            this.lblCreateNewEvent.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateNewEvent.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreateNewEvent.Location = new System.Drawing.Point(966, 644);
            this.lblCreateNewEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateNewEvent.Name = "lblCreateNewEvent";
            this.lblCreateNewEvent.Size = new System.Drawing.Size(161, 23);
            this.lblCreateNewEvent.TabIndex = 25;
            this.lblCreateNewEvent.Text = "Create a new event:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel6.Controls.Add(this.cmbUnits);
            this.panel6.Location = new System.Drawing.Point(793, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(154, 25);
            this.panel6.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.rtbDescription);
            this.panel2.Location = new System.Drawing.Point(970, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 240);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel3.Controls.Add(this.rtbTitle);
            this.panel3.Location = new System.Drawing.Point(970, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 30);
            this.panel3.TabIndex = 28;
            // 
            // AdminCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1224, 733);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblCreateNewEvent);
            this.Controls.Add(this.lblDescriptionEvent);
            this.Controls.Add(this.lblTitleEvent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.pbEventImage);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.CalendarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1240, 772);
            this.Name = "AdminCalendar";
            this.Text = "AdminCalendar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminCalendar_FormClosing);
            this.Load += new System.EventHandler(this.AdminCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.RichTextBox rtbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleEvent;
        private System.Windows.Forms.Label lblDescriptionEvent;
        private System.Windows.Forms.Label lblCreateNewEvent;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}