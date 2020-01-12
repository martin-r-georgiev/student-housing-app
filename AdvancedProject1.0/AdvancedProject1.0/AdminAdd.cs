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
        List<User> userList = new List<User>();
        List<HouseUnit> unitList = new List<HouseUnit>();

        public AdminAdd()
        {
            InitializeComponent();
        }

        private void AdminAdd_Load(object sender, EventArgs e)
        {
            unitList.Clear();

            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand($"SELECT unitID FROM HUnitTable", con);
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                HouseUnit newUnit = new HouseUnit(dataReader.GetInt32(0));
                unitList.Add(newUnit);
            }
            con.Close();
        }

        private void btnAddNewTenant_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dataReader;

            con.Open();

            cmd = new SqlCommand($"SELECT Username FROM Users WHERE Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
            dataReader = cmd.ExecuteReader();


            if (tbUsername.Text.Length > 0 && tbPassword.Text.Length > 0 && tbFirstName.Text.Length > 0 && tbLastName.Text.Length > 0)
            {
                User newUser = new User(tbUsername.Text, tbPassword.Text,
                               tbFirstName.Text, tbLastName.Text, cbAdmin.Checked);
                if (!cbAdmin.Checked && cmbHouseUnits.SelectedIndex != -1) newUser.SetHouseID(unitList[cmbHouseUnits.SelectedIndex].GetUnitID());
                if (dataReader.Read())
                {
                    MessageBox.Show("User with such username already exists!");
                }
                else
                {
                    try
                    {
                        if (!unitList[cmbHouseUnits.SelectedIndex].IsAtCapacity())
                        {
                            newUser.InsertToDatabase();
                            MessageBox.Show("Successfully added new user.");
                            if (!cbAdmin.Checked && cmbHouseUnits.SelectedIndex != -1) unitList[cmbHouseUnits.SelectedIndex].AddTenant(newUser);
                            RefreshText();
                        }
                        else MessageBox.Show("This housing unit has reached its tenant capacity.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all empty boxes!");
            }
            cmd.Dispose();
            dataReader.Close();
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
                //TO DO: FIX BUG (OutOfRange Exception for unitList.IndexOf()
                if (unitList.IndexOf(unit) >= 0)
                {
                    unitList[unitList.IndexOf(unit)].RemoveTenant(userList[cmbUserList.SelectedIndex].GetUserID());
                    unitList.Remove(unit);
                    MessageBox.Show("I AM WITHIN RANGE");
                }
                else MessageBox.Show("I AM OUT OF RANGE");
            }
            cmbUserList.SelectedIndex = -1;
        }

        private void cmbUserList_DropDown(object sender, EventArgs e)
        {
            cmbUserList.Items.Clear();
            userList.Clear();

            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand($"SELECT firstName, lastName, userID, isAdmin, houseID FROM Users", con);
            SqlDataReader dataReader = cmd.ExecuteReader();

            while(dataReader.Read())
            {
                if(dataReader.GetBoolean(3)) cmbUserList.Items.Add($"[Admin] {dataReader.GetString(0)} {dataReader.GetString(1)}");
                else cmbUserList.Items.Add($"[-{dataReader.GetValue(4)}-]  {dataReader.GetString(0)} {dataReader.GetString(1)}");
                User newUser = new User(dataReader.GetString(2));
                userList.Add(newUser);
            }
            con.Close();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            //TO DO: Check for empty textboxes
            //TO DO: Clear textboxes
            if (Int32.TryParse(tbUnitID.Text, out int unitID) && Int32.TryParse(tbCapacity.Text, out int cap) && tbAddress.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
                SqlCommand cmd;
                SqlDataReader dataReader;
                con.Open();

                cmd = new SqlCommand($"SELECT userID FROM UnitUserList WHERE unitID=@unitID", con);
                cmd.Parameters.AddWithValue("@unitID", unitID);
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    MessageBox.Show("A housing unit already exists with that ID. Please change its value to another one.");
                }
                else
                {
                    if (tbUnitID.Text.Length == 3)
                    {
                        HouseUnit newUnit = new HouseUnit(unitID,
                                        tbAddress.Text, cap);
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
                    else MessageBox.Show("Please use a 3-Digit House Unit ID");
                }
                con.Close();
                tbAddress.Clear();
                tbCapacity.Clear();
                tbUnitID.Clear();
            }
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
                //cmbHouseUnits.Items.Add($"Housing Unit [{dataReader.GetInt32(0)}]");
                HouseUnit newUnit = new HouseUnit(dataReader.GetInt32(0)); 
                cmbHouseUnits.Items.Add(newUnit.GetInfo());
                unitList.Add(newUnit);
            }
            con.Close();

        }

        private void RefreshText()
        {
            tbUsername.Clear();
            tbPassword.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            cmbHouseUnits.ResetText();
        }

        private void RefreshHouseUnit()
        {
            tbUnitID.Clear();
            tbAddress.Clear();
            tbCapacity.Clear();
        }
    }
}
