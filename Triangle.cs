using System;
using System.Drawing;

namespace ConsoleApp1
{
    public class Triangle : Rectangle
    {
        public Triangle(PointF basePoint, PointF shiftToSecondCorner, PointF shiftToThirdCorner) : base(basePoint, shiftToSecondCorner)
        {
            this.ShiftToThirdCorner = shiftToThirdCorner;
        }
        public PointF ShiftToThirdCorner { get; protected set; }
        public override void Print() => Console.WriteLine($"Triangle.\nSides of the Triangle:\n\tA:X = {Coordinates.X}, A:Y = {Coordinates.Y}\n\tB:X = {Coordinates.X+Shift.X}, B:Y = {Coordinates.Y+Shift.Y}\n\tC:X = {Coordinates.X+ShiftToThirdCorner.X}, C:Y = {Coordinates.Y+ShiftToThirdCorner.Y}");
        public override void ToScale(float scale)
        {
            base.ToScale(scale);
            ShiftToThirdCorner = new PointF(ShiftToThirdCorner.X * scale, ShiftToThirdCorner.Y * scale);
        }
    }
}
