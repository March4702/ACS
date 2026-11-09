using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACS
{
    public partial class FormAdd : Form
    {
        public string CategoryOriginal { get; set; }
        public string GenderOriginal { get; set; }
        public string StreetOriginal { get; set; }
        public string TownOriginal { get; set; }
        public DataTable DtTown;
        public DataTable DtStreet;
        public Boolean SaveClicked { get; set; } = false;
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            InitScreen();
        }

        private void InitScreen()
        {
            //DataTable DtTown = new DataTable();
            //DtTown = AddressClass.TownItems(TextBoxState.Text.Trim(), "");
            ComboBoxTown.Text = "Strathalbyn";
            ComboBoxCategory = PersonClass.CategoryItems(ComboBoxCategory);
            ComboBoxCategory.SelectedIndex = 1;
            ComboBoxGender = PersonClass.GenderItems(ComboBoxGender);
            ComboBoxGender.SelectedIndex = 1;
            DateTime today = DateTime.Today;
            TextBoxCreated.Text = today.ToString("yyyyMMdd");
            today = DateTime.Today.AddYears(-60);
            TextBoxDOB.Text = today.ToString("yyyyMMdd");
            TextBoxLastName.Focus();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (SaveClicked == false)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit without saving?",
                    "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveClicked = true;
            String SaveClause = null;
            if (PersonClass.ID_Person == 0)   // If creating a new person
            {
                var cols = new List<string>();
                var vals = new List<string>();

                // Local helpers
                Action<string, string> AddString = (col, value) =>
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        var escaped = value.Replace("'", "''");
                        cols.Add(col);
                        vals.Add($"'{escaped}'");
                    }
                    };

                Action<string, string> AddIntFromText = (col, textValue) =>
                {
                    if (!string.IsNullOrWhiteSpace(textValue) && int.TryParse(textValue.Trim(), out var ival))
                    {
                        cols.Add(col);
                        vals.Add(ival.ToString());
                    }
                };

                Action<string, int> AddIntFromValue = (col, intValue) =>
                {
                    if (intValue != 0)
                    {
                        cols.Add(col);
                        vals.Add(intValue.ToString());
                    }
                };

                // String fields from UI
                AddString("LastName", TextBoxLastName.Text);
                AddString("PreferredName", TextBoxPreferredName.Text);
                AddString("FirstNames", TextBoxFirstNames.Text);
                AddString("Mobile", TextBoxMobile.Text);
                AddString("Email", TextBoxEmail.Text);

                // Address / person fields (strings)
                AddString("NumberOnStreet", TextBoxNumberOnStreet.Text  );
                AddString("Flat_Floor", TextBoxFlat_Floor.Text);

                AddString("DOB_YYYYMMDD", TextBoxDOB.Text);
                // Date/integer fields (YYYYMMDD) from UI
                //AddIntFromText("DOB_YYYYMMDD", TextBoxDOB.Text);
                AddString("Created_YYYYMMDD", TextBoxCreated.Text);
                AddString("Inactivated_YYYYMMDD", TextBoxInactivated.Text);

                // Foreign keys from PersonClass (assumed set by UI selections)
                AddIntFromValue("FK_ID_Category", PersonClass.FK_ID_Category);
                AddIntFromValue("FK_ID_Gender", PersonClass.FK_ID_Gender);
                AddIntFromValue("FK_ID_Street", PersonClass.FK_ID_Street);
                AddIntFromValue("FK_ID_Town", PersonClass.FK_ID_Town);

                if (cols.Count > 0)
                {   
                    SaveClause = "INSERT INTO Person (" + string.Join(", ", cols) + ") VALUES (" + string.Join(", ", vals) + ")";
                    MessageBox.Show(SaveClause);
                    DB.MyCommand(SaveClause);
                }
                else
                {
                    MessageBox.Show("No values provided - nothing to insert.");
                }

                Close();
            }
        }            // ************** End of Save Changes

        private void ComboBoxTown_Focus()
        {
            ComboBoxTown_Enter(this, EventArgs.Empty);
        }

        private void ComboBoxTown_Enter(object sender, EventArgs e)
        {
            DtTown = new DataTable();
            string Str1 = string.Empty;
            if (TextBoxState.Text.Trim() == "")  // No state_code
            {
                MessageBox.Show("Please enter a State Code first.");
            }
            else
            {
                ComboBoxTown.Visible = true;
                //ComboBoxTown.Location = new Point(460, 380);    // Town
                TownOriginal = ComboBoxTown.Text;
                Str1 = " state_code = '" + TextBoxState.Text + "'";
                DtTown = AddressClass.TownItems(TextBoxState.Text, TownOriginal);   // Public DataTable DtTown
                ComboBoxTown.DataSource = DtTown;
                ComboBoxTown.DisplayMember = "name";
                ComboBoxTown.ValueMember = "id";
                ComboBoxTown.Visible = true;
            }
        }

        private void ComboBoxTown_KeyUp(object sender, KeyEventArgs e)
        {
            DtTown = AddressClass.TownItems(TextBoxState.Text, ComboBoxTown.Text);   // Public DataTable DtTown
        }



        private void TextBoxStreet_Enter(object sender, EventArgs e)
        {
            DtStreet = new DataTable();
            string Str1 = string.Empty;
            ListBoxStreet.Location = new Point(460, 380);
            StreetOriginal = TextBoxStreet.Text;
            TextBoxStreet.Text = "";
            DtStreet = AddressClass.SelectStreets(string.Empty);    // Public DataTable DtStreet
            ListBoxStreet.DataSource = DtStreet;
            ListBoxStreet.DisplayMember = "StreetName";
            ListBoxStreet.ValueMember = "ID_Street";
            ListBoxStreet.Visible = true;
        }


        private void ListBoxStreet_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxStreet.Text = ListBoxStreet.GetItemText(ListBoxStreet.SelectedItem);
            int IDStreet = Convert.ToInt32(ListBoxStreet.SelectedValue);
            PersonClass.FK_ID_Street = IDStreet;
            PersonClass.PersonTblChanged = 1;
            ListBoxStreet.Visible = false;
            ComboBoxTown.Focus();
        }

        private void TextBoxStreet_KeyUp(object sender, KeyEventArgs e)
        {
            //  NB Tab Key will not trigger this event, so no need to check for it
            //  Update the list box with streets that match the typed text
            if (e.KeyCode == Keys.Enter)
            {
                if (ListBoxStreet.Items.Count > 0)
                {   // If there are items in the list box, select the first one
                    TextBoxStreet.Text = ListBoxStreet.GetItemText(ListBoxStreet.SelectedItem);
                    int IDStreet = Convert.ToInt32(ListBoxStreet.SelectedValue);
                    PersonClass.FK_ID_Street = IDStreet;
                    PersonClass.PersonTblChanged = 1;
                    ListBoxStreet.Visible = false;
                }
                else
                {
                    // Add street Name to DB Street Table and get the new ID_Street
                    PersonClass.FK_ID_Street = AddressClass.AddStreet(TextBoxStreet.Text); ;
                    PersonClass.PersonTblChanged = 1;
                    ListBoxStreet.Visible = false;
                }
                ComboBoxTown.Focus();
            }
            else
            {
                DtStreet = AddressClass.SelectStreets(TextBoxStreet.Text);    // Public DataTable DtStreet
                if (TextBoxStreet.Visible == true)
                {
                    ListBoxStreet.DataSource = DtStreet;
                    ListBoxStreet.DisplayMember = "StreetName";
                    ListBoxStreet.ValueMember = "ID_Street";
                    ListBoxStreet.Visible = true;
                }
                else
                {
                    if (ListBoxStreet.Items.Count == 0)
                    {
                        ListBoxStreet.Visible = false;
                    }
                }
            }
        }
    }
}
