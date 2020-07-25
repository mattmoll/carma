using System;
using System.Collections.Generic;
using System.Text;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using Carm.Bll;


namespace Carm.Shr
{
    public class StrategyEmisor : Strategy
    {
        StatMsg m_smResult = new StatMsg();

        // Llamamos al constructor del padre.
        public StrategyEmisor(Bel.ECodigo p_eCodigo) : base(p_eCodigo) { }

        // Redefinimos el metodo dameString para que devuelve 
        override public string dameString()
        {
            // Conseguimos el codigo de vendedor a partir del usuario.
            string l_strCodVend = Bll.Vendedores.fGetCodVendAsString(m_smResult);

            // Instanciamos el objeto que nos dara el nombre del reservador con el codigo de vendedor sacado del DBConn
            GetVendedor l_nvGetName = new GetVendedor(l_strCodVend);

            //Devolvemos el nombre y apellido del vendedor.
            return l_nvGetName.dameNombreVendedor();
        }
    }
}


