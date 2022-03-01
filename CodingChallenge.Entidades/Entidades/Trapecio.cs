

namespace CodingChallenge.Entidades
{
    public class Trapecio: FormaGeometrica
    {
        private decimal baseMenor;
        private decimal baseMayor;
        private decimal altura;
        public Trapecio(decimal baseMenor, decimal baseMayor, decimal altura)
        {
            this.baseMenor = baseMenor;
            this.baseMayor = baseMayor;
            this.altura = altura;
        }
        public override decimal CalcularArea()
        {

            return (decimal) ( (baseMenor+baseMayor)/2) * altura;

        }

        public override decimal CalcularPerimetro()
        {
            return baseMenor + baseMayor + altura;

        }
    }
}
