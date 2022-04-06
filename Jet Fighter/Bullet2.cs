using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Jet_Fighter
{
    internal class Bullet2
    {
        public int size = 10;
        public int xSpeed, ySpeed;
        public int x, y;

        public Bullet2(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;


        }
        public void Move(Size screenSize)
        {
            x += xSpeed;
            y += ySpeed;

            //check if ball has reached right or left edge
            if (x > screenSize.Width - size || x < 0)
            {
                xSpeed *= -1; ;
            }

            //check if ball has reached right or left edge
            if (y > screenSize.Height - size || y < 0)
            {
                ySpeed *= -1; ;
            }
        }
        public bool Collision(PlayerWhite p)
        {
            Rectangle bulletRec = new Rectangle(x, y, size, size);

            Rectangle heroRec = new Rectangle(p.x, p.y, p.height, p.width);

            if (bulletRec.IntersectsWith(heroRec))
            {
                //if (ySpeed > 0)
                //{
                //    y = p.y - size - p.height;
                //}
                //else
                //{
                //    y = p.y + p.height;
                //}

                ySpeed *= -1;
                return true;


            }

            return false;
        }

        public bool Collision(PlayerBlack p)
        {
            Rectangle bulletRec = new Rectangle(x, y, size, size);

            Rectangle PlayerBlack = new Rectangle(p.x, p.y, p.height, p.width);

            if (bulletRec.IntersectsWith(PlayerBlack))
            {
                //if (ySpeed > 0)
                //{
                //    y = p.y - size - p.height;
                //}
                //else
                //{
                //    y = p.y + p.height;
                //}

                ySpeed *= -1;
                return true;


            }

            return false;
        }
    }
}
