using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Booking.BookingModel;
using Domain.Opgave.OpgaveModel;
using Domain.StamData.Ansat.AnsatModel;
using Domain.StamData.Kompetencer.KompetenceModel;

namespace Domain.Booking.BookingDomainServices
{
    public interface IBookingDomainService
    {
        //public OpgaveEntity? GetOpgave(int opgaveId);
        //public AnsatEntity? GetAnsat(int ansatId);
        //public KompetenceEntity? GetKompetence(int opgaveKompetenceId);
        IEnumerable<BookingEntity> TjekBooking(int ansatId);
    }
}
