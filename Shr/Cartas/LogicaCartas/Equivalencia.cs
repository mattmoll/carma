using System;
using System.Collections.Generic;
using System.Text;

namespace Carm.Shr
{
    class Equivalencia
    {
        public CodigoCarta codigoCarta;
        public string equivalencia;

        public Equivalencia(CodigoCarta p_ccCod, string p_strEq)
        {
            equivalencia = p_strEq;
            codigoCarta = p_ccCod;
        }
    }
}
