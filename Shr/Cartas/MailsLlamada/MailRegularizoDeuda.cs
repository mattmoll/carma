using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carm.Shr
{
    public class MailRegularizoDeuda : MailLlamada
    {
        public MailRegularizoDeuda(int nroCliente, int numeroAvalon, string razonSocial, string usuario, string observacion)
        {
            this.CargarDatosBase(nroCliente, numeroAvalon, razonSocial, usuario, observacion);
        }

        public override string textoConTusDatosParticulares()
        {
            return String.Format("Regularizó su deuda.");
        }

        public override string tipoLlamada()
        {
            return "Regularización de Deuda";
        }
    }
}
