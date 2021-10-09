using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    //맴버변수 -> 클래스 내부에 있다고 해서 맴버변수
    int Att;
    int HP;

    void Fight()
    {
        //Console.WriteLine("플레이어가 싸운다");

        int Damage;
        //내부에서만 사용 가능하다.
        //함수가 끝나면 바로 사라진다.

    }
    //게임에서 사용하기 위해 설계했다.
    //즉 설계도대로 만들기 위한 코드가 따로 있다는 것
}

namespace _06LocalVar
{
    /* c#은 클래스밖에 모르는 바보이다
     * 프로그램의 시작조차도 클래스안에 묶어나야 한다.
     */
    class Program
    {
        static void Main(string[] args)
        {
            //함수 안에 있는 녀석들을 지역변수 라고 한다.
            int ATT = 0;
            ATT = 50;
            //즉 클래스 내부의 변수 -> 맴버변수
            //함수 안에 있는 변수 -> 지역변수

            // 지역변수는 함수 내부에서만 사용이 가능하다
             


            /* 객체화는 매우 중요한 작업이다.
             * 클래스 = 설계도
             */
            //Player NewPlayer1 = new Player();
            //Player NewPlayer2 = new Player();
            /*Player의 설계대로 플러에이를 만드는데
            * 그 이름을 NewPlayer라고 한다.
            */
            //Console.WriteLine("지역변수");
        }
    }
}