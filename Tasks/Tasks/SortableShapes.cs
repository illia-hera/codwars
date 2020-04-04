using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Shape : IComparable<Shape>
    {
        protected double area;

        public int CompareTo(Shape comparePart)
        {
            return this.area.CompareTo(comparePart.area);
        }

        private static void Main()
        {

        }
    }

    public class CustomShape : Shape
    {
        public CustomShape(double area)
        {
            base.area = area;
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            base.area = width * height;
        }
    }

    public class Square : Shape
    {
        public Square(double side)
        {
            base.area = Math.Pow(side, 2);
        }
    }

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            base.area = Math.Pow(radius, 2) * Math.PI;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double triangleBase, double height)
        {
            base.area = triangleBase * height / 2;
        }
    }
}
