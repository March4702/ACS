using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace ACS
{
    internal class AddressClass
    {
        public static string StateCode { get; set; }
        // Reusable SQL selection string for ADO.NET commands
        public static string SelectTownStr = "SELECT id, name, state_code, postcode FROM Town";
        public static string SelectStreetStr = "SELECT ID_Street, StreetName FROM Street";

        public static int AddStreet(string StreetName)
        {
            DB.MyCommand("INSERT INTO Street (StreetName) VALUES ('" + StreetName + "')");
            int NewStreetId = 0;
            DataTable Dbt = DB.MySelection("SELECT * FROM Street WHERE StreetName = '" + StreetName + "'");
            if (Dbt.Rows.Count > 0)
            {
                NewStreetId = Convert.ToInt32(Dbt.Rows[0]["id_Street"]);
            }
            return NewStreetId;
        }  //  END AddStreet(string StreetName)

        public static DataTable SelectAStreet(int StreetId)
        {
            string Str1 = SelectStreetStr;
            Str1 += " WHERE ID_Street = " + StreetId;
            DataTable Dt = DB.MySelection(Str1);
            return Dt;
        }  //  END SelectAStreet()

        public static DataTable SelectStreets(string StartName)
        {
            string Str1 = SelectStreetStr;
            if (!string.IsNullOrEmpty(StartName))
            {
                Str1 += " WHERE StreetName LIKE '" + StartName + "%'";
            }
            Str1 += " ORDER BY StreetName";
            DataTable Dt = DB.MySelection(Str1);
            return Dt;
        }  //  END SelectAStreet()

        public static DataTable SelectATown(int TownId)
        {
            string Str1 = SelectTownStr + " WHERE id = " + TownId;
            DataTable Dt = DB.MySelection(Str1);
            return Dt;
        }  //  END SelectATown(int TownId, string SearchTerm)


        //  SelectTowns(string TheState_Code, string StartName) 
        public static DataTable TownItems(string TheState_Code, string StartName)
        {
            string Str1 = SelectTownStr + " WHERE state_code = '" + TheState_Code + "' ";
            if (StartName != "")
            {
                Str1 += "AND name LIKE '" + StartName + "%' ORDER BY name";
            }
            else
                Str1 += "ORDER BY name";
            DataTable Dt = DB.MySelection(Str1);
            return Dt;
        }  //  END SelectTowns(string TheState_Code, string StartName)
    }
}          //  END AddressClass
