using System;
using System.Diagnostics;
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
        private TenantMain mainForm = null;
        string chat;
        string[] chats;
        string currentHouseUnitChat;
        string generalChat;
        List<string> generalChatLines;
        List<string> chatLines;
        User loggedInUser;

        void RefreshListbox()
        {
            if (tcChats.SelectedIndex == 1)
            {
                chatLines = currentHouseUnitChat.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                lbChat.Items.Clear();
                foreach (string line in chatLines)
                    lbChat.Items.Add(line);
            } else if (tcChats.SelectedIndex == 0)
            {
                generalChatLines = generalChat.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                lbGeneralChat.Items.Clear();
                foreach (string line in generalChatLines)
                    lbGeneralChat.Items.Add(line);
            }
            lbChat.SelectedIndex = lbChat.Items.Count - 1;
            lbChat.SelectedIndex = -1;
            lbGeneralChat.SelectedIndex = lbGeneralChat.Items.Count - 1;
            lbGeneralChat.SelectedIndex = -1;
        }

        public Social(TenantMain calledForm)
        {
            InitializeComponent();
            mainForm = calledForm as TenantMain;
            loggedInUser = new User(formLogin.userKey);
            tp2.Text = $"House Unit {loggedInUser.GetHouseID()}";
            chat = System.IO.File.ReadAllText(@"Chat.txt");
            generalChat = chat.Split('~')[1].Substring(4);
            if (!CheckForCorrectChat()) CheckForCorrectChat();
            chatLines = new List<string>();
            chatLines = currentHouseUnitChat.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            generalChatLines = new List<string>();
            generalChatLines = generalChat.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            //Split it on every new line, remove all empty entries, put all in a list
        }

        private void Social_Load(object sender, EventArgs e)
        {
            RefreshListbox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TenantMain tenantMainScreen = new TenantMain();
            tenantMainScreen.Show();
            this.Close();
        }


        private void btnSendChat_Click(object sender, EventArgs e)
        {
            //Allows usage of ENTER on keyboard
            this.AcceptButton = btnSendChat;
            if (!tbChat.Text.Contains("~"))
            {
                SendMessage();
                RefreshListbox();
            }
            else MessageBox.Show("Invalid key entered. (~)");
        }

        private void LbChat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool CheckForCorrectChat()
        {
            chats = chat.Split('~');
            for (int i = 0; i < chats.Length; i++)
            {
                if (chats[i].Split(':')[0].Contains(loggedInUser.GetHouseID().ToString()))
                {
                    currentHouseUnitChat = chats[i].Substring(4);
                    return true;
                }
            }
            chat += $"{loggedInUser.GetHouseID()}: \n~ \n";
            System.IO.File.WriteAllText(@"Chat.txt", chat);
            MessageBox.Show($"Welcome to the new chat of house unit {loggedInUser.GetHouseID()}");
            return false;
        }
        private void SendMessage()
        {
            string newLine = $"[{DateTime.Now.ToString(@"h\:mm tt")}]  -{loggedInUser.GetHouseID()}- {loggedInUser.GetFirstName()}: {tbChat.Text}";
            chats = chat.Split('~');

            if (tcChats.SelectedIndex == 0)
            {
                generalChatLines.Add(newLine);
                chats[1] = "ALL:\n";
                foreach (string s in generalChatLines)
                    chats[1] += s + "\n";
                generalChat = chats[1].Substring(4);
            }

            if (tcChats.SelectedIndex == 1)
            {

                chatLines.Add(newLine);
                //Add the new line to a list
                for (int i = 0; i < chats.Length; i++)
                {
                    if (chats[i].Split(':')[0].Contains(loggedInUser.GetHouseID().ToString()))
                    {
                        chats[i] = loggedInUser.GetHouseID().ToString() + ":\n";
                        foreach (string s in chatLines)
                            chats[i] += s + "\n";
                        currentHouseUnitChat = chats[i].Substring(4); //use this variable for refreshing the listbox for memory purposes
                    }
                }
            }
            //Add the chat list to the current chat array

            List<string> chatList = new List<string>();
            for (int i = 0; i < chats.Length; i++)
            {
                if (chats[i].Contains(":"))
                    chatList.Add(chats[i]);
            }
            //remove all the empty entries

            chat = "~";
            foreach (string s in chatList)
                chat += s + "~";
            System.IO.File.WriteAllText(@"Chat.txt", chat);
            tbChat.Text = "";
        }

        private void tcChats_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListbox();
        }

        private void Social_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")) { }
            else Application.Exit();
        }

        private void Tp2_Click(object sender, EventArgs e)
        {

        }

        private void LbGeneralChat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
