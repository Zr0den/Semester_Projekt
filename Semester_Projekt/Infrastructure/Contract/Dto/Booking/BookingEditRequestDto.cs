using System.Diagnostics.Contracts;

namespace Semester_Projekt.Infrastructure.Contract.Dto.Booking
{
    public class BookingEditRequestDto
    {
        public int BookingID { get; set; }
        public string BookingName { get; set; }
        public int OpgaveID { get; set; }
        public int AnsatID { get; set; }
    }
}
