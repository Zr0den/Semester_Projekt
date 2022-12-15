using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Pages.Opgave;

namespace Semester_Projekt.Pages.Booking
{
    public class IndexBookingModel : PageModel
    {

        private readonly IService _service;

        public IndexBookingModel(IService service)
        {
            _service = service;
        }

        [BindProperty] public List<BookingIndexViewModel> BookingModel { get; set; } = new();


        public async Task OnGet()
        {
            var businessmodel = await _service.GetAllBooking();

            BookingModel = new List<BookingIndexViewModel>();

            businessmodel?.ToList().ForEach(dto => BookingModel.Add(new BookingIndexViewModel
            {
                BookingID = dto.BookingID,
                BookingName = dto.BookingName,
                OpgaveID = dto.OpgaveID,
                AnsatID = dto.AnsatID,
                ProjektID = dto.ProjektID,
                StartDato = dto.StartDato,
                SlutDato = dto.SlutDato,
            }));
        }
    }
}
