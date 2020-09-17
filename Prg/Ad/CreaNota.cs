using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetApp;
using TNGS.NetRoutines;
using WeifenLuo.WinFormsUI.Docking;

namespace Carm.Ad.Forms
{
    public partial class CreaNota : Form
    {
        // Miembros.
        StatMsg m_smResult = new StatMsg();
        Bel.ECliNota m_eNota;

        // Constructor que recibe por parametro el numero de cliente y el tipo y los carga en la nota.
        public CreaNota(int p_intNumCliente, string p_strTipo)
        {
            InitializeComponent();

            // Creamos la nota y le cargamos los datos que tenemos.
            m_eNota = Bel.ECliNota.NewEmpty();
            m_eNota.Numcliente = p_intNumCliente;
            m_eNota.Tipo = p_strTipo;
        }

        // Evento del click en el boton de ayuda que muestra un mensaje de por que sale esta pantalla.
        private void gbHelp_Click(object sender, EventArgs e)
        {
            MsgRuts.ShowMsg(this, "Para marcar un cliente como erroneo es obligatorio agregarle una nota indicando cual es el error"+
                " en los datos del cliente. La nota consta basicamente de un Titulo y un Texto para detallar el error.");
        }

        // Evento del click en el boton aceptar que crea la entidad nota y la llena.
        private void gbAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidacionLargoCampos())
                return;
            // Llenamos los datos que faltan.
            m_eNota.Titulo = teTitulo.Text;
            m_eNota.Texto = teTexto.Text;
            m_eNota.Escritor = DBConn.Usuario;

            DateTime l_dtFecha = Bll.Clientes.fGetDate(m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            m_eNota.Fechayhora = l_dtFecha;


            // Validamos que no haya error.
            if (MsgRuts.AnalizeError(this, m_smResult))
                return;

            // Cargamos el resultado como exitoso.
            this.DialogResult = DialogResult.OK;
        }

        // Metodo que valida el largo de los campus y devuelve true si el largo es menor al maximo.
        private bool ValidacionLargoCampos()
        {
            int l_intLongTitulo = teTitulo.Text.Trim().Length;
            int l_intLongTexto = teTexto.Text.Trim().Length;

            if (l_intLongTitulo == 0)
            {
                MsgRuts.ShowMsg(this, "El Título no puede estar vacío.");
                return false;
            }

            if (l_intLongTexto == 0)
            {
                MsgRuts.ShowMsg(this, "El Texto no puede estar vacío.");
                return false;
            }

            if (l_intLongTitulo > 15)
            {
                MsgRuts.ShowMsg(this, "El largo del Título no puede ser mayor a 15 caracteres.");
                return false;
            }

            if (teTexto.Text.Trim().Length > 200)
            {
                MsgRuts.ShowMsg(this, "El largo del Texto no puede ser mayor a 200 caracteres.");
                return false;
            }

            return true;
        }

        // Evento del click del boton cancelar que fija el resultado como erroneo y cierra la ventana.
        private void gbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Propiedad que devuelve la Nota creada.
        public Bel.ECliNota NotaRealizada
        {
            get { return m_eNota; }
        }


    }
}
