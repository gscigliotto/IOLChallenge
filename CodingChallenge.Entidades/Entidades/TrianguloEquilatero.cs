using System;


namespace CodingChallenge.Entidades
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private decimal _lado;
        public TrianguloEquilatero(decimal ancho)
        {
            this._lado = ancho;
        }
        public override decimal CalcularArea()
        {

            return ((decimal)Math.Sqrt(3) / 4) * this._lado * this._lado;

        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;

        }
    }
}
