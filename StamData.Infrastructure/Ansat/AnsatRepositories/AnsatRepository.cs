using Microsoft.EntityFrameworkCore;
using SqlServerContext;
using StamData.Application.Ansat.AnsatQueries;
using StamData.Application.Ansat.AnsatRepositories;
using StamData.Domain.Ansat.AnsatModel;

namespace StamData.Infrastructure.Ansat.AnsatRepositories
{
    public class AnsatRepository : IAnsatRepository
    {
        private readonly ServerContext _db;

        public AnsatRepository(ServerContext db)
        {
            _db = db;
        }

        void IAnsatRepository.AddAnsat(AnsatEntity ansat)
        {
            _db.Add(ansat);
            _db.SaveChanges();

        }

        IEnumerable<AnsatQueryResultDto> IAnsatRepository.GetAllAnsat()
        {
            foreach (var entity in _db.AnsatEntities.AsNoTracking().ToList())
            {
                //skal laves include i AnsatEntities før VVVV virker
                //var kdDtos = new List<KompetenceDto>();
                //entity.KompetenceEntities.ToList().ForEach(k => kdDtos.Add(new KompetenceDto
                //{
                //    KompetenceID = k.KompetenceID,
                //    KompetenceName = k.KompetenceName,
                //}));
                yield return new AnsatQueryResultDto
                {
                    AnsatID = entity.AnsatID,
                    AnsatName = entity.AnsatName, 
                    AnsatTelefon = entity.AnsatTelefon,
                    AnsatType = entity.AnsatType, 
                    UserId = entity.UserId,
                    //KompetenceEntities = kdDtos
                };
            }
        }

        

        void IAnsatRepository.UpdateAnsat(AnsatEntity model)
        {
            _db.Update(model);
            _db.SaveChanges();
        }

        AnsatEntity IAnsatRepository.LoadAnsat(int ansatId)
        {
            var dbEntity = _db.AnsatEntities.AsNoTracking().FirstOrDefault(a => a.AnsatID == ansatId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");
            return dbEntity;
        }


        AnsatQueryResultDto IAnsatRepository.GetAnsat(int ansatId)
        {
            //.Include(b => b.KompetenceEntities)
            var dbEntity = _db.AnsatEntities.AsNoTracking().FirstOrDefault(a=> a.AnsatID == ansatId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");
            //var kdDtos = new List<KompetenceDto>();
            //dbEntity.KompetenceEntities.ToList().ForEach(k => kdDtos.Add(new KompetenceDto
            //{
            //    KompetenceID = k.KompetenceID,
            //    KompetenceName = k.KompetenceName,
            //}));


            return new AnsatQueryResultDto
            {
                AnsatID = dbEntity.AnsatID,
                AnsatName = dbEntity.AnsatName,
                AnsatTelefon = dbEntity.AnsatTelefon,
                AnsatType = dbEntity.AnsatType,
                UserId = dbEntity.UserId,
                //KompetenceEntities = kdDtos,
            };
        }
    }
}


