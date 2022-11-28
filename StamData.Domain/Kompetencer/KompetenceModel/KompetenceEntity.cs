using StamData.Domain.Ansat.AnsatModel;

namespace StamData.Domain.Kompetencer.KompetenceModel
{
    public class KompetenceEntity
    {
        public int KompetenceID { get; private set; }
        public string KompetenceName { get; private set; }
        public virtual ICollection<AnsatEntity> Ansatte { get; private set; }

        public KompetenceEntity(
            int kompetenceID,
            string kompetenceName,
            ICollection<AnsatEntity> ansatte)
        {
            this.Ansatte = new HashSet<AnsatEntity>();
            KompetenceName = kompetenceName;
        }

        internal KompetenceEntity()
        {

        }


        public void Edit(string kompetenceName, ICollection<AnsatEntity> ansatte)
        {
            KompetenceName = kompetenceName;
            Ansatte = ansatte;
        }

    }




}
