using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;

namespace Semester_Projekt.Pages.Kunde
{
    public class IndexKundeModel : PageModel
    {
        private readonly IService _service;

        public IndexKundeModel(IService service)
        {
            _service = service;
        }

        [BindProperty] public List<KundeIndexViewModel> KundeIndexViewModel { get; set; } = new();


        public async Task OnGet()
        {
            var businessModel = await _service.GetAllKunde(User.Identity?.Name ?? string.Empty);

            KundeIndexViewModel = new List<KundeIndexViewModel>();

            businessModel?.ToList().ForEach(dto => KundeIndexViewModel.Add(new KundeIndexViewModel
            {
                KundeName = dto.KundeName,
                KundeAdresse = dto.KundeAdresse,
                KundeID = dto.KundeID,
                KundeCVR = dto.KundeCVR,
                KUserID = dto.KUserID,
                KundePostNr = dto.KundePostNr
            }));



        }
    }
}
