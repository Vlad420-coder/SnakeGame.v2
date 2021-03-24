using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeGame.v2
{
    class Snake
    {
        public int amount;
        public float XRectSize;
        public float YRectSize;
        public List<Point> coords = new List<Point>();
    }
}
