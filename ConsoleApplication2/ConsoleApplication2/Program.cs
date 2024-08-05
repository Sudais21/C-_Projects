using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int number;
             Console.WriteLine("Enter a number:");
             number = Convert.ToInt32(Console.ReadLine());
             if(number%2==0){
                 Console.WriteLine("Even number:");
             }
             else
             {
                 Console.WriteLine("Odd number:");
             }
             Console.ReadKey();
         } */
           /* float number;
            float number2;
            float multiply;
            Console.WriteLine("Enter number1" );
            number = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter number2");
            number2 = Convert.ToSingle(Console.ReadLine());
            multiply = number * number2;
            Console.WriteLine(multiply);
            Console.ReadKey();
            */
            /*string countryName;
            Console.WriteLine("Enter Country name:");
            countryName = Console.ReadLine();
            Console.WriteLine(countryName.Length);
            Console.ReadKey();*/

          /*  string sentence;
            Console.WriteLine("Enter a Sentence:");
            sentence = Console.ReadLine();
            string [] newSentence= sentence.Split(' ');
            Console.WriteLine(newSentence.Length);
            Console.ReadKey();*/

            int number1;
            int number2;
            int rupees;
            int dollars;
            Console.WriteLine("Enter your preference to convert dollar into rupees press1 or rupees into dollar press2:");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1.Equals(1))
            {
                Console.WriteLine("Dollars into rupees is:");
                dollars = 2 * 233;
                Console.WriteLine(dollars);
            }
            else if(number2.Equals(2)){
                Console.WriteLine("rupees into dollars is:");
                rupees = 233 * 1000;
                Console.WriteLine(rupees);
            }
            Console.ReadKey();

        }
    }
}

