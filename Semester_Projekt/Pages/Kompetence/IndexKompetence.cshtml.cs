using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Ansat;
using Semester_Projekt.Pages.Ansat;
using StamData.Domain.Ansat.AnsatModel;

namespace Semester_Projekt.Pages.Kompetence
{
    public class IndexModel : PageModel
    {
        private readonly IService _service;

        public IndexModel(IService service)
        {
            _service = service;
        }

        [BindProperty] public List<KompetenceIndexViewModel> KompetenceIndexViewModel { get; set; } = new();
        public AnsatIndexViewModel AnsatIndexViewModel { get; set; }


        [BindProperty] public List<int> Kompetence { get; set; }
         





        public async Task OnGet()
        {
            var businessmodel = await _service.GetAllKompetence();

            KompetenceIndexViewModel = new List<KompetenceIndexViewModel>();

            businessmodel?.ToList().ForEach(dto => KompetenceIndexViewModel.Add(new KompetenceIndexViewModel
            {
                KompetenceID = dto.KompetenceID,
                KompetenceName = dto.KompetenceName,
            }));
        }

        public async Task OnPost()
        {
            var a = new AnsatCreateRequestDto();
            foreach (var k in Kompetence)
            {
                //a.KompetenceEntities.KompetenceID = k;
                //await _service.AddAnsatKompetence(a);
            }
        }
    }
}

