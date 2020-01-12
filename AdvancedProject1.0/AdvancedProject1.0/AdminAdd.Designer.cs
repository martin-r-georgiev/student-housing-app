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
            this.tabUser = new System.Windows.Forms.TabPage();
            this.cmbHouseUnits = new System.Windows.Forms.ComboBox();
            this.cmbUserList = new System.Windows.Forms.ComboBox();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.cbShowHide = new System.Windows.Forms.CheckBox();
            this.btnAddNewTenant = new System.Windows.Forms.Button();
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
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.tbUnitID = new System.Windows.Forms.TextBox();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbUnitsList = new System.Windows.Forms.ComboBox();
            this.btnRemoveTenant = new System.Windows.Forms.Button();
            this.lbTenantList = new System.Windows.Forms.ListBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.gbAssignUser = new System.Windows.Forms.GroupBox();
            this.cmbAssignUserList = new System.Windows.Forms.ComboBox();
            this.cmbAssignUnitList = new System.Windows.Forms.ComboBox();
            this.lblHouseUnit2 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnAssignUser = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabHouseUnit.SuspendLayout();
            this.gbAssignUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Controls.Add(this.tabHouseUnit);
            this.tabControl1.Location = new System.Drawing.Point(15, 64);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.gbAssignUser);
            this.tabUser.Controls.Add(this.cmbHouseUnits);
            this.tabUser.Controls.Add(this.cmbUserList);
            this.tabUser.Controls.Add(this.btnRemoveUser);
            this.tabUser.Controls.Add(this.cbAdmin);
            this.tabUser.Controls.Add(this.cbShowHide);
            this.tabUser.Controls.Add(this.btnAddNewTenant);
            this.tabUser.Controls.Add(this.lblHouseUnit);
            this.tabUser.Controls.Add(this.tbLastName);
            this.tabUser.Controls.Add(this.lblLastName);
            this.tabUser.Controls.Add(this.tbFirstName);
            this.tabUser.Controls.Add(this.lblFirstName);
            this.tabUser.Controls.Add(this.tbPassword);
            this.tabUser.Controls.Add(this.lblPassword);
            this.tabUser.Controls.Add(this.tbUsername);
            this.tabUser.Controls.Add(this.lblUsername);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabUser.Size = new System.Drawing.Size(1013, 328);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User Controls";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // cmbHouseUnits
            // 
            this.cmbHouseUnits.FormattingEnabled = true;
            this.cmbHouseUnits.Location = new System.Drawing.Point(156, 195);
            this.cmbHouseUnits.Name = "cmbHouseUnits";
            this.cmbHouseUnits.Size = new System.Drawing.Size(186, 24);
            this.cmbHouseUnits.TabIndex = 15;
            this.cmbHouseUnits.DropDown += new System.EventHandler(this.cmbHouseUnits_DropDown);
            // 
            // cmbUserList
            // 
            this.cmbUserList.FormattingEnabled = true;
            this.cmbUserList.Location = new System.Drawing.Point(708, 36);
            this.cmbUserList.Margin = new System.Windows.Forms.Padding(5);
            this.cmbUserList.Name = "cmbUserList";
            this.cmbUserList.Size = new System.Drawing.Size(276, 24);
            this.cmbUserList.TabIndex = 14;
            this.cmbUserList.DropDown += new System.EventHandler(this.cmbUserList_DropDown);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(796, 81);
            this.btnRemoveUser.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(188, 48);
            this.btnRemoveUser.TabIndex = 13;
            this.btnRemoveUser.Text = "Remove user";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(156, 15);
            this.cbAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(113, 21);
            this.cbAdmin.TabIndex = 12;
            this.cbAdmin.Text = "Administrator";
            this.cbAdmin.UseVisualStyleBackColor = true;
            this.cbAdmin.CheckedChanged += new System.EventHandler(this.cbAdmin_CheckedChanged);
            // 
            // cbShowHide
            // 
            this.cbShowHide.AutoSize = true;
            this.cbShowHide.Location = new System.Drawing.Point(349, 73);
            this.cbShowHide.Margin = new System.Windows.Forms.Padding(5);
            this.cbShowHide.Name = "cbShowHide";
            this.cbShowHide.Size = new System.Drawing.Size(64, 21);
            this.cbShowHide.TabIndex = 11;
            this.cbShowHide.Text = "Show";
            this.cbShowHide.UseVisualStyleBackColor = true;
            this.cbShowHide.CheckedChanged += new System.EventHandler(this.cbShowHide_CheckedChanged);
            // 
            // btnAddNewTenant
            // 
            this.btnAddNewTenant.Location = new System.Drawing.Point(156, 251);
            this.btnAddNewTenant.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddNewTenant.Name = "btnAddNewTenant";
            this.btnAddNewTenant.Size = new System.Drawing.Size(151, 39);
            this.btnAddNewTenant.TabIndex = 10;
            this.btnAddNewTenant.Text = "Add";
            this.btnAddNewTenant.UseVisualStyleBackColor = true;
            this.btnAddNewTenant.Click += new System.EventHandler(this.btnAddNewTenant_Click);
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
            this.tbLastName.Size = new System.Drawing.Size(186, 22);
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
            this.tbFirstName.Size = new System.Drawing.Size(186, 22);
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
            this.tbPassword.Size = new System.Drawing.Size(186, 22);
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
            this.tbUsername.Size = new System.Drawing.Size(186, 22);
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
            this.tabHouseUnit.Controls.Add(this.lblCapacity);
            this.tabHouseUnit.Controls.Add(this.lbTenantList);
            this.tabHouseUnit.Controls.Add(this.btnRemoveTenant);
            this.tabHouseUnit.Controls.Add(this.cmbUnitsList);
            this.tabHouseUnit.Controls.Add(this.tbCapacity);
            this.tabHouseUnit.Controls.Add(this.label2);
            this.tabHouseUnit.Controls.Add(this.tbAddress);
            this.tabHouseUnit.Controls.Add(this.label1);
            this.tabHouseUnit.Controls.Add(this.btnAddUnit);
            this.tabHouseUnit.Controls.Add(this.tbUnitID);
            this.tabHouseUnit.Controls.Add(this.lblUnitID);
            this.tabHouseUnit.Location = new System.Drawing.Point(4, 25);
            this.tabHouseUnit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabHouseUnit.Name = "tabHouseUnit";
            this.tabHouseUnit.Padding = new System.Windows.Forms.Padding(2);
            this.tabHouseUnit.Size = new System.Drawing.Size(1013, 328);
            this.tabHouseUnit.TabIndex = 1;
            this.tabHouseUnit.Text = "Add House Unit";
            this.tabHouseUnit.UseVisualStyleBackColor = true;
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(136, 151);
            this.tbCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(132, 22);
            this.tbCapacity.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Capacity:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(136, 106);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(132, 22);
            this.tbAddress.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address:";
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Location = new System.Drawing.Point(136, 203);
            this.btnAddUnit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(132, 32);
            this.btnAddUnit.TabIndex = 2;
            this.btnAddUnit.Text = "Add";
            this.btnAddUnit.UseVisualStyleBackColor = true;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // tbUnitID
            // 
            this.tbUnitID.Location = new System.Drawing.Point(136, 62);
            this.tbUnitID.Margin = new System.Windows.Forms.Padding(4);
            this.tbUnitID.Name = "tbUnitID";
            this.tbUnitID.Size = new System.Drawing.Size(132, 22);
            this.tbUnitID.TabIndex = 1;
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Location = new System.Drawing.Point(63, 62);
            this.lblUnitID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(54, 17);
            this.lblUnitID.TabIndex = 0;
            this.lblUnitID.Text = "Unit ID:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(27, 22);
            this.btnBack.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // cmbUnitsList
            // 
            this.cmbUnitsList.FormattingEnabled = true;
            this.cmbUnitsList.Location = new System.Drawing.Point(826, 23);
            this.cmbUnitsList.Name = "cmbUnitsList";
            this.cmbUnitsList.Size = new System.Drawing.Size(154, 24);
            this.cmbUnitsList.TabIndex = 7;
            this.cmbUnitsList.DropDown += new System.EventHandler(this.cmbUnits_DropDown);
            this.cmbUnitsList.SelectedIndexChanged += new System.EventHandler(this.cmbUnits_SelectedIndexChanged);
            // 
            // btnRemoveTenant
            // 
            this.btnRemoveTenant.Location = new System.Drawing.Point(840, 239);
            this.btnRemoveTenant.Name = "btnRemoveTenant";
            this.btnRemoveTenant.Size = new System.Drawing.Size(140, 42);
            this.btnRemoveTenant.TabIndex = 8;
            this.btnRemoveTenant.Text = "Remove tenant";
            this.btnRemoveTenant.UseVisualStyleBackColor = true;
            this.btnRemoveTenant.Click += new System.EventHandler(this.btnRemoveTenant_Click);
            // 
            // lbTenantList
            // 
            this.lbTenantList.FormattingEnabled = true;
            this.lbTenantList.ItemHeight = 16;
            this.lbTenantList.Location = new System.Drawing.Point(712, 58);
            this.lbTenantList.Name = "lbTenantList";
            this.lbTenantList.Size = new System.Drawing.Size(267, 164);
            this.lbTenantList.TabIndex = 9;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(709, 26);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(70, 17);
            this.lblCapacity.TabIndex = 10;
            this.lblCapacity.Text = "[Capacity]";
            this.lblCapacity.Visible = false;
            // 
            // gbAssignUser
            // 
            this.gbAssignUser.Controls.Add(this.btnAssignUser);
            this.gbAssignUser.Controls.Add(this.lblUser);
            this.gbAssignUser.Controls.Add(this.lblHouseUnit2);
            this.gbAssignUser.Controls.Add(this.cmbAssignUnitList);
            this.gbAssignUser.Controls.Add(this.cmbAssignUserList);
            this.gbAssignUser.Location = new System.Drawing.Point(648, 168);
            this.gbAssignUser.Name = "gbAssignUser";
            this.gbAssignUser.Size = new System.Drawing.Size(336, 122);
            this.gbAssignUser.TabIndex = 16;
            this.gbAssignUser.TabStop = false;
            this.gbAssignUser.Text = "Assign user to House Unit";
            // 
            // cmbAssignUserList
            // 
            this.cmbAssignUserList.FormattingEnabled = true;
            this.cmbAssignUserList.Location = new System.Drawing.Point(94, 31);
            this.cmbAssignUserList.Name = "cmbAssignUserList";
            this.cmbAssignUserList.Size = new System.Drawing.Size(225, 24);
            this.cmbAssignUserList.TabIndex = 0;
            this.cmbAssignUserList.DropDown += new System.EventHandler(this.cmbAssignUserList_DropDown);
            // 
            // cmbAssignUnitList
            // 
            this.cmbAssignUnitList.FormattingEnabled = true;
            this.cmbAssignUnitList.Location = new System.Drawing.Point(94, 75);
            this.cmbAssignUnitList.Name = "cmbAssignUnitList";
            this.cmbAssignUnitList.Size = new System.Drawing.Size(113, 24);
            this.cmbAssignUnitList.TabIndex = 1;
            this.cmbAssignUnitList.DropDown += new System.EventHandler(this.cmbAssignUnitList_DropDown);
            // 
            // lblHouseUnit2
            // 
            this.lblHouseUnit2.AutoSize = true;
            this.lblHouseUnit2.Location = new System.Drawing.Point(6, 78);
            this.lblHouseUnit2.Name = "lblHouseUnit2";
            this.lblHouseUnit2.Size = new System.Drawing.Size(82, 17);
            this.lblHouseUnit2.TabIndex = 17;
            this.lblHouseUnit2.Text = "House Unit:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(46, 34);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 17);
            this.lblUser.TabIndex = 18;
            this.lblUser.Text = "User:";
            // 
            // btnAssignUser
            // 
            this.btnAssignUser.Location = new System.Drawing.Point(223, 67);
            this.btnAssignUser.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAssignUser.Name = "btnAssignUser";
            this.btnAssignUser.Size = new System.Drawing.Size(96, 39);
            this.btnAssignUser.TabIndex = 17;
            this.btnAssignUser.Text = "Assign user";
            this.btnAssignUser.UseVisualStyleBackColor = true;
            this.btnAssignUser.Click += new System.EventHandler(this.btnAssignUser_Click);
            // 
            // AdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1147, 446);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAdd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminAdd_FormClosing);
            this.Load += new System.EventHandler(this.AdminAdd_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.tabHouseUnit.ResumeLayout(false);
            this.tabHouseUnit.PerformLayout();
            this.gbAssignUser.ResumeLayout(false);
            this.gbAssignUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabHouseUnit;
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
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.ComboBox cmbUserList;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.TextBox tbUnitID;
        private System.Windows.Forms.Label lblUnitID;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHouseUnits;
        private System.Windows.Forms.ListBox lbTenantList;
        private System.Windows.Forms.Button btnRemoveTenant;
        private System.Windows.Forms.ComboBox cmbUnitsList;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.GroupBox gbAssignUser;
        private System.Windows.Forms.Label lblHouseUnit2;
        private System.Windows.Forms.ComboBox cmbAssignUnitList;
        private System.Windows.Forms.ComboBox cmbAssignUserList;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnAssignUser;
    }
}