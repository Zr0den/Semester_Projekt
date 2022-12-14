using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Booking.BookingRepositories;

namespace Application.Booking.BookingQueries.Implementations
{
    public class BookingGetAllQuery : IBookingGetAllQuery
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingGetAllQuery(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        IEnumerable<BookingQueryResultDto> IBookingGetAllQuery.GetAllBooking()
        {
            return _bookingRepository.GetAllBooking();
        }
    }
}
