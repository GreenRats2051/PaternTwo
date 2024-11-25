using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Num1
{
    public class Sphere : ICloneable
    {
        public string Color { get; set; }
        public (float X, float Y, float Z) Position { get; set; }

        public Sphere(string color, (float X, float Y, float Z) position)
        {
            Color = color;
            Position = position;
        }

        public ICloneable Clone()
        {
            return new Sphere(Color, Position);
        }

        public override string ToString()
        {
            return $"Круг: Цвет={Color}, Позиция=({Position.X}, {Position.Y}, {Position.Z})";
        }
    }
}
