using InheritanceEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceEntity
{
     class Student:Person
    {
        public int Class;
        public float Fees;
        public float Marks;
        public char Grade;

        static void Main()
        {
            Student student1 = new Student();
        }
    }
    
}
