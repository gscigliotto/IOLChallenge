using CodingChallenge.Entidades;

namespace CodingChallenge.Entidades.Factory
{
    public interface IFormaGeometricaFactory
    {
        Circulo CrearCirculo(decimal diametro);
        Cuadrado CrearCuadrado(decimal lado);
        TrianguloEquilatero crearTrianguloEquilatero(decimal lado);
        Trapecio CrearTrapecio(decimal baseMenor, decimal baseMayor, decimal altura);
        Rectangulo CrearRectangulo(decimal baseLado, decimal altura);

    }
}
