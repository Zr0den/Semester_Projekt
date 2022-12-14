using Semester_Projekt.Infrastructure.Contract.Dto.Booking;
using Semester_Projekt.Infrastructure.Contract.Dto.Kunde;
using Semester_Projekt.Infrastructure.Contract.Dto.Opgave;
using AnsatCreateRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Ansat.AnsatCreateRequestDto;
using AnsatEditRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Ansat.AnsatEditRequestDto;
using AnsatQueryResultDto = Semester_Projekt.Infrastructure.Contract.Dto.Ansat.AnsatQueryResultDto;
using KompetenceCreateRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Kompetence.KompetenceCreateRequestDto;
using KompetenceEditRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Kompetence.KompetenceEditRequestDto;
using KompetenceQueryResultDto = Semester_Projekt.Infrastructure.Contract.Dto.Kompetence.KompetenceQueryResultDto;
using ProjektCreateRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Projekt.ProjektCreateRequestDto;
using ProjektEditRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Projekt.ProjektEditRequestDto;
using ProjektQueryResultDto = Semester_Projekt.Infrastructure.Contract.Dto.Projekt.ProjektQueryResultDto;



namespace Semester_Projekt.Infrastructure.Contract
{
    public interface IService
    {
        //Ansat
        Task CreateAnsat(AnsatCreateRequestDto dto);
        Task<AnsatQueryResultDto> GetAnsat(int ansatId, string userID);
        Task<IEnumerable<AnsatQueryResultDto>> GetAllAnsat(string identityName);
        Task EditAnsat(AnsatEditRequestDto ansatEditRequestDto);
        Task<IEnumerable<AnsatQueryResultDto>> GetAllAnsatIndex();



        //Kompetence
        Task EditKompetence(KompetenceEditRequestDto kompetenceEditRequestDto);
        Task CreateKompetence(KompetenceCreateRequestDto dto);
        Task<IEnumerable<KompetenceQueryResultDto>> GetAllKompetence();
        Task<KompetenceQueryResultDto> GetKompetence(int kompetenceId);


        //Projekt
        Task EditProjekt(ProjektEditRequestDto projektEditRequestDto);
        Task CreateProjekt(ProjektCreateRequestDto dto);
        Task<IEnumerable<ProjektQueryResultDto>> GetAllProjekt();
        Task<ProjektQueryResultDto> GetProjekt(int projektId);

        // Kunde
        Task CreateKunde(KundeCreateRequestDto dto);
        Task<KundeQueryResultDto> GetKunde(int kundeId, string kUserID);
        Task<IEnumerable<KundeQueryResultDto>> GetAllKunde(string identityName);
        Task<IEnumerable<KundeQueryResultDto>> GetAllKundeIndex();

        Task EditKunde(KundeEditRequestDto kundeEditRequestDto);

        // Opgave
        Task EditOpgave(OpgaveEditRequestDto opgaveEditRequestDto);
        Task CreateOpgave(OpgaveCreateRequestDto dto);
        Task<IEnumerable<OpgaveQueryResultDto>> GetAllOpgave();
        Task<OpgaveQueryResultDto> GetOpgave(int opgaveId);

        // Booking
        Task EditBooking(BookingEditRequestDto bookingEditRequestDto);
        Task CreateBooking(BookingCreateRequestDto dto);
        Task<IEnumerable<BookingQueryResultDto>> GetAllBooking();
        Task<BookingQueryResultDto> GetBooking(int bookingId);
    }
}
