using System.Net.Mime;
using Application.Booking.BookingCommands;
using Application.Booking.BookingQueries;
using Microsoft.AspNetCore.Mvc;

namespace Semester_Projekt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : Controller
    {
        private readonly ICreateBookingCommand _createBookingCommand;
        private readonly IEditBookingCommand _editBookingCommand;
        private readonly IBookingGetAllQuery _bookingGetAllQuery;
        private readonly IBookingGetQuery _bookingGetQuery;

        public BookingController(ICreateBookingCommand createBookingCommand, IEditBookingCommand editBookingCommand, IBookingGetAllQuery BookingGetAllQuery, IBookingGetQuery BookingGetQuery)
        {
            _createBookingCommand = createBookingCommand;
            _editBookingCommand = editBookingCommand;
            _bookingGetAllQuery = BookingGetAllQuery;
            _bookingGetQuery = BookingGetQuery;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Post([FromBody] BookingCreateRequestDto request)
        {
            _createBookingCommand.CreateBooking(request);
        }
        [HttpGet]
        public ActionResult<IEnumerable<BookingQueryResultDto>> GetAll()
        {
            var result = _bookingGetAllQuery.GetAllBooking().ToList();
            //if(!result.Any())
            //    return NotFound();
            return result.ToList();
        }

        [HttpGet("{bookingId}")]
        public ActionResult<BookingQueryResultDto> Get(int bookingId)
        {
            return _bookingGetQuery.GetBooking(bookingId);
        }

        [HttpPut]
        public void Put([FromBody] BookingEditRequestDto request)
        {
            _editBookingCommand.EditBooking(request);
        }
    }
}
