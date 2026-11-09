using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS
{
    internal class PersonGridScreen
    {
        private void InitDisplay()
        {
            //PersonClass.PersonInit();
            PersonClass.CategorySelected = string.Empty;
            PersonClass.PersonTblChanged = 0;
            PersonClass.ID_Person = 0;
            PersonClass.LastName = string.Empty;
            PersonClass.PreferredName = string.Empty;
            PersonClass.FirstNames = string.Empty;
            PersonClass.Mobile = string.Empty;
            PersonClass.Email = string.Empty;
            PersonClass.CategoryName = string.Empty;
        }
    }
}
