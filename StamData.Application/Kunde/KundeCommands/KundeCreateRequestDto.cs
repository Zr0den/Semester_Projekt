namespace StamData.Application.Kunde.KundeCommands
{
    public class KundeCreateRequestDto
    {
        public string KundeUserId { get; set; }
        public string KundeName { get; set; }
        public string KundeAdresse { get; set; }
        public int KundePostNr { get; set; }
        public int KundeCVR { get; set; }
    }
}
