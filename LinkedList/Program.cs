using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //시퀸스 배열형 List
            //시퀸스 노드형 LinkedList

            LinkedList<int> LList = new LinkedList<int>();
            LList.AddFirst(10);
            LList.AddFirst(20);
            LList.AddFirst(33);
            LList.AddFirst(44);
            LList.AddFirst(55);


            for (LinkedListNode<int> StartNode = LList.First; null != StartNode; StartNode = StartNode.Next)
            {
                Console.WriteLine(StartNode.Value);
            }

            for (LinkedListNode<int> LastNode = LList.Last; null != LastNode; LastNode = LastNode.Previous)
            {
                Console.WriteLine(LastNode.Value);
            }

            LList.Remove(20);

            LList.RemoveLast();

            LinkedListNode<int> CurNode = LList.First.Next.Next;
            LList.AddBefore(CurNode, 90);
            //LinkedList.Clear(); 몽땅 지워라


            //노드들을 관리해 주는애: LinkedList<T>
            //노드 사이를 건너가는 애 LinkedListNode<T>
            //추가/ 제거 RemoveLst, AddAfter, AddBefore, AddFirst...

        }
    }
}
