using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Semester_Projekt.Infrastructure.Contract;

namespace Semester_Projekt.Pages.Ansat
{
    public class IndexModel : PageModel
    {
        private readonly IService _service;

        public IndexModel(IService service)
        {
            _service = service;
        }

        [BindProperty] public List<AnsatIndexViewModel> IndexViewModel { get; set; } = new();

        public async Task OnGet()
        {
            var businessModel = await _service.GetAll(User.Identity?.Name ?? string.Empty);
                
            IndexViewModel = new List<AnsatIndexViewModel>();

            businessModel?.ToList().ForEach(dto => IndexViewModel.Add(new AnsatIndexViewModel
            {
                AnsatName = dto.AnsatName,
                AnsatTelefon = dto.AnsatTelefon,
                AnsatID = dto.AnsatID,
                AnsatType = dto.AnsatType,
                UserId = dto.UserId
            }));
        }
    }
}
