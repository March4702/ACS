using ACS;
using System;
using System.Collections.Generic;
using System.Data;  
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ACS
{
    public static class PersonClass
    {
        public static string CategorySelected { get; set; }

        public static int PersonTblChanged { get; set; } = 0;
        public static int ID_Person { get; set; }
        public static string LastName { get; set; }
        public static string PreferredName { get; set; }
        public static string FirstNames { get; set; }
        public static string Mobile { get; set; }
        public static string Email { get; set; }
        public static string CategoryName { get; set; } = string.Empty;
        public static string Gender { get; set; } = string.Empty;
        public static int DOB_YYYYMMDD { get; set; }
        public static int Created_YYYYMMDD { get; set; }
        public static int Inactivated_YYYYMMDD { get; set; }
        public static int FK_ID_Category { get; set; }
        public static int FK_ID_Gender { get; set; }
        public static int FK_ID_Town { get; set; }
        public static int FK_ID_Street { get; set; }
        public static int ADD_1_0 { get; set; }
        public static string GridSelect { get; set; }
        public static string SelectClause { get; set; }
        public static string OrderByClause { get; set; }
        public static string WhereClause { get; set; }
        public static string AndNeeded { get; set; }

        public static DataTable DtableDGV { get; set; }
        public static DataTable DtPerson { get; set; }
        public static DataTable DtGender { get; set; }
        public static DataTable DtPersonCategory { get; set; }
        
        public static void PersonInit()
        {
            ID_Person = 0;
            LastName = string.Empty;
            PreferredName = string.Empty;
            FirstNames = string.Empty;
            Mobile = string.Empty;
            Email = string.Empty;
            DOB_YYYYMMDD = 0;
            Created_YYYYMMDD = 0;
            Inactivated_YYYYMMDD = 0;
            FK_ID_Category = 0;
            FK_ID_Gender = 0;
            FK_ID_Street = 0;
            FK_ID_Town = 0;
            WhereClause = string.Empty;
            OrderByClause = string.Empty;
            AndNeeded = "No";
        }  //  END PersonInit()

        public static DataTable SelectPeopleData(string CategorySelected)
        {
            string sql_1 = $"SELECT * FROM V_PersonGrid ";
            if (CategorySelected != "EveryOne")
            {
                sql_1 += $"WHERE Category = '{CategorySelected}'";
            }
            sql_1 += " ORDER BY LastName, PreferredName";
            return DtableDGV = DB.MySelection(sql_1);
        }

        public static DataTable FillPerson(int ThePersonID)
        {
            SelectClause = "SELECT ID_Person, " +
            "LastName, PreferredName, FirstNames, " +
            "Mobile, Email, " +
            "DOB_YYYYMMDD, Created_YYYYMMDD, Inactivated_YYYYMMDD, " +
            "NumberOnStreet, Flat_Floor, " +
            "FK_ID_Category, FK_ID_Gender, FK_ID_Street, " +
            "FK_ID_Town " +
            "FROM Person ";
            if (ThePersonID == 0)
            {
                SelectClause += "ORDER BY LastName, PreferredName";
            }
            else
            {
                SelectClause += "WHERE ID_Person = " + ThePersonID.ToString() + " ORDER BY LastName, PreferredName";
            }


            DtPerson = DB.MySelection(SelectClause);

            ID_Person = Convert.ToInt32(DtPerson.Rows[0]["ID_Person"]);
            LastName = DtPerson.Rows[0]["LastName"].ToString();
            PreferredName = DtPerson.Rows[0]["PreferredName"].ToString();
            FirstNames = DtPerson.Rows[0]["FirstNames"].ToString();
            Mobile = DtPerson.Rows[0]["Mobile"].ToString();
            Email = DtPerson.Rows[0]["Email"].ToString();
            if (DtPerson.Rows[0]["DOB_YYYYMMDD"] != DBNull.Value)
                DOB_YYYYMMDD = Convert.ToInt32(DtPerson.Rows[0]["DOB_YYYYMMDD"]);
            if (DtPerson.Rows[0]["Created_YYYYMMDD"] != DBNull.Value)
                Created_YYYYMMDD = Convert.ToInt32(DtPerson.Rows[0]["Created_YYYYMMDD"]);
            if (DtPerson.Rows[0]["Inactivated_YYYYMMDD"] != DBNull.Value)
                Inactivated_YYYYMMDD = Convert.ToInt32(DtPerson.Rows[0]["Inactivated_YYYYMMDD"]);
            FK_ID_Category = Convert.ToInt32(DtPerson.Rows[0]["FK_ID_Category"]);
            FK_ID_Gender = Convert.ToInt32(DtPerson.Rows[0]["FK_ID_Gender"]);
            FK_ID_Street = Convert.ToInt32(DtPerson.Rows[0]["FK_ID_Street"]);
            FK_ID_Town = Convert.ToInt32(DtPerson.Rows[0]["FK_ID_Town"]);
            return DtPerson;
        }  //  END FillPerson()Created_YYYYMMDD

        public static void FillPersonGrid(int ThePersonID)
        {
            SelectClause = "SELECT * FROM V_PersonGrid";
            if (ThePersonID != 0)
            {
                SelectClause += " WHERE ID_Person = " + ThePersonID.ToString();
            }
            DtableDGV = DB.MySelection(SelectClause);
            ID_Person = Convert.ToInt32(DtableDGV.Rows[0]["ID_Person"]);
        }
        //  END FillPersonGrid(int ThePersonID)


        public static ComboBox CategoryItems(ComboBox cmb)
        {
            SelectClause = "SELECT * FROM PersonCategory ORDER BY CategoryName";
            DtPersonCategory = DB.MySelection(SelectClause);
            cmb.DataSource = DtPersonCategory;
            cmb.DisplayMember = "CategoryName";
            cmb.ValueMember = "ID_Category";
            return cmb;
        }  //  END FillPersonCategory()     

        public static ComboBox GenderItems(ComboBox cmb)
        {
            SelectClause = "SELECT * FROM PersonGender ORDER BY Gender";
            DtGender = DB.MySelection(SelectClause);
            cmb.DataSource = DtGender;
            cmb.DisplayMember = "Gender";
            cmb.ValueMember = "ID_Gender";
            return cmb;
        }  //  END FillPersonCategory()     


        public static void FillPersonCategory(int NewID)
        {
            SelectClause = "SELECT ID_Category, " +
                    "CategoryName " +
                    "FROM PersonCategory ";
            if (NewID != 0)
            {
                SelectClause += "WHERE ID_Category = " + NewID;
            }
            DtPersonCategory = DB.MySelection(SelectClause);
            CategoryName = DtPersonCategory.Rows[0]["CategoryName"].ToString();
        }
        //  END FillPersonCategory(int NewID)

        public static void FillGender(int ThePersonID)
        {
            SelectClause = "SELECT ID_Gender, " +
                    "Gender " +
                    "FROM PersonGender ";
            if (ThePersonID != 0)
            {
                SelectClause += "WHERE ID_Gender = '" + FK_ID_Gender.ToString() + "' ";
            }
            PersonClass.DtGender = DB.MySelection(SelectClause);

            FK_ID_Gender = Convert.ToInt32(DtGender.Rows[0]["ID_Gender"]);
            Gender = DtGender.Rows[0]["Gender"].ToString();
        }

        //  END FillGender()

        public static void FindGenderByName(string GenderName)
        {
            //  ERIC Finish this - FindGenderByName(string GenderName) - 2024-06-05   
        }

    }
    //  END PersonClass

}  //  END ACS