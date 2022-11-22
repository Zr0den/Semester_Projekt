using StamData.Domain.Kompetencer.KompetenceModel;

namespace StamData.Domain.Ansat.AnsatModel
{
    public class AnsatEntity
    {
        public int AnsatID { get; }
        public string UserId { get; private set; }
        public string AnsatName { get; private set; }
        public string AnsatTelefon { get; private set; }
        public string AnsatType { get; private set; }
        public virtual ICollection<KompetenceEntity> Kompetencer { get; private set; }

        internal AnsatEntity()
        {

        }

        public AnsatEntity(string userId, string ansatName, string ansatTelefon, string ansatType, ICollection<KompetenceEntity> kompetencer)
        {
            UserId = userId;
            AnsatName = ansatName;
            AnsatTelefon = ansatTelefon;
            AnsatType = ansatType;
            Kompetencer = kompetencer;
        }



    }

}
