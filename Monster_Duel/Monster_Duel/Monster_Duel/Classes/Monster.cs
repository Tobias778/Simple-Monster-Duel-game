using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Duel.Classes
{
    public class Monster
    {
        private string name;
        private int hp;
        private int damage;
        private Monster target;
        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Damage { get => damage; set => damage = value; }
        public Monster Target { get => target; set => target = value; }

        public Monster()
        {
        }

        public Monster(string name, int hp, int damage)
        {
            this.name = name;
            this.hp = hp;
            this.damage = damage;
        }

        public Monster(string name, int hp, int damage, Monster target)
        {
            this.name = name;
            this.hp = hp;
            this.damage = damage;
            this.target = target;
        }

        public bool IsDead()
        {
            return this.hp <= 0; // return type is true or false 
        }

        public void deadMessage()
        {
            Console.WriteLine(this.name + " is Dead!");
        }

        public void attack()
        {
            Console.WriteLine(this.name + " VS " + this.target.name);
            this.target.hp -= this.damage; // this.target.hp = this.target.hp - thi.damage;

            // I should declare the boolean variable to store the result of IsDead() function
            bool result = IsDead();// true or false

            if(result == true) {
                deadMessage();
            }

            //if(IsDead()) {
            //    deadMessage();
            //}
        }
    }
}
