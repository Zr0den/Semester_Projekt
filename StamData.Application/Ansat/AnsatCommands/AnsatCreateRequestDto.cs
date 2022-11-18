using StamData.Domain.Kompetencer.KompetenceModel;

namespace StamData.Application.Ansat.AnsatCommands
{
    public class AnsatCreateRequestDto
    {
        public string AnsatId { get; set; }
        public string AnsatName { get; set; }
        public string AnsatTelefon { get; set; }
        public string AnsatEmail { get; set; }
        public string AnsatType { get; set; }
        public ICollection<KompetenceEntity> KompetenceList { get; set; }
    }
}
