using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public int At = 10;
    public int Hp = 100;

    public void Att(Monster _Monster)
    {
        _Monster.Hp -= At;
    }
}

class Monster
{
    public int At = 10;
    public int Hp = 100;

    public void Att(Player _Player)
    {
        _Player.Hp -= At;
    }
}

namespace _12Memory02_Reference_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 값형과 레퍼런스 형을 구분할 줄 알아야 한다.
            // 기본자료형을 선언만 하면 그것은 값형
            
            // 자기가 만든 클래스를 new 클래스명();
            // 해서 만든것을 그 클래스명에 받으면
            // 그건 레퍼런스 형이다.
            
            // Reference는 힙에 생성된 어떠한 메모리의 위치를 가리키는 값이다.
            // Hp:100 At:10
            Monster NewMonster = new Monster();
            
            // Hp:100 At:10
            Player NewPlayer = new Player();

            NewMonster.Att(NewPlayer);
            NewPlayer.Att(NewMonster);
        }
    }
}
