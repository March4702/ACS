namespace ACS
{
    partial class FormPersonEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label labelStreetName;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonEdit));
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelPreferredName = new System.Windows.Forms.Label();
            this.TextBoxPreferredName = new System.Windows.Forms.TextBox();
            this.TextBoxFirstNames = new System.Windows.Forms.TextBox();
            this.LabelFirstNames = new System.Windows.Forms.Label();
            this.TextBoxTown = new System.Windows.Forms.TextBox();
            this.labelTown = new System.Windows.Forms.Label();
            this.TextBoxStreetName = new System.Windows.Forms.TextBox();
            this.TextBoxStateCode = new System.Windows.Forms.TextBox();
            this.TextBoxPostCode = new System.Windows.Forms.TextBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.LabelFMobile = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelGender = new System.Windows.Forms.Label();
            this.Label_PClass = new System.Windows.Forms.Label();
            this.LabelDOB = new System.Windows.Forms.Label();
            this.TextBoxDOB = new System.Windows.Forms.TextBox();
            this.TextBoxCreated = new System.Windows.Forms.TextBox();
            this.LabelCreated = new System.Windows.Forms.Label();
            this.TextBoxInactivated = new System.Windows.Forms.TextBox();
            this.LabelInactive = new System.Windows.Forms.Label();
            this.TextBoxNumberOnStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxMobile = new System.Windows.Forms.TextBox();
            this.ListBoxTown = new System.Windows.Forms.ListBox();
            this.TextBoxGender = new System.Windows.Forms.TextBox();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.ListBoxCategory = new System.Windows.Forms.ListBox();
            this.ListBoxGender = new System.Windows.Forms.ListBox();
            this.ListBoxStreet = new System.Windows.Forms.ListBox();
            this.labelFlat_Floor = new System.Windows.Forms.Label();
            this.TextBoxFlat_Floor = new System.Windows.Forms.TextBox();
            this.LabelStatePCode = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabelStar2 = new System.Windows.Forms.Label();
            labelStreetName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStreetName
            // 
            labelStreetName.Location = new System.Drawing.Point(36, 383);
            labelStreetName.Name = "labelStreetName";
            labelStreetName.Size = new System.Drawing.Size(60, 20);
            labelStreetName.TabIndex = 0;
            labelStreetName.Text = "Street";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(26, 12);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(80, 28);
            this.ButtonSave.TabIndex = 17;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(170, 60);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(300, 30);
            this.TextBoxLastName.TabIndex = 1;
            this.TextBoxLastName.TextChanged += new System.EventHandler(this.TextBoxLastName_TextChanged);
            // 
            // LabelLastName
            // 
            this.LabelLastName.Location = new System.Drawing.Point(35, 63);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(86, 20);
            this.LabelLastName.TabIndex = 0;
            this.LabelLastName.Text = "Last Name";
            // 
            // LabelPreferredName
            // 
            this.LabelPreferredName.Location = new System.Drawing.Point(35, 113);
            this.LabelPreferredName.Name = "LabelPreferredName";
            this.LabelPreferredName.Size = new System.Drawing.Size(121, 20);
            this.LabelPreferredName.TabIndex = 0;
            this.LabelPreferredName.Text = "Preferred Name";
            // 
            // TextBoxPreferredName
            // 
            this.TextBoxPreferredName.Location = new System.Drawing.Point(170, 110);
            this.TextBoxPreferredName.Name = "TextBoxPreferredName";
            this.TextBoxPreferredName.Size = new System.Drawing.Size(300, 30);
            this.TextBoxPreferredName.TabIndex = 3;
            this.TextBoxPreferredName.TextChanged += new System.EventHandler(this.TextBoxPreferredName_TextChanged);
            // 
            // TextBoxFirstNames
            // 
            this.TextBoxFirstNames.Location = new System.Drawing.Point(170, 160);
            this.TextBoxFirstNames.Name = "TextBoxFirstNames";
            this.TextBoxFirstNames.Size = new System.Drawing.Size(135, 30);
            this.TextBoxFirstNames.TabIndex = 4;
            this.TextBoxFirstNames.TextChanged += new System.EventHandler(this.TextBoxFirstName_TextChanged_1);
            // 
            // LabelFirstNames
            // 
            this.LabelFirstNames.Location = new System.Drawing.Point(35, 163);
            this.LabelFirstNames.Name = "LabelFirstNames";
            this.LabelFirstNames.Size = new System.Drawing.Size(94, 20);
            this.LabelFirstNames.TabIndex = 0;
            this.LabelFirstNames.Text = "First Names";
            // 
            // TextBoxTown
            // 
            this.TextBoxTown.Location = new System.Drawing.Point(170, 425);
            this.TextBoxTown.Name = "TextBoxTown";
            this.TextBoxTown.Size = new System.Drawing.Size(358, 30);
            this.TextBoxTown.TabIndex = 11;
            this.TextBoxTown.Enter += new System.EventHandler(this.TextBoxTown_Enter);
            this.TextBoxTown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxTown_KeyUp);
            // 
            // labelTown
            // 
            this.labelTown.Location = new System.Drawing.Point(35, 428);
            this.labelTown.Name = "labelTown";
            this.labelTown.Size = new System.Drawing.Size(103, 20);
            this.labelTown.TabIndex = 0;
            this.labelTown.Text = "Town Suburb";
            // 
            // TextBoxStreetName
            // 
            this.TextBoxStreetName.Location = new System.Drawing.Point(171, 380);
            this.TextBoxStreetName.Name = "TextBoxStreetName";
            this.TextBoxStreetName.Size = new System.Drawing.Size(190, 30);
            this.TextBoxStreetName.TabIndex = 9;
            this.TextBoxStreetName.Enter += new System.EventHandler(this.TextBoxStreetName_Enter);
            this.TextBoxStreetName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxStreetName_KeyUp);
            // 
            // TextBoxStateCode
            // 
            this.TextBoxStateCode.Location = new System.Drawing.Point(171, 478);
            this.TextBoxStateCode.Name = "TextBoxStateCode";
            this.TextBoxStateCode.Size = new System.Drawing.Size(72, 30);
            this.TextBoxStateCode.TabIndex = 12;
            // 
            // TextBoxPostCode
            // 
            this.TextBoxPostCode.Location = new System.Drawing.Point(271, 478);
            this.TextBoxPostCode.Name = "TextBoxPostCode";
            this.TextBoxPostCode.ReadOnly = true;
            this.TextBoxPostCode.Size = new System.Drawing.Size(72, 30);
            this.TextBoxPostCode.TabIndex = 0;
            this.TextBoxPostCode.TabStop = false;
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.Red;
            this.ButtonExit.Location = new System.Drawing.Point(126, 12);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(80, 28);
            this.ButtonExit.TabIndex = 18;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click_1);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(170, 208);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(659, 30);
            this.TextBoxEmail.TabIndex = 6;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // LabelFMobile
            // 
            this.LabelFMobile.Location = new System.Drawing.Point(35, 258);
            this.LabelFMobile.Name = "LabelFMobile";
            this.LabelFMobile.Size = new System.Drawing.Size(55, 20);
            this.LabelFMobile.TabIndex = 0;
            this.LabelFMobile.Text = "Mobile";
            // 
            // LabelEmail
            // 
            this.LabelEmail.Location = new System.Drawing.Point(35, 211);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(48, 20);
            this.LabelEmail.TabIndex = 0;
            this.LabelEmail.Text = "Email";
            // 
            // LabelGender
            // 
            this.LabelGender.Location = new System.Drawing.Point(565, 298);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(63, 20);
            this.LabelGender.TabIndex = 0;
            this.LabelGender.Text = "Gender";
            // 
            // Label_PClass
            // 
            this.Label_PClass.AutoSize = true;
            this.Label_PClass.Location = new System.Drawing.Point(553, 253);
            this.Label_PClass.Name = "Label_PClass";
            this.Label_PClass.Size = new System.Drawing.Size(92, 25);
            this.Label_PClass.TabIndex = 66;
            this.Label_PClass.Text = "Category";
            // 
            // LabelDOB
            // 
            this.LabelDOB.Location = new System.Drawing.Point(564, 341);
            this.LabelDOB.Name = "LabelDOB";
            this.LabelDOB.Size = new System.Drawing.Size(107, 20);
            this.LabelDOB.TabIndex = 0;
            this.LabelDOB.Text = "Date of birth";
            // 
            // TextBoxDOB
            // 
            this.TextBoxDOB.Location = new System.Drawing.Point(677, 338);
            this.TextBoxDOB.Name = "TextBoxDOB";
            this.TextBoxDOB.Size = new System.Drawing.Size(152, 30);
            this.TextBoxDOB.TabIndex = 14;
            this.TextBoxDOB.TextChanged += new System.EventHandler(this.TextBoxDOB_TextChanged);
            // 
            // TextBoxCreated
            // 
            this.TextBoxCreated.Location = new System.Drawing.Point(678, 380);
            this.TextBoxCreated.Name = "TextBoxCreated";
            this.TextBoxCreated.Size = new System.Drawing.Size(152, 30);
            this.TextBoxCreated.TabIndex = 15;
            this.TextBoxCreated.TextChanged += new System.EventHandler(this.TextBoxCreated_TextChanged);
            // 
            // LabelCreated
            // 
            this.LabelCreated.Location = new System.Drawing.Point(564, 383);
            this.LabelCreated.Name = "LabelCreated";
            this.LabelCreated.Size = new System.Drawing.Size(97, 20);
            this.LabelCreated.TabIndex = 0;
            this.LabelCreated.Text = "Created";
            // 
            // TextBoxInactivated
            // 
            this.TextBoxInactivated.Location = new System.Drawing.Point(677, 418);
            this.TextBoxInactivated.Name = "TextBoxInactivated";
            this.TextBoxInactivated.Size = new System.Drawing.Size(152, 30);
            this.TextBoxInactivated.TabIndex = 16;
            this.TextBoxInactivated.TextChanged += new System.EventHandler(this.TextBoxInactivated_TextChanged);
            // 
            // LabelInactive
            // 
            this.LabelInactive.Location = new System.Drawing.Point(564, 428);
            this.LabelInactive.Name = "LabelInactive";
            this.LabelInactive.Size = new System.Drawing.Size(107, 20);
            this.LabelInactive.TabIndex = 0;
            this.LabelInactive.Text = "Inactivated";
            // 
            // TextBoxNumberOnStreet
            // 
            this.TextBoxNumberOnStreet.Location = new System.Drawing.Point(171, 340);
            this.TextBoxNumberOnStreet.Name = "TextBoxNumberOnStreet";
            this.TextBoxNumberOnStreet.Size = new System.Drawing.Size(114, 30);
            this.TextBoxNumberOnStreet.TabIndex = 7;
            this.TextBoxNumberOnStreet.TextChanged += new System.EventHandler(this.TextBoxNumberOnStreet_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Number";
            // 
            // TextBoxMobile
            // 
            this.TextBoxMobile.Location = new System.Drawing.Point(170, 253);
            this.TextBoxMobile.Name = "TextBoxMobile";
            this.TextBoxMobile.Size = new System.Drawing.Size(135, 30);
            this.TextBoxMobile.TabIndex = 5;
            this.TextBoxMobile.TextChanged += new System.EventHandler(this.TextBoxMobile_TextChanged_1);
            // 
            // ListBoxTown
            // 
            this.ListBoxTown.FormattingEnabled = true;
            this.ListBoxTown.ItemHeight = 25;
            this.ListBoxTown.Location = new System.Drawing.Point(258, 27);
            this.ListBoxTown.Name = "ListBoxTown";
            this.ListBoxTown.Size = new System.Drawing.Size(218, 204);
            this.ListBoxTown.TabIndex = 75;
            this.ListBoxTown.Visible = false;
            this.ListBoxTown.Click += new System.EventHandler(this.ListBoxTown_Click);
            // 
            // TextBoxGender
            // 
            this.TextBoxGender.Location = new System.Drawing.Point(678, 293);
            this.TextBoxGender.Name = "TextBoxGender";
            this.TextBoxGender.Size = new System.Drawing.Size(152, 30);
            this.TextBoxGender.TabIndex = 76;
            this.TextBoxGender.Enter += new System.EventHandler(this.TextBoxGender_Enter);
            this.TextBoxGender.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxGender_KeyUp);
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Location = new System.Drawing.Point(678, 248);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(152, 30);
            this.TextBoxCategory.TabIndex = 77;
            this.TextBoxCategory.TextChanged += new System.EventHandler(this.TextBoxCategory_TextChanged);
            this.TextBoxCategory.Enter += new System.EventHandler(this.TextBoxCategory_Enter);
            this.TextBoxCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxCategory_KeyUp);
            // 
            // ListBoxCategory
            // 
            this.ListBoxCategory.BackColor = System.Drawing.Color.LightYellow;
            this.ListBoxCategory.FormattingEnabled = true;
            this.ListBoxCategory.ItemHeight = 25;
            this.ListBoxCategory.Location = new System.Drawing.Point(482, 29);
            this.ListBoxCategory.Name = "ListBoxCategory";
            this.ListBoxCategory.Size = new System.Drawing.Size(146, 154);
            this.ListBoxCategory.TabIndex = 0;
            this.ListBoxCategory.TabStop = false;
            this.ListBoxCategory.Visible = false;
            this.ListBoxCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxCategory_MouseClick);
            // 
            // ListBoxGender
            // 
            this.ListBoxGender.BackColor = System.Drawing.Color.LightYellow;
            this.ListBoxGender.FormattingEnabled = true;
            this.ListBoxGender.ItemHeight = 25;
            this.ListBoxGender.Location = new System.Drawing.Point(687, 54);
            this.ListBoxGender.Name = "ListBoxGender";
            this.ListBoxGender.Size = new System.Drawing.Size(143, 129);
            this.ListBoxGender.TabIndex = 78;
            this.ListBoxGender.Visible = false;
            this.ListBoxGender.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxGender_MouseClick);
            // 
            // ListBoxStreet
            // 
            this.ListBoxStreet.FormattingEnabled = true;
            this.ListBoxStreet.ItemHeight = 25;
            this.ListBoxStreet.Location = new System.Drawing.Point(355, 258);
            this.ListBoxStreet.Name = "ListBoxStreet";
            this.ListBoxStreet.Size = new System.Drawing.Size(183, 204);
            this.ListBoxStreet.TabIndex = 79;
            this.ListBoxStreet.Visible = false;
            this.ListBoxStreet.Click += new System.EventHandler(this.ListBoxStreet_Click);
            // 
            // labelFlat_Floor
            // 
            this.labelFlat_Floor.AutoSize = true;
            this.labelFlat_Floor.Location = new System.Drawing.Point(36, 296);
            this.labelFlat_Floor.Name = "labelFlat_Floor";
            this.labelFlat_Floor.Size = new System.Drawing.Size(115, 25);
            this.labelFlat_Floor.TabIndex = 80;
            this.labelFlat_Floor.Text = "Flat or Floor";
            // 
            // TextBoxFlat_Floor
            // 
            this.TextBoxFlat_Floor.Location = new System.Drawing.Point(171, 296);
            this.TextBoxFlat_Floor.Name = "TextBoxFlat_Floor";
            this.TextBoxFlat_Floor.Size = new System.Drawing.Size(114, 30);
            this.TextBoxFlat_Floor.TabIndex = 81;
            // 
            // LabelStatePCode
            // 
            this.LabelStatePCode.Location = new System.Drawing.Point(36, 481);
            this.LabelStatePCode.Name = "LabelStatePCode";
            this.LabelStatePCode.Size = new System.Drawing.Size(81, 27);
            this.LabelStatePCode.TabIndex = 82;
            this.LabelStatePCode.Text = "State PCode";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(128, 63);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(28, 36);
            this.Label1.TabIndex = 83;
            this.Label1.Text = "*";
            // 
            // LabelStar2
            // 
            this.LabelStar2.AutoSize = true;
            this.LabelStar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStar2.ForeColor = System.Drawing.Color.Red;
            this.LabelStar2.Location = new System.Drawing.Point(128, 481);
            this.LabelStar2.Name = "LabelStar2";
            this.LabelStar2.Size = new System.Drawing.Size(28, 36);
            this.LabelStar2.TabIndex = 84;
            this.LabelStar2.Text = "*";
            // 
            // FormPersonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.LabelStar2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabelStatePCode);
            this.Controls.Add(this.labelFlat_Floor);
            this.Controls.Add(this.TextBoxFlat_Floor);
            this.Controls.Add(this.ListBoxStreet);
            this.Controls.Add(this.ListBoxGender);
            this.Controls.Add(this.ListBoxCategory);
            this.Controls.Add(this.TextBoxCategory);
            this.Controls.Add(this.TextBoxGender);
            this.Controls.Add(this.ListBoxTown);
            this.Controls.Add(this.TextBoxMobile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxInactivated);
            this.Controls.Add(this.LabelInactive);
            this.Controls.Add(this.TextBoxCreated);
            this.Controls.Add(this.LabelCreated);
            this.Controls.Add(this.TextBoxDOB);
            this.Controls.Add(this.LabelDOB);
            this.Controls.Add(this.Label_PClass);
            this.Controls.Add(this.LabelGender);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.LabelFMobile);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.TextBoxPostCode);
            this.Controls.Add(this.TextBoxStateCode);
            this.Controls.Add(labelStreetName);
            this.Controls.Add(this.TextBoxStreetName);
            this.Controls.Add(this.TextBoxTown);
            this.Controls.Add(this.labelTown);
            this.Controls.Add(this.TextBoxNumberOnStreet);
            this.Controls.Add(this.TextBoxFirstNames);
            this.Controls.Add(this.LabelFirstNames);
            this.Controls.Add(this.TextBoxPreferredName);
            this.Controls.Add(this.LabelPreferredName);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.TextBoxLastName);
            this.Controls.Add(this.ButtonSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormPersonEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add / Edit a person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelPreferredName;
        private System.Windows.Forms.TextBox TextBoxPreferredName;
        private System.Windows.Forms.TextBox TextBoxFirstNames;
        private System.Windows.Forms.Label LabelFirstNames;
        private System.Windows.Forms.TextBox TextBoxTown;
        private System.Windows.Forms.Label labelTown;
        private System.Windows.Forms.TextBox TextBoxStreetName;
        private System.Windows.Forms.TextBox TextBoxStateCode;
        private System.Windows.Forms.TextBox TextBoxPostCode;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label LabelFMobile;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelGender;
        private System.Windows.Forms.Label Label_PClass;
        private System.Windows.Forms.Label LabelDOB;
        private System.Windows.Forms.TextBox TextBoxDOB;
        private System.Windows.Forms.TextBox TextBoxCreated;
        private System.Windows.Forms.Label LabelCreated;
        private System.Windows.Forms.TextBox TextBoxInactivated;
        private System.Windows.Forms.Label LabelInactive;
        private System.Windows.Forms.TextBox TextBoxNumberOnStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxMobile;
        private System.Windows.Forms.ListBox ListBoxTown;
        private System.Windows.Forms.TextBox TextBoxGender;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.ListBox ListBoxCategory;
        private System.Windows.Forms.ListBox ListBoxGender;
        private System.Windows.Forms.ListBox ListBoxStreet;
        private System.Windows.Forms.Label labelFlat_Floor;
        private System.Windows.Forms.TextBox TextBoxFlat_Floor;
        private System.Windows.Forms.Label LabelStatePCode;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label LabelStar2;
    }
}