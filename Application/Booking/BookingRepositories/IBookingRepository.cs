using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Booking.BookingQueries;
using Domain.Booking.BookingModel;

namespace Application.Booking.BookingRepositories
{
    public interface IBookingRepository
    {
        void AddBooking(BookingEntity booking);
        BookingEntity LoadBooking(int bookingId);
        void UpdateBooking(BookingEntity model);
        IEnumerable<BookingQueryResultDto> GetAllBooking();
        BookingQueryResultDto GetBooking(int bookingId);
    }
}
