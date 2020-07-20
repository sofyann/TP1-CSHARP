namespace TP1
{
    public abstract class Forme
    {
        public abstract double CalculAir();
        public abstract double CalculPerimetre();

        public override string ToString()
        {
            return $"Aire = {this.CalculAir()}\n" +
                $"Périmètre = {this.CalculPerimetre()}"; ;
        }
    }

}