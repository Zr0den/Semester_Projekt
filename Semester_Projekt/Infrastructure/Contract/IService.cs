using AnsatCreateRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Ansat.AnsatCreateRequestDto;
using AnsatQueryResultDto = Semester_Projekt.Infrastructure.Contract.Dto.Ansat.AnsatQueryResultDto;
using AnsatEditRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Ansat.AnsatEditRequestDto;
using KompetenceEditRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Kompetence.KompetenceEditRequestDto;
using KompetenceCreateRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Kompetence.KompetenceCreateRequestDto;
using KompetenceQueryResultDto = Semester_Projekt.Infrastructure.Contract.Dto.Kompetence.KompetenceQueryResultDto;
using ProjektEditRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Projekt.ProjektEditRequestDto;
using ProjektCreateRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Projekt.ProjektCreateRequestDto;
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
    }
}
