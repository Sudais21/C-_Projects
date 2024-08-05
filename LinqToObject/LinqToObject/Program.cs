using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            var result = from s in mylist
                         where s > 3 && s < 10
                         select s;
            foreach(var i in result)
            {
                Console.WriteLine(i);
            }
            List<int> mylist2 = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            var result2 = from s in mylist
                         where s > 3 && s < 10 orderby s descending
                         select s;
            foreach (var i in result2)
            {
               
                Console.WriteLine(i);
            }
           List<int> mylist3 = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            var result3 = from s in mylist
                          where s > 3 && s < 10
                          orderby s ascending
                          select s;
            foreach (var i in result3)
            {
              
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
