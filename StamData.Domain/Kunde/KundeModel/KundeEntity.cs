namespace StamData.Domain.Kunde.KundeModel
{
    public class KundeEntity
    {
        public int KundeKey { get; set; }
        public string KundeName { get; set; }
        public string KundeTelefon { get; set; }
        public string KundeEmail { get; set; }
        public string KundeAdresse { get; set; }
        public int PostNr { get; set; }
        public int KundeCVR { get; set; }
    }
}
