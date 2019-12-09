using System;
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
    public partial class AdminAdd : Form
    {
        int counter = 0;
        public AdminAdd()
        {
            InitializeComponent();
        }

        private void btnAddNewTenant_Click(object sender, EventArgs e)
        {
            //TO DO: Check for empty textboxes
            User newUser = new User(++counter, tbUsername.Text, tbPassword.Text,
                tbFirstName.Text, tbLastName.Text, Convert.ToInt32(tbHouseUnit.Text));
            try
            {
                newUser.AddToDB();
                MessageBox.Show("Successfully added new tenant.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
