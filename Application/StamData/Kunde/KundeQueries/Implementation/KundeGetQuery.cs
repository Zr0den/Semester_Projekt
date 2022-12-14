using Application.StamData.Kunde.KundeRepositories;

namespace Application.StamData.Kunde.KundeQueries.Implementation
{
    public class KundeGetQuery : IKundeGetQuery
    {
        private readonly IKundeRepository _repository;

        public KundeGetQuery(IKundeRepository repository)
        {
            _repository = repository;
        }

        KundeQueryResultDto IKundeGetQuery.GetKunde(int kundeId, string kUserID)
        {
            return _repository.GetKunde(kundeId, kUserID);
        }
    }
}
