﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Booking.BookingCommands
{
    public interface IEditBookingCommand
    {
        void EditBooking(BookingEditRequestDto bookingEditRequestDto);
    }
}
