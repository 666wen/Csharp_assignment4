using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignment4
{
    public class MyList<T>
    {
        public List<T> Lt { get; set; }
        public int Cnt { get; set; }

        public MyList()
        {
            Lt = new List<T>();
            Cnt = 0;
        }

        public void Add(T element)
        { 
            Lt.Add(element);
            Cnt++;
        }

        public T Remove(int index)
        {
            T temp=Lt[index];
            Lt.RemoveAt(index);
            Cnt--;
            return temp;
        }

        public bool Contains(T element)
        {
            foreach (T item in Lt)
            {
                if(item.Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            Lt.Clear();
            Cnt=0;
        }

        public void InsertAt(T element, int index)
        {
            List<T> temp = new List<T>();
            int i = 0;
            bool flag = true;
            Cnt++;
            while(i<Cnt)
            {
                if(i==index && flag)
                {
                    temp.Add(element);
                    flag=false;
                    continue;
                }
                temp.Add(Lt[i]);
                i++;
            }
        }

        public void DeleteAt(int index)
        {
            if(index<Cnt)
            {
                Lt.RemoveAt(index);
                Cnt--;
            }else
            {
                throw new IndexOutOfRangeException();
            }
            
        }

        public T Find(int index)
        {
            if (index < Cnt)
            {
                return Lt[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }









    }
}
