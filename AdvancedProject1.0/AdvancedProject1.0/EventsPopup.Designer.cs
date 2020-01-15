namespace AdvancedProject1._0
{
    partial class EventsPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsPopup));
            this.dtpEvent = new System.Windows.Forms.DateTimePicker();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbEventImage = new System.Windows.Forms.PictureBox();
            this.cbImageList = new System.Windows.Forms.ComboBox();
            this.lblImageSelect = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbGlobalEvent = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpEvent
            // 
            this.dtpEvent.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.dtpEvent.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpEvent.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.dtpEvent.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.dtpEvent.CustomFormat = "    dd /MMM/ yyyy";
            this.dtpEvent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvent.Location = new System.Drawing.Point(-3, -1);
            this.dtpEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEvent.Name = "dtpEvent";
            this.dtpEvent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpEvent.Size = new System.Drawing.Size(375, 29);
            this.dtpEvent.TabIndex = 0;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTitle.Location = new System.Drawing.Point(19, 247);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(375, 25);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.Enter += new System.EventHandler(this.TbTitle_Enter);
            this.tbTitle.Leave += new System.EventHandler(this.TbTitle_Leave);
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDescription.Location = new System.Drawing.Point(4, 4);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(372, 198);
            this.tbDescription.TabIndex = 2;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateEvent.BackgroundImage")));
            this.btnCreateEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateEvent.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateEvent.FlatAppearance.BorderSize = 3;
            this.btnCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateEvent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateEvent.Location = new System.Drawing.Point(211, 64);
            this.btnCreateEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(186, 56);
            this.btnCreateEvent.TabIndex = 3;
            this.btnCreateEvent.Text = "Create Event\r\n";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // pbEventImage
            // 
            this.pbEventImage.InitialImage = null;
            this.pbEventImage.Location = new System.Drawing.Point(16, 64);
            this.pbEventImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbEventImage.Name = "pbEventImage";
            this.pbEventImage.Size = new System.Drawing.Size(173, 160);
            this.pbEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEventImage.TabIndex = 7;
            this.pbEventImage.TabStop = false;
            // 
            // cbImageList
            // 
            this.cbImageList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbImageList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImageList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbImageList.FormattingEnabled = true;
            this.cbImageList.Location = new System.Drawing.Point(3, 2);
            this.cbImageList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbImageList.Name = "cbImageList";
            this.cbImageList.Size = new System.Drawing.Size(180, 24);
            this.cbImageList.TabIndex = 8;
            this.cbImageList.DropDown += new System.EventHandler(this.cbImageList_DropDown);
            this.cbImageList.SelectedIndexChanged += new System.EventHandler(this.cbImageList_SelectedIndexChanged);
            // 
            // lblImageSelect
            // 
            this.lblImageSelect.AutoSize = true;
            this.lblImageSelect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblImageSelect.Location = new System.Drawing.Point(209, 137);
            this.lblImageSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageSelect.Name = "lblImageSelect";
            this.lblImageSelect.Size = new System.Drawing.Size(158, 25);
            this.lblImageSelect.TabIndex = 9;
            this.lblImageSelect.Text = "Select event type:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Location = new System.Drawing.Point(16, 377);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 207);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel2.Location = new System.Drawing.Point(17, 270);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 2);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtpEvent);
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 28);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Location = new System.Drawing.Point(16, 310);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(377, 33);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel6.Controls.Add(this.cbImageList);
            this.panel6.Location = new System.Drawing.Point(211, 166);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(187, 31);
            this.panel6.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 44);
            this.panel3.TabIndex = 12;
            // 
            // cbGlobalEvent
            // 
            this.cbGlobalEvent.AutoSize = true;
            this.cbGlobalEvent.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbGlobalEvent.Location = new System.Drawing.Point(214, 204);
            this.cbGlobalEvent.Name = "cbGlobalEvent";
            this.cbGlobalEvent.Size = new System.Drawing.Size(140, 29);
            this.cbGlobalEvent.TabIndex = 13;
            this.cbGlobalEvent.Text = "Global event";
            this.cbGlobalEvent.UseVisualStyleBackColor = true;
            this.cbGlobalEvent.Visible = false;
            // 
            // EventsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(416, 597);
            this.Controls.Add(this.cbGlobalEvent);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblImageSelect);
            this.Controls.Add(this.pbEventImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.tbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EventsPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventsPopup";
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEvent;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbEventImage;
        private System.Windows.Forms.ComboBox cbImageList;
        private System.Windows.Forms.Label lblImageSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbGlobalEvent;
    }
}