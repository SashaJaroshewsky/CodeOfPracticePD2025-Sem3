using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Reservation
    {
        public Member Member { get; private set; }
        public Book Book { get; private set; }
        public DateTime ReservationDate { get; private set; }
        public DateTime DueDate { get; private set; }

        private int reservationCounterDays = 14;
        public Reservation(Member member, Book book)
        {
            Member = member;
            Book = book;
            ReservationDate = DateTime.Now;
            DueDate = ReservationDate.AddDays(reservationCounterDays);
        }

        public Reservation(Member member, Book book, int days)
        {
            reservationCounterDays = days;
            Member = member;
            Book = book;
            ReservationDate = DateTime.Now;
            DueDate = ReservationDate.AddDays(reservationCounterDays);
        }
    }
}
