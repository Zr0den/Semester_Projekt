using StamData.Domain.Ansat.AnsatModel;

namespace StamData.Domain.Kompetencer.KompetenceModel
{
    public class KompetenceEntity
    {
        public int KompetenceID { get; private set; }
        public string KompetenceName { get; private set; }
        public virtual ICollection<AnsatEntity> AnsatEntities { get; private set; }

        public KompetenceEntity(
            int kompetenceID,
            string kompetenceName,
            ICollection<AnsatEntity> ansatEntities)
        {
            AnsatEntities = ansatEntities;
            KompetenceName = kompetenceName;
        }

        internal KompetenceEntity()
        {

        }


        public void EditKompetence(string kompetenceName, ICollection<AnsatEntity> ansatEntities)
        {
            KompetenceName = kompetenceName;
            AnsatEntities = ansatEntities;
        }

    }




}
