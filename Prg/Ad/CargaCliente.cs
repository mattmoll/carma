using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS;
using TNGS.NetApp;
using TNGS.NetRoutines;
using TNGS.NetControls;
using WeifenLuo.WinFormsUI.Docking;


namespace Carm.Ad
{
    public partial class CargaCliente : Form
    {
        private StatMsg m_smResult;

        public CargaCliente()
        {
            InitializeComponent();
           
            m_smResult = new StatMsg();

        }

        // pone en blanco todos los campos de DatosBasicos Movil
        private void limpiarTodosLosCamposDatosBasicos()
        {
            teNombreFantasia.Clear();
            teAnotaciones.Clear();

        }

        // chequea que todos los campos tengan datos validos.
        private bool ValidarControles()
        {
            // si alguno de los campos basico es invalido, mostramos un error.
            if (
                   (!teAnotaciones.IsValid)
                   || (!teNombreFantasia.IsValid)
               )
            {
                MsgRuts.ShowMsg(this, "Algun campo basico es invalido");
                return false;
            }
            else
            {
                return true;
            }


        }
        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            MsgRuts.ShowMsg(this, "Esta seguro que desea limpiar los campos?", MessageBoxButtons.OKCancel);
            limpiarTodosLosCamposDatosBasicos();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            /*
            //nos fijamos que todos los campos sean validos.
            if (!ValidarControles())
                return;

            //llenamos la entidad Movil con los datos basicos
            CargarDatosBasicosEnEntidadMovil(m_entMovil);

            //generamos el estado default y nos fijamos que se haya creado con exito, sino lanzamos un error
            Bel.EMovilEstado l_eMvlEstado = GenerarEstadoDefault();
            if (l_eMvlEstado.Patente == "")
            {
                MsgRuts.ShowMsg(this, "Error al cargar el estado");
                return;
            }
            */

                // si es estado de Update se llama al metodo que elimina todos los equipamientos, carga los nuevos y graba la entidad.
                //Bll.Moviles.CambiarEquipamientoYGrabarMovil(m_entMovil, ObtenerLEntidadSeleccionadosCheckedList(), m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
                MsgRuts.ShowMsg(this, "El Movil ha sido modificado satisfactoriamente");
            

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
