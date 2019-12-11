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
            this.cbShowHide = new System.Windows.Forms.CheckBox();
            this.btnAddNewTenant = new System.Windows.Forms.Button();
            this.tbHouseUnit = new System.Windows.Forms.TextBox();
            this.lblHouseUnit = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tabHouseUnit = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabTenant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTenant);
            this.tabControl1.Controls.Add(this.tabHouseUnit);
            this.tabControl1.Location = new System.Drawing.Point(15, 64);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTenant
            // 
            this.tabTenant.Controls.Add(this.cbAdmin);
            this.tabTenant.Controls.Add(this.cbShowHide);
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
            this.tabTenant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTenant.Name = "tabTenant";
            this.tabTenant.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTenant.Size = new System.Drawing.Size(740, 328);
            this.tabTenant.TabIndex = 0;
            this.tabTenant.Text = "Add user";
            this.tabTenant.UseVisualStyleBackColor = true;
            // 
            // cbShowHide
            // 
            this.cbShowHide.AutoSize = true;
            this.cbShowHide.Location = new System.Drawing.Point(327, 75);
            this.cbShowHide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbShowHide.Name = "cbShowHide";
            this.cbShowHide.Size = new System.Drawing.Size(64, 21);
            this.cbShowHide.TabIndex = 11;
            this.cbShowHide.Text = "Show";
            this.cbShowHide.UseVisualStyleBackColor = true;
            this.cbShowHide.CheckedChanged += new System.EventHandler(this.cbShowHide_CheckedChanged);
            // 
            // btnAddNewTenant
            // 
            this.btnAddNewTenant.Location = new System.Drawing.Point(544, 267);
            this.btnAddNewTenant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewTenant.Name = "btnAddNewTenant";
            this.btnAddNewTenant.Size = new System.Drawing.Size(156, 39);
            this.btnAddNewTenant.TabIndex = 10;
            this.btnAddNewTenant.Text = "Add";
            this.btnAddNewTenant.UseVisualStyleBackColor = true;
            this.btnAddNewTenant.Click += new System.EventHandler(this.btnAddNewTenant_Click);
            // 
            // tbHouseUnit
            // 
            this.tbHouseUnit.Location = new System.Drawing.Point(156, 198);
            this.tbHouseUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHouseUnit.Name = "tbHouseUnit";
            this.tbHouseUnit.Size = new System.Drawing.Size(151, 22);
            this.tbHouseUnit.TabIndex = 9;
            // 
            // lblHouseUnit
            // 
            this.lblHouseUnit.AutoSize = true;
            this.lblHouseUnit.Location = new System.Drawing.Point(59, 198);
            this.lblHouseUnit.Name = "lblHouseUnit";
            this.lblHouseUnit.Size = new System.Drawing.Size(82, 17);
            this.lblHouseUnit.TabIndex = 8;
            this.lblHouseUnit.Text = "House Unit:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(156, 149);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(151, 22);
            this.tbLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(59, 149);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(156, 122);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(151, 22);
            this.tbFirstName.TabIndex = 5;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(59, 122);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(156, 71);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(151, 22);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(59, 71);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(156, 43);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(151, 22);
            this.tbUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(59, 43);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // tabHouseUnit
            // 
            this.tabHouseUnit.Location = new System.Drawing.Point(4, 25);
            this.tabHouseUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHouseUnit.Name = "tabHouseUnit";
            this.tabHouseUnit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHouseUnit.Size = new System.Drawing.Size(740, 328);
            this.tabHouseUnit.TabIndex = 1;
            this.tabHouseUnit.Text = "Add House Unit";
            this.tabHouseUnit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(156, 17);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(113, 21);
            this.cbAdmin.TabIndex = 12;
            this.cbAdmin.Text = "Administrator";
            this.cbAdmin.UseVisualStyleBackColor = true;
            this.cbAdmin.CheckedChanged += new System.EventHandler(this.cbAdmin_CheckedChanged);
            // 
            // AdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox cbShowHide;
        private System.Windows.Forms.CheckBox cbAdmin;
    }
}