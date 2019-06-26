using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesClasses
{
    class Circle
    {
        public string Name { get; private set; }
        public double Radius { get; private set; }
        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
        }
        public Circle(string name)
        {
            Name = name;
            Radius = 5;
        }
        public Circle()
        {
            Name = "Unknown";
            Radius = 5;
        }
        public void SayHello()
        {
            Console.WriteLine($"I'm a circle with the name {Name}!");
        }
        public void WriteArea()
        {
            double area = (Radius * Radius * Math.PI);
            Console.WriteLine($"My name is {Name}. I have a radius of {Radius} and an area of {area}");
        }
    }
}
