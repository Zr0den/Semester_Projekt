using Domain.StamData.Kunde.KundeModel;

namespace Application.Projekt.ProjektCommands
{
    public class ProjektCreateRequestDto
    {
        public string ProjektName { get; set; }
        public string UserID { get; set; }
        public int KundeID { get; set; }
    }
}

