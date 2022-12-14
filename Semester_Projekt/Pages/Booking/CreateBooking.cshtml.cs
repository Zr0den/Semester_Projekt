using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Booking;
using Semester_Projekt.Pages.Opgave;

namespace Semester_Projekt.Pages.Booking
{
    public class CreateBookingModel : PageModel
    {
        private readonly IService _service;

        public CreateBookingModel(IService service)
        {
            _service = service;
        }
        public BookingCreateViewModel BookingCreate { get; set; }
        [BindProperty] public List<BookingIndexViewModel> BookingModel { get; set; } = new();
        [BindProperty] public List<OpgaveIndexViewModel> OpgaveModel { get; set; } = new();
        [BindProperty] public string BookingOpgaveName { get; set; }
        [BindProperty] public int BookingOpgaveID { get; set; }
        [BindProperty] public int BookingProjektID { get; set; }



        public async Task OnGet()
        {
            var businessModel = await _service.GetAllOpgave();

            OpgaveModel = new List<OpgaveIndexViewModel>();

            businessModel?.ToList().ForEach(dto => OpgaveModel.Add(new OpgaveIndexViewModel
            {
                OpgaveID = dto.OpgaveID,
                OpgaveName = dto.OpgaveName,
                OpgaveType = dto.OpgaveType,
                KompetenceID = dto.KompetenceID,

            }));
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            var dto = new BookingCreateRequestDto
            {
                BookingName = BookingOpgaveName,
                OpgaveID = BookingOpgaveID,
                ProjektID = BookingProjektID,
            };

            await _service.CreateBooking(dto);



            return new RedirectToPageResult("/Booking/EditBooking");
        }
    }
}
