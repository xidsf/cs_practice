using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _28Partial; //namespace _28Partial을 생략한다는 의미

namespace _28Partial
{
    class Program
    {
        static void Main(string[] args)
        {

            Player NewPlayer = new Player();

            NewPlayer.Func1();
            NewPlayer.Damage();
            //위처럼 코드를 짤 때도 같은 클래스로 취급된다.

        }
    }
}
