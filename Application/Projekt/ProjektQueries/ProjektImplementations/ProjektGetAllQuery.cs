using Application.Projekt.ProjektRepositories;

namespace Application.Projekt.ProjektQueries.ProjektImplementations
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
