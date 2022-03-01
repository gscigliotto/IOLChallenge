

namespace CodingChallenge.Entidades
{
    public abstract class FormaGeometrica
    {

        public string Nombre { get; set; }
        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();
    }
}
