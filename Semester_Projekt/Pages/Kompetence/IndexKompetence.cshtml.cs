using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Contract.Dto.Kompetence;
using StamData.Domain.Kompetencer.KompetenceModel;

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
    }
}

