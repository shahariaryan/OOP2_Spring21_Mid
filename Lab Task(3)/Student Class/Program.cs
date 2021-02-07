using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    private string name;
    private int id;
    private string depertment;
    private float cgpa;


    public Student() { }
    public Student(string name, int id, string depertment, float cgpa)
    {
        this.name = name;
        this.id = id;
        this.depertment = depertment;
        this.cgpa = cgpa;
    }
    public void ShowStudentInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Depertment: " + depertment);
        Console.WriteLine("cgpa: " + cgpa);

    }
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        Student s2 = new Student("Rahman, Fozlur", 18 - 39097 - 3, "Bsc. CSE", 3.39f);
        s2.ShowStudentInfo();

    }
}
