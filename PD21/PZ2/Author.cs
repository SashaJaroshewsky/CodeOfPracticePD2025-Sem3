using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Author
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
       
        public Author(int id ,string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
        
    }
}
