using System;
using System.Collections.Generic;
using System.Text;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using Carm.Bll;


namespace Carm.Shr
{
    public class StrategyReservador : Strategy
    {
        StatMsg m_smResult = new StatMsg();

        // Llamamos al constructor del padre.
        public StrategyReservador(Bel.ECodigo p_eCodigo) : base(p_eCodigo) { }

        // Redefinimos el metodo dameString para que devuelve el nombre y apellido del vendedor reservador
        override public string dameString()
        {
            // Instanciamos el objeto que nos dara el nombre del reservador con el codigo de vendedor sacado del cliente 
            GetVendedor l_nvGetName = new GetVendedor(this.m_eCliente.Codvend);

            //Devolvemos el nombre y apellido del vendedor.
            return l_nvGetName.dameNombreVendedor();
        }
    }
}
