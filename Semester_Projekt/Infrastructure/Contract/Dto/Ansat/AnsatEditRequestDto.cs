namespace Semester_Projekt.Infrastructure.Contract.Dto.Ansat
{
    public class AnsatEditRequestDto
    {
        public int AnsatID { get; set; }
        public string AnsatName { get; set; }
        public string AnsatType { get; set; }
        public string AnsatTelefon { get; set; }
        public string UserID { get; set; }
        public List<int> KompetenceIds { get; set; }

    }

    //public class KompetenceEditDto
    //{
    //    public int KompetenceID { get; set; }
    //}

}
