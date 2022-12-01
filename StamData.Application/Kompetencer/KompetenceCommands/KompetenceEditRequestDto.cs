using StamData.Domain.Ansat.AnsatModel;

namespace StamData.Application.Kompetencer.KompetenceCommands
{
    public class KompetenceEditRequestDto
    {
        public int KompetenceID { get; set; }
        public string KompetenceName { get; set; }
    }
}
