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
        //TO DO: ADD LB HISTORY TO TXT FILE
        string productString;
        User loggedInUser;
        List<String> Product;
        List<double> Balance = new List<double>();
        List<string> Residents = new List<string>();

        public Groceries()
        {
            InitializeComponent();
            loggedInUser = new User(formLogin.userKey);
            productString = System.IO.File.ReadAllText(@"Groceries.txt");
            Product = new List<string>();
            Product = productString.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            AddToHistory();
            RefreshProductList();
            lblCurrentToBuy.Text = Residents[0];
            lblNextToBuy.Text = Residents[Residents.Count - 1];
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
                DialogResult dialogResult = MessageBox.Show($"Are you sure you wish to pay?", "Groceries payment", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    double tbPrice;
                    if (Double.TryParse(tbPaid.Text, out tbPrice))
                    {
                        foreach (string name in Residents)
                        {
                            if (!name.Contains(loggedInUser.GetFirstName()))
                            {
                                Balance[Residents.IndexOf(name)] -= Math.Round(tbPrice / Residents.Count, 2);
                            }
                        }
                    }
                    RefreshHistory();
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

        void ClearGroceries()
        {
            Product.Clear();
            lbGroceries.Items.Clear();
            tbPaid.Clear();
            System.IO.File.WriteAllText(@"Groceries.txt", String.Empty);
            productString = System.IO.File.ReadAllText(@"Groceries.txt");
        }

        void AddToHistory()
        {
            HouseUnit newUnit = new HouseUnit(loggedInUser.GetHouseID());
            foreach (User tenant in newUnit.Tenants())
            {
                string name = $"{tenant.GetFirstName()}";
                Residents.Add(name);
                Balance.Add(0);
            }
        }

        void RefreshHistory()
        {
            lbHistory.Items.Clear();

            foreach (string name in Residents)
            {
                if (loggedInUser.GetFirstName() == lblCurrentToBuy.Text && !name.Contains(lblCurrentToBuy.Text))
                {
                    string msg = name + "\tpay " + "\t" + "$ " + Balance[Residents.IndexOf(name)] + $"  to {lblCurrentToBuy.Text}";
                    lbHistory.Items.Add(msg);
                }
                else if (loggedInUser.GetFirstName() != lblCurrentToBuy.Text && !name.Contains(loggedInUser.GetFirstName()))
                {
                    string msg = name + "\tpay " + "\t" + "$ " + Balance[Residents.IndexOf(name)] + $"  to {loggedInUser.GetFirstName()}";
                    lbHistory.Items.Add(msg);
                }
            }
            lbHistory.Items.Add("________________________________________________________");
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
        }

        private void btnAllPaid_Click(object sender, EventArgs e)
        {
            lbHistory.Items.Clear();
        }
    }
}
