using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Projekt;

namespace Semester_Projekt.Pages.Projekt
{
    public class CreateProjektModel : PageModel
    {
        private readonly IService _service;

        public CreateProjektModel(IService service)
        {
            _service = service;
        }
        [BindProperty]
        public ProjektCreateViewModel ProjektModel { get; set; } = new();
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            var dto = new ProjektCreateRequestDto
            {
                ProjektName = ProjektModel.ProjektName,
                KundeID = ProjektModel.KundeID,
                SælgerID = ProjektModel.SælgerID
            };

            await _service.CreateProjekt(dto);

            return new RedirectToPageResult("/Projekt/IndexProjekt");
        }
    }
}
