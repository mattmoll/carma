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

namespace Sima.Ct
{
    public partial class Cartas : DockContent
    {
        enum TiposCarta { Mailing = 1, CartasPresentacion, Presupuestos, CartasIntencion };

        // Miembros
        TiposCarta m_tcTipoCartaSelected;
        StatMsg m_smResult = new StatMsg();
        Bel.LEModeloCartas m_leModelosCartas;

        // Constructor que guarda el miembro del tipo de carta
        public Cartas()
        {
            InitializeComponent();

            // Dockeamos el form
            ((MainFrame)App.GetMainWindow()).AddContent(this);
        }

        // Evento de carga del form que llena la lista de modelos disponibles
        private void Cartas_Load(object sender, EventArgs e)
        {
            cdcTipoCartas.AddIntCD(1, "Mailing");
            cdcTipoCartas.AddIntCD(2, "Cartas Presentación");
            cdcTipoCartas.AddIntCD(3, "Presupuestos");
            cdcTipoCartas.AddIntCD(4, "Cartas Intención-Convenios");

            PrgRuts.ReseteaBarraInferior();
        }

        // Evento de cierre del formulario que libera la ventana principal
        private void Cartas_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainFrame)App.GetMainWindow()).CloseAllDocuments();
            App.LockMenu(false);
        }

        // Dispara la creacion de un nuevo modelo de carta.
        private void gbNuevoUnitario_Click(object sender, EventArgs e)
        {
            int l_iCant = m_leModelosCartas.Count;
            // Disparamos el dockeable de modelos.
            Formato l_frmFormato = new Formato(this,(int)m_tcTipoCartaSelected, p_bEsMasivo:false);
        }


        private void gbNuevoMasivo_Click(object sender, EventArgs e)
        {
            int l_iCant = m_leModelosCartas.Count;
            // Disparamos el dockeable de modelos.
            Formato l_frmFormato = new Formato(this, (int)m_tcTipoCartaSelected, p_bEsMasivo: true);
        }


        // Dispara la modificacion del modelo de carta seleccionado en la lista.
        private void gbModificar_Click(object sender, EventArgs e)
        {
            // Validamos
            if (lstCartas.SelectedStrCode == "")
            {
                MsgRuts.ShowMsg(this, "No hay un modelo de carta seleccionado para su modificación");
                return;
            }
            // Disparamos el dockeable de modelos.
            Formato l_frmFormato = new Formato(this,m_leModelosCartas[lstCartas.SelectedStrCode]);
        }

        // Borra el modelo de carta seleccionado en la lista pidiendo antes confirmacion.
        private void gbBorrar_Click(object sender, EventArgs e)
        {
            // Validamos
            if (lstCartas.SelectedStrCode == "")
            {
                MsgRuts.ShowMsg(this, "No hay un modelo de carta seleccionado para su borrado");
                return;
            }
            // Pedimos confirmacion de borrado.
            if (MsgRuts.AskUser(this,
                "Atención!!! \r\n\r\n ¿Está seguro que desea borrar el modelo de carta:  " + lstCartas.SelectedItem.ToString() + " ?") 
                == DialogResult.Yes)
            {
                // Borramos el modelo de carta
                Bll.Tablas.MdcRemove(lstCartas.SelectedStrCode, m_leModelosCartas[lstCartas.SelectedStrCode].FxdVersion, m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
            }

            this.YouHaveToUpdate();
        }

        // Metodo publico para que le avisen al form que tiene que actualizar su lista de modelos.
        public void YouHaveToUpdate()
        {
            CargaModelosEnLista();
        }

        // Recupera los modelos de la base y los carga en la lista.
        private void CargaModelosEnLista()
        {
            // Recuperamos los modelos de las cartas
            m_leModelosCartas = Bll.Tablas.MdcGetByTipo(((int)m_tcTipoCartaSelected).ToString(),
                                                                            m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            lstCartas.FillFromStrLEntidad(m_leModelosCartas, Bel.EModeloCarta.CodCmp, Bel.EModeloCarta.DesCmp, "deleted");
        }

        private void cdcTipoCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_tcTipoCartaSelected = (TiposCarta)cdcTipoCartas.SelectedIntCode;
            CargaModelosEnLista();
        }

        private void lstCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDescription.Text = m_leModelosCartas[lstCartas.SelectedStrCode].Des;
        }
    }
}
