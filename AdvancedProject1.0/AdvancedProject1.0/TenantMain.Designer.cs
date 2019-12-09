namespace AdvancedProject1._0
{
    partial class TenantMain
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
            this.btnCleaning = new System.Windows.Forms.Button();
            this.btnSocial = new System.Windows.Forms.Button();
            this.btnGroceries = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.lblHousingName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHouseRules = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCleaning
            // 
            this.btnCleaning.Location = new System.Drawing.Point(65, 137);
            this.btnCleaning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.Size = new System.Drawing.Size(107, 98);
            this.btnCleaning.TabIndex = 0;
            this.btnCleaning.Text = "Cleaning";
            this.btnCleaning.UseVisualStyleBackColor = true;
            this.btnCleaning.Click += new System.EventHandler(this.btnCleaning_Click);
            // 
            // btnSocial
            // 
            this.btnSocial.Location = new System.Drawing.Point(409, 137);
            this.btnSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSocial.Name = "btnSocial";
            this.btnSocial.Size = new System.Drawing.Size(107, 98);
            this.btnSocial.TabIndex = 1;
            this.btnSocial.Text = "Social";
            this.btnSocial.UseVisualStyleBackColor = true;
            this.btnSocial.Click += new System.EventHandler(this.btnSocial_Click);
            // 
            // btnGroceries
            // 
            this.btnGroceries.Location = new System.Drawing.Point(180, 137);
            this.btnGroceries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGroceries.Name = "btnGroceries";
            this.btnGroceries.Size = new System.Drawing.Size(107, 98);
            this.btnGroceries.TabIndex = 2;
            this.btnGroceries.Text = "Groceries";
            this.btnGroceries.UseVisualStyleBackColor = true;
            this.btnGroceries.Click += new System.EventHandler(this.btnGroceries_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(295, 137);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(107, 98);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // lblHousingName
            // 
            this.lblHousingName.AutoSize = true;
            this.lblHousingName.Location = new System.Drawing.Point(199, 38);
            this.lblHousingName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHousingName.Name = "lblHousingName";
            this.lblHousingName.Size = new System.Drawing.Size(111, 17);
            this.lblHousingName.TabIndex = 4;
            this.lblHousingName.Text = "Housing Agency";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(560, 20);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 52);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHouseRules
            // 
            this.btnHouseRules.Location = new System.Drawing.Point(16, 273);
            this.btnHouseRules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHouseRules.Name = "btnHouseRules";
            this.btnHouseRules.Size = new System.Drawing.Size(65, 59);
            this.btnHouseRules.TabIndex = 6;
            this.btnHouseRules.Text = "House Rules";
            this.btnHouseRules.UseVisualStyleBackColor = true;
            this.btnHouseRules.Click += new System.EventHandler(this.btnHouseRules_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(199, 86);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(109, 17);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Welcome Admin";
            // 
            // TenantMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 377);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnHouseRules);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHousingName);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnGroceries);
            this.Controls.Add(this.btnSocial);
            this.Controls.Add(this.btnCleaning);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TenantMain";
            this.Text = "TenantMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCleaning;
        private System.Windows.Forms.Button btnSocial;
        private System.Windows.Forms.Button btnGroceries;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Label lblHousingName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHouseRules;
        private System.Windows.Forms.Label lblWelcome;
    }
}