using EntityFramework.Contexts;
using EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportEvents.API.Models;

namespace SportEvents.API.Controllers
{
    /// <summary>
    /// Controller to retrive sporting event data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly ILogger<EventController> _logger;
        private readonly EventContext _context;

        public EventController(ILogger<EventController> logger, EventContext context)
        {
            _logger = logger;
            _context = context;
        }

        /// <summary>
        /// Retrives a specific sporting event by id
        /// </summary>
        /// <param name="id"></param>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Events/GN0JQ6NRDJPPDNP
        ///
        /// </remarks>
        /// <response code="200">Returns the event</response>
        /// <response code="404">No event with specified id was found</response>
        [HttpGet("{id}")]
        public ActionResult<EventData> GetEventById(string id)
        {
            var evt = _context.Events
                .Include(evt => evt.ParentSportEvents)
                .Include(evt => evt.RelatedSportsEvents)
                .Include(evt => evt.Meta)
                .Include(evt => evt.State)
                .Include(evt => evt.WeatherConditions)
                .Include(evt => evt.DateAndTimeInfo)
                .SingleOrDefault(evt => evt.Id.Equals(id));

            if(evt == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(evt);
        }

        /// <summary>
        /// Searches for events based on description, sporting id, sport discipline id or type.  
        /// </summary>
        /// <param name="request"></param>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Events/Search
        ///     {
        ///         "description": "First Set"
        ///     }
        ///
        /// </remarks>
        /// <response code="200">Returns the event</response>
        /// <response code="404">No event with specified id was found</response>
        [HttpPost("search")]
        public ActionResult<SearchResponseModel> SearchEvents(SearchRequestModel request)
        {
            if(request == null)
            {
                return new BadRequestResult();
            }

            var response = new SearchResponseModel();

            var query = _context.Events.AsQueryable();
            if(request.Description != null)
            {
                query = query.Where(evt => evt.Description == request.Description);
            }
            if(request.SportId  != null)
            {
                query = query.Where(evt => evt.SportId == request.SportId);
            }
            if (request.SportsDisciplineId != null)
            {
                query = query.Where(evt => evt.SportsDisciplineId == request.SportsDisciplineId);
            }
            if (request.Type != 0)
            {
                query = query.Where(evt => evt.Type == request.Type);
            }

            var results = query
                .Include(evt => evt.ParentSportEvents)
                .Include(evt => evt.RelatedSportsEvents)
                .Include(evt => evt.Meta)
                .Include(evt => evt.State)
                .Include(evt => evt.WeatherConditions)
                .Include(evt => evt.DateAndTimeInfo)
                .ToList();
            response.Results = results;
            response.Count = results.Count;

            return new OkObjectResult(response);
        }
    }
}
