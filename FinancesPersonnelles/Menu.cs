using FinancesPersonnelles.Accounts;
using FinancesPersonnelles.BudgetSetup;
using FinancesPersonnelles.Movements;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void groupsAddBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupsUpdateBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupsDelBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void setupBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void reportsBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void accountsMenuBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountsSetup fm = new AccountsSetup();
            fm.Show();
        }

        private void groupsMenuBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GroupSetup fm = new GroupSetup();
            fm.Show();
        }

        private void opMenuBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MovementsSetup fm = new MovementsSetup();
            fm.Show();
        }

        private void Menu_Leave(object sender, EventArgs e)
        {
            Login fm = new Login();
            fm.Show();
        }

        private void BudgetlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BudgetSetups fm = new BudgetSetups();
            fm.Show();
        }
    }
}
