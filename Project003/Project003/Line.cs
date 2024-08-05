using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project003
{
    public class Line
    {
        private Point startPoint;
        private Point endPoint;
        private string color;

        public Line(Point startPoint, Point endPoint, string color)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.color = color;
        }

        public Line(Point startPoint, Point endPoint, System.Drawing.Color lineColor)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            LineColor = lineColor;
        }

        public Point StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        public Point EndPoint
        {
            get { return endPoint; }
            set { endPoint = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public object LineColor { get; internal set; }

        public override string ToString()
        {
            return string.Format("Start Point: ({0}), End Point: ({1})", startPoint, endPoint);
        }
    }

    public class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", x, y);
        }
    }
    public bool IntersectsWith(Line other, out PointF intersection)
    {
        intersection = PointF.Empty;

        float x1 = Start.X;
        float y1 = Start.Y;
        float x2 = End.X;
        float y2 = End.Y;
        float x3 = other.Start.X;
        float y3 = other.Start.Y;
        float x4 = other.End.X;
        float y4 = other.End.Y;

        float det = (x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4);

        if (det == 0)
        {
            return false;
        }

        float xi = ((x3 - x4) * (x1 * y2 - y1 * x2) - (x1 - x2) * (x3 * y4 - y3 * x4)) / det;
        float yi = ((y3 - y4) * (x1 * y2 - y1 * x2) - (y1 - y2) * (x3 * y4 - y3 * x4)) / det;

        intersection = new PointF(xi, yi);

        return (xi >= Math.Min(x1, x2) && xi <= Math.Max(x1, x2) &&
                yi >= Math.Min(y1, y2) && yi <= Math.Max(y1, y2)) &&
                (xi >= Math.Min(x3, x4) && xi <= Math.Max(x3, x4) &&
                 yi >= Math.Min(y3, y4) && yi <= Math.Max(y3, y4));


    }
}
