using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class StClass // static class(정적 클래스)란 정적 맴버변수와 정적 맴버함수만 넣을 수 있다.
{
    static int TEST = 100 ;
    // int TEST = 100;(X)
    static void Test2()
    {
        Console.WriteLine("Hello");
    }
}

public class Player
{
}

namespace _15StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("콘솔 라이트 라인은 ... 정적맴버함수에요");
        }
    }
}
