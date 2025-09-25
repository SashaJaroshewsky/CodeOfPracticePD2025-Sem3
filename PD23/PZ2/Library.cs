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

        private int InputInt()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Error input");
            }
            return value;
        }

        private string InputString()
        {
            return Console.ReadLine();
        }

        public User CreateUser()
        {
            Console.WriteLine("CreateUser");
            Console.Write("Enter id: ");
            int id = InputInt();
            Console.Write("Enter name: ");
            string userName = InputString();

            return new User(id, userName);
        }


        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public Book CreateBook()
        {
            Console.WriteLine("CreateBook");
            Console.Write("Enter id: ");
            int id = InputInt();
            Console.Write("Enter title: ");
            string title = InputString();
            Book book = new Book(id, title);
           return book;
        }
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public Reservation? CreateReservation()
        {
            Console.WriteLine("CreateReservation");
            Console.Write("Enter user id: ");
            int userId = InputInt();

            User foundUser = null;
            foreach (var user in _users)
            {
                if(user.Id == userId)
                {
                    foundUser = user;
                }
            }

            if (foundUser == null)
            {
                Console.WriteLine("User not found");
                return null;
            }

            Console.Write("Enter book id: ");
            int bookId = InputInt();
            Book foundBook = null;
            foreach (var book in _books)
            {
                if (book.Id == bookId)
                {
                    foundBook = book;
                }
            }
            if (foundBook == null)
            {
                Console.WriteLine("Book not found");
                return null;
            }
            Console.Write("reservationDurationDays: ");
            int reservationDurationDays = InputInt();
            if (reservationDurationDays <= 0)
            {
                return new Reservation(foundUser, foundBook);
            }
            else
            {
                return new Reservation(foundUser, foundBook, reservationDurationDays);
            }

           
        }

        public void AddReservation(Reservation reservation)
        {
            _reservations.Add(reservation);
        }


        public void ShowInfo()
        {
            Console.WriteLine("Users:");
            foreach (var user in _users)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.UserName}");
            }
            Console.WriteLine("\nBooks:");
            foreach (var book in _books)
            {
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}");
            }
            Console.WriteLine("\nReservations:");
            foreach (var reservation in _reservations)
            {
                Console.WriteLine($"User: {reservation.User.UserName}, Book: {reservation.Book.Title}, Reserved At: {reservation.ReservationTime}, Expires At: {reservation.ExpirationTime}");
            }
        }
    }
}
