using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NuGet.ProjectModel;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Pages.Kompetence;

namespace Semester_Projekt.Pages.Ansat
{
    public class IndexModel : PageModel
    {
        private readonly IService _service;

        public IndexModel(IService service)
        {
            _service = service;
        }

        [BindProperty] public List<AnsatIndexViewModel> AnsatIndexViewModel { get; set; } = new();
        //[BindProperty] public List<KompetenceIndexViewModel> KompetenceIndexViewModel { get; set; } = new();


        public async Task OnGet()
        {
            var businessModel = await _service.GetAllAnsat();
                
            AnsatIndexViewModel = new List<AnsatIndexViewModel>();

            businessModel?.ToList().ForEach(dto => AnsatIndexViewModel.Add(new AnsatIndexViewModel
            {
                AnsatName = dto.AnsatName,
                AnsatTelefon = dto.AnsatTelefon,
                AnsatID = dto.AnsatID,
                AnsatType = dto.AnsatType,
                UserId = dto.UserId,
            }));

            //var businessmodel2 = await _service.GetAllKompetence();

            //KompetenceIndexViewModel = new List<KompetenceIndexViewModel>();

            //businessmodel2?.ToList().ForEach(dto2 => KompetenceIndexViewModel.Add(new KompetenceIndexViewModel
            //{
            //    KompetenceName = dto2.KompetenceName,
            //}));
        }
    }
}