using Business.Dto;

namespace Business.Interfaces
{
    public interface IReadableLogLocation
    {
        public LogRequest All();

        // Nežinau, ar key tikrai bus int
        public bool Exists(int key);
        
        // Nežinau, ar key tikrai bus int
        public LogDto Get(int key);
    }
}
