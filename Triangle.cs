using System;

namespace TP1
{
    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override string ToString()
        {
            return $"Triange de côté A = {A}, B = {B}, C = {C}\n" +
                base.ToString();
        }

        public override double CalculAir()
        {
           var p = (A + B + C) / 2d;
           return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override double CalculPerimetre()
        {
            return A+B+C;
        }
    }
}