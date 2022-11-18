using StamData.Domain.Ansat.AnsatModel;

namespace StamData.Domain.Kompetencer.KompetenceModel
{
    public class KompetenceEntity
    {
        public int KompetenceKey { get; set; }
        public string KompetenceId { get; set; }
        public string KompetenceType { get; set; }
        public ICollection<AnsatEntity> AnsatteEntities { get; set; }
    }
}
