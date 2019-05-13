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

        private void Put(int i, T element)
        {
            if (_arr == null)
            {
                _currSize = i * 2;
                _arr = new T[_currSize];
                _arr[i] = element;
            }
            else if (i >= _currSize)
            {
                var newArr = new T[i * 2];
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

        public long Length()
        {
            return _arr.Length;
        }

        public T this[int i]
        {
            get { return _arr[i]; }
            set { Put(i, value); }
        }
    }
}
