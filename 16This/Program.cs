using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{

    private int Hp = 100;
    private int At = 10;
    // 정적 맴버변수만을 정적 맴버함수에서 사용할 수 있다.
    private static int StTest = 100;

    // static 맴버함수는 객체를 만들지 않고도 사용할 수 있으므로 this라는 개념이 없다.
    public static void PVP(Player _Left, Player _Right)
    {
        StTest = 50;
        _Left.Hp -= _Right.At;
        _Right.Hp -= _Left.At;
    }
    public void Damage(int _Damage)
    {
        Hp -= _Damage;
    }
    public void Heal(int _Heal)
    {
        Hp += _Heal;
    }
    
    public static void PVP(Player _this, int _Damage)
    {
        _this.Hp -= _Damage;  
    }
}

namespace _16This
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            Player.PVP(NewPlayer1, 100);
        }
    }
}
