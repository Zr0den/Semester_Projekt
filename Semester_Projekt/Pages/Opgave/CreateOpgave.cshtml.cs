using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Opgave;
using Semester_Projekt.Pages.Kompetence;

namespace Semester_Projekt.Pages.Opgave
{
    public class CreateOpgaveModel : PageModel
    {
        private readonly IService _service;

        public CreateOpgaveModel(IService service)
        {
            _service = service;
        }
        [BindProperty]
        public OpgaveCreateViewModel OpgaveModel { get; set; } = new();
        [BindProperty] public List<KompetenceIndexViewModel> KompetenceModel { get; set; } = new();
        [BindProperty] public int Kompetence { get; set; }

        public async Task OnGet()
        {
            var businessModel = await _service.GetAllKompetence();

            KompetenceModel = new List<KompetenceIndexViewModel>();

            businessModel?.ToList().ForEach(dto => KompetenceModel.Add(new KompetenceIndexViewModel()
            {
                KompetenceID = dto.KompetenceID,
                KompetenceName = dto.KompetenceName,
            }));
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            var dto = new OpgaveCreateRequestDto
            {
                OpgaveName = OpgaveModel.OpgaveName,
                OpgaveType = OpgaveModel.OpgaveType,
                KompetenceID = Kompetence,
            };

            await _service.CreateOpgave(dto);

            return new RedirectToPageResult("/Opgave/IndexOpgave");
        }
    }
}
