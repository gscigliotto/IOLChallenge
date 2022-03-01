

namespace CodingChallenge.Entidades
{
    public class Cuadrado : FormaGeometrica
    {
        private decimal _lado;

        public Cuadrado(decimal lado)
        {
            this._lado = lado;
        }

         
        public override decimal CalcularArea()
        {
              return this._lado * this._lado;
            
        }

        public override decimal CalcularPerimetro()
        {
            return this._lado * 4;
            
        }

    }
}
