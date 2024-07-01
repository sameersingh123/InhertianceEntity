using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceEntity
{
     class NTStaff: Staff
    {
        public string DName;
        public int MgrId;

        static void Main()
        {
            NTStaff nTStaff = new NTStaff();
            nTStaff.Id = 1;
            nTStaff.Name = "John";
            nTStaff.Address = "123, New Street";
            nTStaff.Phone = "1234567890";
            nTStaff.Designation = "Manager";
            nTStaff.Salary = 50000;
            nTStaff.DName = "IT";
            nTStaff.MgrId = 2;
        }
    }
}
