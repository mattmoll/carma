using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using Carm.Bll;

namespace Carm.Shr
{
    public class StrategyConVentana : Strategy
    {
        FormBase m_formAEjecutar;
        bool m_boolYaSeEjecuto;

        public StrategyConVentana(Bel.ECodigo p_eCodigo)
            : base(p_eCodigo)
        {
            m_boolYaSeEjecuto = false;
        }

        // Metodo que inyecta el cliente al formulario y lo dispara obteniendo el resultado.
        override public string dameString()
        {
            if ((m_boolYaSeEjecuto) && !(m_formAEjecutar.debePedirInputNuevamente()))
                return m_formAEjecutar.dameString();

            // inyectamos la dependencia del cliente
            m_formAEjecutar.inyectClient(base.m_eCliente);
            m_formAEjecutar.codigoAReemplazar = this.descripcionCodigo;

            // Ejecutamos el form.
            m_formAEjecutar.ShowDialog(null);

            // Si finaliza bien, devolvemos la string resultado, sino vacio.
            if (m_formAEjecutar.DialogResult == DialogResult.OK)
            {
                m_boolYaSeEjecuto = true;
                return m_formAEjecutar.dameString();
            }
            else
                return "";
        }

        // Metodo que permite inyectar un formulario al strategy.
        public void inyectFormulario(FormBase p_frmFormulario)
        {
            m_formAEjecutar = p_frmFormulario;
        }

    }
}
