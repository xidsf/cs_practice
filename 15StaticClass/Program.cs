using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//정적 클래스란 정적맴버변수와 정적맴버 함수만을 가질 수 있는 클래스이다.
static class StClass
{
    //일반 맴버변수는 선언만 해도 오류가 뜬다.
}

class Player
{
    //함수의 위치는 어디에 있는 상관 없다.
    //있기만 하면 시작한다.
    static void Main(string[] args)
    {
        Console.WriteLine("Console.WriteLine은 정적 맴버 함수이다.");
    }
    //어디에 있든 static void Main()이라는 함수가 있으면 거기서 프로그램이 시작한다.
    
}


namespace _15StaticClass
{
    class Program
    {
        
    }
}
