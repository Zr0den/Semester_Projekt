using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Booking.BookingRepositories;

namespace Application.Booking.BookingCommands.Implementations
{
    public class EditBookingCommand : IEditBookingCommand
    {
        private readonly IBookingRepository _bookingRepository;

        public EditBookingCommand(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        void IEditBookingCommand.EditBooking(BookingEditRequestDto bookingEditRequestDto)
        {
            var model = _bookingRepository.LoadBooking(bookingEditRequestDto.BookingID);

            model.EditBooking(bookingEditRequestDto.BookingName, bookingEditRequestDto.OpgaveID,
                bookingEditRequestDto.AnsatID);

            _bookingRepository.UpdateBooking(model);
        }
    }
}
