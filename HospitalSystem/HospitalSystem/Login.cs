using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSystem
{
    public partial class Login : Form
    {
        public int MyProperty { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdminAccount account = new AdminAccount();
            if (account.VerifyAccount(userNameTxtBx.Text, passwordTxtBx.Text))
            {
                // Go to management page.
                Console.WriteLine("Login Succcessful");
            }
            else
            {
                // Throw up alert.
                Console.WriteLine("Login Failed");
            }

        }
    }
}
