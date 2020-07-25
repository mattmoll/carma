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
using Sima.Shr;

namespace Sima.Ct
{
    public partial class Formato : DockContent
    {
        StatMsg m_smResult = new StatMsg();
        int m_iTipoCarta;
        Bel.EModeloCarta m_entModelo = null;
        Cartas m_frmCartas;
        bool m_bEsMasivo;

        // Constructor base.
        public Formato(Cartas p_frmCartas, int p_iTipoCarta, bool p_bEsMasivo)
        {
            InitializeComponent();

            m_iTipoCarta = p_iTipoCarta;
            m_frmCartas = p_frmCartas;
            m_bEsMasivo = p_bEsMasivo;

            // Dockeamos el form
            ((MainFrame)App.GetMainWindow()).AddContent(this);
        }

        // Constructor para apertura del form en modo modificacion (recibe entidad)
        public Formato(Cartas p_frmCartas, Bel.EModeloCarta p_entModelo)
            : this(p_frmCartas, Convert.ToInt32(p_entModelo.Codtipocarta), p_entModelo.Esmailmasivo.Equals("S"))
        {
            // Nos guardamos la entidad para el momento de persistencia y cargamos los datos.
            m_entModelo = p_entModelo;
            teTitulo.Text = p_entModelo.Des;
            rtfFormato.RichText = p_entModelo.Texto;
        }

        #region Eventos

        // Evento de carga del formulario.
        private void Formato_Load(object sender, EventArgs e)
        {
            // Traemos la lista de codigos a mostrar.
            Bel.LECodigos l_leCodigos = Bll.Tablas.CdgUpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            if (m_bEsMasivo)
                l_leCodigos.Filter(String.Format("{0} = 'S'", Bel.ECodigo.AceptamailmasivoCmp));
 

            // Ciclamos por los codigos y los cargamos en la lista.
            foreach (Bel.ECodigo l_eCodigo in l_leCodigos)
                lstCampos.AddStrCD(l_eCodigo.Cod, l_eCodigo.Des, 0);


            lstCampos.Sorted = false;

            PrgRuts.ReseteaBarraInferior();
        }

        // Agrega el codigo del item seleccionado de la lista en el RTF.
        private void gbAddCampo_Click(object sender, EventArgs e)
        {
            // Agregamos el texto del codigo seleccionado al rtf.
            agregarTexto(lstCampos.SelectedStrCode);
        }

        // Agrega el texto del campo en formato codigoVariable (<## ##>) al RTF
        private void gbAddCampoVariable_Click(object sender, EventArgs e)
        {
            int l_iLongitudCampo = (int)Enumeradores.limCaracteres.contenidoCampoVar;

            // Armamos el codigo variable en una variable local.
            string l_strCodigoVariable = String.Format("{0}{1}{2}",
                                                       "<##",
                                                       teCampoVariable.Text.Trim().PadRight(l_iLongitudCampo, '*'),
                                                       "##>");
            agregarTexto(l_strCodigoVariable);
            teCampoVariable.Text = "";
        }

        // Metodo que agrega un texto dado y lo bloquea en el RTF.
        private void agregarTexto(string p_strTextToAdd)
        {
            // Conseguimos el index en donde hay que agregar y validamos.
            int l_iIndex = rtfFormato.RTBAccess.SelectionStart;
            if (l_iIndex > -1)
            {
                // Agregamos el codigo haciendo una seleccion nula y cambiando la misma por el texto a agregar.
                rtfFormato.RTBAccess.Select(l_iIndex, 0);
                rtfFormato.RTBAccess.SelectedText = p_strTextToAdd;
                // Bloqueamos el texto agregado.
                BlockText(p_strTextToAdd.Length);
            }
        }

        // Borra el campo modificable (si el usuario está parado sobre un codigo modificable).
        private void gbBorraCampoModif_Click(object sender, EventArgs e)
        {
            // Validamos
            rtfFormato.RTBAccess.SelectionLength = 3;
            if (rtfFormato.RTBAccess.SelectedText != "<##")
            {
                MsgRuts.ShowMsg(this, "No se encuentra posicionado sobre un Código Modificable");
                return;
            }

            // Borramos el codigo modificable del texto.
            BorraCodigo((int)Enumeradores.limCaracteres.campoVariable);
        }

        // Borra el campo de la base (si el usuario está parado sobre un codigo base).
        private void gbBorraCampoBase_Click(object sender, EventArgs e)
        {
            // Validamos
            rtfFormato.RTBAccess.SelectionLength = 3;
            if (rtfFormato.RTBAccess.SelectedText != "<//")
            {
                MsgRuts.ShowMsg(this, "No se encuentra posicionado sobre un Código de la Base");
                return;
            }

            // Borramos el codigo de la base del texto.
            BorraCodigo((int)Enumeradores.limCaracteres.campoFijo);
        }

        // Persiste en la base de datos el modelo de carta creado.
        private void gbGrabar_Click(object sender, EventArgs e)
        {
            // Validamos.
            if (!teTitulo.IsValid)
            {
                MsgRuts.ShowMsg(this, "El Título ingresado no es valido");
                return;
            }
            if (rtfFormato.Text.Trim() == "")
            {
                MsgRuts.ShowMsg(this, "No se puede guardar un modelo de carta vacío");
                return;
            }

            // Creamos (si estamos en modo nuevo) y llenamos la entidad Modelo Carta.
            CreaEntidadSiCorresponde();
            m_entModelo.Des = teTitulo.Text.Trim();
            m_entModelo.Texto = rtfFormato.RichText;
            m_entModelo.Esmailmasivo = m_bEsMasivo? "S": "N";

            Bll.Tablas.MdcSave(m_entModelo, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            MsgRuts.ShowMsg(this, "Se ha grabado el Modelo de Carta exitosamente");

            m_frmCartas.YouHaveToUpdate();
            this.Close();

        }

        #endregion



        #region Metodos

        // Crea una entida modelo y la guarda en el miembro si estamos en modo nuevo.
        private void CreaEntidadSiCorresponde()
        {
            // Si no existe la entidad en el miembro, la creamos y cargamos los datos base.
            if (m_entModelo == null)
            {
                m_entModelo = Bel.EModeloCarta.NewEmpty();
                m_entModelo.Cod = Bll.Tablas.MdcNextKey(m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
                m_entModelo.Codtipocarta = m_iTipoCarta.ToString();
            }
        }

        // Logica de blockeo del texto del RTF en la cantidad de caracteres que recibe por parametro.
        private void BlockText(int p_intCantCaracteres)
        {
            rtfFormato.RTBAccess.SelectionStart -= p_intCantCaracteres;
            rtfFormato.RTBAccess.SelectionLength = p_intCantCaracteres;
            // Comentamos el cambio de font porque hay problemas con eso en el instanciador. Habria que 
            // aramar otro esquema que formatee y solo muestre algunas cosas en pantalla y no esos codigos horribles (hide).
            //rtfFormato.RTBAccess.SelectionFont = new Font(rtfFormato.RTBAccess.SelectionFont,
            //                                               rtfFormato.RTBAccess.SelectionFont.Style | FontStyle.Bold);
            rtfFormato.RTBAccess.SelectionProtected = true;
            rtfFormato.RTBAccess.SelectionStart += p_intCantCaracteres;
            rtfFormato.RTBAccess.SelectionLength = p_intCantCaracteres;
            //rtfFormato.RTBAccess.SelectionFont = new Font(rtfFormato.RTBAccess.SelectionFont,
            //                                               rtfFormato.RTBAccess.SelectionFont.Style & FontStyle.Bold);
        }

        // Borra la cantidad de caracteres que recibe por parametro desde donde este posicionado el cursor.
        private void BorraCodigo(int p_intCantCaracteres)
        {
            rtfFormato.RTBAccess.SelectionLength = p_intCantCaracteres;
            rtfFormato.RTBAccess.SelectionProtected = false;
            rtfFormato.RTBAccess.SelectedText = ""; // Borramos el codigo seleccionado.
        }

        #endregion






    }
}
