using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public int HP = 100;
    public int AT = 10;

    public bool IsDeath()
    {
        Console.WriteLine("HP Test");
        return HP <= 0;
    }


    public void TestFunc(Player _Player)
    {
        TestFunc2(_Player);
    }
    public void TestFunc2(Player _Player)
    {
        TestFunc3(_Player);
    }
    public void TestFunc3(Player _Player)
    {
        _Player.AT = 100; //값에 직접적으로 접근할 떄 null값이 터짐
    }
}

namespace _37Reference01
{
    class Program
    {
        static int number = 100;
        static void PlayerTest(int[] _ArrTest)
        {
            _ArrTest[0] = 9999;
        }

        static void ClassTest(Player _test)
        {
            _test.AT = 1000;
        }

        static void ATTest(Player _test)
        {
            Console.WriteLine("AT Test");

            _test.AT = 10000;
        }

        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Player NewPlayer2 = null;
            NewPlayer.AT = 50;
            //NewPlayer = new Player(); 이러면 새로운 NewPlayer가 만들어지고 기존의 AT = 50인 Player는 자동으로 지워진다.
            int[] ArrNumber = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // 한번에 모든 값을 다 넣어줘야 한다.

            ClassTest(NewPlayer);//힙에 있는 녀셕이 이 함수에 들어갔다 나왔다는 개념

            PlayerTest(ArrNumber);

            //ATTest(NewPlayer2); 사용할 떄만 오류
            //NewPlayer2.IsDeath();

            NewPlayer.TestFunc(null);
        }
    }
}
