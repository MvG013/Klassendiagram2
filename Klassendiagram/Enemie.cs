using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendiagram
{
    class Enemie
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Hitpoints { get; set; }
        public int Attack { get; set; }
        public string Walk { get; set; }


        public Enemie(string name, int x, int y, int hitpoints, int attack)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Hitpoints = hitpoints;
            this.Attack = attack;
        }

        public void GiveDamage (Player player)
        {

        }

        public void walking(string richting)
        {
            
        }
    }
}