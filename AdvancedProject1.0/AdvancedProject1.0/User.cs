using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject1._0
{
    class User
    {
        private int studentNum;
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private int houseNum;
        private string studentID;

        public void InitialiseNewUser(int num, string user, string pass, string fname, string lname, int houseNr)
        {
            studentNum = num;
            username = user;
            password = pass;
            firstName = fname;
            lastName = lname;
            houseNum = houseNr;
            string student_id = $"{houseNr}_{num}_{fname}_{lname}";
            studentID = student_id;
        }
    }
}
