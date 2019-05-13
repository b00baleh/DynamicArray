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
            arr[10] = 123;
            Console.WriteLine(arr[10]);

            for(var i=0; i< 300; i++)
                arr[i] = i;

            for (var i = 0; i < arr.Length(); i++)
                Console.Write(arr[i] + " ");
            Console.ReadLine();
        }
    }
}
