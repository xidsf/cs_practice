using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*객체지향 프로그래밍에서는
 * 가장 먼저 해야하는 것은
 * 내가 RPG뭘 만들고 싶다
 * class를 선언한다.
 * class Dragon
 * {
 *      int AT; //맴버변수
 *      int HP;
 *      //맴버 함수
 *      void Damage()자신이 공격을 받는다는 개념 즉 드래곤이라는 것의 하위 개념
 *      {
 *          HP = HP - 10;   
 *      }
*/
class Player
{
    //객체지향의 캡슐화 은닉화를 대표하는 문법이
    //접근제한 지정자이다.
    public int HP; //공개
    protected int ATT; //자식에게만 공개
    private int DEF; //내부에만 공개

    public void Fight()
    {
        Console.WriteLine("싸운다");
    }
}

namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            /* 만들어진 객체의 내용을 사용하기 위해서는
             * 객체의 이름.을 사용한다.
             *
             *NewPlayer. ->접근제한 지정자라는 문법을 사용하지 않으면
             *외부에 공개하지 않는다.
             */

            NewPlayer.HP = 0; //public화 하면 나만 죽인다가 아니라
            //다른 사람도 죽일 수 있다.
            NewPlayer.Fight();

        }
    }
}