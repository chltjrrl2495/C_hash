using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// static
public class Player
{
    int At = 10;
    int Hp = 100;
    static public void PVP(Player _Left, Player _Right)
    {
        _Left.Hp -= _Right.At;
        _Right.Hp -= _Left.At;
    }

    public void Damage(int _Damage)
    {
        Hp -= 100;
    }

    public void Damage(Player _Other)
    {
        // 자기 자신의 레퍼런스는 자신의 내부에서
        // 모두 public인 상태다.
        Hp -= _Other.At;
    }
}

public class Monster
{
    private int At = 100;
    int Hp = 100;
    public void Damage(int _Damage)
    {
        Hp -= 100;

    }
}

namespace _14StaticFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player.PVP(NewPlayer1, NewPlayer2);
        }
    }
}
