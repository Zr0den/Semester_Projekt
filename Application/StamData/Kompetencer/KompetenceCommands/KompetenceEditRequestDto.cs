namespace Application.StamData.Kompetencer.KompetenceCommands
{
    public class KompetenceEditRequestDto
    {
        public int KompetenceID { get; set; }
        public string KompetenceName { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
