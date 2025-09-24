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

        public void AddReservation()
        {
            _reservations.Add(CreateReservation());
        }

        public Reservation CreateReservation()
        {
            Console.WriteLine("Enter book ID");
            int.TryParse(Console.ReadLine(), out int bookID);

            Console.WriteLine("Enter User ID");
            int.TryParse(Console.ReadLine(), out int userID);

            Book book1 = new();
            User user1 = new();
            foreach (Book book in _books)
            {
                if(book.BookNumber == bookID)
                {
                    book1 = book;
                }
            }

            foreach(User user in _users)
            {
                if(user.Id == userID)
                    { user1 = user; }
            }

            return new Reservation(user1, book1);
        }

        public Book CreateBook()
        {
            Console.WriteLine("Enter book ID");
            int.TryParse(Console.ReadLine(), out int result);

            Console.WriteLine("Enter title");
            string title = Console.ReadLine();

            return new Book(result, title);
        }
        public void AddBook(Book book)
        {
            _books.Add(book);

        }

        public void AddBook()
        {
            _books.Add(CreateBook());
        }

        public void AddUser()
        {

            _users.Add(CreateUser());
        }

        public User CreateUser()
        {
            Console.WriteLine("Enter user ID");
            int.TryParse(Console.ReadLine(), out int result);

            Console.WriteLine("Enter  name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter  name");
            string surname = Console.ReadLine();

            return new User(result, name, surname);
        }

        public void ShowBooks()
        {
            foreach (Book book in _books)
            {
                Console.WriteLine(book.BookNumber);
                Console.WriteLine(book.Title);
            }
        }

        public void ShowReservation()
        {
            foreach(Reservation reservation in _reservations)
            {
                Console.WriteLine("++++++++++++++");
                Console.WriteLine(reservation.User.Name);
                Console.WriteLine(reservation.Book.Title);
                Console.WriteLine(reservation.DateTime);
                Console.WriteLine("++++++++++++++");
            }
        }
    }
}
