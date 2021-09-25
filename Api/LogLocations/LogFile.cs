using Business.Dto;
using Business.Interfaces;
using System;

namespace Api.LogLocations
{
    public class LogFile : ILogStoreLocation, IReadableLogLocation
    {
        public void Create(LogRequest request)
        {
            throw new NotImplementedException();
        }

        public LogRequest All()
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
