using System;
using System.IO;
using System.Diagnostics;
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
        HouseUnit targetUnit;

        List<User> AssignUserList = new List<User>();

        private void RefreshUnitsList()
        {
            unitList.Clear();

            SqlConnection con = SqlConnectionHandler.GetSqlConnection();

            SqlCommand cmd = new SqlCommand($"SELECT unitID FROM HUnitTable", con);
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                HouseUnit newUnit = new HouseUnit(dataReader.GetInt32(0));
                unitList.Add(newUnit);
            }
            con.Close();
        }

        public AdminAdd()
        {
            InitializeComponent();
        }

        private void AdminAdd_Load(object sender, EventArgs e)
        {
            RefreshUnitsList();
        }

        private void btnAddNewTenant_Click(object sender, EventArgs e)
        {

            SqlConnection con = SqlConnectionHandler.GetSqlConnection();
            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand($"SELECT Username FROM Users WHERE Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
            dataReader = cmd.ExecuteReader();

            if (tbUsername.Text.Length > 0 && tbPassword.Text.Length > 0 && tbFirstName.Text.Length > 0 && tbLastName.Text.Length > 0)
            {
                if ((tbFirstName.Text.Contains("~")) || (tbFirstName.Text.Contains(" ")) || (tbFirstName.Text.Contains(":"))){
                    MessageBox.Show("Invalid symbols!"); }
                else {
                    User newUser = new User(tbUsername.Text, tbPassword.Text,
                                   tbFirstName.Text, tbLastName.Text, cbAdmin.Checked);
                    if (!cbAdmin.Checked && cmbHouseUnits.SelectedIndex != -1) newUser.UnitID = unitList[cmbHouseUnits.SelectedIndex].UnitID;
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
            tbPassword.UseSystemPasswordChar = !cbShowHide.Checked;
        }

        private void cbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            lblHouseUnit.Visible = cmbHouseUnits.Visible = !cbAdmin.Checked;
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (cmbUserList.SelectedIndex != -1)
            {
                User targetUser = userList[cmbUserList.SelectedIndex];
                HouseUnit unit = new HouseUnit(targetUser.UnitID);
                DialogResult dialogResult = MessageBox.Show($"Are you sure you wish to completely remove this user?", "User removal", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    targetUser.RemoveFromDatabase();
                    unit.RemoveTenant(targetUser.UserID);
                }
                RefreshUnitsList();
            }
            cmbUserList.SelectedIndex = cmbUnitsList.SelectedIndex = -1;
        }

        private void cmbUserList_DropDown(object sender, EventArgs e)
        {
            cmbUserList.Items.Clear();
            userList.Clear();

            SqlConnection con = SqlConnectionHandler.GetSqlConnection();

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
            if (Int32.TryParse(tbUnitID.Text, out int unitID) && Int32.TryParse(tbCapacity.Text, out int cap) && tbAddress.Text.Length > 0)
            {
                SqlConnection con = SqlConnectionHandler.GetSqlConnection();
                SqlCommand cmd;

                cmd = new SqlCommand($"SELECT userID FROM UnitUserList WHERE unitID=@unitID", con);
                cmd.Parameters.AddWithValue("@unitID", unitID);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    MessageBox.Show("A housing unit already exists with that ID. Please change its value to another one.");
                }
                else
                {
                    if (tbUnitID.Text.Length == 3 && int.Parse(tbUnitID.Text) > 0)
                    {
                        HouseUnit newUnit = new HouseUnit(unitID, tbAddress.Text, cap);
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
                    else MessageBox.Show("Please use a 3-Digit House Unit ID. The ID needs to be a positive value.");
                }
                con.Close();
                RefreshUnitsList();
                tbAddress.Clear();
                tbCapacity.Clear();
                tbUnitID.Clear();
            }
        }

        private void cmbHouseUnits_DropDown(object sender, EventArgs e)
        {
            RefreshUnitsList();
            cmbHouseUnits.Items.Clear();
            for(int i = 0; i < unitList.Count; i ++)
            {
                HouseUnit newUnit = new HouseUnit(unitList[i].UnitID);
                cmbHouseUnits.Items.Add(newUnit.GetInfo());
            }
        }

        private void RefreshText()
        {
            tbUsername.Clear();
            tbPassword.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            cmbHouseUnits.ResetText();
        }

        private void AdminAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")) { }
            else Application.Exit();
        }

        private void cmbUnits_DropDown(object sender, EventArgs e)
        {
            cmbUnitsList.Items.Clear();
            foreach(HouseUnit unit in unitList)
            {
                cmbUnitsList.Items.Add(unit.UnitID);
            }
        }

        private void cmbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenantList.Items.Clear();
            if (cmbUnitsList.SelectedIndex != -1)
            {
                lblCapacity.Text = $"{unitList[cmbUnitsList.SelectedIndex].Tenants.Count}/{unitList[cmbUnitsList.SelectedIndex].Capacity} Tenants";
                lblCapacity.Visible = true;

                targetUnit = unitList[cmbUnitsList.SelectedIndex];   
                foreach (User user in unitList[cmbUnitsList.SelectedIndex].Tenants)
                {
                    lbTenantList.Items.Add(user.Name);
                }
            }  
        }

        private void btnRemoveTenant_Click(object sender, EventArgs e)
        {
            if (lbTenantList.SelectedIndex != -1)
            {
                targetUnit.Tenants[lbTenantList.SelectedIndex].UnitID = 0;
                targetUnit.RemoveAt(lbTenantList.SelectedIndex);
                lbTenantList.Items.RemoveAt(lbTenantList.SelectedIndex);

                lblCapacity.Text = $"{targetUnit.Tenants.Count}/{targetUnit.Capacity} Tenants";
                RefreshUnitsList();
            }
            else MessageBox.Show("Please select a tenant first.");
        }

        private void btnAssignUser_Click(object sender, EventArgs e)
        {
            if (cmbAssignUserList.SelectedIndex != -1 && cmbAssignUnitList.SelectedIndex != -1)
            {
                unitList[cmbAssignUnitList.SelectedIndex].AddTenant(AssignUserList[cmbAssignUserList.SelectedIndex]);
                AssignUserList[cmbAssignUserList.SelectedIndex].UnitID = (int)cmbAssignUnitList.SelectedItem;
                AssignUserList.RemoveAt(cmbAssignUserList.SelectedIndex);
                cmbAssignUserList.SelectedIndex = cmbUnitsList.SelectedIndex = - 1;
                RefreshUnitsList();
            }
            else MessageBox.Show("Please make your selection(s).");
        }

        private void cmbAssignUnitList_DropDown(object sender, EventArgs e)
        {
            cmbAssignUnitList.Items.Clear();
            foreach (HouseUnit unit in unitList)
            {
                cmbAssignUnitList.Items.Add(unit.UnitID);
            }
        }

        private void cmbAssignUserList_DropDown(object sender, EventArgs e)
        {
            cmbAssignUserList.Items.Clear();
            AssignUserList.Clear();

            SqlConnection con = SqlConnectionHandler.GetSqlConnection();
            SqlCommand cmd = new SqlCommand($"SELECT userID, houseID, isAdmin FROM Users", con);
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                if (!dataReader.GetBoolean(2))
                {
                    if (dataReader.GetInt32(1) == 0)
                    {
                        User newUser = new User(dataReader.GetString(0));
                        cmbAssignUserList.Items.Add(newUser.Name);
                        AssignUserList.Add(newUser);
                    }
                }
            }
            con.Close();
        }
    }
}
