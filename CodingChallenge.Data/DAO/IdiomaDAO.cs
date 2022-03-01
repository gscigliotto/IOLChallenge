
using CodingChallenge.Entidades;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

using System.IO;


namespace CodingChallenge.Data.DAO
{
    public class IdiomaDAO: IIdiomaDAO
    {
        public  Idioma getIdioma(int idioma)
        {
            Idioma reporte = new Idioma();

            //TODO TOMAR LA RUTA DE UN PARAMETRO
            StreamReader r = new StreamReader ( "CodingChallenge.Data\\Idiomas.json");
            string json =r.ReadToEnd();

            var  rta = JObject.Parse(json);
            var idm = rta[Convert.ToString(idioma)];
            if (rta[Convert.ToString(idioma)] != null)
            {
                reporte.SetLabelDictionary(JsonConvert.DeserializeObject<Dictionary<string, string>>(idm.ToString()));

            }
            else
            {
                throw new Exception("No esta dado de alta el idioma seleccionado en el archivo de idiomas");
            }
            return reporte;

        }
    }
}
