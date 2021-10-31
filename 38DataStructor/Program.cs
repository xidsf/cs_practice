using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//자료구조

class MyDataStruct<T>
{
    //넣기
    //탐색
    //확장

    public void Push (T _Data)
    {
        if(true/*만약 오버하면*/)
        {
            this.Exp(100);
        }
    }
    public int Find(T _Data)
    {
        return 100;
    }
    public void Exp(int _Size)
    {

    }
}

namespace _38DataStructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //자려구조 라는건
            //int 10개를 관리한다고 생각하면
            //1, 2, 3, 4, 5, 6, ,7, 8, 9, 10

            //자료구조에는
            //다음의 구조나 인터페이스를 지원한다.
            //함수로 표현한다.
            //삽입
            //탐색
            //확장
            //이런 것에 배열은 매우 불편한 자료구조이다.
            
            //보통 컨테이너 라는 용어를 사용하는데
            //시퀸스 컨테이너 : 넣으면 넣는대로 들어감
            //보통 List라는 이름이 들어가면 시퀸스(C++ 에서는 vector, c#에는 없음)        Sorted List는 정렬이니 연관이다.

            //연관 컨테이너 : 자료간의 몬가 연관이 있음(ex 숫자를 push하면 자료순서를 오름차순(정해진 규칙)으로 바꿈)
            //보통 Dictionary(c# 해쉬맵) map(C++)

            //어댑터 컨테이너 stack queue



            //데이터의 메모리 구조는
            //배열 : 말 그대로 따닥따닥 자료가 붙어있음
            //노드형 구조 : 어떤 자료가 다음에 연관된 자료를 알고 있는 것


            int[] Arr = new int[10]; // 자료구조

            Arr[0] = 0;
            Arr[1] = 1;


            MyDataStruct<int> MDS = new MyDataStruct<int>();

            MDS.Push(100);//보통 push안에 다 exp해줌
            MDS.Push(100);

            MDS.Find(50);

            //MDS.Exp(10); 보통 자동으로 이루어진다.
        }
    }
}
