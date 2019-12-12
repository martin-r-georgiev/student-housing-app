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
    public partial class AdminAdd : Form
    {
        public AdminAdd()
        {
            InitializeComponent();
        }

        List<User> userList = new List<User>();
        List<HouseUnit> unitList = new List<HouseUnit>();

        private void btnAddNewTenant_Click(object sender, EventArgs e)
        {
            //TO DO: Check for empty textboxes
            User newUser = new User(tbUsername.Text, tbPassword.Text,
                           tbFirstName.Text, tbLastName.Text, cbAdmin.Checked);
            if(!cbAdmin.Checked && cmbHouseUnits.SelectedIndex != -1) newUser.SetHouseID(unitList[cmbHouseUnits.SelectedIndex].GetUnitID());
            try
            {
                newUser.InsertToDatabase();
                unitList[cmbHouseUnits.SelectedIndex].AddTenant(newUser);
                MessageBox.Show("Successfully added new user.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AdminMain adminMainScreen = new AdminMain();
            adminMainScreen.Show();
            this.Close();
        }

        private void cbShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowHide.Checked == true)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void cbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAdmin.Checked)
            {
                lblHouseUnit.Visible = false;
                cmbHouseUnits.Visible = false;
            }
            else
            {
                lblHouseUnit.Visible = true;
                cmbHouseUnits.Visible = true;
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (cmbUserList.SelectedIndex != -1)
            {
                userList[cmbUserList.SelectedIndex].RemoveFromDatabase();
                HouseUnit unit = new HouseUnit(userList[cmbUserList.SelectedIndex].GetHouseID());
                unitList[unitList.IndexOf(unit)].RemoveTenant(userList[cmbUserList.SelectedIndex].GetUserID());
            }
            cmbUserList.SelectedIndex = -1;
        }

        private void cmbUserList_DropDown(object sender, EventArgs e)
        {
            cmbUserList.Items.Clear();
            userList.Clear();

            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand($"SELECT firstName, lastName, userID, isAdmin FROM Users", con);
            SqlDataReader dataReader = cmd.ExecuteReader();

            while(dataReader.Read())
            {
                if(dataReader.GetBoolean(3)) cmbUserList.Items.Add($"[Admin] {dataReader.GetString(0)} {dataReader.GetString(1)}");
                else cmbUserList.Items.Add($"{dataReader.GetString(0)} {dataReader.GetString(1)}");
                User newUser = new User(dataReader.GetString(2));
                userList.Add(newUser);
            }
            con.Close();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            //TO DO: Check for empty textboxes
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dataReader;
            con.Open();

            cmd = new SqlCommand($"SELECT userID FROM UnitUserList WHERE unitID=@unitID", con);
            cmd.Parameters.AddWithValue("@unitID", Convert.ToInt32(tbUnitID.Text));
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                MessageBox.Show("A housing unit already exists with that ID. Please change its value to another one.");
            }
            else
            {
                HouseUnit newUnit = new HouseUnit(Convert.ToInt32(tbUnitID.Text),
                                tbAddress.Text, Convert.ToInt32(tbCapacity.Text));
                try
                {
                    newUnit.InsertToDatabase();
                    MessageBox.Show("Successfully added new house unit.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            con.Close();    
        }

        private void cmbHouseUnits_DropDown(object sender, EventArgs e)
        {
            cmbHouseUnits.Items.Clear();
            unitList.Clear();

            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand($"SELECT unitID FROM HUnitTable", con);
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                cmbHouseUnits.Items.Add($"Housing Unit [{dataReader.GetInt32(0)}]");
                HouseUnit newUnit = new HouseUnit(dataReader.GetInt32(0));
                unitList.Add(newUnit);
            }
            con.Close();

        }
    }
}
