using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Zone
{
    string name = "None";

    public Zone(string _Name)
    {
        name = _Name;
    }

    public List<Zone> LinkedZone = new List<Zone>();

    public Zone Update()
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("이곳은" + name + "입니다.");
            Console.WriteLine("이동할 수 있는 장소: ");
            for (int i = 0; i < LinkedZone.Count; i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + LinkedZone[i].name);
            }

            //ConsoleKey.D1;

            //형변환이 가능한 애가 있고 안되는 애가 있는데
            //enum은 int로 가능하다.
            int number = (int)Console.ReadKey().Key;
            //다른 숫자를 넣으면 터짐
            //방어코드 필요
            number -= 49;
            return LinkedZone[number];

        }
    }
}


namespace NodeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Zone NewZone0 = new Zone("태초마을");
            Zone NewZone1 = new Zone("초급사냥터");
            Zone NewZone2 = new Zone("중급사냥터");
            Zone NewZone3 = new Zone("중급 마을");
            Zone NewZone4 = new Zone("고급마을");

            NewZone0.LinkedZone.Add(NewZone1);
            NewZone1.LinkedZone.Add(NewZone3);
            NewZone2.LinkedZone.Add(NewZone0);
            NewZone3.LinkedZone.Add(NewZone2);
            NewZone3.LinkedZone.Add(NewZone4);

            Zone StartZone = NewZone0;

            while(true)
            {
                StartZone = StartZone.Update();
            }
            
        }
    }
}
