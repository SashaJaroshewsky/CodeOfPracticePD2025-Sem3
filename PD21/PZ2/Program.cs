namespace PZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            //Member member = new Member(1, "John", "Doe");
            //Member member2 = new Member(2, "Jane", "Smith");
            //Member member3 = new Member(3, "Alice", "Johnson");

            //library.AddMember(member);
            //library.AddMember(member2);
            //library.AddMember(member3);

            //Book book1 = new Book(1, "The Great Gatsby");
            //Book book2 = new Book(2, "To Kill a Mockingbird");
            //Book book3 = new Book(3, "1984");

            //library.AddBook(book1);
            //library.AddBook(book2);
            //library.AddBook(book3);

            //Reservation reservation1 = new Reservation(member, book1);
            //Reservation reservation2 = new Reservation(member2, book2, 7);

            //library.AddReservation(reservation1);
            //library.AddReservation(reservation2);

            library.AddMember(library.CreateMember());
            library.AddBook(library.CreateBook());

            Reservation reservation = library.CreateReservation();

            if (reservation == null)
            {
                Console.WriteLine("Eroor");
                return;
            }
            library.AddReservation(reservation);
            library.ShowInfo();
        }
    }
}
