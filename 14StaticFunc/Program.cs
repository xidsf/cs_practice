using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player
{
    int HP = 100;
    int ATT = 10;
    public void Damage(Player _Other)
    {
        //자기 자신의 레퍼런스는 자기 자신 내부에서는 
        //보두 퍼블릭인 상태이다.
        HP -= _Other.ATT;
    }
    //객체화를 하지 않아도 플레이어 클래스의 내부는 내부라서
    //접근제한지정자에 
    static public  void PVP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.ATT;
        _Right.HP -= _Left.ATT;
    }
    /*static public void PVE(Player _Left, Monster _Right) 다른 클래스는 접근제한지정자의 영향을 받는다.
    {
        _Left.HP -= _Right.ATT;
        _Right.HP -= _Left.ATT;
    }*/

}

public class Monster
{
    private int ATT = 5;
    int HP = 50;
}


namespace _14StaticFunc
{
    class Program
    {
        // 메인함수도 클래스에 속한 정적 함수이다.
        //어떤 클래스 내부에 존재하는 Main이라는
        //정적 맴버함수에서 c#프로그램이 시작한다.
        static void Main(string[] args)
        {
            //f12를 누르면 그 클래스로 타고 들어갈 수 있다.
            //그 클래스의 세부 내용이 기록된 곳으로 갈 수 있다.

            Console.WriteLine("hi");//f12로 타고 들어가면 이 친구도 정적맴버함수인 것을 알 수 있다.
            //즉 Console이라는 클래스의 정적맴버함수라는 것이다.

            /*Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();

            NewPlayer1.Damage(5);
            //public 인 맴버변수들도 클래스를 선언한 뒤에 사용해야 한다.

            Player.PVP(NewPlayer1, NewPlayer2);
            // 정적 맴버변수와 마찬가지로 클래스에 속해있으면서 클래스를 선언하지 않아도
            // 사용할 수 있는 함수를 정적 맴버함수라고 한다.*/



        }
    }
}
