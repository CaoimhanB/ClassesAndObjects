using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects //constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "Harry Potter", 400);
            Book book2 = new Book("Lord Of The Rings", "Tolkein", 700);
            Book book3 = new Book("A Game Of Thrones", "George R.R Martin", 800);

            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}
