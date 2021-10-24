using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32Array
{
    class Item
    {
        public string Name;
        public int AT;
        public int Def;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //배열은 자료형이라고 할 수 있으며
            //기본 자료형에 속한다.
            //선언방식은 어떤 자료형[]

            //모든 자료형은 구조체 아니면 클래스에 가까운데
            //기본 자료형도 마찬가지

            //[0][0][0][0][0][0][0][0][0][0]
            //만드는 순간 int가 10개 생겼다고 말할 수 있다.
            int[] arr = new int[10];
            arr[0] = 10;
            //arr은 int의 배열형 즉 int의 집합
            //arr[10]은 당연히 int형 왜냐? int의 집합이니 그 집합의 한 원소는 당연히 int이다.

            float[] arr2 = new float[10];
            //float로 만들면 float형 변수 10개가 만들어지고 그 하나하나는 모두 flaot이다.


            //c#에서는 모든 자료형은 class아니면 struct에 가까운데
            // 이는 맴버변수와 맴버함수가 있다는 것이다.
            
            //이들은 모두 여러개가 모여있고 연속되어 있다.
            //그 모여있는 자료들에 접근하는 법
            for(int i = 0; i < arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            //배열은 아이템이 100개 있다

            //item이라는 참조형을 담을 수 있는 공간이 10개가 생겼다.
            //즉 item이라는 메모리를 가리킬 수 있는 참조형이 10개 생겼다는 것이다.
            //item이 10개가 만들어진 것은 아니다.
            Item[] ArrItem = new Item[10];

            for (int i = 0; i < ArrItem.Length; i++)
            {
                ArrItem[i] = new Item();
            }

            ArrItem[0].Name = "철검";
            ArrItem[1].Name = "철갑옷";
            ArrItem[2].Name = "철모자";
            ArrItem[3].Name = "철신발";
            ArrItem[4].Name = "철바지";

            for (int i = 0; i < ArrItem.Length; i++)
            {
                Console.WriteLine(ArrItem[i].Name);
            }

        }
    }
}
