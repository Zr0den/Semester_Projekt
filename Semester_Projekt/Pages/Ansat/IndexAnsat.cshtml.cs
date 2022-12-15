using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NuGet.ProjectModel;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Ansat;
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
        //[BindProperty] public List<AnsatQueryResultDto> AnsatKompetencer { get; set; } = new();

        [BindProperty] public List<KompetenceIndexViewModel> KompetenceIndexViewModel { get; set; } = new();


        public async Task OnGet()
        {
            var businessModel = await _service.GetAllAnsat(User.Identity?.Name ?? string.Empty);
                
            AnsatIndexViewModel = new List<AnsatIndexViewModel>();

            businessModel?.ToList().ForEach(dto => AnsatIndexViewModel.Add(new AnsatIndexViewModel
            {
                AnsatName = dto.AnsatName,
                AnsatTelefon = dto.AnsatTelefon,
                AnsatID = dto.AnsatID,
                AnsatType = dto.AnsatType,
                UserID = dto.UserID,
                
            }));

            //AnsatKompetencer = new List<AnsatQueryResultDto>();

            //businessModel?.ToList().ForEach(k => AnsatKompetencer.Add(new AnsatQueryResultDto
            //{
            //    KompetenceEntities = k.KompetenceEntities,
            //}));




        }
    }
}
