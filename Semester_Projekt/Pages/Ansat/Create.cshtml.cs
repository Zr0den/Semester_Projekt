using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.OpenApi.Extensions;
using Semester_Projekt.Infrastructure.Contract;
using AnsatCreateRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Ansat.AnsatCreateRequestDto;


namespace Semester_Projekt.Pages.Ansat
{
    public class CreateModel : PageModel
    {
        private readonly IService _service;

        public CreateModel(IService service)
        {
            _service = service;
        }
        [BindProperty]
        public AnsatCreateViewModel AnsatModel { get; set; } = new();
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            var dto = new AnsatCreateRequestDto
            {
                AnsatName = AnsatModel.AnsatName,
                AnsatType = AnsatModel.AnsatType,
                AnsatTelefon = AnsatModel.AnsatTelefon,
                UserID = User.Identity?.Name ?? string.Empty,
            };

            await _service.Create(dto);

            return new RedirectToPageResult("/Ansat/Index");
        }

    }
}
