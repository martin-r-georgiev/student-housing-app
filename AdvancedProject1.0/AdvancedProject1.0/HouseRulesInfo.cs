using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject1._0
{
    class HouseRulesInfo
    {
        private string houseRules = System.IO.File.ReadAllText(@"HouseRules.txt");

        public void ChangeText(string newRules)
        {
            houseRules = houseRules.Replace(houseRules, newRules);
            System.IO.File.WriteAllText(@"HouseRules.txt", houseRules);
        }
        public string GetRules()
        {
            return houseRules;
        }
    }
}
