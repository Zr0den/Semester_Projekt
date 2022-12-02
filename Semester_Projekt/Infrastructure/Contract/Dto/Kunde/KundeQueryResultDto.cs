namespace Semester_Projekt.Infrastructure.Contract.Dto.Kunde
{
    public class KundeQueryResultDto
    {
        public int KundeID { get; set; }
        public string KundeUserId { get; set; }
        public string KundeName { get; set; }
        public string KundeAdresse { get; set; }
        public int KundePostNr { get; set; }
        public int KundeCVR { get; set; }
    }
}
