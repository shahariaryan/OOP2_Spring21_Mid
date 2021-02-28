using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskAssosiation
{
    class department
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private student[] students;
        private int studentCount;
        public int StudentCount
        {
            set { studentCount = value; }
            get { return studentCount; }

           }

         public department() {
            students = new student[60];
        }

        public department(string name, string id)
        {
            this.name = name;
            this.id = id;
            students = new student[60];
        }
        public void AddStudents(params student[] arrStudent)
        {
           foreach(var s in arrStudent)
            {
                students[ studentCount++]= s;
                s.Department = this;
            }
        }
        public void AllStudents()
        {
            for(int i=0; i<studentCount;i++)
            {
                students[i].ShowInfo();
            }

        }

        public void ShowInfo()
        {
            Console.WriteLine("name is: " + name);
            Console.WriteLine("id is: " + id);
        }
    }
}
