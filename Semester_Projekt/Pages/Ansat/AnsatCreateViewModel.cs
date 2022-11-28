using StamData.Domain.Kompetencer.KompetenceModel;

namespace Semester_Projekt.Pages.Ansat
{
    public class AnsatCreateViewModel
    {
        public string? AnsatName { get; set; }
        public string? AnsatTelefon { get; set; }
        public string? AnsatType { get; set; }
        public virtual ICollection<KompetenceEntity>? Kompetencer { get; set; }
    }
}
