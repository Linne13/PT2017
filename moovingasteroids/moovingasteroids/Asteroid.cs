using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace moovingasteroids
{
    public class Asteroid
    {
        public Point location;
        public int x;
        public int y;
        Pen pen = new Pen(Color.White);


        public Asteroid(Point p, int xx, int yy)
        {

            location = new Point();
            location = p;
            x = xx;
            y = yy;

        }
        public void move()
        {
            location.X += x;
            location.Y += y;
            if (location.X < 2) location.X = 500;
            if (location.Y < 2) location.Y = 500;
            if (location.X > 500) location.X = 1;
            if (location.Y > 500) location.Y = 1;
        }
        public void draw(Graphics g)
        {
            g.DrawEllipse(pen, location.X, location.Y, 30, 30);

        }
    }
}
