namespace Application.StamData.Ansat.AnsatQueries
{
    public class AnsatQueryResultDto
    {
        public int AnsatID { get; set; }
        public string AnsatName { get; set; }
        public string AnsatTelefon { get; set; }
        public string AnsatType { get; set; }
        public string UserId { get; set; }
        public List<KompetenceGetDto> KompetenceEntities { get; set; }
    }
    public class KompetenceGetDto
    {
        public int KompetenceID { get; set; }
        public string KompetenceName { get; set; }
    }
}
