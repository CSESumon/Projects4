using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableBookApp
{
    class Book
    {
        public string ISBN;
        public string title;

        public Book GetBook(string ISBN)
        {
            Hashtable books = new Hashtable();
            Book book1 = new Book();
            return book1 = (Book)books[ISBN];
        }
    }
}
