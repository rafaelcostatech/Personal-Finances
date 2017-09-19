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
        private MainDBEntities db;

        public AccountsSetup()
        {
            InitializeComponent();
            db = new MainDBEntities();
            BindDGView(db.Accounts.ToList());

            accountsSetupTypeCBox.ValueMember = "Id";
            accountsSetupTypeCBox.DisplayMember = "Desc";
            accountsSetupTypeCBox.DataSource = db.AccountTypes.ToList();
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
                    db = new MainDBEntities();
                }

                var Account = new Account() { Type = type, Description = desc, Start_Date = startDate, Balance = balance };
                db.Accounts.Add(Account);
                db.SaveChanges();

                MessageBox.Show("Account \"" + desc + "\" successfully added!");

                BindDGView(db.Accounts.ToList());

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        private bool Update(int Id, int newType, string newDesc, DateTime newStartDate, float newBalance)
        {
            try
            {
                if (db == null)
                {
                    db = new MainDBEntities();
                }

                Account NewAccount = db.Accounts.Find(Id);
                NewAccount.Type = newType;
                NewAccount.Description = newDesc;
                NewAccount.Start_Date = newStartDate;
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
                    db = new MainDBEntities();
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
            accountsSetupGridView.Columns[5].Visible = false;
        }

        private void accountsSetupInsertButton_Click(object sender, EventArgs e)
        {
            if (accountsSetupTypeCBox.SelectedValue != null &&
                accountsSetupRichText.Text != null &&
                accountsSetupDateTimePicker.Value != null &&
                accountsSetupBalanceTextBox.Text != null)
            {
                if (Save(int.Parse(accountsSetupTypeCBox.SelectedValue.ToString()), 
                    accountsSetupRichText.Text.ToString(), 
                    accountsSetupDateTimePicker.Value, 
                    float.Parse(accountsSetupBalanceTextBox.Text)))
                {
                    accountsSetupTypeCBox.SelectedItem = null;
                    accountsSetupRichText.Text = "";
                    accountsSetupBalanceTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("A problem occurred while trying to process the informations. Restart the program and if the problem persists, contact the administrator of the system.");
                }
            }
            else
            {
                MessageBox.Show("One or more fields are empty. Review and complete the form");
            }
        }

        private void accountsSetupUpdateButton_Click(object sender, EventArgs e)
        {
            if (accountsSetupTypeCBox.SelectedValue != null &&
                accountsSetupRichText.Text != null &&
                accountsSetupDateTimePicker.Value != null &&
                accountsSetupBalanceTextBox.Text != null)
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
            else
            {
                MessageBox.Show("One or more fields are empty. Review and complete the form");
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
            if (accountsSetupGridView.Rows.Count != 0)
            {
                accountsSetupUpdateButton.Enabled = true;
                accountsSetupExclusionButton.Enabled = true;
                accountsSetupTypeCBox.Text = accountsSetupGridView.SelectedRows[0].Cells[1].Value.ToString();
                accountsSetupRichText.Text = accountsSetupGridView.SelectedRows[0].Cells[2].Value.ToString();
                accountsSetupDateTimePicker.Value = DateTime.Parse(accountsSetupGridView.SelectedRows[0].Cells[3].Value.ToString());
                accountsSetupBalanceTextBox.Text = accountsSetupGridView.SelectedRows[0].Cells[4].Value.ToString();

            }
        }

        private void accountsSetupBalanceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
