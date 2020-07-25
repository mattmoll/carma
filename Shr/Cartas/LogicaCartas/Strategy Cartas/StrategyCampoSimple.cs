using System;
using System.Collections.Generic;
using System.Text;

namespace Carm.Shr
{
    public class StrategyCampoSimple : Strategy
    {

        public StrategyCampoSimple(Bel.ECodigo p_eCodigo, Bel.LECodigos p_leCodigosSimples)
            : base(p_eCodigo)
        {
            
        }

        // Redefinimos el metodo dameString para la estrategia en particular de los campos simples (switch de equivalencia)
        override public string dameString()
        {
            string l_strEq;
            switch (m_eCodigo.Equivalencia.Trim())
            {
                case "cli_nro_altura":{ l_strEq = m_eCliente.Altura.ToString(); break;}
                case "cli_ede_direccion": { l_strEq = m_eCliente.Direccion; break;}
                case "cli_ede_rsocial": { l_strEq = m_eCliente.Rsocial; break;}
                case "cli_tel_telefono1": { l_strEq = m_eCliente.Telefono1; break;}
                case "cli_des_loc": { l_strEq = m_eCliente.Cli_des_loc; break; }
                case "cli_nro_numero": { l_strEq = m_eCliente.Numero.ToString(); break; }
                case "cli_nro_nroavalon": { l_strEq = m_eCliente.Nroavalon.ToString(); break; }
                default: { l_strEq = ""; break; }
            }

            return l_strEq;
        }

    }
}
