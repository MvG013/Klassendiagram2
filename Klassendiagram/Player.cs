using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendiagram
{
    class Player
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Hitpoints { get; set; }
        public int Walkspeed { get; set; }
        public string Walk { get; set; }

        public Player(string name, int x, int y, int hitpoints, int walkspeed)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Hitpoints = hitpoints;
            this.Walkspeed = walkspeed;
        }

        public void TakeDamage(Enemie enemie)
        {

        }

        public void walking(string richting)
        {

        }
    }
}
