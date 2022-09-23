using Homework4.Core.Entities;

namespace Homework4.Core.Interfaces
{
    public interface IParrotService
    {
        void Create(Parrot parrot);
        Parrot Get(int id);
        List<Parrot> GetAll();
        void Update(Parrot parrot);
        void Delete(int id);
    }

}
