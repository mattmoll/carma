using System;
using System.Collections.Generic;
using System.Text;

namespace Carm.Shr
{
    class CodigoCarta
    {
        public int index;
        public string codigo;

        public CodigoCarta(int p_intIndex,string p_strCodigo)
        {
            index = p_intIndex;
            codigo = p_strCodigo;
        }

        public bool esCodigoVariable
        {
            get
            {
                return (this.codigo.Length == (int)Enumeradores.limCaracteres.campoVariable);
            }
        }

        public string descripcionCodigo
        {
            get
            {
                int indiceFinal = 0;
                string descripcion;
                if (this.esCodigoVariable)
                {
                    // Remove the initial part of the code.
                    descripcion = this.codigo.Remove(0, 3);
                    indiceFinal = descripcion.IndexOf('*');
                    if (indiceFinal == 0)
                        indiceFinal = descripcion.IndexOf("##");
                    descripcion = descripcion.Remove(indiceFinal, descripcion.Length - indiceFinal);
                    return descripcion;
                }
                else
                {
                    // no se usa por ahora. Si es necesario agregarlo.
                    return "";
                }
            }
        }
    }
}
