﻿using Application.StamData.Ansat.AnsatQueries;
using Application.StamData.Ansat.AnsatRepositories;
using Domain.StamData.Ansat.AnsatModel;
using Microsoft.EntityFrameworkCore;
using SqlServerContext;

namespace Infrastructure.StamData.Ansat.AnsatRepositories
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

        //void IAnsatRepository.AddAnsatKompetence(int ansatId)
        //{
        //    //var a = new AnsatCreateRequestDto();
        //    //var k = _db.KompetenceEntities.First();
        //    //a.KompetenceEntities.Add(k);

        //    var ansat = _db.AnsatEntities.Include(b => b.KompetenceEntities).Single(a => a.AnsatID == 6);

        //    var kompetence = _db.KompetenceEntities.Include(b => b.AnsatEntities).Single(a => a.KompetenceID == 1);

        //    _db.Entry(ansat).Collection(x => x.KompetenceEntities).Load();
        //    ansat.KompetenceEntities.Add(kompetence);


        //    _db.SaveChanges();
        //}



        IEnumerable<AnsatQueryResultDto> IAnsatRepository.GetAllAnsat(string userID)
        {
            foreach (var entity in _db.AnsatEntities.AsNoTracking().Where(b => b.UserID == userID).Include(a => a.KompetenceEntities).ToList())
            {
                //skal laves include i AnsatEntities før VVVV virker
                var kdDtos = new List<KompetenceGetDto>();
                entity.KompetenceEntities.ToList().ForEach(k => kdDtos.Add(new KompetenceGetDto
                {
                    KompetenceID = k.KompetenceID,
                    KompetenceName = k.KompetenceName,
                }));
                yield return new AnsatQueryResultDto
                {
                    AnsatID = entity.AnsatID,
                    AnsatName = entity.AnsatName, 
                    AnsatTelefon = entity.AnsatTelefon,
                    AnsatType = entity.AnsatType, 
                    UserID = entity.UserID,
                    KompetenceEntities = kdDtos
                };
            }
        }

        IEnumerable<AnsatQueryResultDto> IAnsatRepository.GetAllAnsatIndex()
        {
            foreach (var entity in _db.AnsatEntities.AsNoTracking().Include(a => a.KompetenceEntities).ToList())
            {
                //skal laves include i AnsatEntities før VVVV virker
                var kdDtos = new List<KompetenceGetDto>();
                entity.KompetenceEntities.ToList().ForEach(k => kdDtos.Add(new KompetenceGetDto
                {
                    KompetenceID = k.KompetenceID,
                    KompetenceName = k.KompetenceName,
                }));
                yield return new AnsatQueryResultDto
                {
                    AnsatID = entity.AnsatID,
                    AnsatName = entity.AnsatName,
                    AnsatTelefon = entity.AnsatTelefon,
                    AnsatType = entity.AnsatType,
                    UserID = entity.UserID,
                    KompetenceEntities = kdDtos
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
            var dbEntity = _db.AnsatEntities.FirstOrDefault(a => a.AnsatID == ansatId);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");

            _db.Entry(dbEntity).Collection(a => a.KompetenceEntities).Load();

            return dbEntity;
        }


        AnsatQueryResultDto IAnsatRepository.GetAnsat(int ansatId, string userID)
        {
            var dbEntity = _db.AnsatEntities.AsNoTracking().Include(a => a.KompetenceEntities).FirstOrDefault(a=> a.AnsatID == ansatId && a.UserID == userID);
            if (dbEntity == null) throw new Exception("Ansat findes ikke i databasen");
            var kdDtos = new List<KompetenceGetDto>();
            dbEntity.KompetenceEntities.ToList().ForEach(k => kdDtos.Add(new KompetenceGetDto
            {
                KompetenceID = k.KompetenceID,
                KompetenceName = k.KompetenceName,
            }));


            return new AnsatQueryResultDto
            {
                AnsatID = dbEntity.AnsatID,
                AnsatName = dbEntity.AnsatName,
                AnsatTelefon = dbEntity.AnsatTelefon,
                AnsatType = dbEntity.AnsatType,
                UserID = dbEntity.UserID,
                KompetenceEntities = kdDtos,
            };
        }

        IEnumerable<AnsatQueryResultDto> IAnsatRepository.GetAllAnsatDerKanLaveOpgaven(int opgaveId)
        {
            var opgave = _db.OpgaveEntities.FirstOrDefault(a => a.OpgaveID == opgaveId);
            var kompetence = _db.KompetenceEntities.Include(a => a.AnsatEntities).FirstOrDefault(a => a.KompetenceID == opgave.KompetenceID);

            var result = new List<AnsatQueryResultDto>();

            foreach (var ansat in kompetence.AnsatEntities)
            {
                result.Add(new AnsatQueryResultDto
                {
                    AnsatID = ansat.AnsatID,
                    AnsatName = ansat.AnsatName,
                    AnsatType = ansat.AnsatType,
                    AnsatTelefon = ansat.AnsatTelefon
                });
            }
            return result;
        }
    }
}


