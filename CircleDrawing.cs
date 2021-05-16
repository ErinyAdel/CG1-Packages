using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDA_And_Bresenham_Algorithm
{
    class CircleDrawing
    {
        private static void circlePlotPoints(int Xc, int Yc, int x, int y, List<Point> setPixels)
        {
            //List<Point> setPixels = new List<Point>();

            setPixels.Add(new Point(Xc + x, Yc + y));
            setPixels.Add(new Point(Xc + y, Yc + x));

            setPixels.Add(new Point(Xc - y, Yc + x));
            setPixels.Add(new Point(Xc - x, Yc + y));

            setPixels.Add(new Point(Xc - x, Yc - y));
            setPixels.Add(new Point(Xc - y, Yc - x));

            setPixels.Add(new Point(Xc + y, Yc - x));
            setPixels.Add(new Point(Xc + x, Yc - y));

            // return setPixels;
        }

        public static List<Point> circleMidpoint(int Xc, int Yc, int r)
        {
            int x = 0;
            int y = r;
            int d = 1 - r;

            // Plot First Set Of Points //
            List<Point> res = new List<Point>();
            circlePlotPoints(Xc,Yc,x,y,res);
            while (x < y)
            {
                x++;
                if (d < 0)
                    d += 2 * (x + 1) + 1;
                else {
                    y--;
                    d += 2 * (x + 1) + 1 - 2 * (y - 1);
                }
                circlePlotPoints(Xc, Yc, x, y, res);
            }

            return res;
        }
    }
}
