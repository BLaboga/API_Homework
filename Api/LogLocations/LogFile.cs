using Business;
using Business.Dto;
using System;
using System.Collections.Generic;

namespace Api.LogLocations
{
    public class LogFile : ILogStoreLocation, IReadableLogLocation
    {
        public void Create(LogRequest request)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LogDto> All()
        {
            throw new NotImplementedException();
        }

        public LogDto Get(int key)
        {
            throw new NotImplementedException();
        }

        public bool Exists(int key)
        {
            throw new NotImplementedException();
        }
    }
}
