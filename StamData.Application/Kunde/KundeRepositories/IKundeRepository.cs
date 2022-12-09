using StamData.Application.Kunde.KundeQueries;
using StamData.Domain.Kunde.KundeModel;

namespace StamData.Application.Kunde.KundeRepositories
{
    public interface IKundeRepository
    {
        void AddKunde(KundeEntity kunde);
        KundeEntity LoadKunde(int kundeId);
        void UpdateKunde(KundeEntity model);
        IEnumerable<KundeQueryResultDto> GetAllKunde(string kundeUserId);
        KundeQueryResultDto GetKunde(int kundeId, string kundeUserId);
    }
}
