using Microsoft.AspNetCore.Mvc;
using StamData.Application.Kunde.KundeCommands;
using StamData.Application.Kunde.KundeQueries;

namespace Semester_Projekt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KundeController : Controller
    {
        private readonly ICreateKundeCommand _createKundeCommand;
        private readonly IKundeGetAllQuery _kundeGetAllQuery;
        private readonly IEditKundeCommand _editKundeCommand;
        private readonly IKundeGetQuery _kundeGetQuery;

        public KundeController(ICreateKundeCommand createKundeCommand, IKundeGetAllQuery kundeGetAllQuery, IEditKundeCommand editKundeCommand, IKundeGetQuery kundeGetQuery)
        {
            _createKundeCommand = createKundeCommand;
            _kundeGetAllQuery = kundeGetAllQuery;
            _editKundeCommand = editKundeCommand;
            _kundeGetQuery = kundeGetQuery;
        }

        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[Consumes(MediaTypeNames.Application.Json)]
        [HttpPost]
        public void Post([FromBody] KundeCreateRequestDto request)
        {
            _createKundeCommand.CreateKunde(request);
        }
        [HttpGet("{kundeUserId}")]
        public ActionResult<IEnumerable<KundeQueryResultDto>> GetAll(string kundeUserId)
        {
            var result = _kundeGetAllQuery.GetAllKunde(kundeUserId).ToList();
            if (!result.Any())
                return NotFound();

            return result.ToList();
        }
        [HttpGet("{kundeId}/{kundeUserId}")]
        public KundeQueryResultDto GetKunde(int kundeId, string kundeUserId)
        {
            return _kundeGetQuery.GetKunde(kundeId, kundeUserId);
        }

        [HttpPut]
        public void Put([FromBody] KundeEditRequestDto request)
        {
            _editKundeCommand.EditKunde(request);
        }
    }
}
