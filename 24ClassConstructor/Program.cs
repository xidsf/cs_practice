using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Unit
{
    protected int AT;
    protected string name;
    public void fight()
    {
        int a = 0;
    }
}


class Player : Unit
{
    public Player()
    {
        name = "플레이어";
        AT = 100;
        //이걸 통해 알 수 있듯이 이미 부모클래스가 만들어 졌을 때 만들어져 있다.
        //즉 Unit의 생성자가 호출됬다 -> AT가 만들어 졌다
        //또한 자신의 클래스를 리턴해야 하는 함수이다.

        //근데 접근제한지정자가 들어가는 것을 보았을 때 바꿀 수 있을텐데
        //private로 지정하면 NewPlayer를 생성할 수도 없다.
    }
    //생성자
    //특징
    //리턴값이 없다(void든 int든)
    //만들어질 때 한번 실행되는 함수


    /*
    public Player()
    {
        int Number = 0;
    }*/
    //작성하지 않는다면 눈에 보이지 않는 이러한 함수가 있다고 생각하면 된다.
}

class Monster : Unit
{
    public Monster(string _Name)
    {
        name = _Name;//당연히 응용으로 인자값으로 받을 수도 있다.
    }
}

namespace _24ClassConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Monster NewMonster = new Monster("오크");
        }
    }
}
