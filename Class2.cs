using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestOOPs_040325
{
    internal class studentQ6
    {
        public int roll {  get; set; }               //properties
        public string name {  get; set; }
        public double per {  get; set; }
        public string res {  get; set; }

     
    }
    class myclass
    {
        public void mymethod()
        {
            int rl;
            string nm;
            double percen;
            string result;  
            studentQ6[] std = new studentQ6[3];                    //array of student
            for (int i = 0; i < std.Length; i++)        // adding into array
            {
                std[i]=new studentQ6();
                Console.WriteLine("Enter roll numbr");
                rl=int.Parse(Console.ReadLine());
                std[i].roll = rl;
                Console.WriteLine("Enter name");
                nm = Console.ReadLine();
                std[i].name = nm;
                Console.WriteLine("enter percentaage");
                percen = double.Parse(Console.ReadLine());
                std[i].per=percen;
                Console.WriteLine("Enter result");
                result = Console.ReadLine();
                
                std[i].res=result;

            }
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Topper of class");
            var rs = std.Max(x => x.per);                              //linq for maximum
            Console.WriteLine(rs);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Passed Student\n");
            var rss= std.Where(x=>x.res=="pass" || x.res=="Pass").ToList();                //linq for passed student
            foreach (var item in rss)
            {
                Console.WriteLine($"Roll no: {item.roll} Name: {item.name} Percentage:{item.per} Result: {item.res}");
            }

        }
    }
}
