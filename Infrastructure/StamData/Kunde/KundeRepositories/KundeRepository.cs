using Application.StamData.Kunde.KundeQueries;
using Application.StamData.Kunde.KundeRepositories;
using Domain.StamData.Kunde.KundeModel;
using Microsoft.EntityFrameworkCore;
using SqlServerContext;

namespace Infrastructure.StamData.Kunde.KundeRepositories
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

        IEnumerable<KundeQueryResultDto> IKundeRepository.GetAllKunde(string kUserID)
        {
            foreach (var entity in _db.KundeEntities.AsNoTracking().Where(a => a.KUserID == kUserID).ToList())
            {
                yield return new KundeQueryResultDto
                {
                    KundeID = entity.KundeID,
                    KundeName = entity.KundeName,
                    KundeAdresse = entity.KundeAdresse,
                    KundePostNr = entity.KundePostNr,
                    KUserID = entity.KUserID,
                    KundeCVR = entity.KundeCVR,
                };
            }
        }
        IEnumerable<KundeQueryResultDto> IKundeRepository.GetAllKundeIndex()
        {
            foreach (var entity in _db.KundeEntities.AsNoTracking().ToList())
            {
                yield return new KundeQueryResultDto
                {
                    KundeID = entity.KundeID,
                    KundeName = entity.KundeName,
                    KundeAdresse = entity.KundeAdresse,
                    KundePostNr = entity.KundePostNr,
                    KUserID = entity.KUserID,
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


        KundeQueryResultDto IKundeRepository.GetKunde(int kundeId, string kUserID)
        {
            var dbEntity = _db.KundeEntities.AsNoTracking().FirstOrDefault(a => a.KundeID == kundeId && a.KUserID == kUserID);
            if (dbEntity == null) throw new Exception("Kunde findes ikke i databasen");
            


            return new KundeQueryResultDto
            {
                KundeID = dbEntity.KundeID,
                KundeName = dbEntity.KundeName,
                KundeAdresse = dbEntity.KundeAdresse,
                KundePostNr = dbEntity.KundePostNr,
                KUserID = dbEntity.KUserID,
                KundeCVR = dbEntity.KundeCVR
            };
        }
    }
}
