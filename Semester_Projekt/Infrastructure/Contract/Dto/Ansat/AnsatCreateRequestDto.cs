using StamData.Domain.Kompetencer.KompetenceModel;

namespace Semester_Projekt.Infrastructure.Contract.Dto.Ansat

{
    public class AnsatCreateRequestDto
    {
        public string UserId { get; set; }
        public string AnsatName { get; set; }
        public string AnsatTelefon { get; set; }
        public string AnsatType { get; set; }
        public KompetenceCreateDto KompetenceEntities { get; set; }
    }

    public class KompetenceCreateDto
    {
        public int KompetenceID { get; set; }
    }

}
