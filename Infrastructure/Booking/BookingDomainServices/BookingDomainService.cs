using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Booking.BookingDomainServices;
using Domain.Booking.BookingModel;
using Domain.Opgave.OpgaveModel;
using Domain.StamData.Ansat.AnsatModel;
using Domain.StamData.Kompetencer.KompetenceModel;
using Microsoft.EntityFrameworkCore;
using SqlServerContext;

namespace Infrastructure.Booking.BookingDomainServices
{
    public class BookingDomainService : IBookingDomainService
    {
        private readonly ServerContext _db;

        public BookingDomainService(ServerContext db)
        {
            _db = db;
        }

        IEnumerable<BookingEntity> IBookingDomainService.TjekBooking(int ansatId)
        {
            return _db.BookingEntities.AsNoTracking().Where(a => a.AnsatID == ansatId);
        }
        //AnsatEntity? IBookingDomainService.GetAnsat(int ansatId)
        //{
        //    return _db.AnsatEntities.Include(a => a.KompetenceEntities).FirstOrDefault(a => a.AnsatID == ansatId);

        //}

        //KompetenceEntity? IBookingDomainService.GetKompetence(int opgaveKompetenceId)
        //{
        //    return _db.KompetenceEntities.FirstOrDefault(a => a.KompetenceID == opgaveKompetenceId);
        //}

        //OpgaveEntity? IBookingDomainService.GetOpgave(int opgaveId)
        //{
        //    return _db.OpgaveEntities.FirstOrDefault(a => a.OpgaveID == opgaveId);
        //}
    }
}
