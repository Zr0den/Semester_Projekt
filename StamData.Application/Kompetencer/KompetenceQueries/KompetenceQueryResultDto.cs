using StamData.Domain.Ansat.AnsatModel;

namespace StamData.Application.Kompetencer.KompetenceQueries
{
    public class KompetenceQueryResultDto
    {
        public int KompetenceID { get; set; }
        public string KompetenceName { get; set; }
        public virtual ICollection<AnsatEntity> Ansatte { get; set; }
    }
}
