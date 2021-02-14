using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Main Array is: ");
            int[] arr1 = new int[] { 2, 4 };
            int[] arr2 = new int[2];
            foreach (int value in arr1)
            {
                Console.WriteLine(value);
            }

            Array.Copy(arr1, arr2, 2);

            Console.WriteLine("Copy Array is: ");
            foreach (int value in arr2)
            {
                Console.WriteLine(value);
            }

            int[] arr = { 2, 3, 4, 6, 7 };
            int count = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length - 1; j++)
                {

                    if (arr[j] == arr[j + 1])
                        count = count + 1;
                }
                
            }
        }
    }
}