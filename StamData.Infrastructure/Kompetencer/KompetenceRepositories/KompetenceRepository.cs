using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SqlServerContext;
using StamData.Application.Ansat.AnsatQueries;
using StamData.Application.Ansat.AnsatRepositories;
using StamData.Application.Kompetencer.KompetenceQueries;
using StamData.Application.Kompetencer.KompetenceRepositories;
using StamData.Domain.Ansat.AnsatModel;
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

        void IKompetenceRepository.Add(KompetenceEntity kompetence)
        {
            _db.Add(kompetence);
            _db.SaveChanges();

        }

        IEnumerable<KompetenceQueryResultDto> IKompetenceRepository.GetAll(int kompetenceId)
        {
            foreach (var entity in _db.Kompetencer.AsNoTracking().Where(a => a.KompetenceID == kompetenceId).ToList())
            {
                yield return new KompetenceQueryResultDto
                {
                    KompetenceID = entity.KompetenceID,
                    KompetenceName = entity.KompetenceName,
                    Ansatte = { }
                };
            }
        }

        void IKompetenceRepository.Update(KompetenceEntity model)
        {
            _db.Update(model);
            _db.SaveChanges();
        }

        KompetenceEntity IKompetenceRepository.Load(int kompetenceId)
        {
            var dbEntity = _db.Kompetencer.AsNoTracking().FirstOrDefault(a => a.KompetenceID == kompetenceId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");
            return dbEntity;
        }

        KompetenceQueryResultDto IKompetenceRepository.Get(int kompetenceId)
        {
            var dbEntity = _db.Kompetencer.AsNoTracking().FirstOrDefault(a => a.KompetenceID == kompetenceId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");



            return new KompetenceQueryResultDto
            {
                KompetenceID = dbEntity.KompetenceID,
                KompetenceName = dbEntity.KompetenceName,
                Ansatte = { }
            };
        }
    }
}
