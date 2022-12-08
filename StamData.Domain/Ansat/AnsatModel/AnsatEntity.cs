using StamData.Domain.Ansat.AnsatDomainServices;
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
        public virtual ICollection<KompetenceEntity> KompetenceEntities { get; private set; }

        internal AnsatEntity()
        {

        }

        public AnsatEntity(
            string userId, 
            string ansatName, 
            string ansatTelefon, 
            string ansatType)
        {
            UserId = userId;
            AnsatName = ansatName;
            AnsatTelefon = ansatTelefon;
            AnsatType = ansatType;
        }

        public void EditAnsat(string ansatName, string ansatTelefon, string ansatType,
            List<int> requestDtoKompetenceIds, IAnsatDomainService ansatDomainService)
        {
            AnsatName = ansatName;
            AnsatTelefon = ansatTelefon;
            AnsatType = ansatType;
            var kompetencer = ansatDomainService.getKompetenceEntities(requestDtoKompetenceIds);
            foreach (var k in kompetencer)
            {
                KompetenceEntities.Add(k);
            }

        }

        public void AddAnsatKompetence(ICollection<KompetenceEntity> kompetenceEntities)
        {
            KompetenceEntities = kompetenceEntities;
        }

    }

}
