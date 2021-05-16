using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDA_And_Bresenham_Algorithm
{
    class LineDrawing
    {
        //static Form1 f1 = new Form1();
        public static List<Point> lineDDA(int x0, int y0, int xEnd, int yEnd)
        {
            List<Point> setPixels = new List<Point>();
            int dx = xEnd - x0,
                dy = yEnd - y0,
                steps, k;
            float xIncrement, yIncrement, x = x0, y = y0;
            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;
            setPixels.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                setPixels.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
            }
            return setPixels;
        }

        public static List<Point> lineBres(int x0, int y0, int xEnd, int yEnd)
        {
            List<Point> setPixels = new List<Point>();
            int dx = Math.Abs(xEnd - x0), dy = Math.Abs(yEnd - y0);
            int p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);
            int x, y;
            /* Determine which endpoint to use as start position. */
            if (x0 > xEnd)
            {
                x = xEnd;
                y = yEnd;
                xEnd = x0;
            }
            else
            {
                x = x0;
                y = y0;
            }
            setPixels.Add(new Point(x, y));
            while (x < xEnd)
            {
                x++;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y++;
                    p += twoDyMinusDx;
                }
                setPixels.Add(new Point(x, y));
            }
            return setPixels;
        }
    }
}
