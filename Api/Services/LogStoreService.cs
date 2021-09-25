using Api.LogLocations;
using Business.Dto;
using Business.Interfaces;
using System.Collections.Generic;

namespace Api.Services
{
    public class LogStoreService : ILogStoreService
    {
        private readonly Dictionary<string, ILogStoreLocation> locations = new Dictionary<string, ILogStoreLocation>
        {
            { "LogConsole", new LogConsole() },
            { "LogEmail", new LogEmail() },
            { "LogFile", new LogFile() },
            { "LogDb", new LogDb() }
        };

        private readonly ILogStoreLocation location;

        public LogStoreService()
        {
            // Lokaciją (pvz. "LogConsole")
            // reikės nuskaityti nuo appsettings.json
            location = locations["LogConsole"];
        }

        public void Create(LogRequest request)
        {
            location.Create(request);
        }

        public bool LocationIsReadable()
        {
            var readableLocation = location as IReadableLogLocation;

            if (readableLocation == null)
                return false;

            return true;
        }

        public LogRequest All()
        {
            var readableLocation = location as IReadableLogLocation;

            return readableLocation.All();
        }

        public bool Exists(int key)
        {
            var readableLocation = location as IReadableLogLocation;

            if (!readableLocation.Exists(key))
                return false;

            return true;
        }

        public LogDto Get(int key)
        {
            var readableLocation = location as IReadableLogLocation;

            return readableLocation.Get(key);
        }
    }
}
