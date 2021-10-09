using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    //접근 제한 지정자를 입력하지 않으면 
    //디폴트로 private
    //즉 private이 일반적이기 때문
    //최대한 외부에서 접근하지 않도록 하는 것이 좋다. 
    //만약 접근할 수 있다면 상당히 위험할 수 있다.
    //그래서 함수를 통해 조정하게 된다.
    int AT = 10;
    int HP = 1000;
    int LV = 1;

    public int GetLv()
    {
        /* 리턴값이란 객체가 자신의 상태를 외부에 알려주는 용도로 사용한다.
         * 또한 외부에 알려주는 순간 함수가 끝나게 된다.
         * 얼마나 많은 코드가 적혀있든간 return을 만나면 함수가 종료된다.
         */
        return LV;
    }

    public void LEVEUP()
    {
        HP = 100;
        AT = 10;
    }
    public int DamageHPAndGetHP(int _Dmg)
    {
        HP = HP - _Dmg;
        return HP;
    }

    public void SetHP(int _HP)
    {
        /* 내가 HP가 0이 되는 순간만을 채크할 수도 있고 
         * 내가 100이 되는 순간을 채크할 수 있다.
         * 가장큰 핵심은 디버깅이 된다.
         * 공격력은 그 자체만으로 의미가 있지만
         * 그 자체로 의미가 명확해지지 않는다.
         * 
         * ex-> 렙업을 해서 공격력 체력이 증가했다고 하면
         * NewPlayer.HP = NewPlayer.HP + 1;
         * NewPlayer.AT = NewPlayer.AT + 1;
         * 이 긴 코드를 일일이 작성하는 것 보단 함수를 만들어 주는 것이 좋다.
         */
        HP = _HP;
    }

    //void[리턴값] Func[이름 혹은 식별자] ()[인자값]
    //함수란 클래스 외부와의 소통을 위해 만든다.
    //인자값에 int _Dmg를 넣는다는 것은 외부에서 한개의
    //int값을 넣어서
    //플레이어에게 전달해 주겠다는 것
    public void Damage1(int _Dmg)
    {
        HP = HP - _Dmg;
    }
    //인자값의 갯수는 여러개가 될 수도 있다.
    //100개 이상도 넣을 수 있다.
    public void Damage2(int _Dmg1, int _Dmg2)
    {
        HP = HP - _Dmg1;
        HP = HP - _Dmg2;
    }


}
//플레이어가 어떤 사양과 내용을 가지고 있다는 것만 적혀있다. 
//만든 것은 아님




namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();
            //private이면 어떻게 AT나HP를 조정하나?
            //이럴 때 필요한 것이 '함수'이다. 

            newPlayer.Damage1(10);
            newPlayer.Damage2(10, 20);
            /* 객체가 외부의 값을 받아서
             * 객체의 내부의 상태를 변화시키기 위해 
             * 함수를 선언하는 경우가 많다.
             */
            Console.WriteLine(newPlayer.GetLv());
            Console.WriteLine(newPlayer.DamageHPAndGetHP(50));
        }
    }
}
