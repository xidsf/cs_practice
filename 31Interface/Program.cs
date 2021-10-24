using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//일단 사용자정의 자료형
interface QuestUnit
{
    //interface는 맴버변수x
    //int a = 0;

    //함수의 형태만 물려줄 수 있는 자료형
    void Talk(QuestUnit _OtherUnit);
    //내용도 없기 때문에 여러개를 넣어도 충돌이 일어나지 않는다.
}

class FightUnit
{
    int AT;
    int HP;

    public void Damage()
    {

    }
}
//인터페이스는 함수 구현을 강제할 수 있다.
//인터페이스를 상속받았다고 치면
class Player : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
}

class Monster : FightUnit
{

}

class NPC : QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NPC NewNPC = new NPC();
        //인터페이스는 실체가 없다.
        //그저 이 함수를 반드시 구현해야한다 라는 것을 알려주는 것


        //업캐스팅이 된다.
        NewPlayer.Talk(NewNPC);
    }
}
