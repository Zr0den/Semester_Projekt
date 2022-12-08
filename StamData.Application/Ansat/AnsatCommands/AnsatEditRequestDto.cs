using StamData.Domain.Kompetencer.KompetenceModel;

namespace StamData.Application.Ansat.AnsatCommands
{
    public class AnsatEditRequestDto
    {
        public int AnsatID { get; set; }
        public string AnsatName { get; set; }
        public string AnsatType { get; set; }
        public string UserId { get; set; }
        public string AnsatTelefon { get; set; }
        public List<int> KompetenceIds { get; set; }
    }

}
