using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEditCategoryOfPeople()
        {
            this.Hide();
            FormPerson formPerson = new FormPerson();
            DialogResult result = formPerson.ShowDialog();
            this.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
            this.Show();
        }

        private void everyoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonClass.CategorySelected = "EveryOne";
            AddEditCategoryOfPeople();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonClass.CategorySelected = "Member";
            AddEditCategoryOfPeople();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonClass.CategorySelected = "Customer";
            AddEditCategoryOfPeople();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonClass.CategorySelected = "Supplier";
            AddEditCategoryOfPeople();
        }

        private void noCatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonClass.CategorySelected = "Non-Member";
            AddEditCategoryOfPeople();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormAdd:
            this.Hide();
            FormAdd formAdd = new FormAdd();
            DialogResult result = formAdd.ShowDialog();
            this.Show();
        }
    }
}
