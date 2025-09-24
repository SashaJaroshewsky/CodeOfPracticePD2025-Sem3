using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Library
    {
        private List<User> _usersList;
        private List<Book> _booksList;
        private List<Reservation> _reservationsList;

        public Library()
        {
            _usersList = new List<User>();
            _booksList = new List<Book>();
            _reservationsList = new List<Reservation>();
        }

        public int InputInt()
        {
           int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }
            return value;
        }

        public string InputString()
        {
            return Console.ReadLine();
        }

        public User CreateUser()
        {
            Console.WriteLine("Create user");
            Console.WriteLine("Enter user ID:");
            int id = InputInt();
            Console.WriteLine("Enter user name:");
            string userName = InputString();
            return new User(id, userName);
        }

        public void AddUser(User user)
        {
            _usersList.Add(user);
        }
        public Book CreateBook()
        {
            Console.WriteLine("Create book");
            Console.WriteLine("Enter book ID:");
            int id = InputInt();
            Console.WriteLine("Enter book title:");
            string title = InputString();
            return new Book(id, title);
        }
        public void AddBook(Book book)
        {
            _booksList.Add(book);
        }

        public Reservation? CreateReservation()
        {
            Console.WriteLine("Create reservation");
            Console.WriteLine("Enter user ID for reservation:");
            int userId = InputInt();
            
           // User user = _usersList.FirstOrDefault(u => u.Id == userId);
           User user = null;
            foreach (var u in _usersList)
            {
                if(u.Id == userId)
                {
                    user = u;
                }
            }
            if (user == null)
            {
                Console.WriteLine("User not found.");
                return null;
            }

            Console.WriteLine("Enter book ID for reservation:");
            int bookId = InputInt();
            Book book = null;
            foreach (var b in _booksList)
            {
                if(b.Id == bookId)
                {
                    book = b;
                }
            }
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return null;
            }
            Console.WriteLine("Enter Day Count");
            int dayCount = InputInt();
            if(dayCount <= 0)
            {
                return new Reservation(user, book);
            }
            return new Reservation(user, book, dayCount);
        }

        public void AddReservation(Reservation reservation)
        {
            _reservationsList.Add(reservation);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Users in library:");
            foreach (var user in _usersList)
            {
                Console.WriteLine($"ID: {user.Id}, UserName: {user.UserName}");
            }
            Console.WriteLine("\nBooks in library:");
            foreach (var book in _booksList)
            {
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}");
            }
            Console.WriteLine("\nReservations in library:");
            foreach (var reservation in _reservationsList)
            {
                Console.WriteLine($"User: {reservation.User.UserName}, Book: {reservation.Book.Title}, Reserved On: {reservation.ReservationDate}, Due On: {reservation.DueDate}");
            }
        }
    }
}
