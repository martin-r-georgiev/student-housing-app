﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProject1._0
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void rbTenant_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTenant.Checked)
            {
                lblName.Text = "First Name";
                lblPass.Text = "Apartment Nr.";
            } else
            {
                lblName.Text = "Username";
                lblPass.Text = "Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rbAdmin.Checked)
            {
                //Add check for username + pass
                AdminMain adminMainScreen = new AdminMain();
                adminMainScreen.Show();
                this.Hide();
            } else
            {
                //Add variable for storing who this is + check for house nr.
                TenantMain tenantMainScreen = new TenantMain();
                tenantMainScreen.Show();
                this.Hide();
            }
        }
    }
}
