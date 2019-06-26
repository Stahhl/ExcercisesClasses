using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercisesClasses
{
    class Cube
    {
        public double Height { get; private set; }
        public double Width { get; private set; }
        public double Depth { get; private set; }


        public double GetVolume => (Height * Width * Depth);

        public Cube(double x, double y, double z)
        {
            Width = x;
            Height = y;
            Depth = z;
        }
        public void WriteVolume()
        {
            double volume = (Height * Width * Depth);
            Console.WriteLine($"The volume of the cube is {volume}");
        }
        public double CalculateVolume()
        {
            return (Height * Width * Depth);
        }
             
    }
}
