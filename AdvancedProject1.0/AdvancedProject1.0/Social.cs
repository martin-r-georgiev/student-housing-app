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
    public partial class Social : Form
    {
<<<<<<< Updated upstream
        private TenantMain mainForm = null;

        public Social(TenantMain calledForm)
        {
            InitializeComponent();
            mainForm = calledForm as TenantMain;
        }

        private void Social_Load(object sender, EventArgs e)
        {
            MessageBox.Show(mainForm.studentID);
=======
        string chat;
        List<string> chatLines;
        public Social()
        {
            InitializeComponent();
            chat = System.IO.File.ReadAllText(@"Chat.txt");
            chatLines = new List<string>();
            chatLines = chat.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();   //Split it on every new line, remove all empty entries, put all in a list
>>>>>>> Stashed changes
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TenantMain tenantMainScreen = new TenantMain();
            tenantMainScreen.Show();
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportPopup reportPopupScreen = new ReportPopup();
            reportPopupScreen.Show();
        }

<<<<<<< Updated upstream
=======
        private void Social_Load(object sender, EventArgs e)
        {
            RefreshListbox();
        }
        void RefreshListbox()
        {
            chatLines = chat.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            lbChat.Items.Clear();
            foreach (string line in chatLines)
            {
                lbChat.Items.Add(line);
            }
        }

        private void btnSendChat_Click(object sender, EventArgs e)
        {
            string newLine = $"{tbChat.Text}\n";
            chat += newLine;
            System.IO.File.WriteAllText(@"Chat.txt", chat);
            RefreshListbox();
            tbChat.Text = "";
        }
>>>>>>> Stashed changes
    }
}
