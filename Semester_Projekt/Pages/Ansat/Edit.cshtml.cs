using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using AnsatEditRequestDto = Semester_Projekt.Infrastructure.Contract.Dto.Ansat.AnsatEditRequestDto;


namespace Semester_Projekt.Pages.Ansat
{
    public class EditModel : PageModel
    {
        private readonly IService _service;

        public EditModel(IService service)
        {
            _service = service;
        }
        [BindProperty]
        public AnsatEditViewModel AnsatModel { get; set; }
        public async Task<IActionResult> OnGet(int? ansatId)
        {
            if (ansatId == null) return NotFound();

            var dto = await _service.Get(ansatId.Value, User.Identity?.Name ?? string.Empty);

            AnsatModel = new AnsatEditViewModel
            {
                AnsatType = dto.AnsatType,
                AnsatTelefon = dto.AnsatTelefon,
                AnsatName = dto.AnsatName,
                AnsatID = dto.AnsatID,
            };

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            await _service.Edit(new AnsatEditRequestDto
            {
                AnsatType = AnsatModel.AnsatType,
                AnsatID = AnsatModel.AnsatID,
                AnsatName = AnsatModel.AnsatName,
                AnsatTelefon = AnsatModel.AnsatTelefon,
                UserId = User.Identity?.Name ?? string.Empty,
            });

            return RedirectToPage("./Index");

        }

    }
}
