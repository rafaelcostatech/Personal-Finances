using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancesPersonnelles.Accounts
{
    public partial class AccountsSetup : Form
    {
        private MainDBEntities2 db;

        public AccountsSetup()
        {
            InitializeComponent();
            db = new MainDBEntities2();
            BindDGView(db.Accounts.ToList());
        }

        private void AccountsSetup_Load(object sender, EventArgs e)
        {

        }

        private bool Save(int type, string desc, DateTime startDate, float balance)
        {
            try
            {
                if (db == null)
                {
                    db = new MainDBEntities2();
                }

                var Account = new Account() { Type = type, Description = desc, DateTime = startDate, Balance = balance };
                db.Accounts.Add(Account);
                db.SaveChanges();

                MessageBox.Show("Account \"" + desc + "\" successfully added!");

                BindDGView(db.Accounts.ToList());

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private bool Update(int Id, int newType, string newDesc, DateTime newStartDate, float newBalance)
        {
            try
            {
                if (db == null)
                {
                    db = new MainDBEntities2();
                }

                Account NewAccount = db.Accounts.Find(Id);
                NewAccount.Type = newType;
                NewAccount.Description = newDesc;
                NewAccount.DateTime = newStartDate;
                NewAccount.Balance = newBalance;
                db.SaveChanges();

                MessageBox.Show("Account \"" + newDesc + "\" successfully changed!");

                BindDGView(db.Accounts.ToList());

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private bool Delete(int Id)
        {
            try
            {
                if (db == null)
                {
                    db = new MainDBEntities2();
                }

                Account AccountToDelete = db.Accounts.Find(Id);
                string DeletedAccount = AccountToDelete.Description;
                db.Accounts.Remove(AccountToDelete);
                db.SaveChanges();

                MessageBox.Show("Account \"" + DeletedAccount + "\" successfully deleted!");

                BindDGView(db.Accounts.ToList());

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void BindDGView(List<Account> AccountsList)
        {
            accountsSetupGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            accountsSetupGridView.DataSource = AccountsList;
        }

        private void accountsSetupInsertButton_Click(object sender, EventArgs e)
        {
            if (Save(int.Parse(accountsSetupTypeCBox.SelectedItem.ToString()), 
                accountsSetupRichText.Text.ToString(), 
                accountsSetupDateTimePicker.Value, 
                float.Parse(accountsSetupBalanceTextBox.Text)))
            {
                accountsSetupTypeCBox.SelectedItem = null;
                accountsSetupRichText.Text = "";
                accountsSetupBalanceTextBox.Text = "";
            }
        }

        private void accountsSetupUpdateButton_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(accountsSetupGridView.SelectedRows[0].Cells[0].Value.ToString());
            if (Update(Id, int.Parse(accountsSetupTypeCBox.SelectedItem.ToString()), 
                accountsSetupRichText.Text.ToString(), 
                accountsSetupDateTimePicker.Value, 
                float.Parse(accountsSetupBalanceTextBox.Text)))
            {
                accountsSetupTypeCBox.SelectedItem = null;
                accountsSetupRichText.Text = "";
                accountsSetupBalanceTextBox.Text = "";
                accountsSetupUpdateButton.Enabled = false;
                accountsSetupExclusionButton.Enabled = false;
            }
        }

        private void accountsSetupExclusionButton_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(accountsSetupGridView.SelectedRows[0].Cells[0].Value.ToString());
            if (Delete(Id))
            {
                accountsSetupTypeCBox.SelectedItem = null;
                accountsSetupRichText.Text = "";
                accountsSetupBalanceTextBox.Text = "";
                accountsSetupUpdateButton.Enabled = false;
                accountsSetupExclusionButton.Enabled = false;
            }
        }

        private void accountsSetupGridView_MouseClick(object sender, MouseEventArgs e)
        {
            accountsSetupUpdateButton.Enabled = true;
            accountsSetupExclusionButton.Enabled = true;
            accountsSetupTypeCBox.Text = accountsSetupGridView.SelectedRows[0].Cells[1].Value.ToString();
            accountsSetupRichText.Text = accountsSetupGridView.SelectedRows[0].Cells[2].Value.ToString();
            accountsSetupDateTimePicker.Value = DateTime.Parse(accountsSetupGridView.SelectedRows[0].Cells[3].Value.ToString());
            accountsSetupBalanceTextBox.Text = accountsSetupGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void accountsSetupBalanceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
