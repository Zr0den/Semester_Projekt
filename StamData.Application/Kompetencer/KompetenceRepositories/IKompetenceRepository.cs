using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StamData.Application.Kompetencer.KompetenceQueries;
using StamData.Domain.Kompetencer.KompetenceModel;

namespace StamData.Application.Kompetencer.KompetenceRepositories
{
    public interface IKompetenceRepository
    {
        KompetenceEntity LoadKompetence(int kompetenceId);
        void UpdateKompetence(KompetenceEntity model);
        void AddKompetence(KompetenceEntity kompetenceEntities);
        IEnumerable<KompetenceQueryResultDto> GetAllKompetence();
        KompetenceQueryResultDto GetKompetence(int kompetenceId);
    }
}
