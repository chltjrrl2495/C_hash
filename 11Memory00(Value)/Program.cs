using _11Memory00_Value_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int At;
    int Hp;

    public int Test(int _Damage)
    {
        _Damage = 1000;
        return _Damage;
    }

}

namespace _11Memory01_Value_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 함수의 인자값
            int Value = 0;
            Player NewPlayer = new Player();
            Value = NewPlayer.Test(Value);

            Console.WriteLine(Value);
        }
    }
}