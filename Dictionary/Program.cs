using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestDic//한번 감싼다.
{
    Dictionary<string, int> NewDic = new Dictionary<string, int>();
    
    public void DicPrint(string _Key)
    {
        if(NewDic.ContainsKey(_Key) == true)
        {
            Console.WriteLine(NewDic[_Key]);
        }
    }

    public void Add(string _string, int _int)
    {
        if(NewDic.ContainsKey(_string) == false)
        {
            NewDic.Add(_string, _int);
        }
    }
}

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //연관 복합
            Dictionary<string, int> NewDic = new Dictionary<string, int>();
            //string = 키 
            //int = 밸류(데이터)
            //보통 만들 때는 class로 감싼다.
            if(NewDic.ContainsKey("1임") == false)//방어코드
            {
                NewDic.Add("1임", 1);
            }
            NewDic.Add("2임", 2);
            NewDic.Add("뭐임", 21513);

            string dictest = "응애";

            //인덱서
            //연산자 겹지정
            //찾는 것에 특화된 녀석
            Console.WriteLine(NewDic["1임"]);
            if (NewDic.ContainsKey(dictest) == true)
            {
                Console.WriteLine(NewDic[dictest]);
            }


            //중복

            NewDic.Add("왕", 1234);
            //NewDic.Add("왕", 17734);
            //같은키 두번 넣어주는 것은 불가능
            //즉 애초에 같은 키의 두 개의 값을 넣을 생각이면 Dictionary를 쓰면 안됨


            //제거
            NewDic.Remove("뭐임");

            TestDic NewTest = new TestDic();//보통 그냥 쓰는 것보다 한 클래스를 만들어 감싸는 것이 좋다.
            //어차피 예외처리 항상 해줘야 해야함
            NewTest.Add("2번", 2);
            NewTest.Add("2번", 9999);
            NewTest.Add("3번", 3);
            NewTest.Add("4번", 4);
            NewTest.DicPrint("99번");

            
        }
    }
}
