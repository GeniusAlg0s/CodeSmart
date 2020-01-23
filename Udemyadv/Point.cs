using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newlocation)
        {
            if(newlocation == null)
            {
                throw new ArgumentException("newlocation");
            }
                
            Move(newlocation.X, newlocation.Y);
          /*  this.X = newlocation.X;
            this.Y = newlocation.Y; */
        }
    }
        
}
