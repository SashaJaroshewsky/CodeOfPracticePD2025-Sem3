using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class User
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        
        public User(int id ,string username)
        {
            Id = id;
            Username = username;
        }
    }
}
