using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS
{
    internal class MyVar
    {
        public static int CRUDint { get; set; } // 1 Create, 2 Read, 3 Update, 4 Delete 
        public static int IDintPerson { get; set; }
        public static int IDintPersonType { get; set; }
        public static int IDintStreet { get; set; }
        public static int IDintStreetType { get; set; }
        public static int IDintTown { get; set; }
        public static string State_code { get; set; }
        public static string LastNameFrom { get; set; }
        public static string LastNameTo { get; set; }
        public static string PrefNameFrom { get; set; }
        public static string PrefNameTo { get; set; }
        public static string MobileStr { get; set; }
        public static string EmailStr { get; set; }
        public static string TownFrom { get; set; }
        public static string TownTo { get; set; }
        public static string AndNeeded { get; set; }
        public static string SelectPeopleStr { get; set; }
        public static string GridSelectStr { get; set; }
        public static string OrderByClause { get; set; }
        public static string WhereClause { get; set; }
        public static DataTable Dtable1 { get; set; }
        public static DataTable DtPerson { get; set; }
        public static DataTable DtPersonType { get; set; }

        public static void InitMvVar()
        {
            IDintPerson = 0;
            IDintPersonType = 0;
            IDintStreet = 0;
            IDintStreetType = 0;
            IDintTown = 0;
            IDintStreetType = 0;
            LastNameFrom = string.Empty;
            LastNameTo = string.Empty;
            PrefNameFrom = string.Empty;
            PrefNameTo = string.Empty;
            MobileStr = string.Empty;
            EmailStr = string.Empty;
            TownFrom = string.Empty;
            TownTo = string.Empty;
            WhereClause = string.Empty;
            State_code = string.Empty;
            OrderByClause = string.Empty;
            AndNeeded = "No";

            SelectPeopleStr = "SELECT t1.ID_Person AS Num, " +
                "t1.LastName, t1.PreferredName, " +
                "t1.NumberOnStreet AS StNum, " +
                "t3.StreetName, t4.StreetTypeDesc AS StrDesc, t5.name AS Town, " +
                "t5.postcode AS PC, t1.Mobile, t1.Email, t2.PersonTypeDesc AS Category, " +
                "t1.Gender, t1.DOB_YYYYMMDD AS DOB, t1.Created_YYYYMMDD AS Created " +
                "FROM Person AS t1 " +
                "LEFT JOIN PersonType AS t2 ON t1.FK_ID_PersonType = t2.ID_PersonType " +
                "LEFT JOIN Street as t3 ON t1.FK_ID_Street = t3.ID_Street " +
                "LEFT JOIN StreetType as t4 ON t4.ID_StreetType = t3.FK_ID_StreetType " +
                "LEFT JOIN TownDetails AS t5 ON t3.FK_ID_Town = t5.ID ";
        }
    }

    internal class PersonClass
    {
        public static int FK_ID_PersonType { get; set; }
        public static string LastName { get; set; }
        public static string PreferredName { get; set; }
        public static string FirstName { get; set; }
        public static string Mobile { get; set; }
        public static string Email { get; set; }
        public static string State_code { get; set; }
        public static string NumberOnStreet { get; set; }
        public static int FK_ID_Street { get; set; }
        public static string Flat_Floor { get; set; }
        public static string Gender { get; set; }
        public static int DOB_YYYYMMDD { get; set; }
        public static int Created_YYYYMMDD { get; set; }
        public static int Inactive_YYYYMMDD { get; set; }
        public static string SelectPerson { get; set; }
        public static string SelectPersonType { get; set; }
        public static string OrderByClause { get; set; }
        public static string WhereClause { get; set; }
        public static string AndNeeded { get; set; }
        public static DataTable DtPerson { get; set; }
        public static DataTable DtPersonType { get; set; }

        public static void InitPerson()
        {
            FK_ID_PersonType = 0;
            LastName = string.Empty;
            PreferredName = string.Empty;
            FirstName = string.Empty;
            Mobile = string.Empty;
            Email = string.Empty;
            State_code = string.Empty;
            NumberOnStreet = string.Empty;
            FK_ID_Street = 0;
            Flat_Floor = string.Empty;
            Gender = string.Empty;
            DOB_YYYYMMDD = 0;
            Created_YYYYMMDD = 0;
            Inactive_YYYYMMDD = 0;
            WhereClause = string.Empty;
            OrderByClause = string.Empty;
            AndNeeded = "No";


            SelectPerson = "SELECT ID_Person, " +
                "LastName, PreferredName, FirstName, " +
                "Mobile, Email, Flat_Floor, " +
                "NumberOnStreet, FK_ID_Street, " +
                "Gender, DOB_YYYYMMDD, Created_YYYYMMDD, " +
                "Inactive_YYYYMMDD, FK_ID_PersonClass, " +
                "state_code, Created_YYYYMMDD " +
                "FROM Person ";

            SelectPersonType = "SELECT ID_PersonType, " +
               "PersonTypeDescription " +
               "FROM PersonType ";
        }

        public static void FillPerson()
        {
            string SelectClause = PersonClass.SelectPerson;
            SelectClause = SelectClause + "WHERE ID_Person = '" + MyVar.IDintPerson.ToString() + "' ";
            //SelectClause += "WHERE ID_Person = " + MyVar.IDintPerson.ToString();
            DtPerson = DB.MySelection(SelectClause);

            FK_ID_PersonType = Convert.ToInt32(DtPerson.Rows[0]["FK_ID_PersonType"]);
            LastName = DtPerson.Rows[0]["LastName"].ToString();
            PreferredName = DtPerson.Rows[0]["PreferredName"].ToString();
            FirstName = DtPerson.Rows[0]["FirstName"].ToString();
            Mobile = DtPerson.Rows[0]["Mobile"].ToString();
            Email = DtPerson.Rows[0]["Email"].ToString();
            State_code = DtPerson.Rows[0]["state_code"].ToString();
            NumberOnStreet = DtPerson.Rows[0]["NumberOnStreet"].ToString();
            FK_ID_Street = Convert.ToInt32(DtPerson.Rows[0]["FK_ID_Street"]);
            Flat_Floor = DtPerson.Rows[0]["Flat_Floor"].ToString();
            Gender = DtPerson.Rows[0]["Gender"].ToString();
            DOB_YYYYMMDD = Convert.ToInt32(DtPerson.Rows[0]["DOB_YYYYMMDD"]);
            Created_YYYYMMDD = Convert.ToInt32(DtPerson.Rows[0]["Created_YYYYMMDD"]);
            Inactive_YYYYMMDD = Convert.ToInt32(DtPerson.Rows[0]["Inactive_YYYYMMDD"]);

        }  //  END FillPerson()

    }  //  END InitPerson()

}   //  END PersonClass


internal class AddressClass
{
    public static string SelectStreetStr { get; set; }
    public static string SelectStreetTypeStr { get; set; }
    public static string SelectTownStr { get; set; }
    public static DataTable DtStreet { get; set; }
    public static DataTable DtStreetType { get; set; }
    public static DataTable DtTown { get; set; }

    public static void InitAddressClass()
    {
        SelectStreetStr = "SELECT ID_Street, " +
                   "StreetName, " +
                   "FK_ID_StreetType, " +
                   "FK_ID_Town " +
                   "FROM Street ";

        SelectStreetTypeStr = "SELECT ID_StreetType, " +
                           "StreetTypeDesc, " +
                           "StreetTypeAbbrev " +
                           "FROM StreetType ";

        SelectTownStr = "SELECT id, " +
                           "name, " +
                           "state_code, " +
                           "state, " +
                           "postcode " +
                           "FROM TownDetails ";
    }
}