using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int HP = 100;
    static int StTest = 1000;

    static void PVP(Player _Left, Player _Right)
    {
        //HP -= 100; 누구의 HP인지 모르기 때문에 못쓴다. 당연한거

        //이 안에서 영향을 받지 않는 것이 정적 맴버 변수, 함수 등이다.
        //
        StTest -= 100;//같은 정적 맴버변수만 정적맴버함수 내에서 쓸 수있다.

    }

/*    public void Damage(int _Dmg)
    {
        //HP -= _Dmg Player2가 호출했으니 Player2의 HP라는걸 알고 있지만 약간 부족하다
        this.HP -= _Dmg;
    }*/

    static void Damage(Player _this, int _Dmg)
    {
        _this.HP -= _Dmg;

        //static 맴버 함수는 자신 즉 객체가 없어도 사용할 수 있기 때문에
        //this를 사용할 수 없다.
    }

    public void Heal(/*Player _this*/int _Heal)
    {

        //문법적 편의성으로 함수의 인자값이 자동적으로 호출되어있다.


        //맴버함수의 호출이란
        //어차피 넣을거 그냥 알아서 넣어줄게 그런 의미이고 그게 this이다.
        HP += _Heal;

        //맴버함수에서 맴버변수를 사용한다면
        //눈에 보이지 않지만 앞에 this.이 생략된 것이다.

        //이것을 잊으면 않되지만 매번 this.을 써서 코드를 써야 한다면
        //더럽게 귀찮을 것이다.
    }

}

namespace _16This
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            NewPlayer2.Heal(/*NewPlayer2*/100);//사실 모든 함수는 이런 꼴이였다. 즉 자기 자신을 넣는 꼴이다.
            //모든 맴버함수를 이렇게 써야한다면 매우 불편하기 때문에 생략해주었고
            //함수 내부에서 그것을 표현하기 위해 this가 있는 것이다.

        }
    }
}
