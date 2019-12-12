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
    public partial class Groceries : Form
    {
        string productString;
        User loggedInUser;
        List<String> Product;
        List<double> Balance = new List<double>();

        public Groceries()
        {
            InitializeComponent();
            loggedInUser = new User(formLogin.userKey);
            productString = System.IO.File.ReadAllText(@"Groceries.txt");
            Product = new List<string>();
            Product = productString.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            RefreshProductList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TenantMain tenantMainScreen = new TenantMain();
            tenantMainScreen.Show();
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.AcceptButton = btnAdd;
            if (tbAddProduct.TextLength == 0)
            {
                MessageBox.Show("Specify a product to add!");
            }
            else
            {
                productString += $"{tbAddProduct.Text}\n";
                System.IO.File.WriteAllText(@"Groceries.txt", productString);
                RefreshProductList();
                tbAddProduct.Clear();
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (tbPaid.TextLength != 0 && lbGroceries.Items.Count != 0)
            {
                double tbPrice;
                if (Double.TryParse(tbPaid.Text, out tbPrice))
                {
                    //TO DO: Add the balance to current Name of person buying and remove from all others      --      lbl + price
                    //TO DO: Add to lbHistory
                    Balance.Add(tbPrice);
                    RefreshHistoryList();
                    ClearGroceries();
                }
            }
            else
            {
                MessageBox.Show("Add at least one product and specify a price!");
            }
        }

        void RefreshProductList()
        {
            Product = productString.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            lbGroceries.Items.Clear();
            foreach (String product in Product)
            {
                lbGroceries.Items.Add(product);
            }
        }

        void RefreshHistoryList()
        {
            lbHistory.Items.Clear();
            foreach (double price in Balance)
            {
                lbHistory.Items.Add(price);
            }
        }

        void ClearGroceries()
        {
            Product.Clear();
            lbGroceries.Items.Clear();
            tbPaid.Clear();
        }

        private void lbGroceries_DoubleClick(object sender, EventArgs e)
        {
            if (lbGroceries.SelectedIndex > -1)
            {
                string itemToDelete = lbGroceries.SelectedItem.ToString();
                Product.Remove(itemToDelete);
                System.IO.File.WriteAllLines(@"Groceries.txt",Product.ToArray());
                productString = System.IO.File.ReadAllText(@"Groceries.txt");
                RefreshProductList();
            }
        }

        private void Groceries_Load(object sender, EventArgs e)
        {
            //HouseUnit newUnit = new HouseUnit(loggedInUser.GetHouseID());
            //string test = "";
            //foreach (User tenant in newUnit.)
            //{
            //    test += $"{tenant.GetFirstName()},";
            //}
            //MessageBox.Show(test);
        }
    }
}
