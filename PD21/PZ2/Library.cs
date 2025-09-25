using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Library
    {
        //public List<Author> Authors = new List<Author>();
        private List<Book> _books;
        private List<Member> _members;
        private List<Reservation> _reservations;

        public Library()
        {
            _books = new List<Book>();
            _members = new List<Member>();
            _reservations = new List<Reservation>();
        }


        public int InputInt()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Error input");
            }

            return result;
        }

        public string InputString()
        {
            return Console.ReadLine();
        }
        public Book CreateBook()
        {
            Console.WriteLine("Create Member");
            Console.WriteLine("Enter Code book");
            int code = InputInt();

            Console.WriteLine("Enter Title book");
            string title = InputString();

            return new Book(code, title);
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void AddBook()
        {

            _books.Add(CreateBook());
        }

        public Member CreateMember()
        {
            Console.WriteLine("Create Member");
            Console.WriteLine("Enter Id member");
            int id = InputInt();
            Console.WriteLine("Enter Name member");
            string name = InputString();
            Console.WriteLine("Enter Surname member");
            string surname = InputString();

            return new Member(id, name, surname);
        }

        public void AddMember(Member member)
        {
            _members.Add(member);
        }

        public Reservation? CreateReservation()
        {
            Console.WriteLine("Create reservation");
            Console.WriteLine("Enter member ID");
            int memberId = InputInt();

            Member foundMember = null;
            foreach (Member member in _members)
            {
                if(member.Id == memberId)
                    foundMember= member;
            }

            if(foundMember == null)
            {
                Console.WriteLine("Member not found");
                return null;
            }

            Console.WriteLine("Enter book code");
            int bookId = InputInt();

            Book foundBook = null;
            foreach (var book in _books)
            {
                if(book.Code == bookId)
                    foundBook= book;
            }
            if(foundBook == null)
            {
                Console.WriteLine("Book not found");
                return null;
            }

            int days = InputInt();
            if (days > 0)
                return new Reservation(foundMember, foundBook, days);
            else
                return new Reservation(foundMember, foundBook);

        }

        public void AddReservation(Reservation reservation)
        {
            _reservations.Add(reservation);
        }


        public void ShowInfo()
        {
            Console.WriteLine("Books:");
            foreach (var book in _books)
            {
                Console.WriteLine($"Code: {book.Code}, Title: {book.Title}");
            }
            Console.WriteLine("Members:");
            foreach (var member in _members)
            {
                Console.WriteLine($"ID: {member.Id}, Name: {member.Name}");
            }
            Console.WriteLine("Reservations:");
            foreach (var reservation in _reservations)
            {
                Console.WriteLine($"Member: {reservation.Member.Name}, Book: {reservation.Book.Title}, Reserved On: {reservation.ReservationDate}, Due On: {reservation.DueDate}");
            }
        }

    }
}
