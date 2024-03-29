using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Ansat;
using Semester_Projekt.Pages.Kompetence;
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
        [BindProperty] public List<KompetenceIndexViewModel> KompetenceIndexViewModel { get; set; } = new();
        [BindProperty] public List<int> Kompetence { get; set; }


        public async Task<IActionResult> OnGet(int? ansatId)
        {
            if (ansatId == null) return NotFound();

            var dto = await _service.GetAnsat(ansatId.Value, User.Identity?.Name ?? string.Empty);

            AnsatModel = new AnsatEditViewModel
            {
                AnsatType = dto.AnsatType,
                AnsatTelefon = dto.AnsatTelefon,
                AnsatName = dto.AnsatName,
                AnsatID = dto.AnsatID,
            };

            var businessmodelKompetence = await _service.GetAllKompetence();

            KompetenceIndexViewModel = new List<KompetenceIndexViewModel>();

            businessmodelKompetence?.ToList().ForEach(dto => KompetenceIndexViewModel.Add(new KompetenceIndexViewModel
            {
                KompetenceID = dto.KompetenceID,
                KompetenceName = dto.KompetenceName,
            }));

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            await _service.EditAnsat(new AnsatEditRequestDto
            {
                AnsatType = AnsatModel.AnsatType,
                AnsatID = AnsatModel.AnsatID,
                AnsatName = AnsatModel.AnsatName,
                AnsatTelefon = AnsatModel.AnsatTelefon,
                UserID = User.Identity?.Name ?? string.Empty,
                KompetenceIds = Kompetence
            });


            return RedirectToPage("./IndexAnsat");

        }

    }
}
