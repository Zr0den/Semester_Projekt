using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Application.ProjektRepositories;

namespace Projekt.Application.ProjektQueries.ProjektImplementations
{
    public class ProjektGetAllQuery : IProjektGetAllQuery
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
