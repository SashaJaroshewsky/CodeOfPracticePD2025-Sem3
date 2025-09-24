namespace PZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook();
            library.ShowBook();
        }
    }
}
