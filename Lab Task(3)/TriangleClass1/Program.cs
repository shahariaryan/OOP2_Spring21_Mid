using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangle
{
    private int x;
    private int y;
    private int z;

    public Triangle() { }
    public Triangle(int x, int y, int z)
    {

        this.x = x;
        this.y = y;
        this.z = z;
    }
    public void ShowTriangleinfo()
    {
        if (x == y && y == z)
        {
            Console.WriteLine("Equilateral Triangle: ", x, y, z);
        }
        else if (x == y || y == z || z == x)
        {
            Console.WriteLine("Isoceles Triangle:", x, y, z);
        }
        else
        {
            Console.WriteLine("Scalene Triangle:", x, y, z);
        }
    }
    public static void Main(string[] args)
    {
        Triangle t1=new Triangle();
        Triangle t2=new Triangle(7, 6, 8);
        t2.ShowTriangleinfo();

    }
}