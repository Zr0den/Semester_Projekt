using Application.StamData.Kunde.KundeRepositories;

namespace Application.StamData.Kunde.KundeQueries.Implementation
{
    public class KundeGetAllQuery : IKundeGetAllQuery
    {
        private readonly IKundeRepository _repository;

        public KundeGetAllQuery(IKundeRepository repository)
        {
            _repository = repository;
        }

        IEnumerable<KundeQueryResultDto> IKundeGetAllQuery.GetAllKunde(string kUserID)
        {
            return _repository.GetAllKunde(kUserID);
        }
        IEnumerable<KundeQueryResultDto> IKundeGetAllQuery.GetAllKundeIndex()
        {
            return _repository.GetAllKundeIndex();
        }
    }
}
