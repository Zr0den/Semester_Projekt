using StamData.Domain.Ansat.AnsatModel;

namespace StamData.Domain.Kompetencer.KompetenceModel
{
    public class KompetenceEntity
    {
        public int KompetenceID { get; set; }
        public int AnsatID { get; set; }
        public string KompetenceName { get; set; }
        public string KompetenceType { get; set; }  
        public virtual AnsatEntity Ansat { get; set; }

    }
}
