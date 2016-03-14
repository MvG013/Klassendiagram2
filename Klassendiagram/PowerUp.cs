using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendiagram
{
    class PowerUp
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Hitpointsup { get; set; }
        public int Walkspeedup { get; set; }

        public PowerUp(string name, int x, int y, int hitpointsup, int walkspeedup)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Hitpointsup = hitpointsup;
            this.Walkspeedup = walkspeedup;
        }
        public void IncreaseHitpoints(int amount)
        {

        }
        public void IncreaseWalkspeed(int amount)
        {

        }
        public void ActivePowerup(int amount)
        {

        }
    }
}
