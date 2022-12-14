using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Booking.BookingQueries
{
    public interface IBookingGetAllQuery
    {
        IEnumerable<BookingQueryResultDto> GetAllBooking();
    }
}
