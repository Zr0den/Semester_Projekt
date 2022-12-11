namespace Application.StamData.Kunde.KundeCommands
{
    public class KundeEditRequestDto
    {
        public int KundeID { get; set; }
        public string KundeUserId { get; set; }
        public string KundeName { get; set; }
        public string KundeAdresse { get; set; }
        public int KundePostNr { get; set; }
        public int KundeCVR { get; set; }
    }
}
