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
    public partial class GroupSetup : Form
    {
        private MainDBEntities db;

        public GroupSetup()
        {
            InitializeComponent();
            db = new MainDBEntities();
            BindDGView(db.Groups.ToList());
        }

        private bool Save(int type, string desc)
        {
            try
            {
                if (db == null)
                {
                    db = new MainDBEntities();
                }

                var MovementGroup = new Group() { Type = type, Description = desc };
                db.Groups.Add(MovementGroup);
                db.SaveChanges();

                MessageBox.Show("Group \"" + desc + "\" successfully added!");

                BindDGView(db.Groups.ToList());

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private bool Update(int Id, int NewType, string NewDesc)
        {
            try
            {
                if (db == null)
                {
                    db = new MainDBEntities();
                }

                Group NewGroup = db.Groups.Find(Id);
                NewGroup.Type = NewType;
                NewGroup.Description = NewDesc;
                db.SaveChanges();

                MessageBox.Show("Group \"" + NewDesc + "\" successfully changed!");

                BindDGView(db.Groups.ToList());

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

                Group GroupToDelete = db.Groups.Find(Id);
                string DeletedGroupe = GroupToDelete.Description;
                db.Groups.Remove(GroupToDelete);
                db.SaveChanges();

                MessageBox.Show("Group \"" + DeletedGroupe + "\" successfully deleted!");

                BindDGView(db.Groups.ToList());

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void BindDGView(List<Group> OpGroups)
        {
            groupMovementSetupGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            groupMovementSetupGridView.DataSource = OpGroups;
        }

        private void groupInsertionInsertButton_Click(object sender, EventArgs e)
        {
            if (groupInsertionComboBox.SelectedItem != null)
            {
                if (Save(int.Parse(groupInsertionComboBox.SelectedItem.ToString()), groupInsertionRichTextBox.Text.ToString()))
                {
                    groupInsertionComboBox.SelectedItem = null;
                    groupInsertionRichTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("One or more fields are empty. Review and complete the form");
            }

        }

        private void groupInsertionUpdateButton_Click(object sender, EventArgs e)
        {
            if (groupInsertionComboBox.SelectedItem != null)
            {
                int Id = int.Parse(groupMovementSetupGridView.SelectedRows[0].Cells[0].Value.ToString());
                if (Update(Id, int.Parse(groupInsertionComboBox.SelectedItem.ToString()), groupInsertionRichTextBox.Text.ToString()))
                {
                    groupInsertionComboBox.SelectedItem = null;
                    groupInsertionRichTextBox.Text = "";
                    groupInsertionUpdateButton.Enabled = false;
                    groupExclusionButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("One or more fields are empty. Review and complete the form");
            }
        }

        private void groupMovementSetupGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void groupMovementSetupGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (groupMovementSetupGridView.Rows.Count != 0)
            {
                groupInsertionUpdateButton.Enabled = true;
                groupExclusionButton.Enabled = true;
                groupInsertionComboBox.Text = groupMovementSetupGridView.SelectedRows[0].Cells[1].Value.ToString();
                groupInsertionRichTextBox.Text = groupMovementSetupGridView.SelectedRows[0].Cells[2].Value.ToString();
            }

        }

        private void groupExclusionButton_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(groupMovementSetupGridView.SelectedRows[0].Cells[0].Value.ToString());
            if (Delete(Id))
            {
                groupInsertionComboBox.SelectedItem = null;
                groupInsertionRichTextBox.Text = "";
                groupInsertionUpdateButton.Enabled = false;
                groupExclusionButton.Enabled = false;
            }
        }
    }
}
