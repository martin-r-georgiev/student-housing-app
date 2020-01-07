namespace AdvancedProject1._0
{
    partial class CalendarItem
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWeekDay = new System.Windows.Forms.Label();
            this.calendarDateBackground = new System.Windows.Forms.Panel();
            this.eventTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeekDayPanel = new System.Windows.Forms.Panel();
            this.calendarEventList = new System.Windows.Forms.FlowLayoutPanel();
            this.calendarDateBackground.SuspendLayout();
            this.eventTablePanel.SuspendLayout();
            this.WeekDayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblWeekDay
            // 
            this.lblWeekDay.AutoSize = true;
            this.lblWeekDay.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblWeekDay.Location = new System.Drawing.Point(3, 3);
            this.lblWeekDay.Name = "lblWeekDay";
            this.lblWeekDay.Size = new System.Drawing.Size(84, 17);
            this.lblWeekDay.TabIndex = 1;
            this.lblWeekDay.Text = "DayOfWeek";
            // 
            // calendarDateBackground
            // 
            this.calendarDateBackground.BackColor = System.Drawing.Color.Gray;
            this.calendarDateBackground.Controls.Add(this.lblDate);
            this.calendarDateBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendarDateBackground.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calendarDateBackground.Location = new System.Drawing.Point(0, 0);
            this.calendarDateBackground.Name = "calendarDateBackground";
            this.calendarDateBackground.Size = new System.Drawing.Size(214, 38);
            this.calendarDateBackground.TabIndex = 2;
            // 
            // eventTablePanel
            // 
            this.eventTablePanel.AutoScroll = true;
            this.eventTablePanel.AutoSize = true;
            this.eventTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eventTablePanel.BackColor = System.Drawing.SystemColors.Control;
            this.eventTablePanel.ColumnCount = 1;
            this.eventTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.eventTablePanel.Controls.Add(this.calendarEventList, 0, 0);
            this.eventTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventTablePanel.Location = new System.Drawing.Point(0, 63);
            this.eventTablePanel.Name = "eventTablePanel";
            this.eventTablePanel.RowCount = 1;
            this.eventTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventTablePanel.Size = new System.Drawing.Size(214, 136);
            this.eventTablePanel.TabIndex = 3;
            // 
            // WeekDayPanel
            // 
            this.WeekDayPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WeekDayPanel.Controls.Add(this.lblWeekDay);
            this.WeekDayPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WeekDayPanel.Location = new System.Drawing.Point(0, 38);
            this.WeekDayPanel.Name = "WeekDayPanel";
            this.WeekDayPanel.Size = new System.Drawing.Size(214, 25);
            this.WeekDayPanel.TabIndex = 3;
            // 
            // calendarEventList
            // 
            this.calendarEventList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.calendarEventList.AutoSize = true;
            this.calendarEventList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calendarEventList.BackColor = System.Drawing.SystemColors.Control;
            this.calendarEventList.Location = new System.Drawing.Point(107, 3);
            this.calendarEventList.Name = "calendarEventList";
            this.calendarEventList.Size = new System.Drawing.Size(0, 130);
            this.calendarEventList.TabIndex = 0;
            this.calendarEventList.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.calendarEventList_ControlRemoved);
            // 
            // CalendarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.eventTablePanel);
            this.Controls.Add(this.WeekDayPanel);
            this.Controls.Add(this.calendarDateBackground);
            this.Name = "CalendarItem";
            this.Size = new System.Drawing.Size(214, 199);
            this.calendarDateBackground.ResumeLayout(false);
            this.calendarDateBackground.PerformLayout();
            this.eventTablePanel.ResumeLayout(false);
            this.eventTablePanel.PerformLayout();
            this.WeekDayPanel.ResumeLayout(false);
            this.WeekDayPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblWeekDay;
        private System.Windows.Forms.Panel calendarDateBackground;
        private System.Windows.Forms.TableLayoutPanel eventTablePanel;
        private System.Windows.Forms.Panel WeekDayPanel;
        private System.Windows.Forms.FlowLayoutPanel calendarEventList;
    }
}
