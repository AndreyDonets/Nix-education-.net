using System;
using System.Drawing;

namespace ConsoleApp1
{
    public class Circle : Point
    {
        public Circle(PointF center, float radius)
        {
            Coordinates = center;
            if (radius <= 0)
                throw new ArgumentException("Radius cannot be less than or equal to zero");
            this.Radius = radius;
        }
        public float Radius { get; protected set; }
        public override void Move(float x, float y) => Coordinates += new SizeF(x, y);
        public override void Print() => Console.WriteLine($"Circle.\nCenter of circle: x = {Coordinates.X}, y = {Coordinates.Y}\n Radius = {Radius}");
        public override void ToScale(float scale)
        {
            Coordinates = new PointF(Coordinates.X * scale, Coordinates.Y * scale);
            Radius = Radius * scale;
        }
    }
}
