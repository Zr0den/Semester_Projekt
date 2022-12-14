using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Booking.BookingCommands
{
    public class BookingCreateRequestDto
    {
        public string BookingName { get; set; }
        public int OpgaveID { get; set; }
        public int ProjektID { get; set; }
    }
}
