using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestOOPs_040325
{
    internal class Circle:shape        //inhertance
    {
        double radius;
       
        public override void displayarea()         //displayarea overriden
        {
            Console.WriteLine("Enter length");
            radius=double.Parse(Console.ReadLine());

            double area = 3.14 * radius * radius;
            Console.WriteLine("area of circle:"+area);


        }
    }
    class shape
    {
        public virtual void displayarea()           //virtual method
        {  

        }
    }

}
