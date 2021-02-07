using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Course
{
    private String courseName;
    private String courseCode;
    private int courseCredit;

    public Course() { }
    public Course(string courseName, String courseCode, int courseCredit)
    {
        this.courseName = courseName;
        this.courseCode = courseCode;
        this.courseCredit = courseCredit;
    }
    public void ShowCourseInfo()
    {
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Course Code: " + courseCode);
        Console.WriteLine("Course Credit: " + courseCredit);


    }
    public static void Main(string[] args)
    {
        Course c1=new Course();
        Course c2=new Course("OOP2", "CS2200", 3);
        c2.ShowCourseInfo();

    }

}