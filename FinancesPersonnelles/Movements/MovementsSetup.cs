using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancesPersonnelles.Movements
{
    public partial class MovementsSetup : Form
    {
        private MainDBEntities db;
        public MovementsSetup()
        {
            InitializeComponent();
            db = new MainDBEntities();
            movementsSetupGroupCBox.ValueMember = "GroupId";
            movementsSetupGroupCBox.DisplayMember = "Description";
            movementsSetupGroupCBox.DataSource = db.Groups.ToList();
            BindDGView(db.Movements.ToList());
            movementsSetupAccountComboBox.ValueMember = "AccountId";
            movementsSetupAccountComboBox.DisplayMember = "Description";
            movementsSetupAccountComboBox.DataSource = db.Accounts.ToList();
        }

        private bool Save(int Id, DateTime Date, float Value, string Desc, int Account )
        {
            try
            {
                if (db == null)
                {
                    db = new MainDBEntities();
                }

                var Movement = new Movement() { GroupId = Id, MovDate = Date, MovValue = Value, MovDescription = Desc, AccountId = Account };
                db.Movements.Add(Movement);
                db.SaveChanges();


                BindDGView(db.Movements.ToList());

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        private bool Update(int NewId, int NewGroupId, DateTime NewDate, float NewValue, string NewDesc, int NewAccount)
        {
            try
            {
                if (db == null)
                {
                    db = new MainDBEntities();
                }

                Movement NewMov = db.Movements.Find(NewId);
                NewMov.GroupId = NewGroupId;
                NewMov.MovDate = NewDate;
                NewMov.MovValue = NewValue;
                NewMov.MovDescription = NewDesc;
                NewMov.AccountId = NewAccount;
                db.SaveChanges();

                BindDGView(db.Movements.ToList());

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

                Movement MovementToDelete = db.Movements.Find(Id);
                db.Movements.Remove(MovementToDelete);
                db.SaveChanges();

                MessageBox.Show("Movement successfully deleted!");

                BindDGView(db.Movements.ToList());

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void BindDGView(List<Movement> MovementsList)
        {
            movementsSetupGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            movementsSetupGridView.DataSource = MovementsList;
            movementsSetupGridView.Columns[5].Visible = false;
        }

        private void movementsSetupInsertButton_Click(object sender, EventArgs e)
        {
            if (movementsSetupGroupCBox.SelectedItem != null &&
                movementsSetupRichText.Text != null &&
                movementsSetupDateTimePicker.Value != null &&
                movementsSetupValueTextBox.Text != null &&
                movementsSetupAccountComboBox.SelectedItem != null)
            {
                if (Save(
                    int.Parse(movementsSetupGroupCBox.SelectedValue.ToString()),
                    movementsSetupDateTimePicker.Value,
                    float.Parse(movementsSetupValueTextBox.Text),
                    movementsSetupRichText.Text.ToString(),
                    int.Parse(movementsSetupAccountComboBox.SelectedValue.ToString())))
                {
                    movementsSetupGroupCBox.SelectedItem = null;
                    movementsSetupRichText.Text = "";
                    movementsSetupValueTextBox.Text = "";
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

        private void movementsSetupUpdateButton_Click(object sender, EventArgs e)
        {
            if (movementsSetupGroupCBox.SelectedItem != null &&
                movementsSetupRichText.Text != null &&
                movementsSetupDateTimePicker.Value != null &&
                movementsSetupValueTextBox.Text != null &&
                movementsSetupAccountComboBox.SelectedItem != null)
            {
                int IdToChange = int.Parse(movementsSetupGridView.SelectedRows[0].Cells[0].Value.ToString());
                if (Update(
                    IdToChange,
                    int.Parse(movementsSetupGroupCBox.SelectedValue.ToString()),
                    movementsSetupDateTimePicker.Value,
                    float.Parse(movementsSetupValueTextBox.Text),
                    movementsSetupRichText.Text.ToString(),
                    int.Parse(movementsSetupAccountComboBox.ValueMember.ToString())))
                {
                    movementsSetupGroupCBox.SelectedItem = null;
                    movementsSetupRichText.Text = "";
                    movementsSetupValueTextBox.Text = "";
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

        private void movementsSetupExclusionButton_Click(object sender, EventArgs e)
        {
            int IdToChange = int.Parse(movementsSetupGridView.SelectedRows[0].Cells[0].Value.ToString());
            if (Delete(IdToChange))
            {
                movementsSetupGroupCBox.SelectedItem = null;
                movementsSetupRichText.Text = "";
                movementsSetupValueTextBox.Text = "";
            }
        }

        private void movementsSetupGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (movementsSetupGridView.Rows.Count != 0)
            {
                movementsSetupUpdateButton.Enabled = true;
                movementsSetupExclusionButton.Enabled = true;
                movementsSetupGroupCBox.Text = movementsSetupGridView.SelectedRows[0].Cells[1].Value.ToString();
                movementsSetupDateTimePicker.Value = DateTime.Parse(movementsSetupGridView.SelectedRows[0].Cells[2].Value.ToString());
                movementsSetupValueTextBox.Text = movementsSetupGridView.SelectedRows[0].Cells[3].Value.ToString();
                movementsSetupRichText.Text = movementsSetupGridView.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
