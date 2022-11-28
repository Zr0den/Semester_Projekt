using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Ansat;

namespace Semester_Projekt.Infrastructure.Implementation
{
    public class Service : IService
    {
        private readonly HttpClient _httpClient;

        public Service(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        async Task IService.Edit(AnsatEditRequestDto ansatEditRequestDto)
        {
            await _httpClient.PutAsJsonAsync("api/ansat", ansatEditRequestDto);
        }

        async Task IService.Create(AnsatCreateRequestDto ansatCreateRequestDto)
        {
            await _httpClient.PostAsJsonAsync("api/ansat", ansatCreateRequestDto);
        }
        async Task<AnsatQueryResultDto?> IService.Get(int ansatId, string userId)
        {
            return await _httpClient.GetFromJsonAsync<AnsatQueryResultDto>($"api/ansat/{ansatId}/{userId}");
        }

        async Task<IEnumerable<AnsatQueryResultDto>?> IService.GetAll(string userId)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<AnsatQueryResultDto>>($"api/ansat/{userId}");
        }

    }
}
