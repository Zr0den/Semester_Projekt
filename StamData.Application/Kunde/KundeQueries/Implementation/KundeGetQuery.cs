using StamData.Application.Kunde.KundeRepositories;

namespace StamData.Application.Kunde.KundeQueries.Implementation
{
    public class KundeGetQuery : IKundeGetQuery
    {
        private readonly IKundeRepository _repository;

        public KundeGetQuery(IKundeRepository repository)
        {
            _repository = repository;
        }

        KundeQueryResultDto IKundeGetQuery.GetKunde(int kundeId)
        {
            return _repository.GetKunde(kundeId);
        }
    }
}
