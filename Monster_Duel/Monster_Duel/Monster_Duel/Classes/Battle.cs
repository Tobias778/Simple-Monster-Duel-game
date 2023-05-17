using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Duel.Classes
{
    public class Battle : Monster
    {
        public Battle() { }

        public void battle (Monster monster1 , Monster monster2)
        {
            Console.WriteLine(monster1.Name + " VS "+ monster2.Name);

            monster1.Target= monster2;  
            monster2.Target= monster1;

            Monster attacker = monster1;

            while(!attacker.Target.IsDead())
            {
                attacker.attack();
                
                attacker = (!attacker.Target.IsDead()) ? attacker.Target : attacker;

            }

            Console.WriteLine(" The winner is " + attacker.Name);

        }

    }
}
