using System;
using System.Data;
using TNGS.NetApp;
using TNGS.NetControls;
using TNGS.NetRoutines;

namespace Carm.Tg
{
    public class CargadorCliente : CargadorExcel
    {
        public string CodMarca { get; set; } = "";

        private StatMsg m_smResult = new StatMsg();

        public override void llenarListaCampos(CDList p_cdlListaCampos)
        {
            p_cdlListaCampos.AddIntCD(1, "01.R. SOCIAL", 0);
            p_cdlListaCampos.AddIntCD(2, "02.N. FANTASÍA", 0);
            p_cdlListaCampos.AddIntCD(3, "03.TELEFONO", 0);
            p_cdlListaCampos.AddIntCD(4, "04.CELULAR", 0);
            p_cdlListaCampos.AddIntCD(5, "05.TELEFONO2", 0);
            p_cdlListaCampos.AddIntCD(6, "06.FAX", 0);
            p_cdlListaCampos.AddIntCD(7, "07.LOCALIDAD (DESCRIPCIÓN)", 0);
            p_cdlListaCampos.AddIntCD(8, "08.DIRECCIÓN", 0);
            p_cdlListaCampos.AddIntCD(9, "09.ALTURA", 0);
            p_cdlListaCampos.AddIntCD(10, "10.CUIL", 0);
            p_cdlListaCampos.AddIntCD(11, "11.URL", 0);
            p_cdlListaCampos.AddIntCD(12, "12.CANT. EMPLEADOS", 0);
            p_cdlListaCampos.AddIntCD(13, "13.COBERTURA", 0);
            p_cdlListaCampos.AddIntCD(14, "14.NRO. AVALON", 0);
            p_cdlListaCampos.AddIntCD(15, "15.ABONO", 0);
            p_cdlListaCampos.AddIntCD(16, "16.EMAIL", 0);
            p_cdlListaCampos.AddIntCD(17, "17.CÓDIGO LOCALIDAD", 0);
        }

        public override void fillVariablesTipadas(ref ListaEntidades p_leListaEntidades, ref Entidad p_eEntidad)
        {
            p_leListaEntidades = Bel.LEClientes.NewEmpty();
            p_eEntidad = Bel.ECliente.NewEmpty();
        }

        public override void fillAttribute(Entidad p_eEntidad, int p_iValor, string p_strValor, DateTime p_dtValor, Decimal p_dValor, DataRowView p_drvItem)
        {
            Bel.ECliente l_eCliente = (Bel.ECliente)p_eEntidad;
            // Lo agregamos en la entidad
            switch ((int)p_drvItem["codbase"])
            {
                case 1: { l_eCliente.Rsocial = p_strValor; break; }
                case 2: { l_eCliente.Nombrefant = p_strValor; break; }
                case 3: { l_eCliente.Telefono1 = p_strValor; break; }
                case 4: { l_eCliente.Celular = p_strValor; break; }
                case 5: { l_eCliente.Telefono2 = p_strValor; break; }
                case 6: { l_eCliente.Fax = p_strValor; break; }
                case 7: { l_eCliente.Cli_des_loc = p_strValor; break; }
                case 8: { l_eCliente.Direccion = p_strValor; break; }
                case 9: { l_eCliente.Altura = p_iValor; break; }
                case 10: { l_eCliente.Cuil = p_strValor; break; }
                case 11: { l_eCliente.Url = p_strValor; break; }
                case 12: { l_eCliente.Cantempleados = p_iValor; break; }
                case 13: { l_eCliente.Cobertura = p_strValor; break; }
                case 14: { l_eCliente.Nroavalon = p_iValor; break; }
                case 15: { l_eCliente.Abono = p_dValor; break; }
                case 16: { l_eCliente.Email = p_strValor; break; }
                case 17: { l_eCliente.Codlocalidad = p_strValor; break; }
            }
        }

        public override void valoresFijosAndAdd(ListaEntidades p_leListaEntidades, Entidad p_eEntidad, bool esGrabacion)
        {
            Bel.ECliente l_eCliente = (Bel.ECliente)p_eEntidad;
            Bel.LEClientes l_leClientes = (Bel.LEClientes)p_leListaEntidades;

            // Ponemos los valores fijos
            l_eCliente.Codtinst = " 1";
            l_eCliente.Alta = "S";
            l_eCliente.Codmarca = CodMarca;
            DateTime l_dtFechaActual = Bll.Clientes.fGetDate(m_smResult);
            if (MsgRuts.AnalizeError(null, m_smResult)) return;
            l_eCliente.Fechaingreso = l_dtFechaActual;
            l_eCliente.Cargador = DBConn.Usuario;

            // Agregamos la entidad a la lista
            l_leClientes.AddEntity(l_eCliente); 
            l_eCliente.Dispose();
        }

        public override void captionamos(ListaEntidades p_leClientes)
        {
            p_leClientes.ClearCaptions();
            p_leClientes.ChangeCaption(Bel.ECliente.RsocialCmp, "V1Razón SocialCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.NombrefantCmp, "V1Nombre de FantasíaCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.Telefono1Cmp, "V1Teléfono 1CN1");
            p_leClientes.ChangeCaption(Bel.ECliente.CelularCmp, "V1CelularCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.Telefono2Cmp, "V1Teléfono 2CN1");
            p_leClientes.ChangeCaption(Bel.ECliente.FaxCmp, "V1FaxCN1");
            p_leClientes.ChangeCaption("cli_des_loc", "V1LocalidadCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.DireccionCmp, "V1DirecciónCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.AlturaCmp, "V1AlturaNN1");
            p_leClientes.ChangeCaption(Bel.ECliente.CuilCmp, "V1CUILCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.UrlCmp, "V1UrlCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.CantempleadosCmp, "V1Cant. EmpleadosNN2");
            p_leClientes.ChangeCaption(Bel.ECliente.NroavalonCmp, "V1Nro. AvalonNN2");
            p_leClientes.ChangeCaption(Bel.ECliente.AbonoCmp, "V1Abono2N2");
            p_leClientes.ChangeCaption(Bel.ECliente.EmailCmp, "V1EmailCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.CodlocalidadCmp, "V1Código LocalidadCN1");
        }

        public override ListaEntidades importarYDevolverRechazados(ListaEntidades p_leListaEntidades, StatMsg p_smResult)
        {
            return Bll.Clientes.fImportar((Bel.LEClientes)p_leListaEntidades, p_smResult);
        }
    }
}
