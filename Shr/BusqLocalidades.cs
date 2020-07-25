using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetControls;
using TNGS.NetRoutines;
using TNGS.NetAppBll;

namespace Carm.Shr
{
    /// <summary>
    /// Formulario para Búsqueda de Localidades Pais
    /// </summary>
    internal partial class BusqLocalidades : Form
    {
        #region Miembros de la Clase 
            private StatMsg m_smResult= null;
        #endregion

        #region Propiedades directas
            public Bel.ELocalidad Localidad {get; private set;}
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="p_bEnabCanc">Habilita ESC para cancelar</param>
        public BusqLocalidades(bool p_bEnabCanc)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // Iniciamos los objetos de la clase
            m_smResult = new StatMsg();

            // Cargamos las provincias
            AppRuts.App_ShowMsg("Cargando provincias...");
            ListaEntidades l_lentProv= Bll.Tablas.LocGetProvincias(m_smResult);
            AppRuts.App_HideMsg();
            if (AppRuts.MsgRuts_AnalizeError(this,m_smResult))
                return;
            


            l_lentProv.Sort("loc_des_provincia");
            cmbProvincias.FillFromStrLEntidad(l_lentProv, "loc_des_provincia", "loc_des_provincia", "deleted");
            cmbProvincias.AddStrCD("***", "(Todas las Provincias)", 0);
            cmbProvincias.SelectedStrCode= "***";

            // Vemos el estado del ESC
            lblCancela.Visible= p_bEnabCanc;
        }

        //---------------------------------------------------------------
        // Eventos de los controles y el formulario
        //---------------------------------------------------------------


        private void GBBuscar_Click(object sender, EventArgs e)
        {

            // Limpiamos el mensaje de error
            lblMensaje.Text = "[F3]- Borra los resultados";
            lblMensaje.ForeColor = Color.FromKnownColor(KnownColor.SkyBlue);
            lblConfirma.Visible = false;

            // Validamos el texto
            string l_strLocalidad = txtLocalidad.Text.Trim();
            if (l_strLocalidad == "") return;

            if (l_strLocalidad.Length < 3)
            {
                // Error
                lblMensaje.Text = "Deben ingresarse al menos 3 caracteres.";
                lblMensaje.ForeColor = Color.Red;
                txtLocalidad.Focus();
                return;
            }

            // Armamos el rango de provincias
            string l_strProvD = cmbProvincias.Text;
            string l_strProvH = cmbProvincias.Text;

            if (cmbProvincias.SelectedStrCode == "***")
            {
                // Van todas
                l_strProvD = "  ";
                l_strProvH = "zz";
            }

            // Buscamos las localidades 
            AppRuts.App_ShowMsg("Buscando localidades...");
            Bel.LELocalidades l_lentLocalidades =
                Bll.Tablas.LocFind(l_strLocalidad, l_strProvD, l_strProvH, m_smResult);
            AppRuts.App_HideMsg();

            if (AppRuts.MsgRuts_AnalizeError(this,m_smResult))
            {
                // Error
                lblMensaje.Text = m_smResult.Msg;
                lblMensaje.ForeColor = Color.Red;
                txtLocalidad.Focus();
                return;
            }

            if (l_lentLocalidades.Count == 0)
            {
                // Error
                lblMensaje.Text = "No se encontraron localidades.";
                lblMensaje.ForeColor = Color.Red;
                txtLocalidad.Focus();
                return;
            }

            // Captionamos y las mostramos
            l_lentLocalidades.AddExprColumn("codigo", typeof(string), "loc_ecd_codpost");
            l_lentLocalidades.ClearCaptions();
            l_lentLocalidades.ChangeCaption("loc_ede_nombre", "V1LocalidadCN1");
            l_lentLocalidades.ChangeCaption("loc_ede_partido", "V1PartidoCN1");
            l_lentLocalidades.ChangeCaption("loc_des_provincia", "V1ProvinciaCN1");
            l_lentLocalidades.ChangeCaption("codigo", "V1CodigoCN1");
            flxgLocalidades.FillFromLentidad(l_lentLocalidades,"");
            flxgLocalidades.Focus();
            lblConfirma.Visible = true;
        }
       


        /// <summary>
        /// Presionar una tecla del formulario
        /// </summary>
        private void BusqLocalidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 0x1b) && (lblCancela.Visible)) {
                // Cancelaron
                Close();
                DialogResult= DialogResult.Cancel;
                e.Handled= true;
                return;
            }
        }

        /// <summary>
        /// Presionar una tecla del formulario
        /// </summary>
        private void BusqLocalidades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 114) {
                // Borrar el contenido de la grilla
                flxgLocalidades.Clear();
                lblConfirma.Visible= false;
                txtLocalidad.Focus();
                e.Handled= true;
                return;
            }
        }



        /// <summary>
        /// Confirmaron una localidad
        /// </summary>
        private void flxgLocalidades_DoubleClick(object sender, EventArgs e)
        {
            // Buscamos la localidad seleccionada
            Localidad= Bll.Tablas.LocGet(flxgLocalidades.ItemSelected.StringArray[3], false, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this,m_smResult)) {
                // Error
                lblMensaje.Text= m_smResult.Msg;
                lblMensaje.ForeColor= Color.Red;
                txtLocalidad.Focus();
                return;
            }

            // Salimos
            Close();
            DialogResult= DialogResult.OK;
            return;
        }


        //---------------------------------------------------------------
        // Operaciones del Formulario
        //---------------------------------------------------------------

        //---------------------------------------------------------------
        // Metodos publicos de la clase
        //---------------------------------------------------------------

        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------


    }

}
