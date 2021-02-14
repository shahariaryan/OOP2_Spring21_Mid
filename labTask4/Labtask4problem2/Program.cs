using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5,3,6,8,9,6,8,6,4 };
            foreach (int i in arr.Distinct())
            {
                Console.WriteLine(i);
            }
        }
    }