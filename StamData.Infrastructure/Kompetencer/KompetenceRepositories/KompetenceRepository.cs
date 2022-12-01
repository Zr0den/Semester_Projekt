using Microsoft.EntityFrameworkCore;
using SqlServerContext;
using StamData.Application.Kompetencer.KompetenceQueries;
using StamData.Application.Kompetencer.KompetenceRepositories;
using StamData.Domain.Kompetencer.KompetenceModel;

namespace StamData.Infrastructure.Kompetencer.KompetenceRepositories
{
    public class KompetenceRepository : IKompetenceRepository
    {
        private readonly ServerContext _db;

        public KompetenceRepository(ServerContext db)
        {
            _db = db;
        }

        void IKompetenceRepository.AddKompetence(KompetenceEntity kompetence)
        {
            _db.Add(kompetence);
            _db.SaveChanges();

        }

        KompetenceQueryResultDto IKompetenceRepository.GetKompetence(int kompetenceId)
        {
            var dbEntity = _db.Kompetencer.AsNoTracking().FirstOrDefault(a => a.KompetenceID == kompetenceId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");
            //var anDtos = new List<AnsatDto>();
            //dbEntity.AnsatEntities.ToList().ForEach(an => anDtos.Add(new AnsatDto
            //{
            //    AnsatType = an.AnsatType,
            //    AnsatTelefon = an.AnsatTelefon,
            //    AnsatID = an.AnsatID,
            //    AnsatName = an.AnsatName,
            //}));


            return new KompetenceQueryResultDto
            {
                KompetenceID = dbEntity.KompetenceID,
                KompetenceName = dbEntity.KompetenceName,
                //AnsatEntities = anDtos,
            };

        }

        

        IEnumerable<KompetenceQueryResultDto> IKompetenceRepository.GetAllKompetence()
        {
            //Include(a => a.AnsatEntities).
            foreach (var entity in _db.Kompetencer.AsNoTracking().ToList())
            {
                //var anDtos = new List<AnsatDto>();
                //entity.AnsatEntities.ToList().ForEach(an => anDtos.Add(new AnsatDto
                //{
                //    AnsatType = an.AnsatType,
                //    AnsatTelefon = an.AnsatTelefon,
                //    AnsatID = an.AnsatID,
                //    AnsatName = an.AnsatName,
                //}));


                yield return new KompetenceQueryResultDto
                {
                    KompetenceID = entity.KompetenceID,
                    KompetenceName = entity.KompetenceName,
                    //AnsatEntities = anDtos,
                };
            }
        }

        void IKompetenceRepository.UpdateKompetence(KompetenceEntity model)
        {
            _db.Update(model);
            _db.SaveChanges();
        }

        KompetenceEntity IKompetenceRepository.LoadKompetence(int kompetenceId)
        {
            var dbEntity = _db.Kompetencer.AsNoTracking().FirstOrDefault(a => a.KompetenceID == kompetenceId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");
            return dbEntity;
        }


    }
}
