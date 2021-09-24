using Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface ILogStoreLocation
    {
        public void Create(LogRequest request);
    }
}
