using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Kompetence;

namespace Semester_Projekt.Pages.Kompetence
{
    public class EditModel : PageModel
    {
        private readonly IService _service;

        public EditModel(IService service)
        {
            _service = service;
        }
        [BindProperty]
        public KompetenceEditViewModel KompetenceModel { get; set; }
        public async Task<IActionResult> OnGet(int? kompetenceId)
        {
            if (kompetenceId == null) return NotFound();

            var dto = await _service.GetKompetence(kompetenceId.Value);

            KompetenceModel = new KompetenceEditViewModel
            {
                KompetenceID = dto.KompetenceID,
                KompetenceName = dto.KompetenceName,
                RowVersion = dto.RowVersion,
            };

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            await _service.EditKompetence(new KompetenceEditRequestDto
            {
                KompetenceID = KompetenceModel.KompetenceID,
                KompetenceName = KompetenceModel.KompetenceName,
                RowVersion = KompetenceModel.RowVersion,
            });

            return RedirectToPage("./IndexKompetence");

        }
    }
}
