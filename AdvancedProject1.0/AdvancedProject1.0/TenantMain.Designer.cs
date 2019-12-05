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
            this.btnCleaning.Location = new System.Drawing.Point(49, 111);
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.Size = new System.Drawing.Size(80, 80);
            this.btnCleaning.TabIndex = 0;
            this.btnCleaning.Text = "Cleaning";
            this.btnCleaning.UseVisualStyleBackColor = true;
            // 
            // btnSocial
            // 
            this.btnSocial.Location = new System.Drawing.Point(307, 111);
            this.btnSocial.Name = "btnSocial";
            this.btnSocial.Size = new System.Drawing.Size(80, 80);
            this.btnSocial.TabIndex = 1;
            this.btnSocial.Text = "Social";
            this.btnSocial.UseVisualStyleBackColor = true;
            // 
            // btnGroceries
            // 
            this.btnGroceries.Location = new System.Drawing.Point(135, 111);
            this.btnGroceries.Name = "btnGroceries";
            this.btnGroceries.Size = new System.Drawing.Size(80, 80);
            this.btnGroceries.TabIndex = 2;
            this.btnGroceries.Text = "Groceries";
            this.btnGroceries.UseVisualStyleBackColor = true;
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(221, 111);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(80, 80);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            // 
            // lblHousingName
            // 
            this.lblHousingName.AutoSize = true;
            this.lblHousingName.Location = new System.Drawing.Point(149, 31);
            this.lblHousingName.Name = "lblHousingName";
            this.lblHousingName.Size = new System.Drawing.Size(85, 13);
            this.lblHousingName.TabIndex = 4;
            this.lblHousingName.Text = "Housing Agency";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(420, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(48, 42);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnHouseRules
            // 
            this.btnHouseRules.Location = new System.Drawing.Point(12, 222);
            this.btnHouseRules.Name = "btnHouseRules";
            this.btnHouseRules.Size = new System.Drawing.Size(49, 48);
            this.btnHouseRules.TabIndex = 6;
            this.btnHouseRules.Text = "House Rules";
            this.btnHouseRules.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(149, 70);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(84, 13);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Welcome Admin";
            // 
            // TenantMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 306);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnHouseRules);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHousingName);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnGroceries);
            this.Controls.Add(this.btnSocial);
            this.Controls.Add(this.btnCleaning);
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