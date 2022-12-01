﻿using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Ansat;
using Semester_Projekt.Infrastructure.Contract.Dto.Kompetence;
using Semester_Projekt.Infrastructure.Contract.Dto.Projekt;


namespace Semester_Projekt.Infrastructure.Implementation
{
    public class Service : IService
    {
        private readonly HttpClient _httpClient;

        public Service(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        //Ansat
        async Task IService.EditAnsat(AnsatEditRequestDto ansatEditRequestDto)
        {
            await _httpClient.PutAsJsonAsync("api/ansat", ansatEditRequestDto);
        }

        async Task IService.CreateAnsat(AnsatCreateRequestDto ansatCreateRequestDto)
        {
            await _httpClient.PostAsJsonAsync("api/ansat", ansatCreateRequestDto);
        }
        async Task<AnsatQueryResultDto?> IService.GetAnsat(int ansatId)
        {
            return await _httpClient.GetFromJsonAsync<AnsatQueryResultDto>($"api/ansat/{ansatId}");
        }

        async Task<IEnumerable<AnsatQueryResultDto>?> IService.GetAllAnsat()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<AnsatQueryResultDto>>($"api/ansat");
        }


        //Kompetence
        async Task IService.EditKompetence(KompetenceEditRequestDto kompetenceEditRequestDto)
        {
            await _httpClient.PutAsJsonAsync("api/kompetence", kompetenceEditRequestDto);
        }

        async Task IService.CreateKompetence(KompetenceCreateRequestDto kompetenceCreateRequestDto)
        {
            await _httpClient.PostAsJsonAsync("api/kompetence", kompetenceCreateRequestDto);
        }

        async Task<KompetenceQueryResultDto?> IService.GetKompetence(int kompetenceId)
        {
            return await _httpClient.GetFromJsonAsync<KompetenceQueryResultDto>($"api/kompetence/{kompetenceId}");
        }

        async Task<IEnumerable<KompetenceQueryResultDto>?> IService.GetAllKompetence()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<KompetenceQueryResultDto>>($"api/kompetence");
        }


        //Projekt
        async Task IService.EditProjekt(ProjektEditRequestDto projektEditRequestDto)
        {
            await _httpClient.PutAsJsonAsync("api/projekt", projektEditRequestDto);
        }

        async Task IService.CreateProjekt(ProjektCreateRequestDto projektCreateRequestDto)
        {
            await _httpClient.PostAsJsonAsync("api/projekt", projektCreateRequestDto);
        }

        async Task<ProjektQueryResultDto?> IService.GetProjekt(int projektId)
        {
            return await _httpClient.GetFromJsonAsync<ProjektQueryResultDto>($"api/projekt/{projektId}");
        }

        async Task<IEnumerable<ProjektQueryResultDto>?> IService.GetAllProjekt()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ProjektQueryResultDto>>($"api/projekt");
        }

    }
}
