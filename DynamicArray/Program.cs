using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new DynArray<int>();
            arr.Put(10, 123);
            Console.WriteLine(arr.Get(10));

            for(var i=0; i< 1000; i++)
                arr.Put(i,i);

            for (var i = 0; i < arr.Length(); i++)
                Console.Write(arr.Get(i) + " ");
            Console.ReadLine();
        }
    }
}
