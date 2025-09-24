using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Book
    {
        public int BookNumber { get; private set; }
        public string Title { get; private set; }

        public Book() { }
        public Book(int number, string title)
        {
            BookNumber = number;
            Title = title;
        }
    }
}
