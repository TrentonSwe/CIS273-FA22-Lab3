using System;
using System.Collections;
using System.Collections.Generic;

namespace Set
{
    public class Set<T> : ISet<T>
    {
        public int Size => Elements.Count;

        public List<T> Elements {get;}

        public void Add(Iset<T> s)
        {
            int newSetSize = s.Size;

            for (int i=0, i < newSetSize; i++)
            {
                if (Elements.Contains(s.Elements[i]) == false)
                {
                    Elements.Add(s.Elements)
                }
            }
        }

        public void Add(T value)
        {
            if (Elements.Contains(value) == false)
            {
                Elements.Add(value)
            }
        }
        
        public bool Contains(T value)
        {
            return Elements.Contains(value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)Elements;
        }

        public void Remove(Iset<T> s)
        {
            int newSetSize = s.Size;

            for(int i=0; i < newSetSize; i++)
            {
                if (Elements.Contains(s.Elements[i]))
                {
                    Elements.Remove(s.Elements);
                }
            }
        }

        public void Remove(T value)
        {
            if (Elements.Contains(value))
            {
                Elements.Remove(value)
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)Elements;
        }
    }

}
