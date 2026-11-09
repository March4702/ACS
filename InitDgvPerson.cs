using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ACS
{
    internal class InitDgvPerson
    {
        public static int GetInt(object dtField)
        {
            int number = Convert.ToInt32(dtField);
            return number;
        }

        public static DataGridView SetGridColumns(DataGridView aDGV)
        {
            aDGV.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            aDGV.Columns[0].Width = 40;    // Num
            aDGV.Columns[1].Width = 240;   // LastName
            aDGV.Columns[2].Width = 130;   // PrefName
            aDGV.Columns[3].Width = 110;   // Mobile
            aDGV.Columns[4].Width = 250;   // Email
            aDGV.Columns[5].Width = 150;   // Town
            aDGV.Columns[6].Width =  90;   // Created 
            aDGV.Columns[7].Width =  90;   // DOB
            aDGV.Columns[8].Width =  90;   // Inactivated
            aDGV.Columns[8].Width = 110;   // Category

            return aDGV;
        }

    }
}

