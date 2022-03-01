using System;
using System.Collections.Generic;

using NUnit.Framework;

using CodingChallenge.Entidades.Factory;
using CodingChallenge.Imprmir;
using CodingChallenge.Entidades;
using CodingChallenge.Entidades.Idiomas;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                new ImprimirFormaHTML(IdiomaReporte.CASTELLANO).Imprimir(new List<FormaGeometrica>() ));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                new ImprimirFormaHTML(IdiomaReporte.INGLES).Imprimir(new List<FormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometricaFactory().CrearCuadrado(5) };

            var resumen = new ImprimirFormaHTML(IdiomaReporte.CASTELLANO).Imprimir(cuadrados);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {

                new FormaGeometricaFactory().CrearCuadrado(5),
                new FormaGeometricaFactory().CrearCuadrado(1),
                new FormaGeometricaFactory().CrearCuadrado(3)
            };

            var resumen = new ImprimirFormaHTML(IdiomaReporte.INGLES).Imprimir(cuadrados);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {

                new FormaGeometricaFactory().CrearCuadrado(5),
                new FormaGeometricaFactory().CrearCirculo(3),
                new FormaGeometricaFactory().crearTrianguloEquilatero(4),
                new FormaGeometricaFactory().CrearCuadrado(2),
                new FormaGeometricaFactory().crearTrianguloEquilatero(9),
                new FormaGeometricaFactory().CrearCirculo(2.75m),
                new FormaGeometricaFactory().crearTrianguloEquilatero(4.2m)

            };

            var resumen = new ImprimirFormaHTML(IdiomaReporte.INGLES).Imprimir(formas);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometricaFactory().CrearCuadrado(5),
                new FormaGeometricaFactory().CrearCirculo(3),
                new FormaGeometricaFactory().crearTrianguloEquilatero(4),
                new FormaGeometricaFactory().CrearCuadrado(2),
                new FormaGeometricaFactory().crearTrianguloEquilatero(9),
                new FormaGeometricaFactory().CrearCirculo(2.75m),
                new FormaGeometricaFactory().crearTrianguloEquilatero(4.2m)
            };

            var resumen = new ImprimirFormaHTML(IdiomaReporte.CASTELLANO).Imprimir(formas);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 formas Perimetro 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellanoContrapecio()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometricaFactory().CrearCuadrado(5),
                new FormaGeometricaFactory().CrearCirculo(3),
                new FormaGeometricaFactory().crearTrianguloEquilatero(4),
                new FormaGeometricaFactory().CrearCuadrado(2),
                new FormaGeometricaFactory().crearTrianguloEquilatero(9),
                new FormaGeometricaFactory().CrearCirculo(2.75m),
                new FormaGeometricaFactory().crearTrianguloEquilatero(4.2m),
                new FormaGeometricaFactory().CrearTrapecio(4,3,2)
            };

            var resumen = new ImprimirFormaHTML(IdiomaReporte.CASTELLANO).Imprimir(formas);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>1 Trapecio | Area 7 | Perimetro 9 <br/>TOTAL:<br/>8 formas Perimetro 106.66 Area 98.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnPortuguesContrapecio()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometricaFactory().CrearCuadrado(5),
                new FormaGeometricaFactory().CrearCirculo(3),
                new FormaGeometricaFactory().crearTrianguloEquilatero(4),
                new FormaGeometricaFactory().CrearCuadrado(2),
                new FormaGeometricaFactory().crearTrianguloEquilatero(9),
                new FormaGeometricaFactory().CrearCirculo(2.75m),
                new FormaGeometricaFactory().crearTrianguloEquilatero(4.2m),
                new FormaGeometricaFactory().CrearTrapecio(4,3,2)
            };

            var resumen = new ImprimirFormaHTML(IdiomaReporte.PORTUGES).Imprimir(formas);

            Assert.AreEqual(
                "<h1>Relatório de formulários</h1>2 Quadrados | ÁREA 29 | Perimetro 28 <br/>2 CírculoS | ÁREA 13.01 | Perimetro 18.06 <br/>3 Triângulos | ÁREA 49.64 | Perimetro 51.6 <br/>1 Trapézio | ÁREA 7 | Perimetro 9 <br/>TOTAL:<br/>8 Formas Perimetro 106.66 ÁREA 98.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometricaFactory().CrearCuadrado(5),
                new FormaGeometricaFactory().CrearCirculo(3),
                new FormaGeometricaFactory().crearTrianguloEquilatero(4),
                new FormaGeometricaFactory().CrearCuadrado(2),
                new FormaGeometricaFactory().crearTrianguloEquilatero(9),
                new FormaGeometricaFactory().CrearCirculo(2.75m),
                new FormaGeometricaFactory().crearTrianguloEquilatero(4.2m),
                new FormaGeometricaFactory().CrearTrapecio(4,3,2)
            };

            var resumen = new ImprimirFormaHTML(IdiomaReporte.ITALIANO).Imprimir(formas);

            Assert.AreEqual(
                "<h1>Rapporto sui moduli</h1>2 quadratos | la zona 29 | Perimetro 28 <br/>2 cerchi | la zona 13.01 | Perimetro 18.06 <br/>3 triangoli | la zona 49.64 | Perimetro 51.6 <br/>1 trapezio | la zona 7 | Perimetro 9 <br/>TOTALE:<br/>8 Forme Perimetro 106.66 la zona 98.65",
                resumen);
        }

        [TestCase]
        public void TestResumenRectangulo ()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometricaFactory().CrearRectangulo(3,2)
            };

            var resumen = new ImprimirFormaHTML(IdiomaReporte.ITALIANO).Imprimir(formas);

            Assert.AreEqual(
                "<h1>Rapporto sui moduli</h1>1 Rettangolo | la zona 6 | Perimetro 10 <br/>TOTALE:<br/>1 Forme Perimetro 10 la zona 6",
                resumen);
        }

    }
}
