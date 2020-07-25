using System;
using System.Collections.Generic;
using System.Text;

namespace Carm.Shr
{
    public abstract class Strategy
    {
        protected Bel.ECodigo m_eCodigo;
        protected Bel.ECliente m_eCliente;
        protected string descripcionCodigo;

        // Constructor que recibe el codigo (del formato de carta) a procesar por parametro
        public Strategy(Bel.ECodigo p_eCodigo)
        {
            m_eCodigo = p_eCodigo;
        }

        // Metodo que inyecta la relacion con el cliente.
        public void inyectClient(Bel.ECliente p_eCliente)
        {
            m_eCliente = p_eCliente;
        }

        public void inyectDescripcionCodigo(string codigo)
        {
            this.descripcionCodigo = codigo;
        }

        // Obligamos a las clases derivadas a definir el metodo dameString que tiene la estrategia en particular.
        abstract public string dameString();

    }
}
