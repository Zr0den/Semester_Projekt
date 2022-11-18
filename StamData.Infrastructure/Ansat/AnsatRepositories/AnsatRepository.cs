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

        IEnumerable<AnsatQueryResultDto> IAnsatRepository.GetAll(string ansatId)
        {
            foreach (var entity in _db.AnsatEntities.AsNoTracking().Where(a => a.AnsatId == ansatId).ToList())
            {
                yield return new AnsatQueryResultDto
                {
                    AnsatKey = entity.AnsatKey,
                    AnsatName = entity.AnsatName, 
                    AnsatTelefon = entity.AnsatTelefon,
                    AnsatEmail = entity.AnsatEmail, 
                    AnsatType = entity.AnsatType, 
                    KompetenceList = entity.KompetenceList
                };
            }
        }

        AnsatQueryResultDto IAnsatRepository.Get(int key, string ansatId)
        {
            var dbEntity = _db.AnsatEntities.AsNoTracking().FirstOrDefault(a => a.AnsatId == ansatId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");

            return new AnsatQueryResultDto
            {
                AnsatKey = dbEntity.AnsatKey,
                AnsatName = dbEntity.AnsatName,
                AnsatTelefon = dbEntity.AnsatTelefon,
                AnsatEmail = dbEntity.AnsatEmail,
                AnsatType = dbEntity.AnsatType,
                KompetenceList = dbEntity.KompetenceList
            };
        }
    }
}


