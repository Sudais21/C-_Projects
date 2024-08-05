using System;
using System.Drawing;

namespace Project002
{
    public class Line
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Color LineColor { get; set; }

        public Line(Point point1, Point point2, Color lineColor)
        {
            Point1 = point1;
            Point2 = point2;
            LineColor = lineColor;
        }

        public override string ToString()
        {
            return $"({Point1.X}, {Point1.Y}) - ({Point2.X}, {Point2.Y})";
        }

        
    }

}
