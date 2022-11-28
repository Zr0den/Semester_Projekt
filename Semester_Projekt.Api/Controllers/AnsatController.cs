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
        private readonly IEditAnsatCommand _editAnsatCommand;

        public AnsatController(ICreateAnsatCommand createAnsatCommand, IAnsatGetAllQuery ansatGetAllQuery, IEditAnsatCommand editAnsatCommand)
        {
            _createAnsatCommand = createAnsatCommand;
            _ansatGetAllQuery = ansatGetAllQuery;
            _editAnsatCommand = editAnsatCommand;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Post([FromBody] AnsatCreateRequestDto request)
        {
            _createAnsatCommand.Create(request);
        }
        [HttpGet("{userId}/{ansatId}")]
        public IEnumerable<AnsatQueryResultDto> GetAll(string userId, int ansatId)
        {
            return _ansatGetAllQuery.GetAll(userId);
        }
        [HttpGet("{userId}")]
        public IEnumerable<AnsatQueryResultDto> Get(string userId)
        {
            return _ansatGetAllQuery.GetAll(userId);
        }

        [HttpPut]
        public void Put([FromBody] AnsatEditRequestDto request)
        {
            _editAnsatCommand.Edit(request);
        }
    }
}
