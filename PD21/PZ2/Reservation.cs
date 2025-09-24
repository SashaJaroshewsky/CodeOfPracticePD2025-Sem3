using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Reservation
    {
        public Member Member;
        public Book Book;
        public DateTime ReservationDate;
        //public DateTime DueDate;

        public Reservation(Member member, Book book, DateTime reservationDate, DateTime dueDate)
        {
            Member = member;
            Book = book;
            ReservationDate = DateTime.Now;
        }
    }
}
