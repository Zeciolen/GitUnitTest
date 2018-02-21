using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointLib
{

        public class Point
        {
            private double x;
            private double y;



            public Point()
            {
                x = y = 0;
            }

            public Point(double newX, double newY)
            {
                x = newX;
                y = newY;
            }

            // returns x and y values of the point, respectively
            public double getX() { return x; }
            public double getY() { return y; }

            // Stretches the point by increasing the distance between the point and zero
            // by the factor scale.  For example, applying stretch(3) to the point (2,3)
            // should yield (6,9).  Only non-negative scale values should be allowed.
            public void stretch(double scale)
            {

            }

            // calculates the stright-line distance between two points.  The value should
            // always be non-negative.
            public double distance(Point other)
            {
                return 0;
            }

            // Rotates the point counter-clockwise by deg degrees.  For example, applying
            // a 90 degree rotation to (1, 0) should give (0, 1).
            public void rotate(double deg)
            {
                double rotCos = Math.Cos(deg * Math.PI / 180);
                double rotSin = Math.Sin(deg * Math.PI / 180);
                double oldX = x;
                double oldY = y;
                x = oldX * rotCos - oldY * rotSin;
                y = oldX * rotSin + oldY * rotCos;
            }

            // returns a string of the form "(x, y)" to display the point, x and y are
            // given to one decimal place
            public String toString()
            {
                return "";
            }

            // returns true if the distance of the point to (0,0) is closer than from
            // other to (0,0), false otherwise.
            public static bool operator <(Point p1, Point p2)
            {
                return true;
            }

            // returns true if the distance of the point to (0,0) is further than from
            // other to (0,0), false otherwise.
            public static bool operator >(Point p1, Point p2)
            {
                return true;
            }
        }
}
