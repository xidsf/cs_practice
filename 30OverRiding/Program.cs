using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Unit
{
    protected string Name = "None";
    protected int ATT = 10;
    protected int HP = 100;


    //일단 함수 한개로 해결할 수 있는 것을 함수 여러개를 만드는 것은 매우 비효율적이다.
    //즉 코드 재활용성 향상
    //코드를 적게 쓰고 최대한의 효과를 누리고 싶다.
    //즉 뭔가 특별한게 더 늘어나거나 추가되는 것은 그리 효율적인 것이 아니다.
    public void Damage(Unit _OtherUnit)
    {
        ATT = _OtherUnit.ATT;

        Console.WriteLine(_OtherUnit.Name+"에게"+ ATT + "만큼의 데미지를 입었습니다.");

        this.HP -= ATT;
    }
    
}

class Player : Unit
{
    public Player(string _Name)
    {
        Name = _Name;
    }
    int ItemAtt = 5;
}

class Monster : Unit
{
    public Monster(string _Name)
    {
        Name = _Name;
    }
}

namespace _30OverRiding
{
    class Program
    {
        static void Main(string[] args)
        {


            Player NewPlayer = new Player("플레이어");
            Monster NewMonster = new Monster("오크");

            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
        }
    }
}
