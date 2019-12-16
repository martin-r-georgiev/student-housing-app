namespace AdvancedProject1._0
{
    partial class AdminMain
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
            this.btnHouseRules = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblHousingName = new System.Windows.Forms.Label();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHouseRules
            // 
            this.btnHouseRules.Location = new System.Drawing.Point(338, 105);
            this.btnHouseRules.Name = "btnHouseRules";
            this.btnHouseRules.Size = new System.Drawing.Size(80, 80);
            this.btnHouseRules.TabIndex = 13;
            this.btnHouseRules.Text = "Update House Rules";
            this.btnHouseRules.UseVisualStyleBackColor = true;
            this.btnHouseRules.Click += new System.EventHandler(this.btnHouseRules_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(397, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(48, 42);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblHousingName
            // 
            this.lblHousingName.AutoSize = true;
            this.lblHousingName.Location = new System.Drawing.Point(163, 28);
            this.lblHousingName.Name = "lblHousingName";
            this.lblHousingName.Size = new System.Drawing.Size(85, 13);
            this.lblHousingName.TabIndex = 11;
            this.lblHousingName.Text = "Housing Agency";
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(127, 105);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(80, 80);
            this.btnEvents.TabIndex = 10;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(232, 105);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(80, 80);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(163, 74);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(84, 13);
            this.lblWelcome.TabIndex = 14;
            this.lblWelcome.Text = "Welcome Admin";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(24, 105);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(80, 80);
            this.btnAddNew.TabIndex = 15;
            this.btnAddNew.Text = "Add Tenant and/or Housing Unit";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 246);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnHouseRules);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHousingName);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnReports);
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHouseRules;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblHousingName;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAddNew;
    }
}