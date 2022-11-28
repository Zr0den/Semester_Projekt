using StamData.Domain.Kompetencer.KompetenceModel;

namespace Semester_Projekt.Infrastructure.Contract.Dto.Ansat

{
    public class AnsatCreateRequestDto
    {
        public string UserID { get; set; }
        public string AnsatName { get; set; }
        public string AnsatTelefon { get; set; }
        public string AnsatType { get; set; }
        public virtual ICollection<KompetenceEntity> Kompetencer { get; set; }
    }
}
