namespace ACS
{
    partial class FormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.Mnu = new System.Windows.Forms.MenuStrip();
            this.MnuFixed = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOther = new System.Windows.Forms.ToolStripMenuItem();
            this.BirthdaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV_Report = new System.Windows.Forms.DataGridView();
            this.Mnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // Mnu
            // 
            this.Mnu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mnu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFixed,
            this.MnuCsv,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.MnuExit,
            this.toolStripMenuItem10});
            this.Mnu.Location = new System.Drawing.Point(0, 0);
            this.Mnu.Name = "Mnu";
            this.Mnu.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.Mnu.Size = new System.Drawing.Size(1332, 36);
            this.Mnu.TabIndex = 0;
            this.Mnu.Text = "Mnu";
            // 
            // MnuFixed
            // 
            this.MnuFixed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAll,
            this.MnuPhone,
            this.MnuLocation,
            this.MnuOther,
            this.BirthdaysToolStripMenuItem});
            this.MnuFixed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MnuFixed.Name = "MnuFixed";
            this.MnuFixed.Size = new System.Drawing.Size(79, 32);
            this.MnuFixed.Text = "&Preset";
            // 
            // MnuAll
            // 
            this.MnuAll.Name = "MnuAll";
            this.MnuAll.Size = new System.Drawing.Size(224, 32);
            this.MnuAll.Text = "&All Info";
            this.MnuAll.Click += new System.EventHandler(this.MnuAll_Click);
            // 
            // MnuPhone
            // 
            this.MnuPhone.Name = "MnuPhone";
            this.MnuPhone.Size = new System.Drawing.Size(224, 32);
            this.MnuPhone.Text = "&Phone Email";
            this.MnuPhone.Click += new System.EventHandler(this.MnuPhone_Click);
            // 
            // MnuLocation
            // 
            this.MnuLocation.Name = "MnuLocation";
            this.MnuLocation.Size = new System.Drawing.Size(224, 32);
            this.MnuLocation.Text = "&Location";
            this.MnuLocation.Click += new System.EventHandler(this.MnuLocation_Click);
            // 
            // MnuOther
            // 
            this.MnuOther.Name = "MnuOther";
            this.MnuOther.Size = new System.Drawing.Size(224, 32);
            this.MnuOther.Text = "&Other Info";
            this.MnuOther.Click += new System.EventHandler(this.MnuOther_Click);
            // 
            // BirthdaysToolStripMenuItem
            // 
            this.BirthdaysToolStripMenuItem.Name = "BirthdaysToolStripMenuItem";
            this.BirthdaysToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.BirthdaysToolStripMenuItem.Text = "Birthdays";
            this.BirthdaysToolStripMenuItem.Click += new System.EventHandler(this.BirthdaysToolStripMenuItem_Click);
            // 
            // MnuCsv
            // 
            this.MnuCsv.Name = "MnuCsv";
            this.MnuCsv.Size = new System.Drawing.Size(123, 32);
            this.MnuCsv.Text = "&CSV Export";
            this.MnuCsv.Click += new System.EventHandler(this.MnuCsv_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(14, 32);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(14, 32);
            // 
            // MnuExit
            // 
            this.MnuExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MnuExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(62, 32);
            this.MnuExit.Text = "&Exit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(14, 32);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(224, 32);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(152, 32);
            // 
            // DGV_Report
            // 
            this.DGV_Report.AllowUserToOrderColumns = true;
            this.DGV_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Report.Location = new System.Drawing.Point(0, 39);
            this.DGV_Report.Name = "DGV_Report";
            this.DGV_Report.RowHeadersWidth = 51;
            this.DGV_Report.RowTemplate.Height = 24;
            this.DGV_Report.Size = new System.Drawing.Size(1332, 614);
            this.DGV_Report.TabIndex = 2;
            this.DGV_Report.Visible = false;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1332, 653);
            this.Controls.Add(this.DGV_Report);
            this.Controls.Add(this.Mnu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MainMenuStrip = this.Mnu;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Report";
            this.Mnu.ResumeLayout(false);
            this.Mnu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.DataGridView DGV_Report;
        private System.Windows.Forms.ToolStripMenuItem MnuFixed;
        private System.Windows.Forms.ToolStripMenuItem MnuAll;
        private System.Windows.Forms.ToolStripMenuItem MnuPhone;
        private System.Windows.Forms.ToolStripMenuItem MnuLocation;
        private System.Windows.Forms.ToolStripMenuItem MnuOther;
        private System.Windows.Forms.ToolStripMenuItem BirthdaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuCsv;
    }
}