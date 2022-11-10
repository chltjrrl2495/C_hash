using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17While
{
    class Program
    {
        static void Main(string[] args)
        {
            // 어떤 함수내에서
            // bool 값이 들어가면 된다.
            // while (참/거짓)
            int Count = 0;
            do
            {
                Console.WriteLine(Count);
                Count++;

            } while (Count<=10);
        }
    }
}
