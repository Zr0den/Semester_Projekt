using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using StamData.Application.Ansat.AnsatCommands;
using StamData.Application.Ansat.AnsatQueries;

namespace Semester_Projekt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnsatController : Controller
    {
        private readonly ICreateAnsatCommand _createAnsatCommand;
        private readonly IAnsatGetAllQuery _ansatGetAllQuery;

        public AnsatController(ICreateAnsatCommand createAnsatCommand, IAnsatGetAllQuery ansatGetAllQuery)
        {
            _createAnsatCommand = createAnsatCommand;
            _ansatGetAllQuery = ansatGetAllQuery;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Post([FromBody] AnsatCreateRequestDto request)
        {
            _createAnsatCommand.Create(request);
        }
        [HttpGet("{ansatId}")]
        public IEnumerable<AnsatQueryResultDto> Get(string userId)
        {
            return _ansatGetAllQuery.GetAll(userId);
        }
    }
}
