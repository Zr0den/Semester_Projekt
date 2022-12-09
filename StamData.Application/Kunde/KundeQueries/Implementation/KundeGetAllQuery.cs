using StamData.Application.Kunde.KundeRepositories;

namespace StamData.Application.Kunde.KundeQueries.Implementation
{
    public class KundeGetAllQuery : IKundeGetAllQuery
    {
        private readonly IKundeRepository _repository;

        public KundeGetAllQuery(IKundeRepository repository)
        {
            _repository = repository;
        }

        IEnumerable<KundeQueryResultDto> IKundeGetAllQuery.GetAllKunde(string kundeUserId)
        {
            return _repository.GetAllKunde(kundeUserId);
        }
    }
}
