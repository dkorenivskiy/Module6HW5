using Homework4.Core.Entities;
using Homework4.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Core.Impl
{
    public class ParrotService : IParrotService
    {
        private IDataProvider _dataProvider;

        public ParrotService(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public void Create(Parrot parrot)
        {
            _dataProvider.Create(parrot);
        }

        public void Delete(int id)
        {
            if (id < 0)
            {
                return;
            }

            _dataProvider.Delete(id);
        }

        public Parrot Get(int id)
        {
            return _dataProvider.Get(id);
        }

        public List<Parrot> GetAll()
        {
            return _dataProvider.GetAll();
        }

        public void Update(Parrot parrot)
        {
            _dataProvider.Update(parrot);
        }

    }
}
