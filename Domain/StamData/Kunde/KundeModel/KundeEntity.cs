using Domain.Projekt.ProjektModel;

namespace Domain.StamData.Kunde.KundeModel
{
    public class KundeEntity
    {
        public int KundeID { get; set; }
        public string KUserID { get; set; }
        public string KundeName { get; set; }
        public string KundeAdresse { get; set; }
        public int KundePostNr { get; set; }
        public int KundeCVR { get; set; }

        public List<ProjektEntity> ProjektEntities { get; set; }

        internal KundeEntity()
        {
            
        }

        public KundeEntity(string kUserID, string kundeName, string kundeAdresse, int kundePostNr, int kundeCvr)
        {
            KUserID = kUserID;
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
