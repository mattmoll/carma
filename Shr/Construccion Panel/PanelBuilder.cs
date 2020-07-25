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
    public class PanelBuilder
    {
        private Panel m_pnPanel;
        Alignment alignment;
        public Size tamañoLabels { private get; set; }
        public Size tamañoControles { private get; set; }
        public Size tamañoNumberEdits { private get; set; }
        public Size tamañoDateEdits { private get; set; }
        public Size tamañoGrouper { private get; set; }
        public enum Alineacion { Vertical = 1, Horizontal = 2 };
        private int tabOrder = 0;


        public PanelBuilder(Size p_szTamaño, Alineacion p_enumAlineacion)
        {
            // Creamos el panel y le fijamos el tamaño y el skinFixed
            m_pnPanel = new Panel();
            m_pnPanel.BackColor = Color.Transparent;
            m_pnPanel.Size = p_szTamaño;

            // Creamos la alineacion correspondiente
            if (p_enumAlineacion == Alineacion.Vertical)
                this.alignment = new VerticalAlign(m_pnPanel.Size);
            else
                this.alignment = new HorizontalAlign(m_pnPanel.Size);

            // Cargamos los tamaños default que nos da el alignment, si el programador quiere puede cambiarlos
            // mediante las properties correspondientes.
            this.tamañoLabels = this.alignment.sizeLabels;
            this.tamañoControles = this.alignment.sizeEdits;
            this.tamañoDateEdits = this.alignment.sizeDateEdits;
            this.tamañoNumberEdits = this.alignment.sizeNumberEdits;
            this.tamañoGrouper = new Size(0, 0);
            m_pnPanel.Location = new Point(40, 20);
        }

        public PanelBuilder AddControlWithLabel(string p_strTexto, Control p_ctrEdit)
        {
            FullLabel l_flLabel = new FullLabel();
            l_flLabel.Text = p_strTexto;
            l_flLabel.Size = this.tamañoLabels;
            l_flLabel.BackColor = Color.Transparent;

            p_ctrEdit.Size = this.getSizeForControl(p_ctrEdit);
            p_ctrEdit.TabIndex = tabOrder++;

            // Delegamos, el añadir los controles creados, en el objeto que maneja la alineacion y las posiciones.
            alignment.addControlWithLabel(l_flLabel, p_ctrEdit, this.getPanel);

            return this;
        }

        public PanelBuilder AddGroupOfRadioButtons(string p_strTitulo, RadioButton[] p_arbRadioButtons, string[] p_asTextos)
        {
            ImgGroup grouper = new ImgGroup();
            grouper.GroupTitle = p_strTitulo;
            grouper.SkinFixed = true;

            // Si no tenemos setteado un tamaño para el grouper, usamos el estandar, sino usamos el setteado.
            grouper.Size = (tamañoGrouper.Height == 0) ? new Size(200, p_arbRadioButtons.Length * 55) : tamañoGrouper;

            // Cargamos los textos a cada radiobutton y los agregamos al agrupador.
            int i = 0;
            foreach (RadioButton radioButton in p_arbRadioButtons)
            {
                radioButton.Text = p_asTextos[i++];
                grouper.Controls.Add(radioButton);
            }

            alignment.addGrouper(grouper, this.getPanel);

            return this;
        }

        public Size getSizeForControl(Control unControl)
        {
            if (unControl.GetType() == typeof(NumberEdit))
                return this.tamañoNumberEdits;
            else if (unControl.GetType() == typeof(DateEdit))
                return this.tamañoDateEdits;
            else if (unControl.GetType() == typeof(GlassButton))
                return unControl.Size;
            else
                return this.tamañoControles;

        }

        public Panel getPanel
        {
            get { return m_pnPanel; }
        }

        public Point location
        {
            get { return m_pnPanel.Location; }
            set { m_pnPanel.Location = value; }
        }


    }
}
