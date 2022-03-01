using System;


namespace CodingChallenge.Entidades
{
   
    public class Circulo : FormaGeometrica
    {
        private decimal _lado;

        public Circulo(decimal ancho)
        {
            this._lado = ancho;
        }
        public override decimal CalcularArea()
        {

            return (decimal)Math.PI * (this._lado / 2) * (this._lado / 2);

        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;

        }

    }
}
