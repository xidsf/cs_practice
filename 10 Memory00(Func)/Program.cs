using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//왜 메모리를 알아야 하는가
/* 메모리는 c#를 배워야 하기 때문에 알아야 하는 것이 아니라
 * 모든 브로그램의 근간이 되는 지식
 * 
 * 모든 프로그램에는 공짜는 없다.
 * 메모리의 구조를 안다는 것은 코드의 동작 원리를 안다는 것이다.
 */

class Player
{
    int HP = 100;
    int ATT = 10;

    
    public void Damage(int _Dmg)//매개변수 또한 NewPlayer.Damage안의 인자값도 공간을 차지한다.
    {//함수의 인자값은 지역변수이다. 함수가 끝나면 사라진다.
        HP -= _Dmg;
    }
    //이 부분은 한번 디버깅 하면 수정이 불가능한 코드 메모리 영역에 있다.
}

class Program
{

    //이녀석을 메인함수라고 하는데
    //static을 빼면 함수의 모양을 가지고 있다
    //단순히 여길 시작이라고 잡은 곳이다.
    //Main()이라는 함수부터 시작한다고 약속해 두었다.


    /*메인함수의 크기는 
     * 지역변수 + a로 크기가 되는데
     * 최소한 지역변수를 전부 담을 수 있을만큼의 크기가 되어야 한다.
     */
    static void Main()
    {
        /* 객체를 만들었다는 것은 메모리를 지불했다는 것
         *Main함수는 스택 메모리에서 실행된다.
         * 참고로 함수는 메모리화되지 않는다.
         */

        int Value = 0; // Main함수에 int Value하나가 선언되었다면 최소한 4바이트여야 한다.


        Console.WriteLine("Hi");//이 함수는 한번 텍스트를 띄워주고 바로 사라진다.

        Player NewPlayer = new Player();//Player NewPlayer가 스택영역 Main내부에 생성
        NewPlayer.Damage(10);//스택 영역이긴 한데 Main밖에 그렸음
        //이후 프로그램이 종료되면 Main함수든 NewPlayer든 전부 종료
    }//메인함수가 끝나면 프로그램이 메모리에서 사라짐
    //즉 우리 프로그램이 스택영역의 메인함수 실행 여부에 따라서 lifecycle이 갈리게 됨.
}

