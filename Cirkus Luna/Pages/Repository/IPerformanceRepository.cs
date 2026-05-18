namespace Eksamen.Repository;
using Eksamen.Model;

    public interface IPerformanceRepository
    {
        public List<Performance> GetAll();
        public Performance GetById(int id);

        public void Add(Performance performance);
        public void Update(Performance performance);

        public void Delete(Performance performance);

    }

