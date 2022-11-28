using StamData.Domain.Kompetencer.KompetenceModel;

namespace StamData.Application.Ansat.AnsatQueries
{
    public class AnsatQueryResultDto
    {
        public int AnsatID { get; set; }
        public string AnsatName { get; set; }
        public string AnsatTelefon { get; set; }
        public string AnsatType { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<KompetenceEntity> Kompetencer { get; private set; }
    }
}
