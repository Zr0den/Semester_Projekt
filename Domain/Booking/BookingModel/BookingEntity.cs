using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Booking.BookingModel
{
    public class BookingEntity
    {
        public int BookingID { get; set; }
        public string BookingName { get; set; }
        public int AnsatID { get; set; }
        public int OpgaveID { get; set; }
        public int ProjektID { get; set; }

        internal BookingEntity()
        {

        }

        public BookingEntity(string bookingName, int opgaveId, int projektId)
        {
            BookingName = bookingName;
            OpgaveID = opgaveId;
            ProjektID = projektId;
        }

        public void EditBooking(string bookingName, int opgaveId, int ansatId)
        {
            BookingName = bookingName;
            OpgaveID = opgaveId;
            AnsatID = ansatId;
        }
    }

}
