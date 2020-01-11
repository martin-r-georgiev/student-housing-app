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
            this.tbCommonRooms.Location = new System.Drawing.Point(206, 60);
            this.tbCommonRooms.Maximum = 7;
            this.tbCommonRooms.Name = "tbCommonRooms";
            this.tbCommonRooms.Size = new System.Drawing.Size(282, 56);
            this.tbCommonRooms.TabIndex = 0;
            this.tbCommonRooms.ValueChanged += new System.EventHandler(this.tbCommonRooms_ValueChanged);
            // 
            // lblCRoomsValue
            // 
            this.lblCRoomsValue.AutoSize = true;
            this.lblCRoomsValue.Location = new System.Drawing.Point(340, 99);
            this.lblCRoomsValue.Name = "lblCRoomsValue";
            this.lblCRoomsValue.Size = new System.Drawing.Size(16, 17);
            this.lblCRoomsValue.TabIndex = 1;
            this.lblCRoomsValue.Text = "0";
            // 
            // lblFrequencySub1
            // 
            this.lblFrequencySub1.AutoSize = true;
            this.lblFrequencySub1.Location = new System.Drawing.Point(186, 31);
            this.lblFrequencySub1.Name = "lblFrequencySub1";
            this.lblFrequencySub1.Size = new System.Drawing.Size(71, 17);
            this.lblFrequencySub1.TabIndex = 2;
            this.lblFrequencySub1.Text = "Every day";
            // 
            // lblCommonRooms
            // 
            this.lblCommonRooms.AutoSize = true;
            this.lblCommonRooms.Location = new System.Drawing.Point(17, 66);
            this.lblCommonRooms.Name = "lblCommonRooms";
            this.lblCommonRooms.Size = new System.Drawing.Size(163, 17);
            this.lblCommonRooms.TabIndex = 3;
            this.lblCommonRooms.Text = "Cleaning common rooms";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(189, 317);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(145, 36);
            this.btnSaveSettings.TabIndex = 4;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblKitchen
            // 
            this.lblKitchen.AutoSize = true;
            this.lblKitchen.Location = new System.Drawing.Point(43, 145);
            this.lblKitchen.Name = "lblKitchen";
            this.lblKitchen.Size = new System.Drawing.Size(112, 17);
            this.lblKitchen.TabIndex = 7;
            this.lblKitchen.Text = "Cleaning kitchen";
            // 
            // lblKitchenValue
            // 
            this.lblKitchenValue.AutoSize = true;
            this.lblKitchenValue.Location = new System.Drawing.Point(340, 179);
            this.lblKitchenValue.Name = "lblKitchenValue";
            this.lblKitchenValue.Size = new System.Drawing.Size(16, 17);
            this.lblKitchenValue.TabIndex = 6;
            this.lblKitchenValue.Text = "0";
            // 
            // tbKitchen
            // 
            this.tbKitchen.Location = new System.Drawing.Point(206, 140);
            this.tbKitchen.Maximum = 7;
            this.tbKitchen.Name = "tbKitchen";
            this.tbKitchen.Size = new System.Drawing.Size(282, 56);
            this.tbKitchen.TabIndex = 5;
            this.tbKitchen.ValueChanged += new System.EventHandler(this.tbKitchen_ValueChanged);
            // 
            // lblBathroom
            // 
            this.lblBathroom.AutoSize = true;
            this.lblBathroom.Location = new System.Drawing.Point(15, 223);
            this.lblBathroom.Name = "lblBathroom";
            this.lblBathroom.Size = new System.Drawing.Size(162, 17);
            this.lblBathroom.TabIndex = 10;
            this.lblBathroom.Text = "Cleaning Bathroom/toilet";
            // 
            // lblBathroomValue
            // 
            this.lblBathroomValue.AutoSize = true;
            this.lblBathroomValue.Location = new System.Drawing.Point(340, 256);
            this.lblBathroomValue.Name = "lblBathroomValue";
            this.lblBathroomValue.Size = new System.Drawing.Size(16, 17);
            this.lblBathroomValue.TabIndex = 9;
            this.lblBathroomValue.Text = "0";
            // 
            // tbBathroom
            // 
            this.tbBathroom.Location = new System.Drawing.Point(206, 217);
            this.tbBathroom.Maximum = 7;
            this.tbBathroom.Name = "tbBathroom";
            this.tbBathroom.Size = new System.Drawing.Size(282, 56);
            this.tbBathroom.TabIndex = 8;
            this.tbBathroom.ValueChanged += new System.EventHandler(this.tbBathroom_ValueChanged);
            // 
            // lblFrequencySub2
            // 
            this.lblFrequencySub2.AutoSize = true;
            this.lblFrequencySub2.Location = new System.Drawing.Point(425, 31);
            this.lblFrequencySub2.Name = "lblFrequencySub2";
            this.lblFrequencySub2.Size = new System.Drawing.Size(90, 17);
            this.lblFrequencySub2.TabIndex = 11;
            this.lblFrequencySub2.Text = "Once a week";
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(203, 285);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(312, 17);
            this.lblNotice.TabIndex = 12;
            this.lblNotice.Text = "* Setting the value to 0 will disable the scheduler";
            // 
            // SchedulePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 365);
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