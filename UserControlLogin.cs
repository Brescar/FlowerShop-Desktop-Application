using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-FlowerShop;Integrated Security=True";

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

            string query = "SELECT COUNT(*) FROM Accounts WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    connection.Close();

                    if (count > 0)
                    {
                        autentification = true;
                        buttonLogin.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        buttonLogin.DialogResult = DialogResult.Cancel;
                    }
                }
            }
        }
    }
}
