using CodingChallenge.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.DAO
{
    interface IIdiomaDAO
    {
        Idioma getIdioma(int idioma);
    }
}
