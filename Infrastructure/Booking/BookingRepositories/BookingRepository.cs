using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Booking.BookingQueries;
using Application.Booking.BookingRepositories;
using Domain.Booking.BookingModel;
using Microsoft.EntityFrameworkCore;
using SqlServerContext;

namespace Infrastructure.Booking.BookingRepositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ServerContext _db;

        public BookingRepository(ServerContext db)
        {
            _db = db;
        }

        public void AddBooking(BookingEntity booking)
        {
            _db.Add(booking);
            _db.SaveChanges();
        }

        BookingEntity IBookingRepository.LoadBooking(int bookingId)
        {
            var dbEntity = _db.BookingEntities.FirstOrDefault(a => a.BookingID == bookingId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");

            return dbEntity;
        }

        public void UpdateBooking(BookingEntity model)
        {
            _db.Update(model);
            _db.SaveChanges();
        }

        public IEnumerable<BookingQueryResultDto> GetAllBooking()
        {
            foreach (var entity in _db.BookingEntities.AsNoTracking().ToList())
            {
                //skal laves include i AnsatEntities før VVVV virker
                yield return new BookingQueryResultDto
                {
                    BookingName = entity.BookingName,
                    BookingID = entity.BookingID,
                    OpgaveID = entity.OpgaveID,
                    AnsatID = entity.AnsatID,
                    ProjektID = entity.ProjektID,
                    StartDato = entity.StartDato,
                    SlutDato = entity.SlutDato
                };
            }
        }

        public BookingQueryResultDto GetBooking(int bookingId)
        {
            var dbEntity = _db.BookingEntities.AsNoTracking().FirstOrDefault(a => a.BookingID == bookingId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");

            return new BookingQueryResultDto
            {
                BookingName = dbEntity.BookingName,
                BookingID = dbEntity.BookingID,
                OpgaveID = dbEntity.OpgaveID,
                AnsatID = dbEntity.AnsatID,
                ProjektID = dbEntity.ProjektID,
                StartDato = dbEntity.StartDato,
                SlutDato = dbEntity.SlutDato
            };
        }
    }
}
