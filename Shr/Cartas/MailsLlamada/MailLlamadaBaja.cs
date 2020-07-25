using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carm.Shr
{
    public class MailLlamadaBaja : MailLlamada
    {

        public string categoria { get; private set; }
        public string motivo { get; private set; }

        public MailLlamadaBaja(int nroCliente, int numeroAvalon, string razonSocial, string usuario, string categoria, string motivo, string observacion)
        {
            this.CargarDatosBase(nroCliente, numeroAvalon, razonSocial, usuario, observacion);
            this.categoria = categoria;
            this.motivo = motivo;
        }

        public override string textoConTusDatosParticulares()
        {
            return String.Format("Fue dado de Baja debido al siguiente motivo: {0} que pertenece a la siguiente categoría: {1}.",
                                  this.categoria, this.motivo);
        }

        public override string tipoLlamada()
        {
            return "Baja";
        }
    }
}
