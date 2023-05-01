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
            p_cdlListaCampos.AddIntCD(3, "03.NOMBRE", 0);
            p_cdlListaCampos.AddIntCD(4, "04.APELLIDO", 0);
            p_cdlListaCampos.AddIntCD(5, "05.TELEFONO", 0);
            p_cdlListaCampos.AddIntCD(6, "06.CELULAR", 0);
            p_cdlListaCampos.AddIntCD(7, "07.TELEFONO2", 0);
            p_cdlListaCampos.AddIntCD(8, "08.FAX", 0);
            p_cdlListaCampos.AddIntCD(9, "09.DIRECCIÓN", 0);
            p_cdlListaCampos.AddIntCD(10, "10.ALTURA", 0);
            p_cdlListaCampos.AddIntCD(11, "11.CUIL", 0);
            p_cdlListaCampos.AddIntCD(12, "12.EMAIL", 0);
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
                case 3: { l_eCliente.Nombre = p_strValor; break; }
                case 4: { l_eCliente.Apellido = p_strValor; break; }
                case 5: { l_eCliente.Telefono1 = p_strValor; break; }
                case 6: { l_eCliente.Celular = p_strValor; break; }
                case 7: { l_eCliente.Telefono2 = p_strValor; break; }
                case 8: { l_eCliente.Fax = p_strValor; break; }
                case 9: { l_eCliente.Direccion = p_strValor; break; }
                case 10: { l_eCliente.Altura = p_iValor; break; }
                case 11: { l_eCliente.Cuil = p_strValor; break; }
                case 12: { l_eCliente.Email = p_strValor; break; }
            }
        }

        public override void valoresFijosAndAdd(ListaEntidades p_leListaEntidades, Entidad p_eEntidad, bool esGrabacion)
        {
            Bel.ECliente l_eCliente = (Bel.ECliente)p_eEntidad;
            Bel.LEClientes l_leClientes = (Bel.LEClientes)p_leListaEntidades;

            // Ponemos los valores fijos
            l_eCliente.Alta = "S";

            l_eCliente.Codmarca = CodMarca;
            var marca = Bll.Tablas.MrcGet(CodMarca, true, m_smResult);
            if (MsgRuts.AnalizeError(null, m_smResult)) return;
            l_eCliente.Codlocalidad = marca.Codlocalidad;

            DateTime l_dtFechaActual = Bll.Clientes.fGetDate(m_smResult);
            if (MsgRuts.AnalizeError(null, m_smResult)) return;

            l_eCliente.Fechaingreso = l_dtFechaActual;
            l_eCliente.Cargador = DBConn.Usuario;
            l_eCliente.Rellamar = "N";

            // Agregamos la entidad a la lista
            l_leClientes.AddEntity(l_eCliente); 
            l_eCliente.Dispose();
        }

        public override void captionamos(ListaEntidades p_leClientes)
        {
            p_leClientes.ClearCaptions();
            p_leClientes.ChangeCaption(Bel.ECliente.RsocialCmp, "V1Razón SocialCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.NombrefantCmp, "V1Nombre de FantasíaCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.NombreCmp, "V1NombreCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.ApellidoCmp, "V1ApellidoCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.Telefono1Cmp, "V1Teléfono 1CN1");
            p_leClientes.ChangeCaption(Bel.ECliente.CelularCmp, "V1CelularCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.Telefono2Cmp, "V1Teléfono 2CN1");
            p_leClientes.ChangeCaption(Bel.ECliente.FaxCmp, "V1FaxCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.DireccionCmp, "V1DirecciónCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.AlturaCmp, "V1AlturaNN1");
            p_leClientes.ChangeCaption(Bel.ECliente.CuilCmp, "V1CUILCN1");
            p_leClientes.ChangeCaption(Bel.ECliente.EmailCmp, "V1EmailCN1");
        }

        public override ListaEntidades importarYDevolverRechazados(ListaEntidades p_leListaEntidades, StatMsg p_smResult)
        {
            return Bll.Clientes.fImportar((Bel.LEClientes)p_leListaEntidades, p_smResult);
        }
    }
}
