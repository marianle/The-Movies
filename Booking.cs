using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_TheMovies
{
    public class Booking
    {
        public int TicketAmount { get; set; }
        public string Name { get; set; }
        public string Movie { get; set; }

        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        public Booking()
        {
         

        }

        public override string ToString()
        {
            return $"Name: {Name} \nTickets: {TicketAmount} \nPhone Number: {PhoneNumber} \nEmail: {Email} ";
        }
    }
}
