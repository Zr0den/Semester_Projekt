using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Booking;
using Semester_Projekt.Pages.Ansat;
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
        [BindProperty]
        public BookingCreateViewModel BookingModel { get; set; } = new();
        //[BindProperty] public List<OpgaveIndexViewModel> OpgaveModel { get; set; }
        //[BindProperty] public string BookingOpgaveName { get; set; }
        [BindProperty] public int opgaveId { get; set; }
        [BindProperty] public int BookingProjektID { get; set; }
        public List<AnsatIndexViewModel> AnsatIndexViewModel { get; set; }
        [BindProperty] public int BookingAnsatID { get; set; }
        [BindProperty] public List<int> Booking { get; set; }



        public async Task OnGet(int opgaveId)
        {


            var businessModel2 = await _service.GetAllAnsatDerKanLaveOpgaven(opgaveId);

            AnsatIndexViewModel = new List<AnsatIndexViewModel>();

            businessModel2?.ToList().ForEach(dto => AnsatIndexViewModel.Add(new AnsatIndexViewModel
            {
                AnsatName = dto.AnsatName,
                AnsatTelefon = dto.AnsatTelefon,
                AnsatID = dto.AnsatID,
                AnsatType = dto.AnsatType,
                UserID = dto.UserID,
            }));
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();
            

            var dto = new BookingCreateRequestDto
            {
                BookingName = BookingModel.BookingName,
                OpgaveID = opgaveId,
                ProjektID = BookingProjektID,
                AnsatID = BookingAnsatID,
                SlutDato = BookingModel.SlutDato,
                StartDato = BookingModel.StartDato,
            };

            await _service.CreateBooking(dto);



            return new RedirectToPageResult("/Projekt/IndexProjekt");
        }
    }
}
