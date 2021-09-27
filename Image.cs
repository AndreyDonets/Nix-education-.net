using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConsoleApp1
{
    public class Image : Rectangle
    {
        public Image(PointF basePoint, PointF shift) : base(basePoint, shift) { }
        private List<Point> figures = new List<Point>();
        public void AddFigure<T>(T figure) where T : Point
        {
            if (Contains(figure.Coordinates))
            {
                if (figure is Circle &&
                    Contains(new PointF(figure.Coordinates.X + (figure as Circle).Radius, figure.Coordinates.Y + (figure as Circle).Radius)) &&
                    Contains(new PointF(figure.Coordinates.X - (figure as Circle).Radius, figure.Coordinates.Y - (figure as Circle).Radius))) { }
                else if (figure is Rectangle && Contains((figure as Rectangle).Shift))
                {
                    if (figure is Triangle && !Contains((figure as Triangle).ShiftToThirdCorner))
                        throw new Exception("This triangle is outside the image");
                }
                else
                    throw new Exception("This figure is outside the image");
            }
            else
                throw new Exception("This point is outside the image");
            figures.Add(figure);
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
