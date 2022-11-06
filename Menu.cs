using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_TheMovies
{
    public class Navigate
    {

        public void Menu()
        {

            Console.WriteLine("1. Movies ");
            Console.WriteLine("2. Bookings");
            Console.WriteLine("3. Exit");

            string menuoption = Console.ReadLine();
            int intOption = ToInt(menuoption);

            if (intOption == 0)
            {
                Console.Clear();
                Console.WriteLine("Please press 1, 2 or 3 and enter.");
                Menu();
            }
            else if (intOption == 1)
            {
                Console.Clear();
                Movies();
            }
            else if (intOption == 2)
            {
                Console.Clear();
                Booking();
            }

            else if (intOption == 3)
            {

            }

            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input");
                Menu();
            }

        }

        public void Movies()
        {

            Movie movie = new Movie();

            Console.WriteLine("1. Add Movie ");
            Console.WriteLine("2. Edit Movie");
            Console.WriteLine("3. Delete Movie ");
            Console.WriteLine("4. Show Movies");
            Console.WriteLine("5. Search Movie ");


            string menuoption = Console.ReadLine();
            int intOption = ToInt(menuoption);

            if (intOption == 4)
            {
                Console.Clear();
                movie.LoadJson();
            }
        }

        public void Booking()
        {

            BookingRepository booking = new BookingRepository();

            Console.WriteLine("1. Add Booking ");
            Console.WriteLine("2. Edit Booking");
            Console.WriteLine("3. Delete Booking ");
            Console.WriteLine("4. Show Booking");
            Console.WriteLine("5. Search Booking");


            string menuoption = Console.ReadLine();
            int intOption = ToInt(menuoption);

            if (intOption == 0)
            {
                Console.Clear();
                Console.WriteLine("Please, press 1, 2, 3, 4 or 5 and enter.");
                Booking();
            }
            else if (intOption == 1)
            {
                Console.Clear();
                booking.AddBooking();
            }
            else if (intOption == 2)
            {
            }

            else if (intOption == 3)
            {
                Console.Clear();
                booking.DeleteBooking();
            }
            
            else if (intOption == 4)
            {

            }

            else if (intOption == 5)
            {

            }
        }

        public static int ToInt(string ConvertToInt)
        {
            try
            {
                return int.Parse(ConvertToInt);
            }
            catch
            {
                return 0;
            }
        }
    }
}
