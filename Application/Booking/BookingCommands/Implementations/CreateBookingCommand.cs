using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Booking.BookingRepositories;
using Domain.Booking.BookingModel;

namespace Application.Booking.BookingCommands.Implementations
{
    public class CreateBookingCommand : ICreateBookingCommand
    {
        private readonly IBookingRepository _bookingRepository;

        public CreateBookingCommand(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        void ICreateBookingCommand.CreateBooking(BookingCreateRequestDto bookingCreateRequestDto)
        {
            var booking = new BookingEntity(bookingCreateRequestDto.BookingName, bookingCreateRequestDto.OpgaveID, bookingCreateRequestDto.ProjektID);

            _bookingRepository.AddBooking(booking);
        }
    }
}
