using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancesPersonnelles
{
    public partial class Login : Form
    {
        private MainDBEntities db;

        public Login()
        {
            InitializeComponent();
            db = new MainDBEntities();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //User user = db.Users.Find(4);
            //if (this.userNameTxtBox.Text == user.Name && this.passwordTxtBox.Text == user.Password)
            //{
                Menu men = new Menu();
                men.Show();
                this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Username or Password incorrect. Please try again using different informations.");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = db.Users.Find(4);
            if (user.Email == null)
            {
                MessageBox.Show("The main user was not changed. Please use the default credentials to log in: admin / admin");
            }
            else
            {
                RecoverPassword fm= new RecoverPassword();
            }
        }
    }
}
