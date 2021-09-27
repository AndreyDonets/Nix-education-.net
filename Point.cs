using System.Drawing;

namespace ConsoleApp1
{
    public abstract class Point
    {
        public PointF Coordinates { get; protected set; }
        public abstract void Print(); 
        // public abstract string Print();
        public abstract void Move(float x, float y);
        public abstract void ToScale(float scale);
    }
}
