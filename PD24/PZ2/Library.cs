using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Library
    {
        private List<User> _users;
        private List<Book> _books;
        private List<Reservation> _reservations;

        public Library()
        {
            _users = new List<User>();
            _books = new List<Book>();
            _reservations = new List<Reservation>();
        }
        public int InputNumber()
        {

            int.TryParse(Console.ReadLine(), out int number);
            return number;
        }

        public string InputString()
        {
            return Console.ReadLine();
        }
        
        public User CreateUser()
        {
            Console.WriteLine("Enter user ID");
            int id = InputNumber();
            Console.WriteLine("Enter username");
            string username = InputString();
            return new User(id, username);
        }

        public User CreateUser(int id, string username)
        {
            return new User(id, username);
        }




        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public Book CreateBook()
        {
            Console.WriteLine("Enter book ID");
            int id = InputNumber();
            Console.WriteLine("Enter book title");
            string title = InputString();
            return new Book(id, title);
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }


        public Reservation? CreateReservation()
        {
            Console.WriteLine("Enter user ID");
            int user = InputNumber();
            User foundUser = null;
            foreach (var u in _users)
            {
                if (u.Id == user)
                {
                    foundUser = u;
                    break;
                }
            }
            if(foundUser == null)
            {
                Console.WriteLine("User not found");
                return null;
            }

            Console.WriteLine("Enter book ID");
            int book = InputNumber();
            Book foundbook = null;
            foreach (var b in _books)
            {
                if (b.Id == book)
                {
                    foundbook = b;
                    break;
                }
            }
            if(foundbook == null)
            {
                Console.WriteLine("Book not found");
                return null;
            }

            return new Reservation(foundUser, foundbook);
        }

        public void AddReservation(Reservation reservation) {
            _reservations.Add(reservation);
        }

        public void ShowInfo()
        {
            foreach (var user in _users)
            {
                Console.WriteLine($"User ID: {user.Id}, Username: {user.Username}");
            }

            foreach(var book in _books)
                {
                Console.WriteLine($"Book ID: {book.Id}, Title: {book.Title}");
            }

            foreach (var reservation in _reservations)
            {
                Console.WriteLine($"Reservation - User: {reservation.User.Username}, Book: {reservation.Book.Title}, Reserved On: {reservation.ReservationDate}, Due On: {reservation.DueDate}");
            }
        }
    }
}
