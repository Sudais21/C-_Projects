using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labPractice
{
    internal class Program
    {



        //class student
        //{
        //    private int age;
        //    public int proPage
        //    {
        //        set
        //        {
        //            if (value <= 0)
        //            {
        //                Console.WriteLine("Invalid");
        //            }
        //            else
        //            {
        //                age = value;
        //            }
        //        }
        //        get
        //        {
        //            return age;
        //        }
        //    }
        //}
        //enum weekdays
        //{
        //    monday,
        //    tuesday,
        //}
        //class Student
        //{
        //    enum items
        //    {
        //        apple = 1,
        //        banana = 2,
        //    }

        public class Student
        {
            ~Student()
            {
                Console.WriteLine("i am sudais");
            }


        }

            static void Main(string[] args)
            {
                //student student = new student();
                //student.proPage = 10;
                //Console.WriteLine(student.proPage);



                //Console.WriteLine(weekdays.monday);
                //Console.WriteLine(weekdays.tuesday);
                //int a = (int)weekdays.tuesday;

                //int b = (int)items.apple;
                //Console.WriteLine(b);

            Student student = new Student();
            
                Console.ReadKey();
            

            }

        
    }
}
    

