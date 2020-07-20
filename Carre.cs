using System;

namespace TP1
{
    internal class Carre : Forme
    {
        public int Longueur { get; set; }

        public override string ToString()
        {
            return $"Carre de côté {Longueur}\n" +
                $"Aire = {this.CalculAir()}\n" +
                $"Périmètre = {this.CalculPerimetre()}";
        }

        
        public override double CalculAir()
        {
            return Longueur * Longueur;
        }

        public override double CalculPerimetre()
        {
            return Longueur * 4;
        }

    }
}