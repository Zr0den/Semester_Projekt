using Application.Opgave.OpgaveQueries;
using Application.Opgave.OpgaveRepositories;
using Domain.Opgave.OpgaveModel;
using Microsoft.EntityFrameworkCore;
using SqlServerContext;

namespace Infrastructure.Opgave.OpgaveRepositories
{
    public class OpgaveRepository : IOpgaveRepository
    {
        private readonly ServerContext _db;

        public OpgaveRepository(ServerContext db)
        {
            _db = db;
        }

        void IOpgaveRepository.AddOpgave(OpgaveEntity opgave)
        {
            _db.Add(opgave);
            _db.SaveChanges();

        }

        IEnumerable<OpgaveQueryResultDto> IOpgaveRepository.GetAllOpgave()
        {
            foreach (var entity in Enumerable.ToList(_db.OpgaveEntities.AsNoTracking()))
            {
                //skal laves include i AnsatEntities før VVVV virker
                //var kdDtos = new List<KompetenceDto>();
                //entity.KompetenceEntities.ToList().ForEach(k => kdDtos.Add(new KompetenceDto
                //{
                //    KompetenceID = k.KompetenceID,
                //    KompetenceName = k.KompetenceName,
                //}));
                yield return new OpgaveQueryResultDto
                {
                    OpgaveID = entity.OpgaveID,
                    OpgaveName = entity.OpgaveName,
                    KompetenceID = entity.KompetenceID,
                    OpgaveType = entity.OpgaveType,
                    //KompetenceEntities = kdDtos
                };
            }
        }



        void IOpgaveRepository.UpdateOpgave(OpgaveEntity model)
        {
            _db.Update(model);
            _db.SaveChanges();
        }

        OpgaveEntity IOpgaveRepository.LoadOpgave(int opgaveId)
        {
            var dbEntity = _db.OpgaveEntities.AsNoTracking().FirstOrDefault(a => a.OpgaveID == opgaveId);
            if (dbEntity == null) throw new Exception("Opgave findes ikke i databasen");
            return dbEntity;
        }


        OpgaveQueryResultDto IOpgaveRepository.GetOpgave(int opgaveId)
        {
            //.Include(b => b.KompetenceEntities)
            var dbEntity = _db.OpgaveEntities.AsNoTracking().FirstOrDefault(a => a.OpgaveID == opgaveId);
            if (dbEntity == null) throw new Exception("Opgave findes ikke i databasen");
            //var kdDtos = new List<KompetenceDto>();
            //dbEntity.KompetenceEntities.ToList().ForEach(k => kdDtos.Add(new KompetenceDto
            //{
            //    KompetenceID = k.KompetenceID,
            //    KompetenceName = k.KompetenceName,
            //}));


            return new OpgaveQueryResultDto
            {
                OpgaveID = dbEntity.OpgaveID,
                OpgaveName = dbEntity.OpgaveName,
                KompetenceID = dbEntity.KompetenceID,
                OpgaveType = dbEntity.OpgaveType,
                //KompetenceEntities = kdDtos,
            };
        }
    }
}
