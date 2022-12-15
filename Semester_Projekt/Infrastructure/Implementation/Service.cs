using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Ansat;
using Semester_Projekt.Infrastructure.Contract.Dto.Booking;
using Semester_Projekt.Infrastructure.Contract.Dto.Kompetence;
using Semester_Projekt.Infrastructure.Contract.Dto.Kunde;
using Semester_Projekt.Infrastructure.Contract.Dto.Opgave;
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
        // AnsatKompetence
        //async Task IService.AddAnsatKompetence(AnsatEditRequestDto ansatEditRequestDto)
        //{
        //    await _httpClient.PutAsJsonAsync("api/ansat", ansatEditRequestDto);

        //}
        //Ansat
        async Task IService.EditAnsat(AnsatEditRequestDto ansatEditRequestDto)
        {
            await _httpClient.PutAsJsonAsync("api/ansat", ansatEditRequestDto);
        }

        async Task IService.CreateAnsat(AnsatCreateRequestDto ansatCreateRequestDto)
        {
            await _httpClient.PostAsJsonAsync("api/ansat", ansatCreateRequestDto);
        }
        async Task<AnsatQueryResultDto?> IService.GetAnsat(int ansatId, string userID)
        {
            return await _httpClient.GetFromJsonAsync<AnsatQueryResultDto>($"api/ansat/{ansatId}/{userID}");
        }

        async Task<IEnumerable<AnsatQueryResultDto>?> IService.GetAllAnsat(string userID)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<AnsatQueryResultDto>>($"api/ansat/{userID}");
        }

        async Task<IEnumerable<AnsatQueryResultDto>?> IService.GetAllAnsatIndex()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<AnsatQueryResultDto>>($"api/ansat");
        }

        async Task<IEnumerable<AnsatQueryResultDto>?> IService.GetAllAnsatDerKanLaveOpgaven(int opgaveId)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<AnsatQueryResultDto>>($"api/ansat/Opgave/{opgaveId}");
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

        // Kunde
        async Task IService.EditKunde(KundeEditRequestDto kundeEditRequestDto)
        {
            await _httpClient.PutAsJsonAsync("api/kunde", kundeEditRequestDto);
        }

        async Task IService.CreateKunde(KundeCreateRequestDto kundeCreateRequestDto)
        {
            await _httpClient.PostAsJsonAsync("api/kunde", kundeCreateRequestDto);
        }
        async Task<KundeQueryResultDto?> IService.GetKunde(int kundeId, string kUserID)
        {
            return await _httpClient.GetFromJsonAsync<KundeQueryResultDto>($"api/kunde/{kundeId}/{kUserID}");
        }

        async Task<IEnumerable<KundeQueryResultDto>?> IService.GetAllKunde(string kUserID)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<KundeQueryResultDto>>($"api/kunde/{kUserID}");
        }
        async Task<IEnumerable<KundeQueryResultDto>?> IService.GetAllKundeIndex()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<KundeQueryResultDto>>($"api/kunde");
        }

        // Opgave
        async Task IService.EditOpgave(OpgaveEditRequestDto opgaveEditRequestDto)
        {
            await _httpClient.PutAsJsonAsync("api/opgave", opgaveEditRequestDto);
        }

        async Task IService.CreateOpgave(OpgaveCreateRequestDto opgaveCreateRequestDto)
        {
            await _httpClient.PostAsJsonAsync("api/opgave", opgaveCreateRequestDto);
        }

        async Task<OpgaveQueryResultDto?> IService.GetOpgave(int opgaveId)
        {
            return await _httpClient.GetFromJsonAsync<OpgaveQueryResultDto>($"api/opgave/{opgaveId}");
        }

        async Task<IEnumerable<OpgaveQueryResultDto>?> IService.GetAllOpgave()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<OpgaveQueryResultDto>>($"api/opgave");
        }

        // Booking
        async Task IService.EditBooking(BookingEditRequestDto bookingEditRequestDto)
        {
            await _httpClient.PutAsJsonAsync("api/Booking", bookingEditRequestDto);
        }

        async Task IService.CreateBooking(BookingCreateRequestDto bookingCreateRequestDto)
        {
            await _httpClient.PostAsJsonAsync("api/Booking", bookingCreateRequestDto);
        }

        async Task<BookingQueryResultDto?> IService.GetBooking(int bookingId)
        {
            return await _httpClient.GetFromJsonAsync<BookingQueryResultDto>($"api/Booking/{bookingId}");
        }

        async Task<IEnumerable<BookingQueryResultDto>?> IService.GetAllBooking()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<BookingQueryResultDto>>($"api/Booking");
        }

    }
}
