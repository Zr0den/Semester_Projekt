using Domain.StamData.Ansat.AnsatModel;

namespace Domain.StamData.Kompetencer.KompetenceModel
{
    public class KompetenceEntity
    {
        public int KompetenceID { get; private set; }
        public string KompetenceName { get; private set; }
        public virtual ICollection<AnsatEntity> AnsatEntities { get; private set; }

        public KompetenceEntity(string kompetenceName)
        {
            KompetenceName = kompetenceName;
        }

        internal KompetenceEntity()
        {

        }


        public void EditKompetence(string kompetenceName)
        {
            KompetenceName = kompetenceName;
        }

    }




}
