using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using Carm.Bel;

namespace Carm.Shr
{
    public partial class VisualizadorCarta : Form
    {
        StatMsg m_smResult = new StatMsg();
        public EModeloCarta modeloCarta {get;set;}
        ECliente m_eCliente;
        private ECliContacto m_eCliContacto;
        private List<ECliente> m_lstClientes;
        private CodesManager m_cmManager;
        private string nombreArchivoAdjunto;
        private bool modoVisualizacion;
        private decimal precio;

        // Constructores

        public VisualizadorCarta()
        {
            InitializeComponent();
            m_eCliente = null;
            m_eCliContacto = null;
            nombreArchivoAdjunto = "";
            modoVisualizacion = false;
        }

        public VisualizadorCarta(Bel.ECliente p_eCliente):this()
        {
            m_eCliente = p_eCliente;
        }

        public VisualizadorCarta(Bel.ECliente p_eCliente, Bel.ECliContacto p_eCliContacto) : this(p_eCliente)
        {
            m_eCliContacto = p_eCliContacto;
        }

        public VisualizadorCarta(List<ECliente> p_lstClientes): this()
        {
            m_lstClientes = p_lstClientes;
        }

        public VisualizadorCarta(ECartasEnv cartaEnviada)
        {
            InitializeComponent();

            modeloCarta = Bel.EModeloCarta.NewFilled(cartaEnviada.Numero.ToString(), "1", cartaEnviada.Texto, cartaEnviada.Des, "N");

            modoVisualizacion = true;
        }


        // Carga del formulario que muestra en pantalla el modelo de la carta y el titulo.
        private void VisualizadorCarta_Load(object sender, EventArgs e)
        {
            // Cargamos el titulo
            lblTitulo.Text = modeloCarta.Des;

            if (modoVisualizacion)
            {
                gbCompletar.Enabled = false;
                gbEnviar.Enabled = false;
                gbImprimir.Enabled = false;
                gbWord.Enabled = false;

                // En el caso de visualizacion mostramos la carta tal como se envio.
                rtfVisualizador.Text = modeloCarta.Texto;
            }
            else
            {
                // Cargamos la carta a pantalla (la que tiene los codigos)
                rtfVisualizador.RichText = modeloCarta.Texto;
            }

            // Instanciamos un CodeManager que sera el encargado de devolvernos las equivalencias a los codigos del modelo.
            m_cmManager = new CodesManager();


        }


        #region Operaciones

        // Evento del boton completar que tiene la logica del parseo y cargado de equivalencias previo a mostrar el texto en pantalla.
        private void gbCompletar_Click(object sender, EventArgs e)
        {
            // Creamos una lista de codigos y la llenamos con los fijos y los variables
            List<CodigoCarta> l_lsCodigos = new List<CodigoCarta>();
            parseaCodigos(rtfVisualizador.RichText, ref l_lsCodigos);

            // Si hay lista de clientes, asignamos el primero para ser procesado.
            if ((m_lstClientes != null) && m_lstClientes.Count > 0)
                m_eCliente = m_lstClientes.First();

            // Llamamos al metodo que se encarga de pedir las equivalencias por cada codigo y mostrarlas en pantalla.
            precio = calcularEquivalenciasYMostrarlasEnPantalla(l_lsCodigos, m_cmManager, rtfVisualizador.RichText);

            habilitarBotones();
        }

        // Evento de envio por mail 
        private void gbEnviar_Click(object sender, EventArgs e)
        {
            EVendedor vendedorSender = Bll.Vendedores.fGetVendedorFromUsu(m_smResult);

            // Llamamos al metodo que envia el mail y validamos. (Esto es comun a todos los casos).
            enviarMail(vendedorSender);
            if (AppRuts.MsgRuts_AnalizeError(null, m_smResult)) return;

            // Si tenemos que enviar mail a una lista y quedan clientes por procesar => procesamos cada uno y enviamos el mail.
            if ((m_lstClientes != null) && (m_lstClientes.Count > 1))
            {
                //  Quitamos el primero de la lista porque ya fue procesado, reseteamos el texto y mandamos a procesar el siguiente.
                m_lstClientes = m_lstClientes.Skip(1).ToList();
                rtfVisualizador.RichText = modeloCarta.Texto;
                gbCompletar_Click(null, new EventArgs());
                gbEnviar_Click(null, new EventArgs());
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Evento de impresion.
        private void gbImprimir_Click(object sender, EventArgs e)
        {
            // Imprimimos el contenido del RTF.
            rtfVisualizador.Print(m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(null, m_smResult)) return;
        }

        // Evento de copia al clipboard.
        private void gbWord_Click(object sender, EventArgs e)
        {

            // Si no hay nada escrito-> de que estamos hablando
            if (rtfVisualizador.RTBAccess.TextLength == 0) return;

            // Copiamos el contenido al PortaPapeles
            int l_iStart = rtfVisualizador.RTBAccess.SelectionStart;
            int l_iLen = rtfVisualizador.RTBAccess.SelectionLength;

            rtfVisualizador.RTBAccess.SelectionStart = 0;
            rtfVisualizador.RTBAccess.SelectionLength = rtfVisualizador.RTBAccess.TextLength;
            rtfVisualizador.RTBAccess.Copy();
            rtfVisualizador.RTBAccess.SelectionStart = l_iStart;
            rtfVisualizador.RTBAccess.SelectionLength = l_iLen;
        }

        #endregion

        #region Metodos privados

        // Metodo que produce el texto final de la carta a partir de las equivalencias de los codigos y el texto original.
        private decimal calcularEquivalenciasYMostrarlasEnPantalla(List<CodigoCarta> p_lsCodigos, CodesManager p_cmManager, string p_strRTFTexto)
        {
            string l_strTextoEnConstruccion = "";
            int l_iIndex = 0;
            Equivalencia l_eEquivalencia;
            decimal precio = 0;

            // Por cada equivalencia de la lista.
            foreach (CodigoCarta l_ccCod in p_lsCodigos)
            {
                // Conseguimos la equivalencia correspondiente.
                l_eEquivalencia = p_cmManager.dameEquivalencia(l_ccCod, m_eCliente);

                if (l_ccCod.codigo == "<//Precio//>")
                    precio = Convert.ToDecimal(l_eEquivalencia.equivalencia);

                // Cambiamos el codigo por su equivalencia y cargamos el resultado en la variable en construccion
                l_strTextoEnConstruccion = cambiarCodigoPorEquivalencia(p_strRTFTexto,
                                                                        l_strTextoEnConstruccion,
                                                                        ref l_iIndex,
                                                                        l_eEquivalencia);

                // Mostramos el cambio de codigo por equivalencia en pantalla.
                mostramosProgresoEnPantalla(p_strRTFTexto, l_strTextoEnConstruccion, l_iIndex);
            }

            // Concatenamos lo que queda despues del ultimo codigo y lo cargamos en pantalla.
            l_strTextoEnConstruccion = concatenamosElResto(p_strRTFTexto, l_strTextoEnConstruccion, l_iIndex);
            rtfVisualizador.RichText = l_strTextoEnConstruccion;
            return precio;
        }

        // Metodo que tiene toda la logica del envio de mail a partir de parametros (sistema) y datos en pantalla.
        private void enviarMail(EVendedor sender)
        {
            List<string> listaDestinatarios = new List<string>();

            if (m_eCliContacto != null)
                listaDestinatarios.Add(m_eCliContacto.Email);
            else
                listaDestinatarios.Add(m_eCliente.Email);

            Bel.EDominio dominioSender = Bll.Tablas.DomGet(sender.Coddominio, true, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(this, m_smResult)) return;

            MailSender.enviarMail(sender, dominioSender, listaDestinatarios, lblTitulo.Text, rtfVisualizador.Text, m_eCliente.Numero, nombreArchivoAdjunto, precio, m_smResult);
        }

        private void habilitarBotones()
        {
            gbImprimir.Enabled = true;
            gbWord.Enabled = true;
            gbEnviar.Enabled = true;
            gbAdjuntar.Enabled = true;
        }

        #region Metodos Auxiliares para manejo de codigos y actualizacion en pantalla

        // Metodo que cambia en el texto de la carta un codigo por su equivalencia.
        private string cambiarCodigoPorEquivalencia(string p_strRTFTexto, string p_strTxtAConstruir, ref int p_iIndex, Equivalencia p_eEquivalencia)
        {
            // Copiamos hasta el siguiente codigo.
            p_strTxtAConstruir = String.Format("{0}{1}",
                                               p_strTxtAConstruir,
                                               p_strRTFTexto.Substring(p_iIndex, p_eEquivalencia.codigoCarta.index - p_iIndex));

            // Agregamos a la string la equivalencia por ese codigo.
            p_strTxtAConstruir = String.Format("{0}{1}", p_strTxtAConstruir, p_eEquivalencia.equivalencia);

            // Actualizamos el index sumandole el largo del codigo que acabamos de saltear.
            p_iIndex = p_eEquivalencia.codigoCarta.index + p_eEquivalencia.codigoCarta.codigo.Length;

            return p_strTxtAConstruir;
        }

        // Metodo que concatena lo que haya quedado despues del index en el texto del rtf y lo devuelve.
        private string concatenamosElResto(string p_strRTFTexto, string p_strTxtAConstruir, int l_iIndex)
        {
            // Concatenamos todo lo que haya luego del ultimo codigo en la carta a la string final.
            p_strTxtAConstruir = String.Format("{0}{1}",
                                            p_strTxtAConstruir,
                                            p_strRTFTexto.Substring(l_iIndex, p_strRTFTexto.Length - l_iIndex));
            return p_strTxtAConstruir;
        }

        // Metodo que arma una variable local donde concatena lo que tenemos construido con lo que falta y la muestra en pantalla.
        private void mostramosProgresoEnPantalla(string p_strRTFTexto, string l_strTextoEnConstruccion, int l_iIndex)
        {
            string l_strTextoAuxPantalla = "";
            // Cargamos en la variable auxiliar el texto concatenando lo que vamos construyendo y el resto del texto con los codigos
            l_strTextoAuxPantalla = concatenamosElResto(p_strRTFTexto, l_strTextoEnConstruccion, l_iIndex);

            // Mostramos en pantalla como va el progreso de la carta y reseteamos la variable auxiliar.
            rtfVisualizador.RichText = l_strTextoAuxPantalla;
        }

        // Metodo que tiene la logica para parsear codigos de la string dada y cargarlos en una lista.
        private void parseaCodigos(string p_strTexto, ref List<CodigoCarta> p_lsCodigos)
        {
            // Definimos el indice por el que vamos a iterar en el texto y una string auxiliar para el CodigoCarta.
            int l_iIndice = 0;
            string l_strCodigo;
            int l_ilongFijo = (int)Enumeradores.limCaracteres.campoFijo;
            int l_ilongVars = (int)Enumeradores.limCaracteres.campoVariable;
            int l_iLongitudCod;
            int l_iIndiceFinalCod;

            // Iteramos hasta que no se encuentre mas la string buscada
            while (true)
            {
                // Buscamos el indice de la cadena buscada en el texto, desde donde quedo la ultima busqueda.
                l_iIndice = p_strTexto.IndexOf("<", l_iIndice);

                // Si la encontramos
                if (l_iIndice != -1)
                {
                    // Buscamos el indice de donde cierre el codigo. Y le sumamos uno por como funciona el IndexOf
                    l_iIndiceFinalCod = p_strTexto.IndexOf(">", l_iIndice) +1; // Asumimos que siempre se encentra el caracter de cierre.
                    // En base a cuanto sea el largo que hay entre el caracter inicial y el final es el tipo de codigo.
                    if ((l_iIndiceFinalCod - l_iIndice) == l_ilongFijo)
                        l_iLongitudCod = l_ilongFijo;
                    else
                        l_iLongitudCod = l_ilongVars;

                    // Obtenemos el codigo con la longitud (segun corresponda).
                    l_strCodigo = p_strTexto.Substring(l_iIndice, l_iLongitudCod);
                    p_lsCodigos.Add(new CodigoCarta(l_iIndice, l_strCodigo));

                    // Actualizamos el indice para que no traiga el mismo codigo.
                    l_iIndice += l_iLongitudCod;
                }
                else // Si no lo encontramos, salimos del while.
                    break;
            }

        }

        #endregion

        private void gbAdjuntar_Click(object sender, EventArgs e)
        {
            if (ofdBuscarAdjuntable.ShowDialog() != DialogResult.OK)
                return;
            nombreArchivoAdjunto = ofdBuscarAdjuntable.FileName;

            AppRuts.MsgRuts_ShowMsg(this, "El archivo fue adjunto correctamente.");
           
        }

        #endregion

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

