namespace AdvancedProject1._0
{
    partial class AdminAdd
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTenant = new System.Windows.Forms.TabPage();
            this.tabHouseUnit = new System.Windows.Forms.TabPage();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbHouseUnit = new System.Windows.Forms.TextBox();
            this.lblHouseUnit = new System.Windows.Forms.Label();
            this.btnAddNewTenant = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabTenant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTenant);
            this.tabControl1.Controls.Add(this.tabHouseUnit);
            this.tabControl1.Location = new System.Drawing.Point(21, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTenant
            // 
            this.tabTenant.Controls.Add(this.btnAddNewTenant);
            this.tabTenant.Controls.Add(this.tbHouseUnit);
            this.tabTenant.Controls.Add(this.lblHouseUnit);
            this.tabTenant.Controls.Add(this.tbLastName);
            this.tabTenant.Controls.Add(this.lblLastName);
            this.tabTenant.Controls.Add(this.tbFirstName);
            this.tabTenant.Controls.Add(this.lblFirstName);
            this.tabTenant.Controls.Add(this.tbPassword);
            this.tabTenant.Controls.Add(this.lblPassword);
            this.tabTenant.Controls.Add(this.tbUsername);
            this.tabTenant.Controls.Add(this.lblUsername);
            this.tabTenant.Location = new System.Drawing.Point(4, 25);
            this.tabTenant.Name = "tabTenant";
            this.tabTenant.Padding = new System.Windows.Forms.Padding(3);
            this.tabTenant.Size = new System.Drawing.Size(740, 328);
            this.tabTenant.TabIndex = 0;
            this.tabTenant.Text = "Add tenant";
            this.tabTenant.UseVisualStyleBackColor = true;
            // 
            // tabHouseUnit
            // 
            this.tabHouseUnit.Location = new System.Drawing.Point(4, 25);
            this.tabHouseUnit.Name = "tabHouseUnit";
            this.tabHouseUnit.Padding = new System.Windows.Forms.Padding(3);
            this.tabHouseUnit.Size = new System.Drawing.Size(556, 281);
            this.tabHouseUnit.TabIndex = 1;
            this.tabHouseUnit.Text = "Add House Unit";
            this.tabHouseUnit.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(52, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(149, 41);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(151, 22);
            this.tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(149, 69);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(151, 22);
            this.tbPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(52, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(149, 119);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(151, 22);
            this.tbFirstName.TabIndex = 5;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(52, 119);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(149, 147);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(151, 22);
            this.tbLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(52, 147);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // tbHouseUnit
            // 
            this.tbHouseUnit.Location = new System.Drawing.Point(149, 196);
            this.tbHouseUnit.Name = "tbHouseUnit";
            this.tbHouseUnit.Size = new System.Drawing.Size(151, 22);
            this.tbHouseUnit.TabIndex = 9;
            // 
            // lblHouseUnit
            // 
            this.lblHouseUnit.AutoSize = true;
            this.lblHouseUnit.Location = new System.Drawing.Point(52, 196);
            this.lblHouseUnit.Name = "lblHouseUnit";
            this.lblHouseUnit.Size = new System.Drawing.Size(82, 17);
            this.lblHouseUnit.TabIndex = 8;
            this.lblHouseUnit.Text = "House Unit:";
            // 
            // btnAddNewTenant
            // 
            this.btnAddNewTenant.Location = new System.Drawing.Point(419, 196);
            this.btnAddNewTenant.Name = "btnAddNewTenant";
            this.btnAddNewTenant.Size = new System.Drawing.Size(87, 46);
            this.btnAddNewTenant.TabIndex = 10;
            this.btnAddNewTenant.Text = "Add";
            this.btnAddNewTenant.UseVisualStyleBackColor = true;
            this.btnAddNewTenant.Click += new System.EventHandler(this.btnAddNewTenant_Click);
            // 
            // AdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminAdd";
            this.Text = "AdminAdd";
            this.tabControl1.ResumeLayout(false);
            this.tabTenant.ResumeLayout(false);
            this.tabTenant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTenant;
        private System.Windows.Forms.TabPage tabHouseUnit;
        private System.Windows.Forms.TextBox tbHouseUnit;
        private System.Windows.Forms.Label lblHouseUnit;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnAddNewTenant;
    }
}