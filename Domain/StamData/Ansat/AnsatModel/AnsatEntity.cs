using Domain.Projekt.ProjektModel;
using Domain.StamData.Ansat.AnsatDomainServices;
using Domain.StamData.Kompetencer.KompetenceModel;

namespace Domain.StamData.Ansat.AnsatModel
{
    public class AnsatEntity
    {
        public int AnsatID { get; }
        public string UserID { get; private set; }
        public string AnsatName { get; private set; }
        public string AnsatTelefon { get; private set; }
        public string AnsatType { get; private set; }
        public virtual ICollection<KompetenceEntity> KompetenceEntities { get; private set; }
        //public virtual ICollection<ProjektEntity> ProjektEntities { get; private set; }


        internal AnsatEntity()
        {

        }

        public AnsatEntity(
            string userID, 
            string ansatName, 
            string ansatTelefon, 
            string ansatType)
        {
            UserID = userID;
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

        //public void AddAnsatKompetence(ICollection<KompetenceEntity> kompetenceEntities)
        //{
        //    KompetenceEntities = kompetenceEntities;
        //}

    }

}
