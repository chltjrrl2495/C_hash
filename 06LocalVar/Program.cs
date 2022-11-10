using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 클래스 안에 있으면 맴버변수
    int Att;
    int Hp;
    
    void Fight()
    {
        int Damage = 0;
        Console.WriteLine("플레이어가 싸운다.");
    }
}



namespace _06LocalVar
{
    // C#은 고지식한 객체지향 언어(클래스밖에 모르는 바보)
    // 프로그램의 시작조차도 클래스 안에 묶어놔야 한다.
    class Program
    {
        static void Main(string[] args) // 시작용 함수
        {
            
            // 함수안에 있다면 지역변수(선언되는순간 메모리화)
            int ATT = 0;
            ATT = 50;
            // 객체화라고 하는 굉장히 중요한 작업
            Player NewPlayer1 = new Player();  // Player의 설계대로 new Player를 만드는데 그 이름은 NewPlayer
            Player NewPlayer2 = new Player();  // Player의 설계대로 new Player를 만드는데 그 이름은 NewPlayer
            Console.WriteLine("지역 변수를 공부해봅시다");

        }
    }
}