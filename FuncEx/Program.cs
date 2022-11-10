using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 접근제한 지정자를 입력하지 않으면
    // 디폴트로 private(외부에 공개X) - 속성들은 외부에서 접근하지 못하는게 일반적으로 좋다.
    private int At = 10;
    private int Hp = 100;
    private int Lv = 1;

    public int ShowLv()
    {
        return Lv; // return을 치는 순간 함수가 끝이고 아래에 친 코드들은 모두 의미가 없다.
        Lv = 1000;
    }
    public void LvUp()
    {
        Lv += 1;
        At += 10;
        Hp += 100;
    }
    public void SetHp(int _Hp)
    {
        Hp = _Hp;
    }
    public void ShowStatus()
    {
        Console.WriteLine(Hp);
        Console.WriteLine(At);
    }
    public void Damage1(int _Dmg)
    {
        Hp -= _Dmg;

    }
    public void Damage2(int _Dmg, int _SubDmg)
    {
        Hp -= _Dmg;
        Hp -= _SubDmg;
    }

    // 리턴값은 자신이 return해주려는 자료형과
    // 동일한 자료형 이어야 한다.
    public int DamageToHpReturn(int _Dmg)
    {
        Hp -= _Dmg;
        return Hp;
    }
}

namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args) // 시작용 함수
        {
            Player NewPlayer = new Player();  // Player의 설계대로 new Player를 만드는데 그 이름은 NewPlayer

            // 이런식으로 외부의 값을 받아서
            // 객체가 내부의 상태를 변화시키기 위해서
            // 함수를 선언하는 경우가 많습니다.
            NewPlayer.ShowStatus();
            NewPlayer.SetHp(1000);
            NewPlayer.DamageToHpReturn(100);
            NewPlayer.ShowStatus();
        }
    }
}
