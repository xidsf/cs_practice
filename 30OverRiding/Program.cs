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
    
    public virtual int DMGAT
    {
        get
        {
            return ATT;
        }
        set
        {
            ATT = value;
        }
    }

    //일단 함수 한개로 해결할 수 있는 것을 함수 여러개를 만드는 것은 매우 비효율적이다.
    //즉 코드 재활용성 향상
    //코드를 적게 쓰고 최대한의 효과를 누리고 싶다.
    //즉 뭔가 특별한게 더 늘어나거나 추가되는 것은 그리 효율적인 것이 아니다.
    public void Damage(Unit _OtherUnit)
    {
        int ATT = _OtherUnit.DMGAT;

        Console.WriteLine(_OtherUnit.Name+"에게"+ ATT + "만큼의 데미지를 입었습니다.");
        this.HP -= ATT;
    }



    //이 문법의 핵심은 자식에서 /*같은 이름의 함수나 프로퍼티*/를 구현했다면 
    //자식형태의 /*같은 이름의 함수나 프로퍼티*/를 호출해달라는 것이고
    //이것을 오버라이딩이라고 한다.
    //다형성(동적바인딩)의 핵심문법
    /*public virtual int GetAT()
    {
        Console.WriteLine("unit att");
        return ATT;
    }*/

}

class Player : Unit
{
    int ItemAtt = 5;

    public Player(string _Name)
    {
        Name = _Name;
    }
    //부모의 DMGAT를 재구현 하였다.
    public override int DMGAT
    {
        get
        {
            Console.WriteLine("player att");
            return ATT + ItemAtt;
        }
    }
}

class Monster : Unit
{
    int MonsterLv = 2;

    public Monster(string _Name)
    {
        Name = _Name;
    }

    public override int DMGAT
    {
        get
        {
            Console.WriteLine("monsteratt");
            return ATT + MonsterLv;
        }
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

            /*NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);*/

            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);



        }
    }
}
