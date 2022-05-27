using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignment4
{
    public class MyStack<T>
    {
        public List<T> St { get; set; }
        public int Cnt { get; set; }

        public MyStack()
        {
            St = new List<T>();
            Cnt = 0;
        }
        public int Count ()
        { 
            return Cnt; 
        }

        public T Pop()
        {
            T temp=St[Cnt];
            St.RemoveAt(Cnt);
            Cnt--;
            return temp;
        }

        public void Push(T item)
        {
            St.Add(item);
            Cnt++;
        }


    }
}
