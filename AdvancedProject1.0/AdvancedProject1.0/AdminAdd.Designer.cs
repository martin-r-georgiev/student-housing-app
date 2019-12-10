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
            this.cbShowHide = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabTenant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTenant);
            this.tabControl1.Controls.Add(this.tabHouseUnit);
            this.tabControl1.Location = new System.Drawing.Point(11, 52);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 290);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTenant
            // 
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
            this.tabTenant.Location = new System.Drawing.Point(4, 22);
            this.tabTenant.Margin = new System.Windows.Forms.Padding(2);
            this.tabTenant.Name = "tabTenant";
            this.tabTenant.Padding = new System.Windows.Forms.Padding(2);
            this.tabTenant.Size = new System.Drawing.Size(553, 264);
            this.tabTenant.TabIndex = 0;
            this.tabTenant.Text = "Add tenant";
            this.tabTenant.UseVisualStyleBackColor = true;
            // 
            // btnAddNewTenant
            // 
            this.btnAddNewTenant.Location = new System.Drawing.Point(408, 217);
            this.btnAddNewTenant.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewTenant.Name = "btnAddNewTenant";
            this.btnAddNewTenant.Size = new System.Drawing.Size(117, 32);
            this.btnAddNewTenant.TabIndex = 10;
            this.btnAddNewTenant.Text = "Add";
            this.btnAddNewTenant.UseVisualStyleBackColor = true;
            this.btnAddNewTenant.Click += new System.EventHandler(this.btnAddNewTenant_Click);
            // 
            // tbHouseUnit
            // 
            this.tbHouseUnit.Location = new System.Drawing.Point(117, 161);
            this.tbHouseUnit.Margin = new System.Windows.Forms.Padding(2);
            this.tbHouseUnit.Name = "tbHouseUnit";
            this.tbHouseUnit.Size = new System.Drawing.Size(114, 20);
            this.tbHouseUnit.TabIndex = 9;
            // 
            // lblHouseUnit
            // 
            this.lblHouseUnit.AutoSize = true;
            this.lblHouseUnit.Location = new System.Drawing.Point(44, 161);
            this.lblHouseUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHouseUnit.Name = "lblHouseUnit";
            this.lblHouseUnit.Size = new System.Drawing.Size(63, 13);
            this.lblHouseUnit.TabIndex = 8;
            this.lblHouseUnit.Text = "House Unit:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(117, 121);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(114, 20);
            this.tbLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(44, 121);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(117, 99);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(114, 20);
            this.tbFirstName.TabIndex = 5;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(44, 99);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(117, 58);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(114, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(44, 58);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(117, 35);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(114, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(44, 35);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // tabHouseUnit
            // 
            this.tabHouseUnit.Location = new System.Drawing.Point(4, 22);
            this.tabHouseUnit.Margin = new System.Windows.Forms.Padding(2);
            this.tabHouseUnit.Name = "tabHouseUnit";
            this.tabHouseUnit.Padding = new System.Windows.Forms.Padding(2);
            this.tabHouseUnit.Size = new System.Drawing.Size(553, 264);
            this.tabHouseUnit.TabIndex = 1;
            this.tabHouseUnit.Text = "Add House Unit";
            this.tabHouseUnit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // cbShowHide
            // 
            this.cbShowHide.AutoSize = true;
            this.cbShowHide.Location = new System.Drawing.Point(245, 61);
            this.cbShowHide.Name = "cbShowHide";
            this.cbShowHide.Size = new System.Drawing.Size(53, 17);
            this.cbShowHide.TabIndex = 11;
            this.cbShowHide.Text = "Show";
            this.cbShowHide.UseVisualStyleBackColor = true;
            this.cbShowHide.CheckedChanged += new System.EventHandler(this.cbShowHide_CheckedChanged);
            // 
            // AdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}