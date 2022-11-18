namespace Ansatte.Application.Commands
{
    public class AnsatCreateRequestDto
    {
        public string AnsatId { get; set; }
        public string AnsatName { get; set; }
        public string AnsatTelefon { get; set; }
        public string AnsatEmail { get; set; }
        public string AnsatType { get; set; }
        public List<string> KompetenceList { get; set; }
    }
}
