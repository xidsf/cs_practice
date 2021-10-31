using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GTest <T>
{
    public T Data;
}

namespace DataStructEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> NewDic;
            List<Dictionary<string, int>> NewList;

            //Dictionary<int, int> <- 이럴거면 그냥 List를 써라

            Dictionary<string, int> DicTest = new Dictionary<string, int>();

            //List와 LinkedList는왠만하면 for문 순회방식을 쓰자
            List<int> ListTest = new List<int>();
            LinkedList<int> LinkedListTest = new LinkedList<int>();
            
            
            DicTest.Add("일", 1);
            DicTest.Add("이", 2);
            DicTest.Add("삼", 3);
            DicTest.Add("사", 4);
            DicTest.Add("오", 5);

            ListTest.Add(1);
            ListTest.Add(2);
            ListTest.Add(3);
            ListTest.Add(4);
            ListTest.Add(5);

            LinkedListTest.AddLast(1);
            LinkedListTest.AddLast(2);
            LinkedListTest.AddLast(3);
            LinkedListTest.AddLast(4);
            LinkedListTest.AddLast(5);


            //foreach문은 자동적으로 반복하는 문장으로서
            //in을 통해 각 배열이든 딕셔너리는 리스트든
            //내부의 자료를 그대로 순회할 수 있게 초리해준다.
            //var은 가장 적합한 자료형으로 
            //in은 자료구조에서 하나씩 빼온다라고만 이해해도 된다.
            //대신 루프에 대한 제한을 하기가 어렵다.
            //보통 dictionary말고는 foreach를 사용하지 않는다고 한다.
            //foreach도 break문 사용이 가능하다.
            foreach (var item in ListTest)
            {
                Console.WriteLine(item);
            }
            foreach (var item in LinkedListTest)
            {
                Console.WriteLine(item);
            }
            foreach (KeyValuePair<string, int> item in DicTest)
            {
                Console.WriteLine(item.Key);
            }

            int number = 10;
            var AA = number;
            //그 시점에서 가장 알맞은 자료형으로 변해준다.
        }
    }
}
