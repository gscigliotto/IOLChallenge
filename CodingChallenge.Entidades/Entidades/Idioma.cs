
using System.Collections.Generic;


namespace CodingChallenge.Entidades
{
    public class Idioma 
    {
        private Dictionary<string, string> ReporteLabel { get; set; }

        public string GetLabel(string clave)
        {
            return this.ReporteLabel[clave];
        }
        public void SetLabelDictionary(Dictionary<string,string> dictionary) {
            this.ReporteLabel = dictionary;
        }


    }
}
