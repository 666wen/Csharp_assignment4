using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignment4
{
    public class GenericRepository<T>: IRepository<T>
    {
        List<T> l=new List<T>();
        void Add(T item)
        {
            l.Add(item);
        }
        void Remove(T item)
        {
            l.Remove(item);
        }
        void Save()
        {
            Console.WriteLine("save successfully!");
        }
        IEnumerable<T> GetAll()
        {
            return l;
        }
        T GetById(int id)
        {
            return l[id];
        }
    }
}
