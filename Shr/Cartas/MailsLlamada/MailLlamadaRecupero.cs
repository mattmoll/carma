using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carm.Shr
{
    public class MailLlamadaRecupero : MailLlamada
    {
        public decimal valorRecuperado { get; private set; }

        public MailLlamadaRecupero(int nroCliente, int numeroAvalon, string razonSocial, string usuario, decimal valorRecuperado, string observacion)
        {
            this.CargarDatosBase(nroCliente, numeroAvalon, razonSocial, usuario, observacion);
            this.valorRecuperado = valorRecuperado;
            this.observacion = observacion;
        }

        public override string textoConTusDatosParticulares()
        {
            return String.Format("Fue recuperado con el siguiente valor: ${0}.", this.valorRecuperado);
        }

        public override string tipoLlamada()
        {
            return "Recupero";
        }
    }
}
