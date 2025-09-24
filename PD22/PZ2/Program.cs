using static System.Net.Mime.MediaTypeNames;

namespace PZ2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook();
            library.AddUser();
            library.AddReservation();
            library.ShowBooks();

            library.ShowReservation();



        }
    }
}
