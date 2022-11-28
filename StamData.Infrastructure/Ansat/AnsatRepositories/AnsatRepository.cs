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

        void IAnsatRepository.Add(AnsatEntity ansat)
        {
            _db.Add(ansat);
            _db.SaveChanges();

        }

        IEnumerable<AnsatQueryResultDto> IAnsatRepository.GetAll(string userId)
        {
            foreach (var entity in _db.AnsatEntities.AsNoTracking().Where(a => a.UserId == userId).ToList())
            {
                yield return new AnsatQueryResultDto
                {
                    AnsatID = entity.AnsatID,
                    AnsatName = entity.AnsatName, 
                    AnsatTelefon = entity.AnsatTelefon,
                    AnsatType = entity.AnsatType, 
                    UserId = entity.UserId,
                    Kompetencer = {  }
                };
            }
        }

        void IAnsatRepository.Update(AnsatEntity model)
        {
            _db.Update(model);
            _db.SaveChanges();
        }

        AnsatEntity IAnsatRepository.Load(int ansatId, string userId)
        {
            var dbEntity = _db.AnsatEntities.AsNoTracking().FirstOrDefault(a => a.AnsatID == ansatId && a.UserId == userId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");
            return dbEntity;
        }


        AnsatQueryResultDto IAnsatRepository.Get(int ansatId, string userId)
        {
            var dbEntity = _db.AnsatEntities.AsNoTracking().FirstOrDefault(a=> a.AnsatID == ansatId && a.UserId == userId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");



            return new AnsatQueryResultDto
            {
                AnsatID = dbEntity.AnsatID,
                AnsatName = dbEntity.AnsatName,
                AnsatTelefon = dbEntity.AnsatTelefon,
                AnsatType = dbEntity.AnsatType,
                UserId = dbEntity.UserId,
                Kompetencer = {  }
            };
        }
    }
}


