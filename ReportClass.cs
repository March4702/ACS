using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ACS
{
    internal class ReportClass
    {
        private static string _sqlText;
        public static DataTable PhoneReport()
        {
            _sqlText = "SELECT LastName, PreferredName, Mobile, Email FROM Person ORDER BY LastName, PreferredName";
            return DB.MySelection(_sqlText);
        }

        public static DataTable AllReport()
        {
          _sqlText = "SELECT * FROM V_All ORDER BY LastName, PreferredName";
          return DB.MySelection(_sqlText);
        }

        public static DataTable LocationReport()
        {
            _sqlText = "SELECT LastName, PreferredName, " +
                "StNum, Town, StreetName, " +
                "PCode FROM V_All " +
                "ORDER BY LastName, PreferredName";
            return DB.MySelection(_sqlText);
        }

        public static DataTable OtherReport()
        {
            _sqlText = "SELECT LastName, PreferredName, " +
                "Category, Gender, " +
                "Created, " +
                "DOB, DOB_MMDD, PersonClosedDate " +
                "FROM V_All " +
                "ORDER BY LastName, PreferredName";
            return DB.MySelection(_sqlText);
        }

        public static DataTable V_ALL_Columns()
        {
            _sqlText = "PRAGMA table_info(V_ALL)";
            return DB.MySelection(_sqlText);
        }

        public static DataTable BirthdayReport()
        {
            _sqlText = "SELECT t1.DOB_YYYYMMDD AS DOB, " +
                "SUBSTRING(DOB_YYYYMMDD, 5, 4) as DOB_MMDD, " +
                "SUBSTRING(DOB_YYYYMMDD, 5, 2) as DOB_MM, " +
                "SUBSTRING(DOB_YYYYMMDD, 7, 2) as DOB_DD, " +
                "(strftime('%Y', 'now') - strftime('%Y', " +
                "substr(DOB_YYYYMMDD, 1, 4) || '-' || " +
                "substr(DOB_YYYYMMDD, 5, 2) || '-' || " +
                "substr(DOB_YYYYMMDD, 7, 2))) - " + 
                "(strftime('%m-%d', 'now') < strftime('%m-%d', " +
                "substr(DOB_YYYYMMDD, 1, 4) || '-' || " +
                "substr(DOB_YYYYMMDD, 5, 2) || '-' || " +
                "substr(DOB_YYYYMMDD, 7, 2))) AS Age, " +
                "t1.LastName, t1.PreferredName " +
                "FROM Person AS t1 " +
                "WHERE DOB_YYYYMMDD > '19000101'";
            return DB.MySelection(_sqlText);
        }


        public static String GetLBName(int LBNum)
        {
            string LBName = "";
            switch (LBNum)
            {
                case 2:
                    LBName = "ListBox12";
                    break;
                case 3:
                    LBName = "ListBox13";
                    break;
                case 4:
                    LBName = "ListBox14";
                    break;
                case 5:
                    LBName = "ListBox15";
                    break;
                default:
                    MessageBox.Show("Invalid List number");
                    break;
            }
            return LBName;
        }

        public static DataGridView CSV_File(DataGridView dgv1)
        {
            // 1. Initialize and configure the save file dialog
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "ExportedData.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Use StreamWriter with UTF8 BOM for better Excel compatibility
                        using (var sw = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                        {
                            // 2. Write the CSV Header Row
                            for (int i = 0; i < dgv1.Columns.Count; i++)
                            {
                                sw.Write(EscapeCSV(dgv1.Columns[i].HeaderText));
                                if (i < dgv1.Columns.Count - 1) sw.Write(",");
                            }
                            sw.WriteLine();

                            // 3. Stream the CSV Data Rows
                            foreach (DataGridViewRow row in dgv1.Rows)
                            {
                                // Skip the empty data entry row at the bottom if it's visible
                                if (row.IsNewRow) continue;

                                for (int j = 0; j < dgv1.Columns.Count; j++)
                                {
                                    object cellValue = row.Cells[j].Value;
                                    string valueString = cellValue != null ? cellValue.ToString() : "";

                                    sw.Write(EscapeCSV(valueString));

                                    if (j < dgv1.Columns.Count - 1) sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }

                        MessageBox.Show("Data successfully exported to CSV!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error writing file to disk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return dgv1;
            }
        }

        // Helper: Escape CSV values for Excel compatibility
        private static string EscapeCSV(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;

            // Normalize line endings to preserve them inside quoted fields
            string value = input.Replace("\r\n", "\n").Replace("\r", "\n");

            bool containsSpecial = value.Contains(",") || value.Contains("\"") || value.Contains("\n");

            if (value.Contains("\""))
            {
                // Double internal quotes
                value = value.Replace("\"", "\"\"");
            }

            if (containsSpecial)
            {
                // Wrap the whole field in double quotes
                value = $"\"{value}\"";
            }

            return value;
        }



    }
}
