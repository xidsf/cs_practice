using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// static

class Monster
{
    static int MonsterDeathCount;

    public void Death()
    {
        MonsterDeathCount += 1;
    }
}

class Player
{
    //일반적인 맴버변수와 다르게 static를 붙이게 되면 정적 맴버변수가 된다.
    //정적 맴버변수는 일반적인 맴버변수와 다르게 객체화를 하지 않아도 사용이 가능하다.
    //또한 클래스의 이름만으로 사용이 가능하다.
    public static int PlayerCount = 0;

    public int HP;
    public int ATT;

    public void setting(int _ATT, int _HP)
    {
        PlayerCount = 100;

        ATT = _ATT;
        HP = _HP;
    }
}

class SidePlayer
{
    static public int StNumber;
    static public int PlayerCount;

    //static이 붙지 않은 맴버변수들은 
    //맴버변수라고 불리며
    //이놈들은 객체 하나하나가 
    //자신의 것을 가진다.
    public int X = 0;
    public int Y = 0;

    public void Gravity()
    {
        Y -= 200;
    }
}

namespace _13StaticVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player.PlayerCount += 1;
            Player NewPlayer2 = new Player();
            Player.PlayerCount += 1;
            Player NewPlayer3 = new Player();
            Player.PlayerCount += 1;


            //맴버변수는 각각 존재한다.
            //플레이어를 3명 만들면
            //플레이어를 3번 new하게 되면
            //플레이어가 3개 생기게 된 것이고
            //그 3명의 플레이어는 각각의 HP와ATT를 가지고 있다.
            NewPlayer1.setting(10, 100);
            NewPlayer2.setting(20, 50);
            NewPlayer3.setting(100, 500);

            Monster NewMonster1 = new Monster();
            Monster NewMonster2 = new Monster();
            Monster NewMonster3 = new Monster();

            NewMonster1.Death();
            NewMonster2.Death();
            NewMonster3.Death();
            //모든 객체가 값을 공유해야할 필요가 있는 데이터를 정의하는데 사용한다.


            //하지만 static맴버변수 즉 정적 맴버번수는 객체화 없이 사용할 수 있고
            //정적 맴버변수는 데이터영역에 들어가게 된다.

            //객체들은 정적 맴버변수를 사용할 수 없다.
            //그러나 클래스 내부 안에서는 사용이 가능하다.




            /*        정리
             *  코드영역 - 상수, 클래스선언 등 수정 불가
             *  데이터영역 - 정적 맴버변수
             *  힙영역 - New 클래스명();으로 만든 모든 클래스의 실채가 있음
             *  스택영역 - 함수의 실행 메모리 영역(그 함수 내의 지역변수 등을 선언)
             */
        }
    }
}
