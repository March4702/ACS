using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACS
{
    public partial class FormPerson : Form
    {
        public string CategorySelected { get; set; }
        public FormPerson()
        {
            InitializeComponent();
            CategorySelected = PersonClass.CategorySelected;
            InitDisplay();
        }

        private void InitDisplay()
        {
            PersonClass.PersonInit();
            DataTable PplData = PersonClass.SelectPeopleData(CategorySelected);
                // CategorySelected = Where Clause
                // string.Empty = Extra Where Clauses
                // (ComboBox1.Text = Order BY
            DgvPerson.DataSource = PplData;
            if (PplData.Rows.Count == 0)
            {
                string msg = $"No records found for {CategorySelected}.";
                MessageBox.Show(msg + "\r\n" + "No records found for this category of people.");
            }
            else
            {
                DgvPerson = InitDgvPerson.SetGridColumns(DgvPerson);
                DgvPerson.BringToFront();
            }
        }

        private void ShowSelectedRecord()
        {
            if (DgvPerson == null ||                        // IF Invalid Info
                DgvPerson.CurrentRow == null ||             // Show error message
                DgvPerson.CurrentRow.Cells == null ||
                DgvPerson.CurrentRow.Cells.Count == 0)
            {
                string message = "No Information Found";
                string caption = "Error Detected";
                MessageBox.Show(message, caption,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }
            else
            {
                DgvPerson.DataSource = PersonClass.DtableDGV;
                int APerson = Convert.ToInt32(DgvPerson.CurrentRow.Cells["Num"].Value);
                PersonClass.ID_Person = APerson;
                Form FormPersonEdit = new FormPersonEdit();
                FormPersonEdit.ShowDialog();
                this.Show();
            }
        }

       

        private void UpdatePerson()
        {
            this.Hide();
            ShowSelectedRecord();
            this.Show();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdatePerson();
        }

  
        private void DgvPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdatePerson();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
