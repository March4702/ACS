namespace ACS
{
    partial class FormPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerson));
            this.DgvPerson = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPerson
            // 
            this.DgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPerson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvPerson.Location = new System.Drawing.Point(0, 48);
            this.DgvPerson.MultiSelect = false;
            this.DgvPerson.Name = "DgvPerson";
            this.DgvPerson.RowHeadersVisible = false;
            this.DgvPerson.RowHeadersWidth = 51;
            this.DgvPerson.Size = new System.Drawing.Size(1332, 605);
            this.DgvPerson.TabIndex = 19;
            this.DgvPerson.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPerson_CellDoubleClick);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(133, 14);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 28);
            this.buttonExit.TabIndex = 36;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(31, 14);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 28);
            this.buttonUpdate.TabIndex = 38;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // FormPerson
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1332, 653);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.DgvPerson);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1350, 700);
            this.Name = "FormPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Person Information";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvPerson;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

