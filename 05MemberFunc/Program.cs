using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* rpg에서 말하는 행동들은
 * 몬스터를 공격한다
 * 공격을 방어한다
 * 지형에서 움직인다
 * 스킬을 사용한다
 * 이런 것 들을 표현하는 것이 맴버함수!
 */

class Player
{
    //명사만으로는 부족하다!
    int ATT;
    int HP;
    /* 맴버함수를 왜 만들어야 하나? 행동을 표현하기 위해
     * 
     */
    /*리턴값*/void /*리턴값*/Move/*인자값*/()
    {//함수 시작
    }//함수 끝

    void Fight()
    {
    }
    void Talk()
    {
    }
    void SkillUse()
    {
    }
}
/* RPG를 만든다 -> 프로젝트를 만든다
 * 주인공이 있다 -> 클래스
 * 주인공이 공격력이 있다 ->맴버변수
 * 주인공이 공격력으로 때린다->맴버 함수
 * 한무 반복
 */