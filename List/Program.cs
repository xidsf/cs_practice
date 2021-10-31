using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            //배열형 / 시퀸스
            //내가 만든 애가 아닌데 이미 있음
            List<int> NewList = new List<int>();

            //자료: 넣어준 int

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((NewList.Count + 1).ToString() + " Add");
                Console.WriteLine("capacity : " + NewList.Capacity);//배열의 크기
                Console.WriteLine("count : " + NewList.Count);//자료의 크기
                NewList.Add(100);
            }

            //탐색에는 유리하지 않은 자료구조지만
            //인덱스로 표현할 수 있다면 탐색에 가장 강력함
            if(NewList.Contains(8))//내부에 이런 자료가 있냐 없냐?를 확인
            {
                Console.WriteLine("내부에 8이 있음");
            }

            Console.Write(NewList[5]);//배열이든 List이든 넘어서 쓰지 말자. 터진다.
            //또한 자료의 개수가 중요하지 배열의 크기는 중요하지 않다.

            NewList.Remove(5);//5가 있으면 지운다.
            NewList.RemoveAt(1);// 첫번째 걸 지운다.
            //NewList.RemoveAll
            //다른 리스트 혹은 배열과 비교해서 중복되는 것이 있으면 지운다.
            NewList.RemoveRange(3, 2);//3부터 2개 지워라.

            NewList.Clear();//몽땅 지워라

        }
    }
}
