using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpensGists
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=100, 
                even=0, 
                odd=0;
            
            for (int num=1;num<i;num++)
            {
                if (num% 2==0)
                {
                    Console.Write("{0}", num);
                    even = even + num;
                }
                else
                {
                    Console.WriteLine(" \t {0}", num);
                    odd = odd + num;
                }
            }
            Console.WriteLine(" \n sum of all even numbers are : {0} \n sum of all odd numbers are : {1}", even, odd);
           
        }
    }
}