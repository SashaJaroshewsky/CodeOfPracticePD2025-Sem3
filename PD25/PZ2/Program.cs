namespace PZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            //User user1 = new User(1, "Alice");
            //User user2 = new User(2, "Bob");

            //library.AddUser(user1);
            //library.AddUser(user2);

            //Book book1 = new Book(1, "1984");
            //Book book2 = new Book(2, "To Kill a Mockingbird");
            //Book book3 = new Book(3, "The Great Gatsby");

            //library.AddBook(book1);
            //library.AddBook(book2);
            //library.AddBook(book3);

            //library.ShowInfo();

            //Reservation reservation1 = new Reservation(user1, book1);
            //Reservation reservation2 = new Reservation(user2, book2, 7);

            //library.AddReservation(reservation1);
            //library.AddReservation(reservation2);
            //Console.WriteLine("===============");
            //library.ShowInfo();

            library.AddUser(library.CreateUser());
            library.AddBook(library.CreateBook());
            Reservation reservation = library.CreateReservation();

            if (reservation == null) return;

            library.AddReservation(reservation);

            Console.WriteLine("===============");
            library.ShowInfo();
        }
    }
}
