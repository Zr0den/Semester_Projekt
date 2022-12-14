using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Projekt;
using Semester_Projekt.Pages.Ansat;
using Semester_Projekt.Pages.Kunde;

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
        [BindProperty] public List<KundeIndexViewModel> KundeIndexViewModel { get; set; } = new();
        [BindProperty] public AnsatIndexViewModel AnsatIndexViewModel { get; set; } = new();
        [BindProperty] public int Kunde { get; set; }





        public async Task OnGet()
        {
            var businessModel = await _service.GetAllKundeIndex();

            KundeIndexViewModel = new List<KundeIndexViewModel>();

            businessModel?.ToList().ForEach(dto => KundeIndexViewModel.Add(new KundeIndexViewModel
            {
                KundeName = dto.KundeName,
                KundeID = dto.KundeID,
                KundeAdresse = dto.KundeAdresse,
                KundeCVR = dto.KundeCVR,
                KundePostNr = dto.KundePostNr,
                KUserID = dto.KUserID,
            }));

            //var businessModel2 = await _service.GetAllAnsatIndex();

            //AnsatIndexViewModel = new AnsatIndexViewModel();

            //businessModel2?.ToList().ForEach(dto => AnsatIndexViewModel.Equals(new AnsatIndexViewModel
            //{
            //    AnsatID = dto.AnsatID
            //}));
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            var dto = new ProjektCreateRequestDto
            {
                ProjektName = ProjektModel.ProjektName,
                KundeID = Kunde,
                UserID = User.Identity?.Name ?? string.Empty,
            };

            await _service.CreateProjekt(dto);

            return new RedirectToPageResult("/Projekt/IndexProjekt");
        }
    }
}
