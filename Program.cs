namespace Booking_TheMovies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Navigate navi = new Navigate();
            BookingRepository bookrep = new BookingRepository();

            navi.Menu();



            Console.ReadLine();
        }
    }
}





