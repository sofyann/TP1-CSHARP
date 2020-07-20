using System;

namespace TP1
{
    internal class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override string ToString()
        {
            return $"Cercle de rayon {Rayon}\n" +
                $"Aire = {this.CalculAir()}\n" +
                $"Périmètre = {this.CalculPerimetre()}";
        }

        public override double CalculAir()
        {
            return Math.PI * (Rayon * Rayon);
        }

        public override double CalculPerimetre()
        {
            return 2 * Math.PI * Rayon;
        }
    }
}