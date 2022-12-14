namespace Semester_Projekt.Infrastructure.Contract.Dto.Kunde
{
    public class KundeEditRequestDto
    {
        public int KundeID { get; set; }
        public string KUserID { get; set; }
        public string KundeName { get; set; }
        public string KundeAdresse { get; set; }
        public int KundePostNr { get; set; }
        public int KundeCVR { get; set; }
    }
}
