using Microsoft.EntityFrameworkCore;
using Projekt.Application.ProjektQueries;
using Projekt.Application.ProjektRepositories;
using Projekt.Domain.ProjektModel;
using SqlServerContext;
using StamData.Domain.Ansat.AnsatModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Infrastructure.ProjektRepositories
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
            foreach (var entity in _db.ProjektEntities.AsNoTracking().ToList())
            {
                //skal laves include i AnsatEntities før VVVV virker
                //var kdDtos = new List<KompetenceDto>();
                //entity.KompetenceEntities.ToList().ForEach(k => kdDtos.Add(new KompetenceDto
                //{
                //    KompetenceID = k.KompetenceID,
                //    KompetenceName = k.KompetenceName,
                //}));
                yield return new ProjektQueryResultDto
                {
                    ProjektID = entity.ProjektID,
                    ProjektName = entity.ProjektName,
                    SælgerID= entity.SælgerID,
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
            //var kdDtos = new List<KompetenceDto>();
            //dbEntity.KompetenceEntities.ToList().ForEach(k => kdDtos.Add(new KompetenceDto
            //{
            //    KompetenceID = k.KompetenceID,
            //    KompetenceName = k.KompetenceName,
            //}));


            return new ProjektQueryResultDto
            {
                ProjektID = dbEntity.ProjektID,
                ProjektName = dbEntity.ProjektName,
                SælgerID = dbEntity.SælgerID,
                KundeID = dbEntity.KundeID,
                //KompetenceEntities = kdDtos,
            };
        }
    }
}
