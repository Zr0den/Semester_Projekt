namespace Semester_Projekt.Infrastructure.Contract.Dto.Booking
{
    public class BookingQueryResultDto
    {
        public int BookingID { get; set; }
        public string BookingName { get; set; }
        public int OpgaveID { get; set; }
        public int AnsatID { get; set; }
        public int ProjektID { get; set; }
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }
    }
}
