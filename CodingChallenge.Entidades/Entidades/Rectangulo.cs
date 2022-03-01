using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Entidades
{
    public class Rectangulo : FormaGeometrica
    {
        private decimal baseLado { get; set; }
        private decimal altura { get; set; }

        public Rectangulo(decimal baseLado ,decimal altura)
        {
            this.baseLado = baseLado;
            this.altura = altura;

        }

        public override decimal CalcularArea()
        {
            return this.baseLado * this.altura;

        }

        public override decimal CalcularPerimetro()
        {
            return (this.altura+this.baseLado) * 2 ;

        }

    }
}
