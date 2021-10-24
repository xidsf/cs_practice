using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    //보통 이런 녀석을 바꾸기 위해 get, set함수를 만든다.
    //즉 일단 이녀석이 타겟
    int AT = 10;
    public int HP = 100;
    //static변수토 프로퍼티가 가능
    static int mStaticValue;

    public static int StaticValue
    {
        get
        {
            return mStaticValue;
        }
        set
        {
            mStaticValue = value;
        }
    }


    public int ProAT
    {
        //프로퍼티의 get함수는 무조건 int를 리턴한다고 본다.
        get
        {
            return AT;
        }
        //무조건 int하나가 들어온다고 생각한다.
        //그런 외부의 값들을 프로퍼티에서는 value로 상수로 정해놓았다.
        set
        {
            AT = value;
        }
    }

    //ctrl + space = 자동완성 이라고 하는데 그냥 tab누르니까 됨 흠....
    public int GetAT()
    {
        if(AT > 999)
        {
            Console.WriteLine("기준치를 넘겼습니다.");
            while (true) { Console.ReadKey(); }
        }

        return AT;
    }
    public void SetAT(int _Value)
    {
        if(_Value > 999)
        {
            Console.WriteLine("기준치를 넘겼습니다.");
            while(true) { Console.ReadKey(); }
        }

        AT = _Value;
    }

}


namespace _26Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            //Player.StaticValue = 100;

            NewPlayer.ProAT = 20;
            NewPlayer.HP = 1000;

            int PlayerAT = NewPlayer.ProAT = 100;
            //NewPlayer.SetAT(9999);

        }
    }
}
