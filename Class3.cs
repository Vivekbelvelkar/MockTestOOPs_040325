using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestOOPs_040325
{
    internal class Circle1:Shape1
    {
        public override void Calculatearea()                //calculate
        {
            Console.WriteLine("enter radius");
            double rad  = double.Parse(Console.ReadLine());
            double area = 3.14 * rad * rad;
            Console.WriteLine("area fo circle: "+area);

        }
    }
    class Rectangle : Shape1                    //inheritance
    {  
        public override void Calculatearea()
        {
            Console.WriteLine("enter length and width");
            int length= int.Parse(Console.ReadLine());
            int width= int.Parse(Console.ReadLine());

            double area = length * width;
            Console.WriteLine("area fo rectangle: "+ area);
        }
    }
    abstract class Shape1
    {
        public abstract void Calculatearea();                      //abstract method
        
    }
}
