using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;

namespace Semester_Projekt.Pages.Opgave
{
    public class IndexOpgaveModel : PageModel
    {
        private readonly IService _service;

        public IndexOpgaveModel(IService service)
        {
            _service = service;
        }
        [BindProperty] public List<OpgaveIndexViewModel> OpgaveModel { get; set; } = new();

        public async Task OnGet()
        {
            var businessModel = await _service.GetAllOpgave();

            OpgaveModel= new List<OpgaveIndexViewModel>();

            businessModel?.ToList().ForEach(dto => OpgaveModel.Add(new OpgaveIndexViewModel
            {
                OpgaveID = dto.OpgaveID,
                OpgaveName = dto.OpgaveName,
                OpgaveType = dto.OpgaveType,
                KompetenceID = dto.KompetenceID,

            }));
        }
    }
}
