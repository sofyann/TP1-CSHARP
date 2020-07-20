using System;

namespace TP1
{
    internal class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public override string ToString()
        {
            return $"Rectangle de longueur =  {Longueur} at largeur= {Largeur}\n" +
                $"Aire = {this.CalculAir()}\n" +
                $"Périmètre = {this.CalculPerimetre()}";
        }

        public override double CalculAir()
        {
            return Largeur * Longueur;
        }

        public override double CalculPerimetre()
        {
            return (Largeur + Longueur) * 2;
        }
    }
}