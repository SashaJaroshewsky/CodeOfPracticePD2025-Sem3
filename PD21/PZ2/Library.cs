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
        private List<Book> Books;
        private List<Member> Members;
        private List<Reservation> Reservations;

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
            Reservations = new List<Reservation>();
        }

        public Book CreateBook()
        {
            // string input = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out int result);
            string title = Console.ReadLine();

            return new Book(result, title);
        }

        public void AddBook()
        {

            Books.Add(CreateBook());
        }

        public void AddMember(Member member)
        {
            Members.Add(member);
        }

        public void MakeReservation(Member member, Book book)
        {
            if (Members.Contains(member) && Books.Contains(book))
            {
                Reservation reservation = new Reservation(member, book, DateTime.Now, DateTime.Now.AddDays(14));
                Reservations.Add(reservation);
            }
            else
            {
                throw new Exception("Member or Book not found in the library.");
            }
        }

        public void ShowBook()
        {
            foreach (Book book in Books) {
                Console.WriteLine(book.Code);
                Console.WriteLine(book.Title);
                Console.WriteLine("+++++++++++++++");
            }
        }

    }
}
