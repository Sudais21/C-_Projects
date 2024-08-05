using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Calculation(int a,int b);
    internal class Program
    {
        public static void Addition(int a,int b)
        {
            int result = a+ b;
            Console.WriteLine("Addition Result is:{0}",result);
        }
        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction Result is:{0}", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication Result is:{0}", result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division Result is:{0}", result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Program.Addition);
            obj.Invoke(20, 10); //30 print
            // Program.Addition(20, 10);
            Calculation obj1 = new Calculation(Program.Subtraction);
            obj1(20, 10);//10
            Calculation obj2 = new Calculation(Program.Multiplication);
            obj2(2, 4); //8
            Calculation obj3 = new Calculation(Program.Division);
            obj3(10, 5); //2

            //obj = Subtraction;
            //obj(20, 10); // 10
            //obj = Multiplication;
            //obj(2, 4); // 8
            //obj=Division;
            //obj(10, 5); // 2
            Console.ReadLine();
        }
    }
}
