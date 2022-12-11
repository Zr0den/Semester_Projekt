using Domain.StamData.Kompetencer.KompetenceModel;

namespace Domain.StamData.Ansat.AnsatDomainServices
{
    public interface IAnsatDomainService
    {
        ICollection<KompetenceEntity> getKompetenceEntities(List<int> kompetenceIds);
    }
}
