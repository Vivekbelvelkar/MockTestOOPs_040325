using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace MockTestOOPs_040325
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                                                    //       ------------------------------question1---------------------------
            student[] stud = new student[3];
            student std = new student();
            //for (int i = 0; i < stud.Length; i++)
            //{
            //    stud[i] = new student();                        //instantition
            //    Console.WriteLine("Enter roll number");
            //    int rl =int.Parse(Console.ReadLine());
            //    stud[i].roll=rl;
            //    Console.WriteLine("Enter name number");

            //    string nm= Console.ReadLine();
            //    stud[i].name = nm;

            //    Console.WriteLine("Enter total marks");
            //    int tmarks=int.Parse(Console.ReadLine());
            //    stud[i].totalmarks = tmarks;

            //}
            //Console.WriteLine("Enter roll number");


            //for (int i = 0; i < stud.Length; i++)
            //{
            //    for (int j = 0; j < stud[i].roll; j++)
            //    {
            //        if (stud[i].totalmarks > stud[j].totalmarks)                       //sorting by descending order
            //        {
            //            int temp = stud[i].totalmarks;
            //            stud[i].totalmarks = stud[j].totalmarks;             
            //            stud[j].totalmarks = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("student sorted by marks descending marks");
            //for (int i = 0;i < stud.Length;i++)
            //{
            //    Console.WriteLine("Roll no: "+stud[i].roll+"Name: "+stud[i].name+"Total marks: " + stud[i].totalmarks);
            //    
            //}
            //------------------------------------------------------question2-----------------------------------------------

            //q2
            //shape sp = new Circle();                     //runtime polymorphism
            //sp.displayarea();

            //------------------------------------------------- question5---------------------------------
            // linqQ5 lq = new linqQ5();
            //lq.method();

            //----------------------------------------------------        question6 ---------
            //question6
            //myclass obj1 = new myclass();
            //obj1.mymethod();

            // -----------------------------------------  question10  ----------
            //question10
            //Console.WriteLine("enter '1' for circle \n '2' for rectangle");
            //int choice=int.Parse(Console.ReadLine());
            //if(choice== 1)
            //{
            //    Shape1 obj2 = new Circle1();
            //    obj2.Calculatearea();
            //}
            //else if(choice== 2)
            //{
            //    Shape1 obj2 = new Rectangle();
            //    obj2.Calculatearea();
            //}

            //------------------------------------------    question8 ---------------------------------------------------
            Booklist bkl = new Booklist();
            bkl.mymethod();

        }

        class student                         //student class
        {
             public  int roll { get; set; }                              //pr0perties
            public  string name { get; set; }
            public int totalmarks {  get; set; }    

        }
    }
}
