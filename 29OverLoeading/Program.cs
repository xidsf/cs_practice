using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum DMGTYPE
{
    PYDMG,
    PRYODMG,
    ICEDMG
}

class Player
{
    //물리방어
    int AttDef = 5;
    //불방어
    int FireDef = 5;
    //물방어
    int IceDef = 5;

    //Damageintint
    public void Damage(int _Dmg, DMGTYPE _Type)
    {
        switch(_Type)
        {
            case DMGTYPE.PYDMG:
                _Dmg -= FireDef;
                break;
            case DMGTYPE.PRYODMG:
                _Dmg -= IceDef;
                break;
            case DMGTYPE.ICEDMG:
                _Dmg -= AttDef;
                break;
        }
    }

    //Damageint
    public void Damage(int _Dmg)//함수 오버로딩
    {

    }

    //Damagefloatint
    public void Damage(float _test, int _Dmg)
    {

    }

    //즉 인자값만 다르면 같은 이름으로 다 똑같이 만들 수 있다.

}

namespace _29OverLoeading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            NewPlayer.Damage(100, DMGTYPE.PRYODMG);

        }
    }
}
