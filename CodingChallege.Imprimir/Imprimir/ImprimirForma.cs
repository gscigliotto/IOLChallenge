


using CodingChallenge.Data.DAO;
using CodingChallenge.Entidades;
using CodingChallenge.Entidades.Idiomas;
using System.Collections.Generic;

namespace CodingChallenge.Imprmir
{
    public class ImprimirForma
    {
        public Idioma idioma;

        public ImprimirForma( IdiomaReporte idiomaReporte)
        {
            IdiomaDAO idiomaDao = new IdiomaDAO();
            idioma = idiomaDao.getIdioma((int)idiomaReporte);

        }



    
    }
}
