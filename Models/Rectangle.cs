using System;
using System.Drawing;

namespace ConsoleApp1.Models
{
    public class Rectangle : Point
    {
        public Rectangle(PointF basePoint, PointF shift) : base(basePoint) => Shift = shift;
        public PointF Shift { get; protected set; }
        public override void Print() => Console.WriteLine($"Rectangle.\nSides of the rectangle:\n\tA:X = {Coordinates.X}, A:Y = {Coordinates.Y}\n\tB:X = {Coordinates.X+Shift.X}, B:Y = {Coordinates.Y}\n\tC:X = {Coordinates.X+Shift.X}, C:Y = {Coordinates.Y+Shift.Y}\n\tD:X = {Coordinates.X}, D:Y = {Coordinates.Y+Shift.Y}");
        public override void Move(float x, float y) => Coordinates += new SizeF(x, y);
        public override void ToScale(float scale)
        {
            Coordinates = new PointF(Coordinates.X * scale, Coordinates.Y * scale);
            Shift = new PointF(Shift.X * scale, Shift.Y * scale);
        }
    }
}
