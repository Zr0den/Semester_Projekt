using AnsatCreateRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Ansat.AnsatCreateRequestDto;
using AnsatQueryResultDto = Semester_Projekt.Infrastructure.Contract.Dto.Ansat.AnsatQueryResultDto;
using AnsatEditRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Ansat.AnsatEditRequestDto;

namespace Semester_Projekt.Infrastructure.Contract
{
    public interface IService
    {
        Task Create(AnsatCreateRequestDto dto);
        Task<AnsatQueryResultDto> Get(int ansatId, string identityName);
        Task<IEnumerable<AnsatQueryResultDto>> GetAll(string identityName);
        Task Edit(AnsatEditRequestDto ansatEditRequestDto);
    }
}
