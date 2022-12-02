namespace StamData.Domain.Kunde.KundeModel
{
    public class KundeEntity
    {
        public int KundeID { get; set; }
        public string KundeUserId { get; set; }
        public string KundeName { get; set; }
        public string KundeAdresse { get; set; }
        public int KundePostNr { get; set; }
        public int KundeCVR { get; set; }

        internal KundeEntity()
        {
            
        }

        public KundeEntity(string kundeUserId, string kundeName, string kundeAdresse, int kundePostNr, int kundeCvr)
        {
            KundeUserId = kundeUserId;
            KundeName = kundeName;
            KundeAdresse = kundeAdresse;
            KundeCVR = kundeCvr;
            KundePostNr = kundePostNr;
        }

        public void EditKunde(string kundeName, string kundeAdresse, int kundePostNr, int kundeCvr)
        {
            KundeName = kundeName;
            KundeAdresse = kundeAdresse;
            KundePostNr = kundePostNr;
            KundeCVR = kundeCvr;
        }

    }

    
}
