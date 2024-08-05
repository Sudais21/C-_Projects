using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        public static void addValue(int a)
        {
            a += 10;
        }
        public static void subtractValue(ref int b)
        {
            b -= 10;
        }
        public static void Main(string[] args)
        {
            // Reference Store memory address

            int a = 20;
            int b = 22;
            Console.WriteLine("Initial value of a is :"+a);
            Console.WriteLine("Initial value of b is :"+b);
            Console.WriteLine("");

            addValue(a);
            Console.WriteLine("Value of a after addition is :"+a);

            subtractValue(ref b);
            Console.WriteLine("Value of b after subraction is :"+b);
            Console.ReadKey();
        }
    }
}
