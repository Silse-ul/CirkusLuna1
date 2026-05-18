using Eksamen.Model;
using Eksamen.Repository;
using Eksamen.Service;

namespace Eksamen.Repository
    
{
    public class PerformanceRepository : IPerformanceRepository
    {
        private List<Performance> _performanceList;

        public PerformanceRepository()
        { 
            //Tom liste der gemmer de ansatte
            _performanceList = new List<Performance>();

            //Vi smider nogle i fra start
            Performance B = new Performance();
            _performanceList.Add(B);

        }

        public List<Performance> GetAll()
        {
            return _performanceList;
        }

        public Performance GetById(int id)
        {
            foreach (Performance item in _performanceList)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public void Delete(Performance performance)
        {
            throw new NotImplementedException();
        }

        public void Add(Performance performance)
        {
            int Id = _performanceList.Count + 1;
            //bookingsystem.RoomId = nextId; skal vores PId matche noget?
            _performanceList.Add(performance);
        }

        public void Update(Performance performance)
        {
            throw new NotImplementedException();
        }
    }
}
