using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carm.Shr
{
    public abstract class MailLlamada
    {
        public int numeroCliente { get; protected set; }
        public int nroAvalon { get; protected set; }
        public string razonSocial { get; protected set; }
        public string usuario { get; protected set; }
        public string observacion { get; protected set; }

        protected void CargarDatosBase(int nroCliente, int numeroAvalon, string razonSocial, string usuario, string observacion)
        {
            this.numeroCliente = nroCliente;
            this.nroAvalon = numeroAvalon;
            this.razonSocial = razonSocial;
            this.usuario = usuario;
            this.observacion = observacion;
        }

        public abstract string textoConTusDatosParticulares();
        public abstract string tipoLlamada();

        public virtual string getTextoMail()
        {
            string textoMail = "";
            textoMail = String.Format("El cliente con número de Avalon : {0}, cuya razón social es: {1} \r\n {2} \r\n Gestion cargada por el usuario: {3}. \r\n Observaciones: {4} \n\n\n Atte. SIMA",
                                      this.nroAvalon, this.razonSocial, this.textoConTusDatosParticulares(), this.usuario, this.observacion);

            return textoMail;
        }

        public virtual string getTituloMail()
        {
            // El titulo es este texto generico mas el titulo que nos da la subclase que conoce el tipo de mail llamada correspondiente.
            return "SIMA: Mail generado automaticamente con motivo de informar un/a " + this.tipoLlamada();
        }


    }
}
