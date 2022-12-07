namespace Semester_Projekt.Infrastructure.Contract.Dto.Opgave
{
    public class OpgaveCreateRequestDto
    {
        public string OpgaveName { get; set; }
        public string OpgaveType { get; set; }
        public int KompetenceID { get; set; }
    }
}
