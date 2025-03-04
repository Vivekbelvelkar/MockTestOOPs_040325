using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;

namespace MockTestOOPs_040325
{
    internal class Book : IComparable<Book>
    {
        public string title { get; set; }
        public string author { get; set; }
        public int pagecount { get; set; }

        public Book(string t, string a, int p)              //constructor
        {
            this.title = t;
            this.author = a;
            this.pagecount = p;
        }


        public int CompareTo(Book bk)                    //sorting logic
        {
            if(this.pagecount<bk.pagecount)
            {
                return -1;
            }
            else if (this.pagecount > bk.pagecount)
            {
                return 1;
            }
            else
            {

                return string.Compare(this.author,bk.author) ;   //sorting by author


            }

        }
        public void show()
        {
            Console.WriteLine($"Ititle: {title} author: {author} pagecount:{pagecount}");    //sorting by author

        }
    }
    class Booklist
    {
        public void mymethod()
        {
            List<Book> books = new List<Book>();    //booklist   

            Console.Write("Enter number  books: ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Book details");
            for (int i = 0; i < count; i++)               //userinput
            {
                

                Console.WriteLine("Title: ");
                string title = Console.ReadLine();

                Console.WriteLine("Author: ");
                string author = Console.ReadLine();

                Console.WriteLine("Price: ");
                int price = int.Parse(Console.ReadLine());

                books.Add(new Book(title, author, price));
            }

            books.Sort();                                 //sorting

            Console.WriteLine("------------------Sorted Books-------------");
            foreach (var book in books)
            {
                book.show();
            }
        }
    }
}
