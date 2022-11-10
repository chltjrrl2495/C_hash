using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 객체지향 프로그래밍에서는
// 가장 처음으로 해야할 일이
// 내가 뭘 만들고 싶다.
// 클래스를 선언한다.

class Player
{
    // 객체지향의 캡슐화 은닉화를 대표하는 문법
    // 접근제한 지정자입니다.
    // 이렇게 세가지 접근제한 지정자가 존재
    public int Hp; // 외부에도 공개
    protected int Att; // 자식에게만 공개
    private int Def; // 내부에만 공개

    public void Fight()
    {
        Console.WriteLine("플레이어가 싸운다.");
        
    }
}



namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args) // 시작용 함수
        {
            Player NewPlayer = new Player();  // Player의 설계대로 new Player를 만드는데 그 이름은 NewPlayer

            // 만들어진 객체의 내용을 사용하기 위해서는
            // 객체의 이름.을 사용한다.
            NewPlayer.Hp = 0;
            NewPlayer.Fight();
            
        }
    }
}
