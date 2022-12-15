using Application.Projekt.ProjektCommands;
using Application.Projekt.ProjektQueries;
using Application.Projekt.ProjektRepositories;
using Domain.Projekt.ProjektModel;
using Microsoft.EntityFrameworkCore;
using SqlServerContext;

namespace Infrastructure.Projekt.ProjektRepositories
{
    public class ProjektRepository : IProjektRepository
    {
        private readonly ServerContext _db;

        public ProjektRepository(ServerContext db)
        {
            _db = db;
        }

        void IProjektRepository.AddProjekt(ProjektEntity projekt)
        {
            _db.Add(projekt);
            _db.SaveChanges();
        }

        IEnumerable<ProjektQueryResultDto> IProjektRepository.GetAllProjekt()
        {
            foreach (var entity in Enumerable.ToList(_db.ProjektEntities.AsNoTracking()))
            {
                yield return new ProjektQueryResultDto
                {
                    ProjektID = entity.ProjektID,
                    ProjektName = entity.ProjektName,
                    UserID = entity.UserID,
                    KundeID = entity.KundeID,
                    //KompetenceEntities = kdDtos
                };
            }
        }



        void IProjektRepository.UpdateProjekt(ProjektEntity model)
        {
            _db.Update(model);
            _db.SaveChanges();
        }

        ProjektEntity IProjektRepository.LoadProjekt(int projektId)
        {
            var dbEntity = _db.ProjektEntities.AsNoTracking().FirstOrDefault(a => a.ProjektID == projektId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");
            return dbEntity;
        }


        ProjektQueryResultDto IProjektRepository.GetProjekt(int projektId)
        {
            //.Include(b => b.KompetenceEntities)
            var dbEntity = _db.ProjektEntities.AsNoTracking().FirstOrDefault(a => a.ProjektID == projektId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");
            


            return new ProjektQueryResultDto
            {
                ProjektID = dbEntity.ProjektID,
                ProjektName = dbEntity.ProjektName,
                UserID = dbEntity.UserID,
                KundeID = dbEntity.KundeID,
                //KompetenceEntities = kdDtos,
            };
        }
    }
}
