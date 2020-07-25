using System;
using System.Collections.Generic;
using System.Text;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using Carm.Bll;

namespace Carm.Shr
{
    class GetVendedor
    {
        StatMsg m_smResult = new StatMsg();
        Bel.EVendedor m_eVendedor;

        // Cosntructor que recibe el codigo de vendedor y carga el miembro consiguiendolo de la base.
        public GetVendedor(string p_strCodVend)
        {
            // Traemos de la base el vendedor a partir del codigo que tiene el cliente asociado.
            m_eVendedor = Bll.Vendedores.Get(p_strCodVend, false, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(null, m_smResult)) return;
        }

        public string dameEmailVendedor()
        {
            if (m_eVendedor != null)
                return m_eVendedor.Email;
            else
                return "";
        }

        // Devuelve el nombre y apellido del vendedor obtenido.
        public string dameNombreVendedor()
        {
            if (m_eVendedor != null)
                return m_eVendedor.Vnd_ede_nya;
            else
                return "";
        }

    }
}
