using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Opgave.Application.OpgaveCommands;
using Opgave.Application.OpgaveQueries;


namespace Semester_Projekt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpgaveController : Controller
    {
        private readonly ICreateOpgaveCommand _createOpgaveCommand;
        private readonly IEditOpgaveCommand _editOpgaveCommand;
        private readonly IOpgaveGetAllQuery _opgaveGetAllQuery;
        private readonly IOpgaveGetQuery _opgaveGetQuery;

        public OpgaveController(ICreateOpgaveCommand createOpgaveCommand, IEditOpgaveCommand editOpgaveCommand, IOpgaveGetAllQuery opgaveGetAllQuery, IOpgaveGetQuery opgaveGetQuery)
        {
            _createOpgaveCommand = createOpgaveCommand;
            _editOpgaveCommand = editOpgaveCommand;
            _opgaveGetAllQuery = opgaveGetAllQuery;
            _opgaveGetQuery = opgaveGetQuery;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Post([FromBody] OpgaveCreateRequestDto request)
        {
            _createOpgaveCommand.CreateOpgave(request);
        }
        [HttpGet]
        public ActionResult<IEnumerable<OpgaveQueryResultDto>> GetAll()
        {
            var result = _opgaveGetAllQuery.GetAllOpgave().ToList();
            if (!result.Any())
                return NotFound();
            return result.ToList();
        }

        [HttpGet("{opgaveId}")]
        public ActionResult<OpgaveQueryResultDto> Get(int opgaveId)
        {
            return _opgaveGetQuery.GetOpgave(opgaveId);
        }

        [HttpPut]
        public void Put([FromBody] OpgaveEditRequestDto request)
        {
            _editOpgaveCommand.EditOpgave(request);
        }
    }
}
