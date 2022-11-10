using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int Hp=100;
    int At=10;

    // 함수의 인자값은
    // 지역변수이다.
    // int_Dmg 지역변수의 특징
    // 함수가 끝나면 사라진다.
    public void Damage(int _Dmg)
    {

    }
}

namespace _10Memory00_Func_
{
    class Program
    {
        static void Main(string[] args) // 시작용 함수
        {
            // 함수는 메모리화 되지 않는다.
            Console.WriteLine("메모리 1차 함수");

            // 지역변수 +a로 계산되는데
            // 최소한 지역변수를 다 포함할 수 있는 크기만큼은
            // 크기가 되어야 한다.
            int Value = 0;
            // 객체를 만들었다는 것은 메모리를 지불했다는 것.
            Player NewPlayer = new Player();
            NewPlayer.Damage(Value);
        }
    }
}