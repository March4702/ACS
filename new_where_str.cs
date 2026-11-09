using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ACS
{
    internal class new_where_str
    {
        public static void newWhereStr(string sName)
        {
            if (sName.Length > 0)                  // LastName From
            {
                string sNewWhere = "LastName >= '" + sName + "'" +";";
                if (MyVar.sAndIsNeeded == "Yes")
                {
                    MyVar.SelectStr += " AND ";
                }
                else
                {
                    MyVar.sAndIsNeeded = " Yes ";
                }
                MyVar.sWhere = sNewWhere;
            }
        }
    }
}
