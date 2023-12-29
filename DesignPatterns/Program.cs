using System;
using System.Collections.Generic;
namespace DesignPatterns
{
    public interface IShape
    {
        IShape Clone();
        void DisplayInfo();
    }

    public class Circle : IShape
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public IShape Clone()
        {
            return new Circle(Radius);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Circle with radius {Radius}");
        }

    }
    public class Square : IShape
    {
        public int SideLength { get; set; }

        public Square(int sideLength)
        {
            SideLength = sideLength;
        }

        public IShape Clone()
        {
            return new Square(SideLength);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Square with side length {SideLength}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create a dictionary to store prototypes
            Dictionary<string, IShape> shapePrototypes = new Dictionary<string, IShape>();

            shapePrototypes["Circle"] = new Circle(10);
            shapePrototypes["Square"] = new Square(20);

            IShape newCircle = shapePrototypes["Circle"].Clone();
            IShape newSquare = shapePrototypes["Square"].Clone();

            newCircle.DisplayInfo();
            newSquare.DisplayInfo();
        }
    }
}