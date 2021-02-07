using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Student
{
    public String name;
    public int  id;
    public String depertment;
    public float cgpa;

    public void ShowDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID " + id);
        Console.WriteLine("Depertment" + depertment);
        Console.WriteLine("CGPA " + cgpa);

    }
}
class TestStudent
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.name = "Fozlur Rahman";
        s1.id = 18390973;
        s1.depertment = "CSE";
        s1.cgpa = 3.39f;
        Console.WriteLine(s1.id);
        Console.WriteLine(s1.name);
        Console.WriteLine(s1.depertment);
        Console.WriteLine(s1.cgpa);

    }
} 