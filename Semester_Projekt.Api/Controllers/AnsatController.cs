using System.Net.Mime;
using Application.StamData.Ansat.AnsatCommands;
using Application.StamData.Ansat.AnsatQueries;
using Application.StamData.Ansat.AnsatRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        private readonly IAnsatRepository _ansatRepository;


        public AnsatController(ICreateAnsatCommand createAnsatCommand, IAnsatGetAllQuery ansatGetAllQuery, IEditAnsatCommand editAnsatCommand, IAnsatGetQuery ansatGetQuery, IAnsatRepository ansatRepository)
        {
            _createAnsatCommand = createAnsatCommand;
            _ansatGetAllQuery = ansatGetAllQuery;
            _editAnsatCommand = editAnsatCommand;
            _ansatGetQuery = ansatGetQuery;
            _ansatRepository = ansatRepository;
        }

        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[Consumes(MediaTypeNames.Application.Json)]
        [HttpPost]
        public void Post([FromBody] AnsatCreateRequestDto request)
        {
            _createAnsatCommand.CreateAnsat(request);
        }
        [HttpGet("{userId}")]
        public ActionResult<IEnumerable<AnsatQueryResultDto>> GetAll(string userId)
        {
            var result = _ansatGetAllQuery.GetAllAnsat(userId).ToList();
            if (!result.Any())
                return NotFound();

            return result.ToList();
        }
        [HttpGet("{ansatId}/{userId}")]
        public AnsatQueryResultDto GetAnsat(int ansatId, string userId)
        {
            return _ansatGetQuery.GetAnsat(ansatId, userId);
        }

        [HttpPut]
        public void Put([FromBody] AnsatEditRequestDto request)
        {
            _editAnsatCommand.EditAnsat(request);
        }

        [HttpPost("{ansatId}")]
        public void PostAnsatKompetence(int ansatId)
        {
            _ansatRepository.AddAnsatKompetence(ansatId);
        }
    }
}
