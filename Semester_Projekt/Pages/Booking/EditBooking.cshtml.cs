using Domain.Opgave.OpgaveModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Semester_Projekt.Areas.Identity.Data;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Booking;
using Semester_Projekt.Infrastructure.Contract.Dto.Projekt;
using Semester_Projekt.Pages.Ansat;
using Semester_Projekt.Pages.Opgave;
using SqlServerContext;

namespace Semester_Projekt.Pages.Booking
{
    public class EditBookingModel : PageModel
    {
        private readonly IService _service;

        public EditBookingModel(IService service)
        {
            _service = service;
        }

        public BookingEditViewModel BookingModel { get; set; }
        public List<BookingIndexViewModel> BookingIndexModel { get; set; }


        public List<OpgaveIndexViewModel> OpgaveModel { get; set; }

        public List<AnsatIndexViewModel> AnsatIndexViewModel { get; set; }
        [BindProperty] public int BookingAnsatID { get; set; }
        [BindProperty] public List<int> Booking { get; set; }



        public async Task OnGet()
        {
            var businessModel = await _service.GetAllAnsatIndex();

            AnsatIndexViewModel = new List<AnsatIndexViewModel>();

            businessModel?.ToList().ForEach(dto => AnsatIndexViewModel.Add(new AnsatIndexViewModel
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

            await _service.EditBooking(new BookingEditRequestDto
            {
                AnsatID = BookingAnsatID,
            });

            return RedirectToPage("/Projekt/IndexProjekt");

        }
    }
}
