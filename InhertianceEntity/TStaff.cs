using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceEntity
{
     class TStaff:Staff
    {
        public string Qualification;
        public string Subject;

        static void Main()
        {
            TStaff tstaff = new TStaff();
            tstaff.Id = 2;
            tstaff.Name = "Jane";
            tstaff.Address = "456, Old Street";
            tstaff.Phone = "0987654321";
            tstaff.Designation = "Teacher";
            tstaff.Salary = 30000;
            tstaff.Qualification = "Masters";
            tstaff.Subject = "Maths";
        }
    }
}
