using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Book
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        
        public Book(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
