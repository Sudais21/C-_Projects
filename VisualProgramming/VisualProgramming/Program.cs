using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming
{
    internal class Program
    {
       /* public class Base
        {
            string name;
           public void display()
            {
                Console.WriteLine("Displaying");
            }
             }
        public class Derived:Base
        {
            string color;
            public void displayResult()
            {
                Console.WriteLine("Display result");
            }
        }
       */
       public class Grand
        {
            public Grand()
            {
                Console.WriteLine("Grand");
            }
            public Grand(int a,int b)
            {
                Console.WriteLine(a + "" + b + "");
            }
        }
        public class Father:Grand
        {
            public Father()
            {
                 Console.WriteLine("Father");
            }
            public Father(int a,int b,int c):base(a,b)
            {
                Console.WriteLine(a+""+b+""+c+"");
            }
        }
        static void Main(string[] args)
        {
            /* Derived d = new Derived();
            d.display();*/

            Grand g = new Grand();
            Grand a = new Grand(2, 4);
            Father f = new Father();
            Father e = new Father(1, 2, 3);

            Console.ReadKey();
        }
    }
}
