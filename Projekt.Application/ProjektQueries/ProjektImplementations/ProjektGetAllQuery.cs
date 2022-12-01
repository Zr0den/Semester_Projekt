using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Application.ProjektQueries.ProjektImplementations
{
    public class ProjektGetAllQuery
    {
        private readonly IProjektRepository _repository;

        public ProjektGetAllQuery(IProjektRepository repository)
        {
            _repository = repository;
        }

        IEnumerable<ProjektQueryResultDto> IProjektGetAllQuery.GetAllProjekt()
        {
            return _repository.GetAllProjekt();
        }

    }
}
