using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Projekt;

namespace Semester_Projekt.Pages.Projekt
{
    public class EditProjektModel : PageModel
    {
        private readonly IService _service;

        public EditProjektModel(IService service)
        {
            _service = service;
        }
        [BindProperty]
        public ProjektEditViewModel ProjektModel { get; set; }
        public async Task<IActionResult> OnGet(int? projektId)
        {
            if (projektId == null) return NotFound();

            var dto = await _service.GetProjekt(projektId.Value);

            ProjektModel = new ProjektEditViewModel
            {
                ProjektID = dto.ProjektID,
                ProjektName = dto.ProjektName,
                KundeID = dto.KundeID,
                SælgerID = dto.SælgerID
            };

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            await _service.EditProjekt(new ProjektEditRequestDto
            {
                ProjektID = ProjektModel.ProjektID,
                ProjektName = ProjektModel.ProjektName,
                
            });

            return RedirectToPage("./IndexProjekt");

        }
    }
}
