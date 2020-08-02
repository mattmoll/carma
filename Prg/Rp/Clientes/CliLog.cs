using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using TNGS.NetRoutines;
using TNGS.NetApp;
using TNGS.NetControls;
using Carm.Shr;
using TNGS.NetAppSupport;
using Carm.Bel;

namespace Carm.Rp
{
    public partial class CliLog : ReporteBase
    {
        // Miembros
        CDCombo cdcUsuarios = new CDCombo();
        DateEdit deFechaIni = new DateEdit();
        DateEdit deFechaFin = new DateEdit();

        // Constructor que llama al constructor base
        public CliLog() : base("CliLog") 
        {
            InitializeComponent();
        }

        public override void buildPanel()
        {
            // Llenamos la combo de usuarios
            Bel.LEVendedores l_leVendedores = Bll.Vendedores.UpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            
            cdcUsuarios.FillFromStrLEntidad(l_leVendedores, "vnd_nom_usuario", "vnd_ede_nya", "deleted");
            cdcUsuarios.AddStrCD("", "--- TODOS ---", 0);
            cdcUsuarios.SelectedStrCode = "";

            // Añadimos la combo al formulario.
            this.panelBuilder.AddControlWithLabel("Fecha Inicio", deFechaIni)
                             .AddControlWithLabel("Fecha Fin", deFechaFin)
                             .AddControlWithLabel("Usuarios", cdcUsuarios);

            
        }

        override public ListaEntidades realizarBusqueda(ref string p_strNombreEmpresa, ref string p_strPrograma,
                                                        ref string p_strNombreReporte, ref string p_strDetalleReporte,
                                                        ref int p_intCorteDeControl)
        {
            // Cargamos los valores por referencia para el posterior cargado del report en el form base.
            p_strNombreReporte = "Log Clientes por usuario: " + cdcUsuarios.SelectedItem.ToString();
            p_intCorteDeControl = 0;

            string l_strUsuarioIni, l_strUsuarioFin;

            // Logica de los limites de busqueda 
            if (cdcUsuarios.SelectedStrCode.Trim() == "")
            {
                l_strUsuarioIni = "  a";
                l_strUsuarioFin = "zzz";
            }
            else
                l_strUsuarioIni = l_strUsuarioFin = cdcUsuarios.SelectedStrCode;

            // Obtenemos la lista entidad.

            ListaEntidades l_leClientes = Bll.Clientes.ZLog(l_strUsuarioIni, l_strUsuarioFin, 
                                                            deFechaIni.Fecha, deFechaFin.Fecha, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            // Captionamos 
            l_leClientes.ChangeCaption(ELogCliente.UsuarioCmp, "V1UsuarioCN1");
            l_leClientes.ChangeCaption(ELogCliente.FechaCmp, "V1FechaFN1");
            l_leClientes.ChangeCaption(ELogCliente.AccionCmp, "V1AccionCN1");
            l_leClientes.ChangeCaption(ELogCliente.NroclienteCmp, "V1Nro. ClienteNN1");
            l_leClientes.ChangeCaption(ELogCliente.NroavalonCmp, "V1Nro. AvalonNN1");
            l_leClientes.ChangeCaption(ELogCliente.RsocialCmp, "V1Razón SocialCN1");
            l_leClientes.ChangeCaption(ELogCliente.NomfantasiaCmp, "V1Nombre FantasíaCN1");

            return l_leClientes;
        }
    }
}
