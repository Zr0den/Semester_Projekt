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
        KompetenceEntity Load(int kompetenceId);
        void Update(KompetenceEntity model);
        void Add(KompetenceEntity kompetence);
        IEnumerable<KompetenceQueryResultDto> GetAll(int kompetenceId);
        KompetenceQueryResultDto Get(int kompetenceId);
    }
}
