using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Reservation
    {
        public User User { get; private set; }
        public Book Book { get; private set; }
        public DateTime ReservationDate { get; private set; }
        public DateTime DueDate { get; private set; }

        private int _dayCount = 14;


        public Reservation(User user, Book book)
        { 
            User = user;
            Book = book;
            ReservationDate = DateTime.Now;
            DueDate = ReservationDate.AddDays(_dayCount);
        }
        public Reservation(User user, Book book, int dayCount)
        {
            _dayCount = dayCount;
            User = user;
            Book = book;
            ReservationDate = DateTime.Now;
            DueDate = ReservationDate.AddDays(_dayCount);
        }
    }
}
