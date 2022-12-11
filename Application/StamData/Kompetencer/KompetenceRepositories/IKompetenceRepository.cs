using Application.StamData.Kompetencer.KompetenceQueries;
using Domain.StamData.Kompetencer.KompetenceModel;

namespace Application.StamData.Kompetencer.KompetenceRepositories
{
    public interface IKompetenceRepository
    {
        KompetenceEntity LoadKompetence(int kompetenceId);
        void UpdateKompetence(KompetenceEntity model);
        void AddKompetence(KompetenceEntity kompetenceEntities);
        IEnumerable<KompetenceQueryResultDto> GetAllKompetence();
        KompetenceQueryResultDto GetKompetence(int kompetenceId);
    }
}
