using Application.Projekt.ProjektRepositories;

namespace Application.Projekt.ProjektQueries.ProjektImplementations
{
    public class ProjektGetQuery : IProjektGetQuery
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
