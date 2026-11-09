using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS
{
    internal class dbWhere
    {
        public static int iID { get; set; }
        public static string sLastName { get; set; }
        public static string sFirstName { get; set; }
        public static string sPost1 { get; set; }
        public static string sPost2 { get; set; }
        public static int iPostTownID { get; set; }
        public static string sStreetNo { get; set; }
        public static string sStreet { get; set; }
        public static string sLocn1 { get; set; }
        public static int iLocnTownID { get; set; }
        public static string sMobile { get; set; }
        public static string sEmail { get; set; }
    }

    internal class myVar
    {
        public static int iID { get; set; }
        public static string sLastNameFrom { get; set; }
        public static string sLastNameTo { get; set; }
        public static string sFirstNameFrom { get; set; }
        public static string sFirstNameTo { get; set; }
        public static string sPreferredNameTo { get; set; }
        public static string sLocnStateFrom { get; set; }
        public static string sLocnStateTo { get; set; }
        public static string sLocnTownFrom { get; set; }
        public static string sLocnTownTo { get; set; }
        public static string sPostCode { get; set; }
        public static string sStreetFrom { get; set; }
        public static string sStreetTo { get; set; }
        public static string sLocn1 { get; set; }
        public static string sMobile { get; set; }
        public static string sEmail { get; set; }

        public static string sWhere { get; set; }
        public static string sOrderBy { get; set; }
        public static string sFrom { get; set; }
        public static string sTo { get; set; }


        public static void init_myVar()
        {
            iID = 0;
            sLastNameFrom = "";
            sLastNameTo = "";
            sFirstNameFrom = "";
            sFirstNameTo = "";
            sLocnStateFrom = "";
            sLocnStateTo = "";
            sLocnTownFrom = "";
            sLocnTownTo = "";
            sPostCode = "";
            sStreetFrom = "";
            sStreetTo = "";
            sLocn1 = "";
            sMobile = "";
            sEmail = "";
            sWhere = "";
            sOrderBy = " Order By Surname, FirstName";
        }

        public static String newWhereStr(){

        string sNewWhere = "";
        string sAndNeeded = "False";

        if (sLastNameFrom.Length > 0)                  // LastName
        {
            sNewWhere += "LastName >= '" + sLastNameFrom + "' ";
            sAndNeeded = "True";
        }
        if (sLastNameFrom.Length > 0)
        {
            if (sAndNeeded == "True")
            {
                sNewWhere += " AND ";
            }
            sNewWhere += "LastName <= '" +sLastNameTo + "' ";
            sAndNeeded = "True";
            }
        return sNewWhere;
        }
    }
}

/*

        if (dbField.sFirstNameFrom.Trim().Length > 0)         // FirstName
        {
            if (sAndNeeded == "True")
            {
                sNewWhere += " AND ";
            }
            sNewWhere += "FirstName >= '" + dbField.sFirstNameFrom + "' ";
            sAndNeeded = "True";
        }

if (dbField.sFirstNameTo.Trim().Length > 0)
{
    if (sAndNeeded == "True")
    {
        sNewWhere += " AND ";
    }
    sNewWhere += "FirstName <= '" + dbField.sFirstNameTo + "' ";
    sAndNeeded = "True";
}

if (dbField.sLocnStateFrom.Trim().Length > 0)         // State (Locn)
{
    if (sAndNeeded == "True")
    {
        sNewWhere += " AND ";
    }
    sNewWhere += "au_Towns.pcState_Code >= '" + dbField.sLocnStateFrom + "' ";
    sAndNeeded = "True";
}
if (dbField.sLocnStateTo.Trim().Length > 0)
{
    if (sAndNeeded == "True")
    {
        sNewWhere += " AND ";
    }
    sNewWhere += "au_Towns.pcState_Code <= '" + dbField.sLocnStateTo + "' ";
    sAndNeeded = "True";
}

if (dbField.sLocnTownFrom.Trim().Length > 0)          // Town
{
    if (sAndNeeded == "True")
    {
        sNewWhere += " AND ";
    }
    sNewWhere += "au_Towns.pcName >= '" + dbField.sLocnTownFrom + "' ";
    sAndNeeded = "True";
}
if (dbField.sLocnTownTo.Trim().Length > 0)
{
    if (sAndNeeded == "True")
    {
        sNewWhere += " AND ";
    }
    sNewWhere += "au_Towns.pcName <= '" + dbField.sLocnTownTo + "' ";
    sAndNeeded = "True";
}

if (dbField.sStreetFrom.Trim().Length > 0)            // Street
{
    if (sAndNeeded == "True")
    {
        sNewWhere += " AND ";
    }
    sNewWhere += "FirstName >= '" + dbField.sFirstNameTo + "' ";
    sAndNeeded = "True";
}
if (dbField.sStreetTo.Trim().Length > 0)
{
    if (sAndNeeded == "True")
    {
        sNewWhere += " AND ";
    }
    sNewWhere += "FirstName <= '" + dbField.sFirstNameFrom + "' ";
    sAndNeeded = "True";
}

if (dbField.sPostCode.Trim().Length > 0)           // PostCode
{
    if (sAndNeeded == "True")
    {
        sNewWhere += " AND ";
    }
    sNewWhere += "= '" + dbField.sPostCode + "' ";
    sAndNeeded = "True";
}

if (dbField.sMobile.Length > 0)                // Mobile
{
    if (sAndNeeded == "True")
    {
        sNewWhere += " AND ";
    }
    sNewWhere += "Mobile LIKE '%" + dbField.sMobile + "%' ";
    sAndNeeded = "True";
}

if (dbField.sOrganisation.Length > 0)                // Organisation
    {
    if (sAndNeeded == "True")
    {
        sNewWhere += " AND ";
    }
    sNewWhere += "CardOrganisation.Description LIKE '%" + dbField.sOrganisation + "%' ";
    sAndNeeded = "True";
    }

    dbField.sWhere = "Where " + sNewWhere;
            }
        }
    }
}
*/
