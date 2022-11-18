namespace Ansatte.Domain.Model
{
    public class AnsatEntity
    {
        public int AnsatKey { get; }
        public string AnsatId { get; private set; }
        public string AnsatName { get; private set; }
        public string AnsatTelefon { get; private set; }
        public string AnsatEmail { get; private set; }
        public string AnsatType { get; private set; }
        public ICollection<KompetenceEntity> KompetenceList { get; private set; }

        internal AnsatEntity()
        {

        }

        public AnsatEntity(string ansatId, string ansatName, string ansatTelefon, string ansatEmail, string ansatType, List<string> kompetenceList)
        {
            AnsatId = ansatId;
            AnsatName = ansatName;
            AnsatTelefon = ansatTelefon;
            AnsatEmail = ansatEmail;
            AnsatType = ansatType;
            KompetenceList = kompetenceList;
        }



    }

}
