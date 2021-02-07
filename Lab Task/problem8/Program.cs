using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter marsks:");
            int marks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gaing Score:");

            if (marks >= 90)
            {
                Console.WriteLine("A+");
            }
            else if (marks >= 85 && marks < 89)
            {
                Console.WriteLine("A");
            }
            else if (marks >= 80 && marks < 84)
            {
                Console.WriteLine("B+");
            }
            else if (marks >= 75 && marks < 79)
            {
                Console.WriteLine("B");
            }

            else if (marks <= 50)
            {
                Console.WriteLine("F");
            }

            else
            {
                Console.WriteLine("ERROR!!!!");
            }

            Console.ReadKey();
        }
    }