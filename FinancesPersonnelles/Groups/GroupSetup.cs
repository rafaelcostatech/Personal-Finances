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
        private MainDBEntities2 db;

        public GroupSetup()
        {
            InitializeComponent();
            db = new MainDBEntities2();
            BindDGView(db.Groups.ToList());
        }

        private bool Save(string type, string desc)
        {
            try
            {
                if (db == null)
                {
                    db = new MainDBEntities2();
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

        private bool Update(int Id, string NewType, string NewDesc)
        {
            try
            {
                if (db == null)
                {
                    db = new MainDBEntities2();
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
                    db = new MainDBEntities2();
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
            if (Save(groupInsertionComboBox.SelectedItem.ToString(), groupInsertionRichTextBox.Text.ToString()))
            {
                groupInsertionComboBox.SelectedItem = null;
                groupInsertionRichTextBox.Text = "";
            }

        }

        private void groupInsertionUpdateButton_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(groupMovementSetupGridView.SelectedRows[0].Cells[0].Value.ToString());
            if (Update(Id, groupInsertionComboBox.SelectedItem.ToString(), groupInsertionRichTextBox.Text.ToString()))
            {
                groupInsertionComboBox.SelectedItem = null;
                groupInsertionRichTextBox.Text = "";
                groupInsertionUpdateButton.Enabled = false;
                groupExclusionButton.Enabled = false;
            }
        }

        private void groupMovementSetupGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void groupMovementSetupGridView_MouseClick(object sender, MouseEventArgs e)
        {
            groupInsertionUpdateButton.Enabled = true;
            groupExclusionButton.Enabled = true;
            groupInsertionComboBox.Text = groupMovementSetupGridView.SelectedRows[0].Cells[1].Value.ToString();
            groupInsertionRichTextBox.Text = groupMovementSetupGridView.SelectedRows[0].Cells[2].Value.ToString();
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
