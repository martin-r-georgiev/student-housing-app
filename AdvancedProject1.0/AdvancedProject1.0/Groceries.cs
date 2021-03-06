﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdvancedProject1._0
{
    public partial class Groceries : Form
    {
        string productString;
        string[] productStrings;
        string currentProducts;
        User loggedInUser;
        List<String> Product;
        List<String> buyHistory;
        List<User> Residents;
        Payments allPayments;
        OrderScheduler schedule;
        HouseUnit tenantUnit;

        public Groceries()
        {
            InitializeComponent();
            loggedInUser = new User(formLogin.userKey);
            tenantUnit = new HouseUnit(loggedInUser.UnitID);  //Stores the current user's house id
            schedule = new OrderScheduler(tenantUnit);
            productString = System.IO.File.ReadAllText(@"Groceries.txt");
            buyHistory = new List<String>();
            buyHistory = Payments.GetPaymentsOfUnit(loggedInUser.UnitID);
            Product = new List<string>();
            Product = productString.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            Residents = new List<User>();
            if (!CheckForCorrectGroceries()) CheckForCorrectGroceries();
            RefreshHistory();
            AddToHistory();
            RefreshProductList();
            lblCurrentToBuy.Text = new User(schedule.CurrentIDGroceries).FirstName;
            lblNextToBuy.Text = schedule.ShowNextUser(EventType.Groceries).FirstName;
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
            else if (tbAddProduct.Text.Contains("~")) MessageBox.Show("Invalid symbol (~)");
            else if (tbAddProduct.Text.Contains(":")) MessageBox.Show("Invalid symbol (:)");
            else
            {
                SendMessage();
                RefreshProductList();
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(tbPaid.Text, out double paid) && tbPaid.TextLength > 0)
            {
                if(lbGroceries.Items.Count != 0)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you wish to pay?", "Groceries payment", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (User u in Residents)
                        {
                            if (!u.FirstName.Equals(loggedInUser.FirstName))
                            {
                                Payment newPayment = new Payment(u.UserID, loggedInUser.UserID, Math.Round(paid / Residents.Count, 2), loggedInUser.UnitID);
                            }
                        }
                        RefreshHistory();
                        ClearGroceries();
                        NameSwap();
                    }
                }
                else MessageBox.Show("Add at least one product and specify a price!");
            }
            else MessageBox.Show("Invalid input for price.");
        }
       
        private void lbGroceries_DoubleClick(object sender, EventArgs e)
        {
            if (lbGroceries.SelectedIndex > -1)
            {
                string itemToDelete = lbGroceries.SelectedItem.ToString();
                Product.Remove(itemToDelete);
                SaveNewText();
                RefreshProductList();
            }
        }

        private void lbHistory_DoubleClick(object sender, EventArgs e)
        {
            if (lbHistory.SelectedIndex > -1)
            {
                if (lbHistory.Items[lbHistory.SelectedIndex].ToString().Split('$')[1].Contains(loggedInUser.FirstName))
                {
                    allPayments = new Payments();
                    allPayments.RemovePayment(lbHistory.SelectedItem.ToString());
                    RefreshHistory();
                }
                else MessageBox.Show("Only the person who payed can remove entries");
            }
        }
        private bool CheckForCorrectGroceries()
        {
            productStrings = productString.Split('~');
            for (int i = 0; i < productStrings.Length; i++)
            {
                if (productStrings[i].Split(':')[0].Contains(loggedInUser.UnitID.ToString()))
                {
                    currentProducts = productStrings[i].Substring(4);
                    return true;
                }
            }
            productString += $"{loggedInUser.UnitID}:\n~";
            System.IO.File.WriteAllText(@"Groceries.txt", productString);
            return false;
        }
        private void SaveNewText()
        {
            productStrings = productString.Split('~');
            for (int i = 0; i < productStrings.Length; i++)
            {
                if (productStrings[i].Split(':')[0].Contains(loggedInUser.UnitID.ToString()))
                {
                    productStrings[i] = loggedInUser.UnitID.ToString() + ":\n";
                    foreach (string s in Product)
                        productStrings[i] += s + "\n";
                    currentProducts = productStrings[i].Substring(4); //use this variable for refreshing the listbox for memory purposes
                }
            }

            //Add the chat list to the current chat array

            List<string> chatList = new List<string>();
            for (int i = 0; i < productStrings.Length; i++)
            {
                if (productStrings[i].Contains(":"))
                    chatList.Add(productStrings[i]);
            }
            //remove all the empty entries

            productString = "~";
            foreach (string s in chatList)
                productString += s + "~";
            System.IO.File.WriteAllText(@"Groceries.txt", productString);
        }
        private void SendMessage()
        {
            string newProd = $"{tbAddProduct.Text}";
            Product.Add(newProd);
            //Add the new line to a list
            SaveNewText();
            tbAddProduct.Text = "";
        }
        void RefreshProductList()
        {
            Product = currentProducts.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
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
            SaveNewText();
        }

        void AddToHistory()
        {
            HouseUnit newUnit = new HouseUnit(loggedInUser.UnitID);
            foreach (User tenant in newUnit.Tenants)
                Residents.Add(tenant);
        }

        void RefreshHistory()
        {
            buyHistory = Payments.GetPaymentsOfUnit(loggedInUser.UnitID);
            lbHistory.Items.Clear();
            foreach (string s in buyHistory)
                lbHistory.Items.Add(s);
        }

        void NameSwap()
        {
            User buyer;
            buyer = schedule.GetNextUser(EventType.Groceries);
            lblCurrentToBuy.Text = buyer.FirstName;
            lblNextToBuy.Text = schedule.ShowNextUser(EventType.Groceries).FirstName;
        }


        private void Groceries_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")) { }
            else Application.Exit();
        }
    }

}
