using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Book
    {
        public int Code { get; private set; }
        public string Title { get; private set; }
       // public Author Author { get; private set; }

        public Book(int code, string title/*, Author author*/)
        {
            Code = code;
            Title = title;
           // Author = author;
        }
    }
}
