using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Book book1 = new Book();
            Book book3 = new Book();

            book1.ISBN = "1234";
            book1.title = "The End";
            book3.GetBook("1234");
            Console.WriteLine(book3);
            Console.ReadLine();
            
            
            

            Book book2 = new Book();
            book2.ISBN = "5678";
            book2.title = "The Begining";
         
            
        }
       

    }
}
