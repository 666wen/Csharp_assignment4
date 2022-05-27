using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignment4
{
    public interface IRepository<T>
    {
        void Add(T item)
        {
            throw new NotImplementedException();
        }
        void Remove(T item)
        {
            throw new NotImplementedException();
        }
        void Save()
        {
            throw new NotImplementedException();
        }
        IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }
        T GetById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
