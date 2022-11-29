using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using StamData.Application.Kompetencer.KompetenceCommands;
using StamData.Application.Kompetencer.KompetenceQueries;

namespace Semester_Projekt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KompetenceController : Controller
    {
        private readonly ICreateKompetenceCommand _createKompetenceCommand;
        private readonly IEditKompetenceCommand _editKompetenceCommand;
        private readonly IKompetenceGetAllQuery _kompetenceGetAllQuery;

        public KompetenceController(ICreateKompetenceCommand createKompetenceCommand, IEditKompetenceCommand editKompetenceCommand, IKompetenceGetAllQuery kompetenceGetAllQuery)
        {
            _createKompetenceCommand = createKompetenceCommand;
            _editKompetenceCommand = editKompetenceCommand;
            _kompetenceGetAllQuery = kompetenceGetAllQuery;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Post([FromBody] KompetenceCreateRequestDto request)
        {
            _createKompetenceCommand.CreateKompetence(request);
        }
        [HttpGet("{kompetenceId}")]
        public ActionResult<IEnumerable<KompetenceQueryResultDto>> GetAll()
        {
            var result = _kompetenceGetAllQuery.GetAllKompetence().ToList();
            if(!result.Any())
                return NotFound();
            return result.ToList();
        }

        [HttpPut]
        public void Put([FromBody] KompetenceEditRequestDto request)
        {
            _editKompetenceCommand.EditKompetence(request);
        }
    }
}
