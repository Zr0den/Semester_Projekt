using StamData.Domain.Kompetencer.KompetenceModel;

namespace StamData.Domain.Ansat.AnsatDomainServices
{
    public interface IAnsatDomainService
    {
        ICollection<KompetenceEntity> getKompetenceEntities(List<int> kompetenceIds);
    }
}
