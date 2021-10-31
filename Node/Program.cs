using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//노드는 자료구조에서만 사용되는 것은 아니다.

//자료구조라고 치면
//자료구조를 보관해야 하므로
//
class Node<T>
{
    public T Data;

    //자기 안에 자기 자신을 다시 가지는 형태로 되어있는 클래스
    public Node<T> Next = null;
    public Node<T> Prev = null;

    public Node(T _Data)
    {
        Data = _Data;
    }

}


namespace _Node
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Node<int> Node1 = new Node<int>(999);
            Node<int> Node2 = new Node<int>(4567);
            Node<int> Node3 = new Node<int>(2512);

            Node1.Next = Node2;
            Node2.Next = Node3;
            Node3.Prev = Node2;
            Node2.Prev = Node1;

            Node<int> CurNode = Node1;

            while(CurNode != null)
            {
                Console.WriteLine(CurNode.Data);
                CurNode = CurNode.Next;
            }
            Console.WriteLine("over");

            Node<int> RCurNode = Node3;

            while(RCurNode != null)
            {
                Console.WriteLine(RCurNode.Data);
                RCurNode = RCurNode.Prev;
            }
        }
    }
}
