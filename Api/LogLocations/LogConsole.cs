using Business;
using Business.Dto;
using System;

namespace Api.LogLocations
{
    public class LogConsole : ILogStoreLocation
    {
        public void Create(LogRequest request)
        {
            // Tipo
            Console.WriteLine(request.ToString());
            // Tik paprastas .ToString() neveiks – reikės adapterio
        }
    }
}
