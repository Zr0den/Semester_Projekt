using Application.StamData.Kunde.KundeCommands;
using Application.StamData.Kunde.KundeQueries;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet("{userID}")]
        public ActionResult<IEnumerable<KundeQueryResultDto>> GetAll(string userID)
        {
            var result = _kundeGetAllQuery.GetAllKunde(userID).ToList();
            //if (!result.Any())
            //    return NotFound();

            return result.ToList();
        }
        [HttpGet]
        public ActionResult<IEnumerable<KundeQueryResultDto>> GetAllIndex()
        {
            var result = _kundeGetAllQuery.GetAllKundeIndex().ToList();
            //if (!result.Any())
            //    return NotFound();

            return result.ToList();
        }
        [HttpGet("{kundeId}/{userID}")]
        public KundeQueryResultDto GetKunde(int kundeId, string userID)
        {
            return _kundeGetQuery.GetKunde(kundeId, userID);
        }

        [HttpPut]
        public void Put([FromBody] KundeEditRequestDto request)
        {
            _editKundeCommand.EditKunde(request);
        }
    }
}
