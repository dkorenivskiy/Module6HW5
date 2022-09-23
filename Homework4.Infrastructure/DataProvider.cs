using Homework4.Core.Entities;
using Homework4.Core.Interfaces;

namespace Homework4.Infrastructure
{
    public class DataProvider : IDataProvider
    {
        private readonly List<Parrot> _parrots;

        public DataProvider()
        {
            _parrots = new List<Parrot>();
        }

        public void Create(Parrot parrot)
        {
            _parrots.Add(parrot);
        }

        public void Delete(int id)
        {
            int index = _parrots.FindIndex(x => x.Id == id);
            _parrots.RemoveAt(index);
        }

        public Parrot Get(int id)
        {
            return _parrots.FirstOrDefault(x => x.Id == id);
        }

        public List<Parrot> GetAll()
        {
            return _parrots;
        }

        public void Update(Parrot parrot)
        {
            int index = _parrots.FindIndex(x => x.Id == parrot.Id);
            _parrots[index] = parrot;
        }
    }
}