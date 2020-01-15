using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace AdvancedProject1._0
{
    public partial class formLogin : Form
    {
        public static string userKey;

        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Allows usage of ENTER on keyboard
            this.AcceptButton = btnLogin;
            SqlConnection con = SqlConnectionHandler.GetSqlConnection();
            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand($"SELECT username, password, firstName, isAdmin, userID FROM Users WHERE username=@Username AND password=@Password", con);
            cmd.Parameters.AddWithValue("@Username", tbName.Text);
            cmd.Parameters.AddWithValue("@Password", tbPass.Text);
            dataReader = cmd.ExecuteReader();

            if(dataReader.Read()) //Checking if the reader returns a value (YES = Matching login credentials)
            {
                userKey = dataReader.GetString(4);
                if (dataReader.GetBoolean(3)) //Checking if user is an administrator
                {
                    MessageBox.Show($"Successfully logged in. Welcome, {dataReader.GetString(2)}.");
                    //Opening the administrator's main menu
                    AdminMain adminMainScreen = new AdminMain();
                    adminMainScreen.Show();
                    this.Hide();
                }
                else
                {
                    if (new User(userKey).UnitID != 0)
                    {
                        MessageBox.Show($"Successfully logged in. Welcome, {dataReader.GetString(2)}.");
                        //Opening the tenant's main menu
                        TenantMain tenantMainScreen = new TenantMain();
                        tenantMainScreen.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Failed login attempt. You do not seem to be assigned to any housing unit. Please contact the housing agency as soon as possible.");
                }
            }
            else MessageBox.Show("Failed login attempt. Please try again.");

            con.Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbPass.UseSystemPasswordChar = !cbShowHide.Checked;
        }

        private void TbName_Enter(object sender, EventArgs e)
        {
                if (tbName.Text == "username")
            {
                tbName.Text = "";
                tbName.ForeColor = Color.FromArgb(36, 42, 86);
            }
        }

        private void TbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                tbName.Text = "username";
                tbName.ForeColor = Color.DarkGray;
            }
        }

        private void TbPass_Enter(object sender, EventArgs e)
        {
            if (tbPass.Text == "password")
            {
                tbPass.Text = "";
                tbPass.UseSystemPasswordChar = true;
                tbPass.ForeColor = Color.FromArgb(36, 42, 86);
            }
        }

        private void TbPass_Leave(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                tbPass.Text = "password";
                tbPass.UseSystemPasswordChar = false;
                tbPass.ForeColor = Color.DarkGray;
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
