using Microsoft.EntityFrameworkCore;
using SqlServerContext;
using StamData.Application.Kunde.KundeQueries;
using StamData.Application.Kunde.KundeRepositories;
using StamData.Domain.Kunde.KundeModel;

namespace StamData.Infrastructure.Kunde.KundeRepositories
{
    public class KundeRepository : IKundeRepository
    {
        private readonly ServerContext _db;

        public KundeRepository(ServerContext db)
        {
            _db = db;
        }

        void IKundeRepository.AddKunde(KundeEntity kunde)
        {
            _db.Add(kunde);
            _db.SaveChanges();

        }

        IEnumerable<KundeQueryResultDto> IKundeRepository.GetAllKunde(string kundeUserId)
        {
            foreach (var entity in _db.KundeEntities.AsNoTracking().Where(a => a.KundeUserId == kundeUserId).ToList())
            {
                yield return new KundeQueryResultDto
                {
                    KundeID = entity.KundeID,
                    KundeName = entity.KundeName,
                    KundeAdresse = entity.KundeAdresse,
                    KundePostNr = entity.KundePostNr,
                    KundeUserId = entity.KundeUserId,
                    KundeCVR = entity.KundeCVR,
                };
            }
        }



        void IKundeRepository.UpdateKunde(KundeEntity model)
        {
            _db.Update(model);
            _db.SaveChanges();
        }

        KundeEntity IKundeRepository.LoadKunde(int kundeId)
        {
            var dbEntity = _db.KundeEntities.AsNoTracking().FirstOrDefault(a => a.KundeID == kundeId);
            if (dbEntity == null) throw new Exception("Kunde findes ikke i databasen");
            return dbEntity;
        }


        KundeQueryResultDto IKundeRepository.GetKunde(int kundeId, string kundeUserId)
        {
            var dbEntity = _db.KundeEntities.AsNoTracking().FirstOrDefault(a => a.KundeID == kundeId && a.KundeUserId == kundeUserId);
            if (dbEntity == null) throw new Exception("Kunde findes ikke i databasen");
            


            return new KundeQueryResultDto
            {
                KundeID = dbEntity.KundeID,
                KundeName = dbEntity.KundeName,
                KundeAdresse = dbEntity.KundeAdresse,
                KundePostNr = dbEntity.KundePostNr,
                KundeUserId = dbEntity.KundeUserId,
                KundeCVR = dbEntity.KundeCVR
            };
        }
    }
}
