using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;
using TNGS.NetAppBll;

namespace Carm.Shr
{
    public partial class ListaServicios : FormBase
    {
        // Esta clase es derivada de FormBase que tiene el miembro resultado y el metodo dameString
        // por lo tanto solo debemos llenar esa string con la logica particular.
        StatMsg m_smResult = new StatMsg();
        public Bel.LEServicios m_leServicios;
        public ItemsString m_isListaCods;
        public string m_strSaltoLinea = "\\par ";

        public ListaServicios()
        {
            InitializeComponent();
        }


        // Evento de confirmacion que llena la string de resultado con la lista seleccionada.
        private void gbConfirm_Click(object sender, EventArgs e)
        {
            m_isListaCods = cdlLista.GetCheckedStrCodes("#");
            base.m_strResultado = generaString(); 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        virtual public string generaString()
        {
            string l_strLista = "";
            Bel.EServicio l_eServicio;
            // Armamos una string con todos los codigos checked.
            foreach (string l_strCodServicio in m_isListaCods)
            {
                // Recuperamos la entidad serivicio y concatenamos a la string su descripcion.
                l_eServicio = m_leServicios[l_strCodServicio];
                l_strLista = String.Format("{0}{1}{2}", l_strLista, l_eServicio.Des, m_strSaltoLinea);
            }
            return l_strLista;
        }

        /*
        // Metodo que agrega delimitadores al comienzo y final de una string.
        private void agregarDelimitadores(ref string p_strString)
        {
            // Definimos el delimitador a utilizar
            string l_strDelimitador = "----------------------------------------------------------------------------------------------";
            // Concatenamos la string que recibimos con delimitador al comienzo y final con salto de linea.
            p_strString = String.Format("{0}{1}{2}{3}", l_strDelimitador,m_strSaltoLinea, p_strString, l_strDelimitador);
        }
         */

        // Evento de carga del formulario que llena la grilla con todos los servicios.
        private void ListaServicios_Load(object sender, EventArgs e)
        {
            // Recuperamos la lista de servicios de la base.
            m_leServicios = Bll.Servicios.UpFull(true, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(null, m_smResult)) return;

            // Cargamos la lista de servicios en el mini report.
            cdlLista.FillFromStrLEntidad(m_leServicios, "srv_cod_cod", "srv_des_des", "deleted");
                                 
            
        }
    }
}
