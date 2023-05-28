using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class UserControlLogin : UserControl
    {
        bool autentification = false;
        string username = string.Empty;
        string password = string.Empty;
        public bool Autentification 
        {
            get { return autentification; }
        }
        public string Username
        {
            get { return username; }
        }
        public string Password 
        { 
            get { return password; } 
        }
        public UserControlLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;
            if (true) { //aici trebuie check in baza de date
                autentification = true;
            }
            else
            {
                MessageBox.Show("Incorrect credentials", "Error",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
    }
}
