using StamData.Application.Kompetencer.KompetenceCommands;
using StamData.Domain.Kompetencer.KompetenceModel;

namespace StamData.Application.Ansat.AnsatCommands
{
    public class AnsatCreateRequestDto
    {
        public string UserId { get; set; }
        public string AnsatName { get; set; }
        public string AnsatTelefon { get; set; }
        public string AnsatType { get; set; }
        public List<KompetenceEntity> KompetenceEntities { get; set; }

    }


}
