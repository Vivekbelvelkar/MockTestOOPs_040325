using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestOOPs_040325
{
    internal class linqQ5
    {
        public void method()
        {
            List<int> ls = new List<int>();                                 //list
            Console.WriteLine("enter 10 numbers");  
            for (int i = 0; i < 10; i++)
            {
                int x = int.Parse(Console.ReadLine());
                ls.Add(x);

            }
            Console.WriteLine("Even numbers");
            var rs = ls.Where(x => x%2==0).ToList();                      //linq even numbers
            foreach(var item in rs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("min from list");
            var rss=ls.Min(x => x);                                     //minimum
            Console.WriteLine(rss);

            Console.WriteLine("maximum");
            var rsss = ls.Max(x => x);                            //maximum
            Console.WriteLine(rsss);    
        }
    }
}
