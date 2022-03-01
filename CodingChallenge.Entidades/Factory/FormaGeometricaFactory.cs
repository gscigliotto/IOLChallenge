

using CodingChallenge.Entidades;


namespace CodingChallenge.Entidades.Factory
{
    public  class FormaGeometricaFactory : IFormaGeometricaFactory
    {
        public Circulo CrearCirculo(decimal diametro)
        {
            return new Circulo(diametro);
         
        }

        public Cuadrado CrearCuadrado(decimal lado)
        {
            return new Cuadrado(lado);
        }

        public Trapecio CrearTrapecio(decimal baseMenor, decimal baseMayor, decimal altura)
        {
            return new Trapecio(baseMenor, baseMayor,altura);
        }

        public TrianguloEquilatero crearTrianguloEquilatero(decimal lado)
        {
            return new TrianguloEquilatero(lado);
        }
        public Rectangulo CrearRectangulo(decimal baseLado, decimal altura)
        {
            return new Rectangulo( baseLado,altura);
        }
    }
}
