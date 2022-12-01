using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StamData.Application.Kompetencer.KompetenceRepositories;

namespace StamData.Application.Kompetencer.KompetenceQueries.KompetenceImplementations
{
    public class KompetenceGetQuery : IKompetenceGetQuery
    {
        private readonly IKompetenceRepository _repository;

        public KompetenceGetQuery(IKompetenceRepository repository)
        {
            _repository = repository;
        }

        KompetenceQueryResultDto IKompetenceGetQuery.GetKompetence(int kompetenceId)
        {
            return _repository.GetKompetence(kompetenceId);
        }
    }
}
