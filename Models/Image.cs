using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConsoleApp1.Models
{
    public class Image : Rectangle
    {
        public Image(PointF basePoint, PointF shift) : base(basePoint, shift)
        { }
        private List<Point> figures = new List<Point>();
        public void AddFigure(Triangle triangle)
        {
            if (Contains(triangle.Coordinates) && Contains(triangle.Shift) && Contains(triangle.ShiftToThirdCorner))
                figures.Add(triangle);
            else
                throw new Exception("This triangle is outside the image");
        }
        public void AddFigure(Rectangle rectangle)
        {
            if (Contains(rectangle.Coordinates) && Contains(rectangle.Shift))
                figures.Add(rectangle);
            else
                throw new Exception("This rectangle is outside the image");
        }
        public void AddFigure(Circle circle)
        {
            if (Contains(circle.Coordinates) &&
                Contains(new PointF(circle.Coordinates.X + circle.Radius, circle.Coordinates.Y + circle.Radius)) &&
                Contains(new PointF(circle.Coordinates.X - circle.Radius, circle.Coordinates.Y - circle.Radius)))
                figures.Add(circle);
            else
                throw new Exception("This circle is outside the image");
        }
        public override void Print()
        {
            Console.WriteLine("Image contains:");
            figures.ForEach((figure) => figure.Print());
            Console.WriteLine();
        }
        public override void Move(float x, float y)
        {
            //base.Move(x, y);
            figures.ForEach((figure) => figure.Move(x, y));
        }
        public override void ToScale(float scale)
        {
            //base.ToScale(scale);
            figures.ForEach((figure) => figure.ToScale(scale));
        }
        private bool Contains(PointF point) => (Coordinates.X <= point.X) && (point.X < (Coordinates.X + Shift.X)) && (Coordinates.Y <= point.Y) && (point.Y < (Coordinates.Y + Shift.Y));
    }
}
