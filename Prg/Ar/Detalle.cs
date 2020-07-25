using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;
using TNGS.NetRoutines;
using TNGS.NetApp;

namespace Sima.Ar
{   
    public partial class Detalle : Form
    {

        //Miembros
        Bel.ECliente m_eCliente = null;
        Bel.EVendedor m_eVendedor = null;

        /* Posibles campos a agregar:
     * clientes:
     *      fecha de ingreso al sistema
     *      cacntidad de veces reservado
     *      fecha de última reserva
     *  vendedor:
     *      cantidad de reservas activas
     *      cantidad máxima de reservas
     *      ventas del mes pasado
     *      reserva anteriores al mismo cliente
     */

        //Constructor de la clase que  trae la entidad solicitud de la cual tenemos que mostrar los datos.
        public Detalle(Bel.ECliente p_eCliente, Bel.EVendedor p_eVendedor)
        {
            InitializeComponent();
            // guardamos los parametros en los miembros.
            m_eCliente = p_eCliente;
            m_eVendedor = p_eVendedor;

        }

        private void Detalle_Load(object sender, EventArgs e)
        {
            // Cargamos los datos del cliente
            TECliRSocial.Text = m_eCliente.Rsocial;
            TECliNFant.Text = m_eCliente.Nombrefant;
            TECliDir.Text = m_eCliente.Direccion;
            TECliTel.Text = m_eCliente.Telefono1;
            TECliFrq.Text = m_eCliente.Cli_des_frq;
            TECliTInst.Text = m_eCliente.Cli_des_tinst;
            TECliUrl.Text = m_eCliente.Url;
            TECliLoc.Text = m_eCliente.Cli_des_loc;
            teCliPartido.Text = m_eCliente.Cli_ede_partido;

            //Cargamos los datos del vendedor
            TEVendApe.Text = m_eVendedor.Apellido;
            TEVendNom.Text = m_eVendedor.Nombre;
            TEVendDir.Text = m_eVendedor.Direccion;
            TEVendMrc.Text = m_eVendedor.Vnd_des_marca;
            TEVendTel.Text = m_eVendedor.Tel1;
            TEVendTVnd.Text = m_eVendedor.Vnd_des_tipovnd;
            TEVendEmail.Text = m_eVendedor.Email;
            teVendBaseOp.Text = m_eVendedor.Vnd_des_baseop;
            neVendResMax.Numero = Convert.ToInt32(m_eVendedor.Vnd_nro_resmax);
            neVendResAct.Numero = Convert.ToInt32(m_eVendedor.Vnd_nro_resact);
        }

        private void gbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
