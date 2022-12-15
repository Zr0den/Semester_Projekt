using Domain.StamData.Ansat.AnsatModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.StamData.Kompetencer.KompetenceModel
{
    public class KompetenceEntity
    {
        public int KompetenceID { get; private set; }
        public string KompetenceName { get; private set; }
        [Timestamp] public byte[] RowVersion { get; private set; }
        public virtual ICollection<AnsatEntity> AnsatEntities { get; private set; }

        public KompetenceEntity(string kompetenceName)
        {
            KompetenceName = kompetenceName;
        }

        internal KompetenceEntity()
        {

        }


        public void EditKompetence(string kompetenceName, byte[] rowVersion)
        {
            KompetenceName = kompetenceName;
            RowVersion = rowVersion;
        }

    }




}
