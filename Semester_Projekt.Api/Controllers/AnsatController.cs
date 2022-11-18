using Microsoft.AspNetCore.Mvc;
using StamData.Application.Ansat.AnsatCommands;

namespace Semester_Projekt.Api.Controllers
{
    public class AnsatController : Controller
    {
        private readonly ICreateAnsatCommand _createAnsatCommand;

        public AnsatController(ICreateAnsatCommand createAnsatCommand)
        {
            _createAnsatCommand = createAnsatCommand;
        }

        [HttpPost]
        public void Post([FromBody] AnsatCreateRequestDto request)
        {
            _createAnsatCommand.Create(request);
        }
    }
}
