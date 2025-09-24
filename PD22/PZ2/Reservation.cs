using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Reservation
    {
        public User User {  get; private set; }
        public Book Book { get; private set; }

        private DateTime ReservationDate;
        private DateTime DueTime;

        public DateTime DateTime => ReservationDate;

        private int _dueTime;

        public Reservation(User user, Book book)
        {
            User = user;
            Book = book;
            ReservationDate = DateTime.Now;
            DueTime = ReservationDate.AddDays(_dueTime);
        }
    }
}
