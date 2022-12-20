using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Recap.Inheritance
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();
    }

    public sealed class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public double GetRadius()
        {
            return radius;
        }
    }

    public sealed class Rectangle : Shape
    {
        private double width;

        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }

        public override double GetPerimeter()
        {
            return 2 * width + 2 * height;
        }
    }
}
