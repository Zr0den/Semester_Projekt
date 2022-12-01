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
        private readonly IAnsatGetQuery _ansatGetQuery;

        public AnsatController(ICreateAnsatCommand createAnsatCommand, IAnsatGetAllQuery ansatGetAllQuery, IEditAnsatCommand editAnsatCommand, IAnsatGetQuery ansatGetQuery)
        {
            _createAnsatCommand = createAnsatCommand;
            _ansatGetAllQuery = ansatGetAllQuery;
            _editAnsatCommand = editAnsatCommand;
            _ansatGetQuery = ansatGetQuery;
        }

        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[Consumes(MediaTypeNames.Application.Json)]
        [HttpPost]
        public void Post([FromBody] AnsatCreateRequestDto request)
        {
            _createAnsatCommand.CreateAnsat(request);
        }
        [HttpGet]
        public ActionResult<IEnumerable<AnsatQueryResultDto>> GetAll()
        {
            var result = _ansatGetAllQuery.GetAllAnsat().ToList();
            if (!result.Any())
                return NotFound();

            return result.ToList();
        }
        [HttpGet("{ansatId}")]
        public AnsatQueryResultDto GetAnsat(int ansatId)
        {
            return _ansatGetQuery.GetAnsat(ansatId);
        }

        [HttpPut]
        public void Put([FromBody] AnsatEditRequestDto request)
        {
            _editAnsatCommand.EditAnsat(request);
        }
    }
}
