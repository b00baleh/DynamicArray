using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class DynArray<T>
    {
        private T[] _arr;
        private long _currSize;

        public void Put(int i, T element)
        {
            if (_arr == null)
            {
                _currSize = i + 100;
                _arr = new T[_currSize];
                _arr[i] = element;
            }
            else if (i >= _currSize)
            {
                var newArr = new T[i + 100];
                for (var j = 0; j < _arr.Length; j++)
                {
                    newArr[j] = _arr[j];
                }
                _arr = newArr;
                _arr[i] = element;
            }
            else
            {
                _arr[i] = element;
            }
        }

        public T Get(int i)
        {
            return _arr[i];
        }

        public long Length()
        {
            return _arr.Length;
        }
    }
}
