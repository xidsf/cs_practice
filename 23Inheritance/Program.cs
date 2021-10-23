using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//똑같은 코드를 여려번 사용하게 되면 코드 재활용성이 떨어지게된다.
//이 코드 재활용성을 향상시키기 위한 문법이
//상속이다.
//(사실 똑같은 코드 2번 쓰기 싫어서 만든거. 함수도 마찬가지이지만...)



//방법은 공통되는 기능을 하는 맴버변수와 맴버함수를 걷어낸다.

class Unit
{
    //        public      protected       private(디폴트)
    // 범위   외부까지    자식까지        나까지만

    //즉 접근제한지정자를 다시 지정해 주어야 한다.
    //자식까지 쓰게 하고싶으면 protected를 사용해야 한다.
    protected int AT = 10;
    protected int HP = 100;

    public void Damage(/*Unit this,*/Unit _OtherUnit)
    {
        this.HP -= _OtherUnit.AT;//this 복습
        //this.Lv
    }
}

//상속시킨다, 내려준다
//c#에서 상속은 오직 하나만 가능하다.
//클래스 상속을 여러개 받는 언어도 있지만 c#은 아니다.(대표적 c++)

//새로운 클래스에 그 모든 맴버변수와 맴버함수를 넣는다.
class Player : Unit
{
    int Lv = 1;
    void Heal(int _Heal)
    {
        HP += 20;
    }
}

class Monster : Unit
{
    
}

namespace _23Inheritance
{
    class Program
    {
        //상속문법을 제대로 사용하기 위해서는 어떤 개열이 있는지 파악해야한다.
        //예를 들면 몬스터나 플레이어나 싸울려고 있는게 아닌가?하는 것

        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();

            /*NewPlayer.Damage(10);
            NewMonster.Damage(5);*/

            //변환을 거치치 않으면 할 수 없다.
            /*int value = 100;
            string strvalue = value;*/ //오류
            //이러한 것은 메모리구조나 처리가 전혀 다르다는 것이다.
            //


            //NewPlayer = NewMonster;
            //Unit FU = NewPlayer;
            NewPlayer.Damage(NewPlayer);
            //업캐스팅
            //자식이 부모형이 되는 것
            //그러므로 자식만이 가지고 있는 것은 버리게 된다.
            //즉 Player나 Monster는 언제든지 Unit이 될 수 있다.

            //다운캐스팅
            //업캐스팅과 반대.
            //마치 나는 unit이지만 player만의 기능을 쓰고 싶다는 것
            //그러나 다운 캐스팅은 지양하자.
            //다운캐스팅은 자신이 상속한 모든 클래스가 될 수 있다는 것이다.
            //즉 실수로 플레이어가 몬스터가 될 수 있고 몬스터가 플레이어가 될 수 있다는 것


            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);//이것처럼 모든 자식 클래스들은 상속받은 부모클래스로 업캐스팅될 수 있다.
        }
    }
}
