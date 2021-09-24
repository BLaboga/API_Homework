using Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IReadableLogLocation
    {
        public IEnumerable<LogDto> All();

        // Nežinau, ar key tikrai bus int
        public LogDto Get(int key);

        // Nežinau, ar key tikrai bus int
        public bool Exists(int key);
    }
}
