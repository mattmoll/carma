using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Carm.Shr
{
    public partial class ListaServiciosDetalle : ListaServicios
    {
        string m_strTabRTF = "\\tab\\tab ";

        public ListaServiciosDetalle()
        {
            InitializeComponent();
        }

        // Redefinimos el metodo que genera la string para que la genere con el detalle de los servicios.
        override public string generaString()
        {
            string l_strLista = "";
            Bel.EServicio l_eServicio;
            string l_strDescripcion = "";
            // Armamos una string con todos los codigos checked.
            foreach (string l_strCodServicio in this.m_isListaCods)
            {
                // Recuperamos la entidad serivicio y concatenamos a la string su descripcion.
                l_eServicio = this.m_leServicios[l_strCodServicio];
                l_strDescripcion = l_eServicio.Des + ":";
                l_strLista = String.Format("{0}{1}{2}", l_strLista, l_strDescripcion, this.m_strSaltoLinea);
                // Le agregamos la descripcion extendida
                l_strLista = String.Format("{0}{1}{2}{3}{4}", 
                                            l_strLista, 
                                            m_strTabRTF, 
                                            l_eServicio.Explicacion,
                                            this.m_strSaltoLinea,
                                            this.m_strSaltoLinea);
            }
            return l_strLista;
        }
    }
}
