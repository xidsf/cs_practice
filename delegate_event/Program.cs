using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_event
{
    delegate void MyDel2(string _Message);

    class EventTest
    {
        public event MyDel2 MyEvent;

        public void Func(string _Message)
        {
            MyEvent(_Message);
        }
    }

    class A
    {
        public void Test1(string _Message)
        {
            Console.WriteLine("test 1");
        }
        public void Test2(string _Message)
        {
            Console.WriteLine("test 2");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            EventTest NewEvent = new EventTest();
            A NewEvent2 = new A();

            NewEvent.MyEvent += NewEvent2.Test1;
            NewEvent.MyEvent += NewEvent2.Test2;

            NewEvent.Func("HI");


            NewEvent.MyEvent -= NewEvent2.Test2;
            NewEvent.Func("Bye");


        }
    }
}
