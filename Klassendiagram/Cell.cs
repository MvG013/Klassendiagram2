using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendiagram
{
    class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Boolean Wall { get; set; }
        public PowerUp Powerup { get; set; }
    }

}
