using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public int HP = 100;
    public int AT = 10;
}




namespace _37Reference01
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NewPlayer.AT = 50;
            NewPlayer = new Player();

        }
    }
}
