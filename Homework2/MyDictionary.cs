using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    class MyDictionary<T>
    {
        T[] _array;
        public MyDictionary()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {

        }

        public int Count
        {
            get { return _array.Length; }
            
        }

    }
}
