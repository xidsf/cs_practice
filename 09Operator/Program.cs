using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int HP = 100;

    public void Damage(int _HP)
    {
        HP = HP - _HP;
    }
}

class calc
{
    public int Plus(int _Left, int _Right)
    {
        return _Left + _Right;
    }
}

namespace _09Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            calc Test = new calc();
            int Result = 0;
            int Left = 7;
            int Right = 3;

            // = : 대입연산자
            //함수에서 리턴된 값이나 연산된 값을 그 값을 받을 수 있는 변수에 넣어라
            //물론 리터럴값일 수도 있다.

            //산술 연산자
            Result = Left + Right; //더하기
            Result = Left - Right;//빼기
            Result = Left * Right;//곱하기
            Result = Left / Right;//나누기
            Result = Left % Right;//나머지
            //이런식으로 산술 연산을 할 수 있고
            //한가지 주의할 점은 나누기와 나머지는 0을 넣으면 안된다.
            //10/0->수학에서는 불가능 하지만
            //컴퓨터에서는 제로디비전이라고하는 오류가 나온다.
            //프로그램이 실행 도중 터질정도의 오류이므로 주의해야한다.

            //연산자는 함수와 비슷하다.
            Result = Left + Right;
            Result = Test.Plus(Left, Right);
            //이 두 가지는 큰 차이가 없다.
            //또한 리턴은 외부에 연산값이나 객체상태값 등을
            //끝나고 나면 외부에 반환하는 것을 말하고
            //이런 식으로 = 연산자가 있다면 오른쪽 부터 실행된다.
            //연산자의 우선순위라는 것이 있는데 =연산자보다 +연산자를 먼저하게 된다.
            //

            //비교 연산자
            //비교연산자는 논리형으로 리턴이된다.
            //논리형은 bool이라는 것이 있다.
            //int는 정수를 넣어줄 수 있는데
            int number = 2315135;
            //Bool은 
            bool BResult = true;
            //와 같이 참, 거짓만 가질 수 있다.

            //100, 200은 정수형 상수라고 하는데
            //참과 거짓이 상수화 된 것이
            //true와 flase라는 것이다. 

            //이때 비교연산자는
            BResult = Left > Right;//left가 right보다 큰가?
            BResult = Left < Right;//left가 right보다 작은가?
            BResult = Left <= Right;//left가 right보다 크거나 같은가?
            BResult = Left >= Right;//left가 right보다 작거나 같은가?
            BResult = Left == Right;//left가 right보다 같은가?
            BResult = Left!= Right;//left가 right보다 다른가?
            //참이라면 true, 거짓이라면flase를 리턴하고
            //그걸 받을 수 있는 자료형이 bool자료형이다.
            //이런 참 거짓을 통해 조건문에서 유리하게 이용할 수 있다.


            //bool논리 연산자
            //참과 거짓을 연산하는 연산자
            //둘다 맞다면, 둘다 틀리다면, 둘이 같다면 등등
            BResult = !true; // NOT
            //false면 ture, ture면false를 리턴한다.
            BResult = true && false; //AND
            //둘다 true일 경우 true를 반환한다.
            BResult = true && true && false; //몇개가 됬든 단 한개라도 false면 false를 반환한다.
            BResult = true || false;//OR 여긴 몇 개가 됬든 true가 한개라도 있으면 true를 반환한다.
            
            BResult = true ^ false; //XOR 여기는 false반환
            //두 bool이 같다면 false 다르다면true를 반환한다.

            //축약연산자
            Result = 0;
            Result = Result + 10;//귀찮으니
            Result += 10;//이렇게 쓴다.
            //+=, -=. /=, *= 전부 할 수 있다.
            Result -= 5;
            Result *= 10;
            Result /= 5;
        }
    }
}
