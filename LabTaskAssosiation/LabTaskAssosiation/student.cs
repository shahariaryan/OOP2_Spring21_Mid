using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskAssosiation
{
    class student
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
            set { Id = value; }
        }
        private float cgpa;
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        department department;

        public department Department
        {
            set { department = value; }
            get { return department; }

         }

        public student() { }
        public student(string name, string id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
        public void ShowInfo()
            {
                Console.WriteLine("name is: " + name);
                Console.WriteLine("id is: " + id);
                Console.WriteLine("Cgpa is: " + cgpa);
            }
        
    }
}
