using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem
{
    class AdminAccount
    {
        private static string Username = "admin";
        private static string Password = "admin";

        public bool VerifyAccount(string uname, string pass)
        {
            return (Username == uname && Password == pass);
        }
    }
}
