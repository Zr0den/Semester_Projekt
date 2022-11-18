using StamData.Domain.Kompetencer.KompetenceModel;

namespace StamData.Application.Ansat.AnsatQueries
{
    public class AnsatQueryResultDto
    {
        public int AnsatKey { get; set; }
        public string AnsatName { get; set; }
        public string AnsatTelefon { get; set; }
        public string AnsatEmail { get; set; }
        public string AnsatType { get; set; }
        public ICollection<KompetenceEntity> KompetenceList { get; set; }
    }
}
