using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// static
class Player
{
    // 일반적인 맴버변수와 다른점
    // static을 붙이게 되면
    // 정적 맴버변수라고 합니다.
    // 정적 맴버변수는 일반적인 맴버변수와 다르게
    // 객체화를 하지 않고도 사용할 수 있다.
    // 그 사용법이 클래스의 이름만으로 사용할수가 있다. 
    public static int PlayerSetCount = 0;

    public int Hp=100;
    public int At=10;

    public void Setting(int _At, int _Hp)
    {
        PlayerSetCount++;
        At = _At;
        Hp = _Hp;
    }
}

namespace _13StaticVar
{
    class Program
    {
        static void Main(string[] args)
        {
            // 플레이어를 3번 new 하게 되면 3개 생긴 것이고
            // 그 3개의 플레이어는 각각의 Hp,At를 갖는다.
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();
            // 이런식으로 객체화를 전혀 하지 않고 사용할 수 있는 녀석을 정적 맴버변수라고 부르고
            // 이런 정적 맴버변수는 데이터 영역에 들어가게 된다.
            
            // 이 맴버변수라고 하는 녀석은 각각 존재한다.
            NewPlayer1.Setting(10, 100);
            NewPlayer2.Setting(20, 50);
            NewPlayer3.Setting(100, 500);

            Console.WriteLine(Player.PlayerSetCount);
        }
    }
}
