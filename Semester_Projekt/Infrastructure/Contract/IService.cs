using Semester_Projekt.Infrastructure.Contract.Dto.Kunde;
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
        Task<AnsatQueryResultDto> GetAnsat(int ansatId);
        Task<IEnumerable<AnsatQueryResultDto>> GetAllAnsat();
        Task EditAnsat(AnsatEditRequestDto ansatEditRequestDto);


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
        Task<KundeQueryResultDto> GetKunde(int kundeId);
        Task<IEnumerable<KundeQueryResultDto>> GetAllKunde();
        Task EditKunde(KundeEditRequestDto kundeEditRequestDto);

        // Tilføj Kompetence
        Task AddAnsatKompetence(AnsatCreateRequestDto dto);
    }
}
