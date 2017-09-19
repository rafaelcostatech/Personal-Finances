using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancesPersonnelles.BudgetSetup
{
    public partial class BudgetSetups : Form
    {
        private MainDBEntities db;
        public BudgetSetups()
        {
            InitializeComponent();
            db = new MainDBEntities();
            budgetGroupCBox.ValueMember = "GroupId";
            budgetGroupCBox.DisplayMember = "Description";
            budgetGroupCBox.DataSource = db.Groups.ToList();
            BindDGView(db.Budgets.ToList());
        }

        private bool Save(int Id, DateTime Date, float Value, string Desc, int Account)
        {
            try
            {
                if (db == null)
                {
                    db = new MainDBEntities();
                }

                var Budget = new Budget() { GroupId = Id, BudDate = Date, BudValue = Value, BudDescription = Desc };
                db.Budgets.Add(Budget);
                db.SaveChanges();


                BindDGView(db.Budgets.ToList());

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        private bool Update(int NewId, int NewGroupId, DateTime NewDate, float NewValue, string NewDesc)
        {
            try
            {
                if (db == null)
                {
                    db = new MainDBEntities();
                }

                Budget NewBudget = db.Budgets.Find(NewId);
                NewBudget.GroupId = NewGroupId;
                NewBudget.BudDate = NewDate;
                NewBudget.BudValue = NewValue;
                NewBudget.BudDescription = NewDesc;
                db.SaveChanges();

                BindDGView(db.Budgets.ToList());

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

                Budget BudgetToDelete = db.Budgets.Find(Id);
                db.Budgets.Remove(BudgetToDelete);
                db.SaveChanges();

                MessageBox.Show("Budget successfully deleted!");

                BindDGView(db.Budgets.ToList());

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void BindDGView(List<Budget> BudgetsList)
        {
            bugetGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bugetGridView.DataSource = BudgetsList;
            bugetGridView.Columns[5].Visible = false;
        }

        private void budgetInsertButton_Click(object sender, EventArgs e)
        {

        }
    }
}
