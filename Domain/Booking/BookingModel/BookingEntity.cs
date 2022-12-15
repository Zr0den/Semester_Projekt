using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Booking.BookingDomainServices;

namespace Domain.Booking.BookingModel
{
    public class BookingEntity
    {
        private readonly IBookingDomainService _domainService;

        public BookingEntity(IBookingDomainService domainService)
        {
            _domainService = domainService;
        }
        public int BookingID { get; set; }
        public string BookingName { get; set; }
        public int AnsatID { get; set; }
        public int OpgaveID { get; set; }
        public int ProjektID { get; set; }

        public DateTime StartDato { get; private set; }
        public DateTime SlutDato { get; private set; }

        internal BookingEntity()
        {

        }

        public BookingEntity(string bookingName, int opgaveId, int projektId, int ansatId, DateTime startDato, DateTime slutDato /*, IBookingDomainService domainService*/)
        {
            BookingName = bookingName;
            OpgaveID = opgaveId;
            ProjektID = projektId;
            AnsatID = ansatId;
            StartDato = startDato;
            SlutDato = slutDato;

            //if (IsDoubleBooking() == false)
            //{
            //    throw new Exception("Ansat er ikke ledig");
            //}


            //var opgave = domainService.GetOpgave(opgaveId);
            //var kopetance = domainService.GetKompetence(opgave.KompetenceID);
            //if (domainService.GetAnsat(ansatId).KompetenceEntities.Any(a => a.KompetenceID == kopetance.KompetenceID))
            //    throw new Exception("Ansat har ikke kompetencen");

        }

        public void EditBooking(string bookingName, int opgaveId, int ansatId)
        {
            BookingName = bookingName;
            OpgaveID = opgaveId;
            AnsatID = ansatId;
        }

        //public bool IsDoubleBooking()
        //{
        //    return _domainService.TjekBooking(AnsatID).Any(a => a.StartDato < SlutDato && a.SlutDato > StartDato);
        //}
    }

}
