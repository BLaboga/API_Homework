using Api.LogLocations;
using Business;
using Business.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogController : ControllerBase
    {
        public readonly ILogStoreLocation location;

        public LogController()
        {
            location = GetLogStoreLocation();
        }

        [HttpPost]
        public ActionResult<LogDto> Create(LogRequest request)
        {
            location.Create(request);
            // Tik čia dar reiktų request.ConvertToLogDto() ar kažką tokio
            return Created(nameof(Create), new LogDto());
        }

        [HttpGet]
        public ActionResult<IEnumerable<LogDto>> All()
        {
            IReadableLogLocation readableLocation = location as IReadableLogLocation;

            if (readableLocation == null)
                return NotFound();
            // Gal reiktų geresnio return tipo
            // Lyg ir yra kažkoks unable to process request

            return Ok(readableLocation.All());
        }

        [HttpGet("{key:int}")]
        public ActionResult<LogDto> Get(int key)
        {
            IReadableLogLocation readableLocation = location as IReadableLogLocation;

            if (readableLocation == null)
                return NotFound();
            // Unable to process request

            if (!readableLocation.Exists(key))
                return NotFound();

            return Ok(readableLocation.Get(key));
        }

        public static ILogStoreLocation GetLogStoreLocation()
        {
            // Šitą dalį nuskaitom iš appsettings.json
            int storeLocationSelection = 1;

            Dictionary<int, ILogStoreLocation> locations = new Dictionary<int, ILogStoreLocation>
            {
                { 1, new LogConsole() },
                { 2, new LogEmail() },
                { 3, new LogFile() },
                { 4, new LogDb() }
            };

            ILogStoreLocation location = locations[storeLocationSelection];

            return location;
        }
    }
}
