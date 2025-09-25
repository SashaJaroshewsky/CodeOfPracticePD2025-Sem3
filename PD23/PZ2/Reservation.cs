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

        public DateTime ReservationTime { get; private set; }
        public DateTime ExpirationTime { get; private set; }

        private int _reservationDurationDays = 14;

        public Reservation(User user, Book book)
        {
            User = user;
            Book = book;
            ReservationTime = DateTime.Now;
            ExpirationTime = ReservationTime.AddDays(_reservationDurationDays);
        }

        public Reservation(User user, Book book, int reservationDurationDays)
        {
            User = user;
            Book = book;
            ReservationTime = DateTime.Now;
            _reservationDurationDays = reservationDurationDays;
            ExpirationTime = ReservationTime.AddDays(_reservationDurationDays);
        }
    }
}
