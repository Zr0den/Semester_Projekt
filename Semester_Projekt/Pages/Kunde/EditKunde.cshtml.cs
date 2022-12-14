using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Kunde;
using Semester_Projekt.Pages.Kompetence;

namespace Semester_Projekt.Pages.Kunde
{
    public class EditKundeModel : PageModel
    {
        private readonly IService _service;

        public EditKundeModel(IService service)
        {
            _service = service;
        }
        [BindProperty]
        public KundeEditViewModel KundeModel { get; set; }


        public async Task<IActionResult> OnGet(int? kundeId)
        {
            if (kundeId == null) return NotFound();

            var dto = await _service.GetKunde(kundeId.Value, User.Identity?.Name ?? string.Empty);

            KundeModel = new KundeEditViewModel
            {
                KundeID = dto.KundeID,
                KundeAdresse = dto.KundeAdresse,
                KundeCVR = dto.KundeCVR,
                KundePostNr = dto.KundePostNr,
                KundeName = dto.KundeName
            };

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            await _service.EditKunde(new KundeEditRequestDto
            {
                KundeAdresse = KundeModel.KundeAdresse,
                KundeID = KundeModel.KundeID,
                KundeName = KundeModel.KundeName,
                KundeCVR = KundeModel.KundeCVR,
                KundePostNr = KundeModel.KundePostNr,
                KUserID =  User.Identity?.Name ?? string.Empty,
            });

            return RedirectToPage("./IndexKunde");

        }
    }
}
