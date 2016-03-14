using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendiagram
{
    class map
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public List<Cell> Cellist { get; set; }

        public map(string name, int height, int width, List<Cell> Celllist)
        {
            this.Name = name;
            this.Height = height;
            this.Width = width;
            this.Cellist = Celllist;
        }
        public void PlacePowerUp()
        {

        }
        public void PlaceWall()
        {

        }
        public void PlaceFinish()
        {

        }
        public void GenerateGrid()
        {

        }
    }
}
