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
    public partial class HouseRules : Form
    {
        HouseRulesInfo houseRules;
        public HouseRules()
        {
            InitializeComponent();
            houseRules = new HouseRulesInfo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HouseRules_Load(object sender, EventArgs e)
        {
            rtbHouseRules.Text = houseRules.GetRules();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            houseRules.ChangeText(rtbHouseRules.Text);
            this.Close();
        }
    }
}
