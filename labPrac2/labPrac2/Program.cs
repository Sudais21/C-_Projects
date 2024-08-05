using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labPrac2
{
    internal class Program
    {
        public class ADD
        {
            int x;
            double y;
            String z;
            public ADD(int a, double b)
            {
                x = a;
                y = b;
            }
            public ADD(int a, Double b, string c)
            {
                x = a;
                y = b;
                z = c;
            }
            public void show()
            {
                Console.WriteLine("ABC");
            }
        
            public class Derived :ADD
            
                public Derived()
                {

                }
            }


        }
        static void Main(string[] args)
        {
        }
    }
}
