namespace Application.Projekt.ProjektQueries
{
    public class ProjektQueryResultDto
    {
        public int ProjektID { get; set; }
        public string ProjektName { get; set; }
        public int SælgerID { get; set; }
        public int KundeID { get; set; }
        public DateTime OprettelsesDato { get; set; }
        public DateTime EstimeretSlutDato { get; set; }

    }
}
