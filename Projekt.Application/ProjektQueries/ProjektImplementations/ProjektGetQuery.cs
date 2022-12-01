using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Application.ProjektQueries.ProjektImplementations
{
    public class ProjektGetQuery
    {
        private readonly IProjektRepository _repository;

        public ProjektGetQuery(IProjektRepository repository)
        {
            _repository = repository;
        }

        ProjektQueryResultDto IProjektGetQuery.GetProjekt(int projektId)
        {
            return _repository.GetProjekt(projektId);
        }
    }
}
