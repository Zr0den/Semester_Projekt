using Application.StamData.Kunde.KundeQueries;
using Domain.StamData.Kunde.KundeModel;

namespace Application.StamData.Kunde.KundeRepositories
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
