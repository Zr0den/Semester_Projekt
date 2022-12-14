using System.Net.Mime;
using Application.Projekt.ProjektCommands;
using Application.Projekt.ProjektQueries;
using Microsoft.AspNetCore.Mvc;

namespace Semester_Projekt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjektController : Controller
    {
        private readonly ICreateProjektCommand _createProjektCommand;
        private readonly IEditProjektCommand _editProjektCommand;
        private readonly IProjektGetAllQuery _projektGetAllQuery;
        private readonly IProjektGetQuery _projektGetQuery;

        public ProjektController(ICreateProjektCommand createProjektCommand, IEditProjektCommand editProjektCommand, IProjektGetAllQuery projektGetAllQuery, IProjektGetQuery projektGetQuery)
        {
            _createProjektCommand = createProjektCommand;
            _editProjektCommand = editProjektCommand;
            _projektGetAllQuery = projektGetAllQuery;
            _projektGetQuery = projektGetQuery;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Post([FromBody] ProjektCreateRequestDto request)
        {
            _createProjektCommand.CreateProjekt(request);
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProjektQueryResultDto>> GetAll()
        {
            var result = _projektGetAllQuery.GetAllProjekt().ToList();
            //if (!result.Any())
            //    return NotFound();
            return result.ToList();
        }

        [HttpGet("{projektId}")]
        public ActionResult<ProjektQueryResultDto> Get(int projektId)
        {
            return _projektGetQuery.GetProjekt(projektId);
        }

        [HttpPut]
        public void Put([FromBody] ProjektEditRequestDto request)
        {
            _editProjektCommand.EditProjekt(request);
        }
    }
}
