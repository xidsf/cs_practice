using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int HP = 100;
    int AT = 10;
    public void Test(int _Dmg)
    {
        _Dmg = 1000;//그러나 _Dmg는 Test의 어느부분을 차지하고 있다.
        //이 함수는 Main과 다른 스택영역에 할당된다.
    }
}


namespace _11Memory00_Value_
{
    class Program
    {
        static void Main(string[] args)
        {

            //함수의 인자값
            int Value = 0;//이것은 Main의 어느 부분을 차지하고 있다. 즉 Main에 속해있다.
            Player NewPlayer = new Player();

            NewPlayer.Test(Value);
            Console.WriteLine(Value);//c언어에서 옛날에 겪어봐서 0인걸 알고 있음
            //value가 0이니 인자값으로 0을 넘겨줬다는 것과 같다.

            //Value값을 바꾸고 싶으면 반환값을 int로 바꾸고 return한 값을 Value에 넣어주면 됨
        }
    }
}
