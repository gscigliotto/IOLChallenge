/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. 
 * Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using CodingChallenge.Entidades;
using CodingChallenge.Entidades.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Imprmir
{
    public class ImprimirFormaHTML : ImprimirForma
    {

        public ImprimirFormaHTML(IdiomaReporte idioma) : base(idioma)
        {
            
        }

        public string Imprimir(List<FormaGeometrica> formas)
        {

            return this.Imprimir(formas,this.idioma);

 
        }
        private string Imprimir(List<FormaGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();
            if (!formas.Any())
            {

                sb.Append("<h1>" + idioma.GetLabel("Listavacia") + "</h1>");

            }
            else
            {
                sb.Append("<h1>" + idioma.GetLabel("Cabecera") + "</h1>");

                var formasGroup = formas.GroupBy(e => e.GetType()).Select(group => new { forma = group.Key, area = group.Sum(item => item.CalcularArea()), perimetro = group.Sum(item => item.CalcularPerimetro()), cantidad = group.Count() });
                foreach (var forma in formasGroup)
                {
                    sb.Append(ObtenerLinea(forma.cantidad, forma.area, forma.perimetro, forma.forma, idioma));
                }

                // FOOTER
                sb.Append(idioma.GetLabel("Total") + "<br/>");
                sb.Append(formasGroup.Sum(e => e.cantidad) + " " + idioma.GetLabel("Formas") + " ");
                sb.Append(idioma.GetLabel("Perimetro") + " " + formasGroup.Sum(e => e.perimetro).ToString("#.##") + " ");
                sb.Append(idioma.GetLabel("Area") + " " + (formasGroup.Sum(e => e.area)).ToString("#.##"));
            }
            return sb.ToString();

        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Type forma, Idioma reporteLang)
        {
            if (cantidad > 0)
            {

                return $"{cantidad} {TraducirForma(forma, cantidad, reporteLang)} | "+ reporteLang.GetLabel("Area") + " " + area.ToString("#.##") +" | "+ reporteLang.GetLabel("Perimetro") + " "+ perimetro.ToString("#.##") +" <br/>";

            }

            return string.Empty;
        }

        private static string TraducirForma(Type tipo, int cantidad, Idioma reporteLang)
        {
            return cantidad == 1 ? reporteLang.GetLabel(tipo.Name) : reporteLang.GetLabel(tipo.Name+"Plural");
        }


    }
}
