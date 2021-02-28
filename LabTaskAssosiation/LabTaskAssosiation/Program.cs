using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskAssosiation
{
    class Program
    {
        static void Main(string[] args)
        {
            department d1 = new department("English Department", "ED");
            department d2 = new department("Computer science", "CS");
            student s1 = new student("Fozlur Rahman","3123123",3.03f);
            student s2 = new student("Feekra Baset", "3222123", 3.69f);
            student s3 = new student("Shahriar", "3333123", 3.00f);
            d1.AddStudents(s1,s2,s3);
            s1.Department = d1;
            s2.Department = d1;
            s3.Department = d1;
            s1.Department.ShowInfo();

            d2.AddStudents(s3);

            d1.AllStudents();
           d2.AllStudents();

        }
    }
}
