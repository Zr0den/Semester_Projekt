using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Kompetence;

namespace Semester_Projekt.Pages.Kompetence
{
    public class CreateModel : PageModel
    {
        private readonly IService _service;

        public CreateModel(IService service)
        {
            _service = service;
        }
        [BindProperty]
        public KompetenceCreateViewModel KompetenceModel { get; set; } = new();
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            var dto = new KompetenceCreateRequestDto
            {
                KompetenceName = KompetenceModel.KompetenceName,
            };

            await _service.CreateKompetence(dto);

            return new RedirectToPageResult("/Kompetence/IndexKompetence");
        }

    }
}
