using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Monster
{
    public int HP = 100;
    public int ATT = 5;

    public void attack(Player _Player)
    {
        _Player.HP -= ATT;
    }
}

class Player
{
    public int HP = 100;
    public int ATT = 10;
    //Monster _Monster클래스가 객체화된 녀석을 받았다.
    public void attack(Monster _Monster)
    {
        _Monster.HP -= ATT;
    }
}

namespace _12Memory02_Reference_
{
    class Program
    {
        static void Main(string[] args)
        {
            //HP 100, ATT 5
            Monster NewMonster = new Monster();
            //HP100, ATT 10
            Player NewPlayer = new Player();

            NewMonster.attack(NewPlayer);//여기는 바뀐다.
            NewPlayer.attack(NewMonster);

            //클래스가 객체화된 놈은 레퍼런스형이라는 자료형이 되고 
            //지금까지 봐왔던 int, bool같은 녀석은 값형이라고 한다.

            //값형과 레퍼런스형은 메모리의 위치와 사용법이 다르기 때문에 
            //다르게 동작한다.

            //Player NewPlayer여기까지는 스택 영역에 생기지만
            //new Player()이녀석은 힙영역에 생성된다.
            //Player NewPlayer를 한 순간 뒤에 있는 영역은 모두 힙 영역에 할당된다.
            //레퍼런스는 힙영역에 생성된 어떠한 메모리의 위키를 가리키는 값


            //"."은 내가 가리키고 있는 위치에 있는 HP를 사용하겠다는 것

            //인자값으로 Player _Player로 하고
            //인자값에 Player NewPlayer를 인자로 받는다면 이는 NewPlayer가 가리키는 어떠한 영역을
            //가리키는 포인터를 인자값으로 받으므로 그 NewPlayer를 바꾸면 그 값 자체가 바뀌게 된다.
            //선언한 함수가 끝나더라도 가리키는 포인터 Player _Player만 없어지고
            //NewPlayer는 그대로 유지되므로 값이 변하게 된다.


            //즉 "값형"과 "레퍼런스형"을 구분해야 한다.
            //자기가 만든 클래스를 new 클래스명();
            //해서 만든 것을 그 클래스 명에 받으면
            //그건 레퍼런스형이다.
        }
    }
}
