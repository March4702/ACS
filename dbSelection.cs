using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS
{
    internal class dbSelection
    {
        public static int getInt(object dtField)
        {
            int number = Convert.ToInt32(dtField);
            return number;
        }
        public static DataGridView setGridColumns(DataGridView aDGV)
        {
            aDGV.DataSource = null;        // Clear current binding (optional)
            DataTable dtCol = new DataTable();
            string aSelectStr = "SELECT * FROM vAllMembers";
            dtCol = db.mySelection(aSelectStr);
            aDGV.DataSource = dtCol;       // Re-bind updated data

            int x = 1;

            // Exit when x becomes greater than 4
            while (x <= 4)
            {
                Console.WriteLine("GeeksforGeeks");

                // Increment the value of x for
                // next iteration
                x++;


                aDGV.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                aDGV.Columns[0].Width = getInt(dtCol.Rows[0][3]); // 50;   Default
                aDGV.Columns[1].Width = getInt(dtCol.Rows[1][3]); // 250;  Default
                aDGV.Columns[2].Width = getInt(dtCol.Rows[2][3]); // 250;  Default
                aDGV.Columns[3].Width = getInt(dtCol.Rows[3][3]); // 230;  Default
                aDGV.Columns[4].Width = getInt(dtCol.Rows[4][3]); // 150;  Default
                aDGV.Columns[5].Width = getInt(dtCol.Rows[5][3]); // 100;  Default
                aDGV.Columns[6].Width = getInt(dtCol.Rows[6][3]); // 250;  Default
                aDGV.Columns[7].Width = getInt(dtCol.Rows[7][3]); // 290;  Default
                aDGV.Columns[8].Width = getInt(dtCol.Rows[8][3]); // 160;  Default



                int dgvRowsCurrent = db.dt.Rows.Count;
            }
            
            return aDGV;
        }

    }
}
