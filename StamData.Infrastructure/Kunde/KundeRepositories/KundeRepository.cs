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

        IEnumerable<KundeQueryResultDto> IKundeRepository.GetAllKunde()
        {
            foreach (var entity in _db.KundeEntities.AsNoTracking().ToList())
            {
                //skal laves include i KundeEntities før VVVV virker
                //var kdDtos = new List<KompetenceDto>();
                //entity.KompetenceEntities.ToList().ForEach(k => kdDtos.Add(new KompetenceDto
                //{
                //    KompetenceID = k.KompetenceID,
                //    KompetenceName = k.KompetenceName,
                //}));
                yield return new KundeQueryResultDto
                {
                    KundeID = entity.KundeID,
                    KundeName = entity.KundeName,
                    KundeAdresse = entity.KundeAdresse,
                    KundePostNr = entity.KundePostNr,
                    KundeUserId = entity.KundeUserId,
                    KundeCVR = entity.KundeCVR,
                    //KompetenceEntities = kdDtos
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


        KundeQueryResultDto IKundeRepository.GetKunde(int kundeId)
        {
            //.Include(b => b.KompetenceEntities)
            var dbEntity = _db.KundeEntities.AsNoTracking().FirstOrDefault(a => a.KundeID == kundeId);
            if (dbEntity == null) throw new Exception("Kunde findes ikke i databasen");
            //var kdDtos = new List<KompetenceDto>();
            //dbEntity.KompetenceEntities.ToList().ForEach(k => kdDtos.Add(new KompetenceDto
            //{
            //    KompetenceID = k.KompetenceID,
            //    KompetenceName = k.KompetenceName,
            //}));


            return new KundeQueryResultDto
            {
                KundeID = dbEntity.KundeID,
                KundeName = dbEntity.KundeName,
                KundeAdresse = dbEntity.KundeAdresse,
                KundePostNr = dbEntity.KundePostNr,
                KundeUserId = dbEntity.KundeUserId,
                KundeCVR = dbEntity.KundeCVR
                //KompetenceEntities = kdDtos,
            };
        }
    }
}
