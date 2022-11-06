using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Booking_TheMovies
{
    public class BookingRepository
    {
        Movie interstellar = new Movie();
        //Movie movie = new Movie("Interstellar");

        Booking booking = new Booking(); // interstellar
        Navigate navi = new Navigate();
        DateTime date = DateTime.Now;

        public void AddBooking()
        {
            while (true)
            {
                Console.Clear();


                // Søg efter film, eller vælg i liste
                Console.Write("Full Name: ");
                booking.Name = Console.ReadLine();

                Console.Write("Amount of tickets: ");
                booking.TicketAmount = Convert.ToInt32(Console.ReadLine());

                Console.Write("Phone number: ");
                booking.PhoneNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Email: ");
                booking.Email = Console.ReadLine();

                Console.Clear();
                Console.WriteLine($"{booking.Name}'s booking has been registered at {date.ToString("f")}.");
                Console.WriteLine("");

                StreamWriter sw = new StreamWriter("..\\..\\..\\Save.txt", true);
                //sw.Write(booking.Name, booking.TicketAmount, booking.PhoneNumber,booking.Email); 
                sw.Write(booking.Name + " ");
                sw.Write(booking.TicketAmount + " ");
                sw.Write(booking.PhoneNumber + " ");
                sw.Write(booking.Email + " ");
                sw.WriteLine("");
                sw.Close();
                navi.Menu();
                break;
            }
        }

        public void EditBooking()
        {

        }

        public void DeleteBooking()
        {
            Console.WriteLine("Insert Email or Phone Number: ");
            string wordToDelete = Console.ReadLine();

            StreamReader sr = new StreamReader("..\\..\\..\\Save.txt");
            string newDocument = sr.ReadToEnd(); // læser dokumentet
            sr.Close(); // Lukker dokumentet igen

            if (newDocument.Contains(wordToDelete))
            {
                var oldLines = System.IO.File.ReadAllLines("..\\..\\..\\Save.txt");
                var newLines = oldLines.Where(line => !line.Contains(wordToDelete));
                System.IO.File.WriteAllLines("..\\..\\..\\Save.txt", newLines);
                Console.Clear();
                Console.WriteLine("The booking has been removed.");
                navi.Menu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry, no booking found with these credentials.");
                navi.Menu();
            }


        }

        public void ShowBooking()
        {

        }

        public void SearchBooking()
        {

        }
    }
}