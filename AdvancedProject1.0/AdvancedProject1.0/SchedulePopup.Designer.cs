namespace AdvancedProject1._0
{
    partial class SchedulePopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulePopup));
            this.tbCommonRooms = new System.Windows.Forms.TrackBar();
            this.lblCRoomsValue = new System.Windows.Forms.Label();
            this.lblFrequencySub1 = new System.Windows.Forms.Label();
            this.lblCommonRooms = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblKitchen = new System.Windows.Forms.Label();
            this.lblKitchenValue = new System.Windows.Forms.Label();
            this.tbKitchen = new System.Windows.Forms.TrackBar();
            this.lblBathroom = new System.Windows.Forms.Label();
            this.lblBathroomValue = new System.Windows.Forms.Label();
            this.tbBathroom = new System.Windows.Forms.TrackBar();
            this.lblFrequencySub2 = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbCommonRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKitchen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBathroom)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCommonRooms
            // 
            this.tbCommonRooms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbCommonRooms.Location = new System.Drawing.Point(180, 64);
            this.tbCommonRooms.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbCommonRooms.Maximum = 7;
            this.tbCommonRooms.Name = "tbCommonRooms";
            this.tbCommonRooms.Size = new System.Drawing.Size(247, 45);
            this.tbCommonRooms.TabIndex = 0;
            this.tbCommonRooms.ValueChanged += new System.EventHandler(this.tbCommonRooms_ValueChanged);
            // 
            // lblCRoomsValue
            // 
            this.lblCRoomsValue.AutoSize = true;
            this.lblCRoomsValue.Location = new System.Drawing.Point(297, 105);
            this.lblCRoomsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCRoomsValue.Name = "lblCRoomsValue";
            this.lblCRoomsValue.Size = new System.Drawing.Size(15, 17);
            this.lblCRoomsValue.TabIndex = 1;
            this.lblCRoomsValue.Text = "0";
            // 
            // lblFrequencySub1
            // 
            this.lblFrequencySub1.AutoSize = true;
            this.lblFrequencySub1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrequencySub1.Location = new System.Drawing.Point(163, 33);
            this.lblFrequencySub1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrequencySub1.Name = "lblFrequencySub1";
            this.lblFrequencySub1.Size = new System.Drawing.Size(64, 17);
            this.lblFrequencySub1.TabIndex = 2;
            this.lblFrequencySub1.Text = "Every day";
            // 
            // lblCommonRooms
            // 
            this.lblCommonRooms.AutoSize = true;
            this.lblCommonRooms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCommonRooms.Location = new System.Drawing.Point(15, 71);
            this.lblCommonRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommonRooms.Name = "lblCommonRooms";
            this.lblCommonRooms.Size = new System.Drawing.Size(155, 17);
            this.lblCommonRooms.TabIndex = 3;
            this.lblCommonRooms.Text = "Cleaning common rooms";
            this.lblCommonRooms.Click += new System.EventHandler(this.LblCommonRooms_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveSettings.BackgroundImage")));
            this.btnSaveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveSettings.Location = new System.Drawing.Point(166, 337);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(147, 50);
            this.btnSaveSettings.TabIndex = 4;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblKitchen
            // 
            this.lblKitchen.AutoSize = true;
            this.lblKitchen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKitchen.Location = new System.Drawing.Point(37, 154);
            this.lblKitchen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKitchen.Name = "lblKitchen";
            this.lblKitchen.Size = new System.Drawing.Size(102, 17);
            this.lblKitchen.TabIndex = 7;
            this.lblKitchen.Text = "Cleaning kitchen";
            this.lblKitchen.Click += new System.EventHandler(this.LblKitchen_Click);
            // 
            // lblKitchenValue
            // 
            this.lblKitchenValue.AutoSize = true;
            this.lblKitchenValue.Location = new System.Drawing.Point(297, 190);
            this.lblKitchenValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKitchenValue.Name = "lblKitchenValue";
            this.lblKitchenValue.Size = new System.Drawing.Size(15, 17);
            this.lblKitchenValue.TabIndex = 6;
            this.lblKitchenValue.Text = "0";
            // 
            // tbKitchen
            // 
            this.tbKitchen.Location = new System.Drawing.Point(180, 149);
            this.tbKitchen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbKitchen.Maximum = 7;
            this.tbKitchen.Name = "tbKitchen";
            this.tbKitchen.Size = new System.Drawing.Size(247, 45);
            this.tbKitchen.TabIndex = 5;
            this.tbKitchen.ValueChanged += new System.EventHandler(this.tbKitchen_ValueChanged);
            // 
            // lblBathroom
            // 
            this.lblBathroom.AutoSize = true;
            this.lblBathroom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBathroom.Location = new System.Drawing.Point(13, 237);
            this.lblBathroom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBathroom.Name = "lblBathroom";
            this.lblBathroom.Size = new System.Drawing.Size(153, 17);
            this.lblBathroom.TabIndex = 10;
            this.lblBathroom.Text = "Cleaning Bathroom/toilet";
            this.lblBathroom.Click += new System.EventHandler(this.LblBathroom_Click);
            // 
            // lblBathroomValue
            // 
            this.lblBathroomValue.AutoSize = true;
            this.lblBathroomValue.Location = new System.Drawing.Point(297, 272);
            this.lblBathroomValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBathroomValue.Name = "lblBathroomValue";
            this.lblBathroomValue.Size = new System.Drawing.Size(15, 17);
            this.lblBathroomValue.TabIndex = 9;
            this.lblBathroomValue.Text = "0";
            // 
            // tbBathroom
            // 
            this.tbBathroom.Location = new System.Drawing.Point(180, 230);
            this.tbBathroom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbBathroom.Maximum = 7;
            this.tbBathroom.Name = "tbBathroom";
            this.tbBathroom.Size = new System.Drawing.Size(247, 45);
            this.tbBathroom.TabIndex = 8;
            this.tbBathroom.ValueChanged += new System.EventHandler(this.tbBathroom_ValueChanged);
            // 
            // lblFrequencySub2
            // 
            this.lblFrequencySub2.AutoSize = true;
            this.lblFrequencySub2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrequencySub2.Location = new System.Drawing.Point(372, 33);
            this.lblFrequencySub2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrequencySub2.Name = "lblFrequencySub2";
            this.lblFrequencySub2.Size = new System.Drawing.Size(82, 17);
            this.lblFrequencySub2.TabIndex = 11;
            this.lblFrequencySub2.Text = "Once a week";
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.Color.Gray;
            this.lblNotice.Location = new System.Drawing.Point(191, 289);
            this.lblNotice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(275, 17);
            this.lblNotice.TabIndex = 12;
            this.lblNotice.Text = "* Setting the value to 0 will disable the scheduler";
            this.lblNotice.Click += new System.EventHandler(this.LblNotice_Click);
            // 
            // SchedulePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(498, 401);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.lblFrequencySub2);
            this.Controls.Add(this.lblBathroom);
            this.Controls.Add(this.lblBathroomValue);
            this.Controls.Add(this.tbBathroom);
            this.Controls.Add(this.lblKitchen);
            this.Controls.Add(this.lblKitchenValue);
            this.Controls.Add(this.tbKitchen);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.lblCommonRooms);
            this.Controls.Add(this.lblFrequencySub1);
            this.Controls.Add(this.lblCRoomsValue);
            this.Controls.Add(this.tbCommonRooms);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SchedulePopup";
            this.Text = "SchedulePopup";
            ((System.ComponentModel.ISupportInitialize)(this.tbCommonRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKitchen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBathroom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbCommonRooms;
        private System.Windows.Forms.Label lblCRoomsValue;
        private System.Windows.Forms.Label lblFrequencySub1;
        private System.Windows.Forms.Label lblCommonRooms;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblKitchen;
        private System.Windows.Forms.Label lblKitchenValue;
        private System.Windows.Forms.TrackBar tbKitchen;
        private System.Windows.Forms.Label lblBathroom;
        private System.Windows.Forms.Label lblBathroomValue;
        private System.Windows.Forms.TrackBar tbBathroom;
        private System.Windows.Forms.Label lblFrequencySub2;
        private System.Windows.Forms.Label lblNotice;
    }
}