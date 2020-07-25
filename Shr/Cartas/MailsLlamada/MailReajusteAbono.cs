using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carm.Shr
{
    public class MailReajusteAbono : MailLlamada
    {
        public decimal abonoAnterior { get; private set; }
        public decimal ajuste { get; private set; }
        public decimal nuevoAbono { get; private set; }

        public MailReajusteAbono(int nroCliente, int numeroAvalon, string razonSocial, string usuario, string observacion, decimal abonoAnterior, decimal ajuste, decimal nuevoAbono)
        {
            this.CargarDatosBase(nroCliente, numeroAvalon, razonSocial, usuario, observacion);
            this.abonoAnterior = abonoAnterior;
            this.ajuste = ajuste;
            this.nuevoAbono = nuevoAbono;
        }

        public override string textoConTusDatosParticulares()
        {
            return String.Format("Tuvo un reajuste de abono. Su abono anterior era: ${0} , el ajuste aplicado es de: ${1} y por lo tanto su nuevo abono es: ${2}", 
                                  this.abonoAnterior, this.ajuste, this.nuevoAbono);
        }

        public override string tipoLlamada()
        {
            return "Reajuste Abono";
        }
    }
}
