using System;
using System.Drawing;
using System.Dynamic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(new PointF(300, 500), 200f);
            var rectangle = new Rectangle(new PointF(150, 15), new PointF(700, 250));
            var triangle = new Triangle(new PointF(150, 15), new PointF(185, 375), new PointF(11, 32));
            var image = new Image(new PointF(0, 0), new PointF(1500, 2500));
            circle.Print();
            rectangle.Print();
            triangle.Print();
            image.AddFigure(circle);
            image.AddFigure(rectangle);
            image.AddFigure(triangle);
            image.ToScale(10f);
            image.Print();
            image.Move(117, 225);
            image.Print();
            Console.ReadLine();
        }
    }
}