using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Booking.BookingRepositories;

namespace Application.Booking.BookingQueries.Implementations
{
    public class BookingGetQuery : IBookingGetQuery
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingGetQuery(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        BookingQueryResultDto IBookingGetQuery.GetBooking(int bookingId)
        {
            return _bookingRepository.GetBooking(bookingId);
        }
    }
}
