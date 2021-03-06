using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDA_And_Bresenham_Algorithm
{
    class EllipseDrawing
    {
        /* The following procedure accepts values for an ellipse
        * center position and its semimajor and semiminor axes, then
        * calculates ellipse positions using the midpoint algorithm.
        */
        public static List<Point> ellipseMidpoint(int xCenter, int yCenter, int Rx, int Ry)
        {
            int Rx2 = Rx * Rx;
            int Ry2 = Ry * Ry;
            int twoRx2 = 2 * Rx2;
            int twoRy2 = 2 * Ry2;
            int p;
            int x = 0;
            int y = Ry;
            int px = 0;
            int py = twoRx2 * y;

            List<Point> res = new List<Point>();

            /* Plot the initial point in each quadrant. */
            ellipsePlotPoints(xCenter, yCenter, x, y, res);

            /* Region 1 */
            p = (int)Math.Abs(Ry2 - (Rx2 * Ry) + (0.25 * Rx2) );
            while (px < py)
            {
                x++;
                px += twoRy2;
                if (p < 0)
                    p += Ry2 + px;
                else
                {
                    y--;
                    py -= twoRx2;
                    p += Ry2 + px - py;
                }
                ellipsePlotPoints(xCenter, yCenter, x, y, res);
            }

            /* Region 2 */
            p = (int)Math.Abs(Ry2 * (x + 0.5) * (x + 0.5) + Rx2 * (y - 1) * (y - 1) - Rx2 * Ry2);
            while (y > 0)
            {
                y--;
                py -= twoRx2;
                if (p > 0)
                    p += Rx2 - py;
                else
                {
                    x++;
                    px += twoRy2;
                    p += Rx2 - py + px;
                }
                ellipsePlotPoints(xCenter, yCenter, x, y, res);
            }
            return res;
        }

        private static void ellipsePlotPoints(int xCenter, int yCenter, int x, int y, List<Point> setPixels)
        {
            setPixels.Add(new Point(xCenter + x, yCenter + y));
            setPixels.Add(new Point(xCenter - x, yCenter + y) );
            setPixels.Add(new Point(xCenter + x, yCenter - y) );
            setPixels.Add(new Point(xCenter - x, yCenter - y) );
        }
    }
}
