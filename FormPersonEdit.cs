using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACS
{
    public partial class FormPersonEdit : Form
    {
        /// <summary>
        /// Gets or sets the town data table.
        public DataTable DtTown { get; set; }
        /// </summary>
        public DataTable DtTownList { get; set; }
        public DataTable DtStreet { get; set; } = new DataTable();
        public Boolean SaveClicked { get; set; } = false;
        public string TmpStr { get; set; }
        public int TableError { get; set; }

        public FormPersonEdit()
        {
            InitializeComponent();
            InitScreen();
        }


        public int InitScreen()
        {
            // Edit selected person
            Text = "Edit selected Person";
            int PersonID = PersonClass.ID_Person;
            PersonClass.PersonInit();
            PersonClass.FillPerson(PersonID);
            PersonClass.FillPersonCategory(PersonClass.FK_ID_Category);
            PersonClass.FillGender(PersonClass.FK_ID_Gender);
            FillTextBoxes();
            return 1;
        }

        private void ButtonExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        // ************** End of setup and close

        // ************** DataTableChanges(DataTable dt)
        private void DataTableChanges(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        var originalValue = row[col, DataRowVersion.Original];
                        var currentValue = row[col, DataRowVersion.Current];
                        if (!Equals(originalValue, currentValue))
                        {
                            if (TmpStr == "")
                            {
                                TmpStr += $" {col.ColumnName} = '{currentValue}'";
                            }
                            else
                            {
                                TmpStr += $", {col.ColumnName} = '{currentValue}'";
                            }
                        }
                    }
                }
            }
        }
        // END DataTableChanges(DataTable dt)

        // ************** Save Changes
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (PersonClass.ID_Person == 0)   // If creating a new person
            {
                // Add a new person
            }
            else
            {
                TmpStr = "";     //  This clause will be built and used to updtae Tables
                DataTableChanges(PersonClass.DtPerson);
                if (TmpStr != "")
                {
                    //MessageBox.Show(PersonClass.SelectPersonClause + "\nDtPerson");
                    //SaveData(PersonClass.DtPerson);
                    String SaveClause = "Update Person SET " + TmpStr +
                        " WHERE ID_Person = " + PersonClass.ID_Person;
                    MessageBox.Show(SaveClause);
                    DB.MyCommand(SaveClause);
                }

                Close();
            }
            // ************** End of Save Changes
        }

        //************** Fill TextBoxes
        private void FillTextBoxes()
        {
            TextBoxLastName.Text = PersonClass.DtPerson.Rows[0]["LastName"].ToString();
            TextBoxPreferredName.Text = PersonClass.DtPerson.Rows[0]["PreferredName"].ToString();
            TextBoxFirstNames.Text = PersonClass.DtPerson.Rows[0]["FirstNames"].ToString();
            TextBoxMobile.Text = PersonClass.DtPerson.Rows[0]["Mobile"].ToString();
            TextBoxEmail.Text = PersonClass.DtPerson.Rows[0]["Email"].ToString();

            PersonClass.FillPersonCategory(PersonClass.FK_ID_Category);
            TextBoxCategory.Text = PersonClass.DtPersonCategory.Rows[0]["CategoryName"].ToString();
            PersonClass.FillGender(PersonClass.ID_Person);
            TextBoxGender.Text = PersonClass.Gender;    //DtGender

            TextBoxDOB.Text = PersonClass.DtPerson.Rows[0]["DOB_YYYYMMDD"] != DBNull.Value ? PersonClass.DtPerson.Rows[0]["DOB_YYYYMMDD"].ToString() : "";
            TextBoxCreated.Text = PersonClass.DtPerson.Rows[0]["Created_YYYYMMDD"] != DBNull.Value ? PersonClass.DtPerson.Rows[0]["Created_YYYYMMDD"].ToString() : "";
            TextBoxInactivated.Text = PersonClass.DtPerson.Rows[0]["Inactivated_YYYYMMDD"] != DBNull.Value ? PersonClass.DtPerson.Rows[0]["Inactivated_YYYYMMDD"].ToString() : "";

            TextBoxNumberOnStreet.Text = PersonClass.DtPerson.Rows[0]["NumberOnStreet"].ToString();
            TextBoxFlat_Floor.Text = PersonClass.DtPerson.Rows[0]["Flat_Floor"].ToString();

            if (PersonClass.FK_ID_Street > 0)
            {
                DtStreet = AddressClass.SelectAStreet(PersonClass.FK_ID_Street);  // Fills AddressClass with peron's records
                TextBoxStreetName.Text = DtStreet.Rows[0]["StreetName"].ToString();
            }

            if (PersonClass.FK_ID_Town > 0)
            {
                DtTown = AddressClass.SelectATown(PersonClass.FK_ID_Town);  // Fills AddressClass with records from town table, using GridVarClass.IDintTown as the key
                TextBoxTown.Text = DtTown.Rows[0]["name"].ToString();
                TextBoxStateCode.Text = DtTown.Rows[0]["state_code"].ToString();
                TextBoxPostCode.Text = DtTown.Rows[0]["postcode"].ToString();
            }
        }
        //************** End Fill TextBoxes


        //************** Get Changes
        private void TextBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            PersonClass.DtPerson.Columns["FirstNames"].ReadOnly = false;  // Make the FirstName column editable, so that we can change it when we select a different category from the combo box
            PersonClass.DtPerson.Rows[0]["FirstNames"] = TextBoxFirstNames.Text;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed, so that we know to update it when we click the save button
        }

        private void TextBoxLastName_TextChanged(object sender, EventArgs e)
        {
            PersonClass.DtPerson.Columns["LastName"].ReadOnly = false;  // Make the LastName column editable, so that we can change it when we select a different category from the combo box
            PersonClass.DtPerson.Rows[0]["LastName"] = TextBoxLastName.Text;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
        }

        private void TextBoxPreferredName_TextChanged(object sender, EventArgs e)
        {
            PersonClass.DtPerson.Columns["PreferredName"].ReadOnly = false;  // Make the PreferredName column editable
            PersonClass.DtPerson.Rows[0]["PreferredName"] = TextBoxPreferredName.Text;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
        }

        private void TextBoxFirstName_TextChanged_1(object sender, EventArgs e)
        {
            PersonClass.DtPerson.Columns["FirstNames"].ReadOnly = false;  // Make the FirstName column editable
            PersonClass.DtPerson.Rows[0]["FirstNames"] = TextBoxFirstNames.Text;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
        }

        private void TextBoxMobile_TextChanged(object sender, EventArgs e)
        {
            PersonClass.DtPerson.Columns["Mobile"].ReadOnly = false;
            PersonClass.DtPerson.Rows[0]["Mobile"] = TextBoxMobile.Text;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            PersonClass.DtPerson.Columns["Email"].ReadOnly = false;  // Make the Email column editable
            PersonClass.DtPerson.Rows[0]["Email"] = TextBoxEmail.Text;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
        }

        private void TextBoxDOB_TextChanged(object sender, EventArgs e)
        {
            PersonClass.DtPerson.Columns["DOB_YYYYMMDD"].ReadOnly = false;  // Make the DOB column editable
            PersonClass.DtPerson.Rows[0]["DOB_YYYYMMDD"] = TextBoxDOB.Text;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
        }

        private void TextBoxCreated_TextChanged(object sender, EventArgs e)
        {
            PersonClass.DtPerson.Columns["Created_YYYYMMDD"].ReadOnly = false;  // Make the Created column editable
            PersonClass.DtPerson.Rows[0]["Created_YYYYMMDD"] = TextBoxCreated.Text;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
        }

        private void TextBoxInactivated_TextChanged(object sender, EventArgs e)
        {
            PersonClass.DtPerson.Columns["Inactivated_YYYYMMDD"].ReadOnly = false;  // Make the Inactivated column editable
            PersonClass.DtPerson.Rows[0]["Inactivated_YYYYMMDD"] = TextBoxInactivated.Text;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
        }

        private void TextBoxMobile_TextChanged_1(object sender, EventArgs e)
        {
            //PersonClass.DtPerson.Rows[0]["Mobile"].ReadOnly = false;  // Make the FK_ID_Category column editable, so that we can change it when we select a different category from the combo box
            PersonClass.DtPerson.Rows[0]["Mobile"] = TextBoxMobile.Text;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed, so that we know to update it when we click the save button
        }

        private void TextBoxCategory_Enter(object sender, EventArgs e)
        {
            TmpStr = TextBoxCategory.Text;
            TextBoxCategory.Text = "";

            //ListBoxCategory.Location = new Point(508, 54); // Set location at runtime
            ListBoxCategory.BackColor = Color.LightYellow;
            ListBoxCategory.DataSource = null;
            ListBoxCategory.Items.Clear();
            PersonClass.DtPersonCategory = null; 
            PersonClass.FillPersonCategory(0);
            ListBoxCategory.DataSource = PersonClass.DtPersonCategory;
            if (PersonClass.DtPersonCategory.Rows.Count > 0)
            {
                ListBoxCategory.DisplayMember = "CategoryName";
                ListBoxCategory.ValueMember = "ID_Category";
                ListBoxCategory.Visible = true;
            }
        }

        private void ListBoxCategory_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxCategory.Text = ListBoxCategory.GetItemText(ListBoxCategory.SelectedItem);
            ListBoxCategory.Visible = false;
            int ii = Convert.ToInt32(ListBoxCategory.SelectedValue);
            PersonClass.DtPerson.Rows[0]["FK_ID_Category"] = ii;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
        }

        private void TextBoxCategory_KeyUp(object sender, KeyEventArgs e)
        {
            TableError = 0;
            string Str1 = TextBoxCategory.Text.Substring(0, 1).ToUpper();
            Str1 = "SELECT ID_Category, " +
                    "CategoryName " +
                    "FROM PersonCategory " +
                    "Where CategoryName LIKE '" + Str1 + "%'";
            PersonClass.DtPersonCategory = DB.MySelection(Str1);
            if (PersonClass.DtPersonCategory.Rows.Count == 1)
            {
                TextBoxCategory.Text = PersonClass.DtPersonCategory.Rows[0]["CategoryName"].ToString();
                PersonClass.FK_ID_Category = Convert.ToInt32(PersonClass.DtPersonCategory.Rows[0]["ID_Category"]);
                PersonClass.DtPerson.Rows[0]["FK_ID_Category"] = PersonClass.DtPersonCategory.Rows[0]["ID_Category"];
                ListBoxCategory.Visible = false;
                PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
            }
            else
            {
                MessageBox.Show("Category not found. Please select a category from the list.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TODO Line 282 extBoxCategory_Start();
                TextBoxCategory.Text = TmpStr;
            }
        }

        private void TextBoxCategory_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void TextBoxGender_Enter(object sender, EventArgs e)
        {
            TableError = 0;
            TmpStr = TextBoxGender.Text;
            TextBoxGender.Text = "";
            // Populate the ListBoxGender with the results
            PersonClass.DtGender = null;
            PersonClass.FillGender(0);
            ListBoxGender.DataSource = PersonClass.DtGender;
            ListBoxGender.DisplayMember = "Gender";
            ListBoxGender.ValueMember = "ID_Gender";
            ListBoxGender.Visible = true;
        }

        private void ListBoxGender_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxGender.Text = ListBoxGender.GetItemText(ListBoxGender.SelectedItem);
            int ii = Convert.ToInt32(ListBoxGender.SelectedValue);
            PersonClass.DtPerson.Rows[0]["FK_ID_Gender"] = ii;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
            ListBoxGender.Visible = false;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
        }

        private void TextBoxGender_KeyUp(object sender, KeyEventArgs e)
        {
            string sqlText = "Select ID_Gender, Gender FROM PersonGender where Gender LIKE '" + TextBoxGender.Text + "%'";
            DataTable dtGenderLocal = DB.MySelection(sqlText);
            if (dtGenderLocal.Rows.Count == 1)
            {
                TextBoxGender.Text = dtGenderLocal.Rows[0]["Gender"].ToString();
                PersonClass.DtPerson.Rows[0]["FK_ID_Gender"] = dtGenderLocal.Rows[0]["ID_Gender"];
                PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
                ListBoxGender.Visible = false;
            }
            else
            {
                PersonClass.FillGender(0);
                ListBoxGender.DataSource = PersonClass.DtGender;
                ListBoxGender.DisplayMember = "Gender";
                ListBoxGender.ValueMember = "ID_Gender";
            }
        }

        private void TextBoxTown_Enter(object sender, EventArgs e)
        {
            if (PersonClass.FK_ID_Town == 0)  // No Existing Town SO no state_code
            {
                MessageBox.Show("Must have a State Code first.");
                TextBoxTown.Text = "";
                TextBoxStateCode.Focus();  //  Set focus to the StateCode TextBox so that the user can enter a state code first
            }
            else//DtTownlist = AddressClass.SelectATown(0, TextBoxTown.Text, string.Empty);   // Public DataTable DtTown             
            {
                ListBoxTown.Visible = false;
                ListBoxTown.Location = new Point(460, 380);    // Town
                ListBoxTown.DataSource = null;
                DtTownList = AddressClass.TownItems(TextBoxStateCode.Text, "");
                ListBoxTown.DataSource = DtTownList;
                ListBoxTown.DisplayMember = "name";
                ListBoxTown.ValueMember = "id";
                ListBoxTown.Visible = true;
            }
        }

        private void ListBoxTown_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ListBoxTown_Click");
            int ID_Town = Convert.ToInt32(ListBoxTown.SelectedValue);
            TextBoxTown.Text = ListBoxTown.GetItemText(ListBoxTown.SelectedItem);
            PersonClass.DtPerson.Rows[0]["FK_ID_Town"] = ID_Town;  //  Does this Work?  ERIC
            PersonClass.FK_ID_Town = ID_Town;   //  Correct New ID Here? But reverts to original value when save buttom
            PersonClass.PersonTblChanged = 1;
            ListBoxTown.Visible = false;
        }


        private void TextBoxTown_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                TownNameDone();
            }
            //string Str1 = " name LIKE '" + TextBoxTown.Text + "%'";
            DtTownList = AddressClass.TownItems(TextBoxStateCode.Text, TextBoxTown.Text);  // string TheState_Code, string StartName
            ListBoxTown.DataSource = null;
            ListBoxTown.Items.Clear();
            ListBoxTown.DataSource = DtTownList;
            ListBoxTown.DisplayMember = "name";
            ListBoxTown.ValueMember = "id";
            ListBoxTown.Visible = true;
        }

         // TownNameDone()
        private void TownNameDone()
        {
            TextBoxTown.Text = ListBoxTown.GetItemText(ListBoxTown.SelectedItem);
            PersonClass.FK_ID_Town = Convert.ToInt32(ListBoxTown.SelectedValue);
            ListBoxTown.DataSource = null;
            ListBoxTown.Visible = false;
            PersonClass.DtPerson.Rows[0]["FK_ID_Town"] = PersonClass.FK_ID_Town;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed, FKey is in PersonTable
        }
         // END of TownNameDone
        // END of TownChanges


        private void TextBoxStreetName_Enter(object sender, EventArgs e)
        {
            TmpStr = TextBoxStreetName.Text;
            TextBoxStreetName.Text = "";
            DtStreet = AddressClass.SelectStreets(string.Empty);  // All Streets
            ListBoxStreet.DataSource = DtStreet;
            ListBoxStreet.DisplayMember = "StreetName";
            ListBoxStreet.ValueMember = "ID_Street";
            ListBoxStreet.Visible = true;
        }

        private void TextBoxStreetName_KeyUp(object sender, KeyEventArgs e)
        {
            ListBoxStreet.DataSource = null;
            ListBoxStreet.Items.Clear();
            ListBoxStreet.DataSource = null;
            DtStreet = AddressClass.SelectStreets(TextBoxStreetName.Text);
            // ListBoxStreet.Refresh();
            ListBoxStreet.DataSource = DtStreet;
            ListBoxStreet.DisplayMember = "StreetName";
            ListBoxStreet.ValueMember = "ID_Street";
            if (e.KeyCode == Keys.Enter && ListBoxStreet.Visible)
            {
                PersonClass.DtPerson.Columns["FK_ID_Street  "].ReadOnly = false;
                PersonClass.DtPerson.Rows[0]["FK_ID_Street"] = ListBoxStreet.ValueMember;
                PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed

            }
        }

        public void StreetNameDone()
        {
            TextBoxStreetName.Text = ListBoxStreet.GetItemText(ListBoxStreet.SelectedItem);
                PersonClass.FK_ID_Street = Convert.ToInt32(ListBoxStreet.SelectedValue);
                PersonClass.DtPerson.Rows[0]["FK_ID_Street"] = DtStreet.Rows[0]["ID_Street"];
                ListBoxStreet.DataSource = null;
                ListBoxStreet.Visible = false;
        }

        private void TextBoxFlat_Floor_TextChanged(object sender, EventArgs e)
        {
            PersonClass.DtPerson.Columns["Flat_Floor"].ReadOnly = false;
            PersonClass.DtPerson.Rows[0]["Flat_Floor"] = TextBoxFlat_Floor.Text;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
        }

        private void TextBoxNumberOnStreet_TextChanged(object sender, EventArgs e)
        {
            PersonClass.DtPerson.Columns["NumberOnStreet"].ReadOnly = false;
            PersonClass.DtPerson.Rows[0]["NumberOnStreet"] = TextBoxNumberOnStreet.Text;
            PersonClass.PersonTblChanged = 1;  // Set flag to indicate that the person table has been changed
        }

        //MessageBox.Show("ListBoxTown_Click");
        private void ListBoxStreet_Click(object sender, EventArgs e)
        {
            int ID_Street = Convert.ToInt32(ListBoxStreet.SelectedValue);
            TextBoxStreetName.Text = ListBoxStreet.GetItemText(ListBoxStreet.SelectedItem);
            PersonClass.DtPerson.Rows[0]["FK_ID_Street"] = ID_Street;  //  Does this Work?  ERIC
            PersonClass.FK_ID_Street = ID_Street;   //  Correct New ID Here? But reverts to original value when save buttom
            PersonClass.PersonTblChanged = 1;
            ListBoxTown.Visible = false;
        }
        //************** END Get Changes
    }
}