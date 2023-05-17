using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Duel.Classes;


namespace Monster_Duel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster lovan = new Monster();
            lovan.Hp = 157;
            lovan.Damage = 10;
            Monster golbin = new Monster("golbin",100,25);
            Monster veroge = new Monster("veroge", 150, 35);

            Battle myBattle = new Battle();
            myBattle.battle(golbin, veroge);

            Console.ReadKey();
        }

    }
}
