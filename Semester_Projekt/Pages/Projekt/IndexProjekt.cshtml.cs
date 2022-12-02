using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;

namespace Semester_Projekt.Pages.Projekt
{
    public class IndexProjektModel : PageModel
    {
        private readonly IService _service;

        public IndexProjektModel(IService service)
        {
            _service = service;
        }
        [BindProperty] public List<ProjektIndexViewModel> ProjektIndexViewModel { get; set; } = new();

        public async Task OnGet()
        {
            var businessModel = await _service.GetAllProjekt();

            ProjektIndexViewModel = new List<ProjektIndexViewModel>();

            businessModel?.ToList().ForEach(dto => ProjektIndexViewModel.Add(new ProjektIndexViewModel
            {
                ProjektName = dto.ProjektName,
                ProjektID = dto.ProjektID,
                SælgerID = dto.SælgerID,
                KundeID = dto.KundeID,
                OprettelsesDato = dto.OprettelsesDato,
                EstimeretSlutDato = dto.EstimeretSlutDato,


            }));
        }
    }
}
