using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TNGS.NetControls;

namespace Carm.Shr
{
    class VerticalAlign : Alignment
    {

        public VerticalAlign(Size tamaño)
            : base(tamaño)
        {
        }

        #region Metodos que hay que sobreescribir para respetar la interfaz

        internal override void pickLastControl(FullLabel label, Control edit)
        {
        }

        // Cargamos los valores de las sepracion para hacer el calculo de las posiciones mas adelante.
        internal override void cargaSeparaciones()
        {
            this.separacionVertical = 5;
            this.separacionHorizontal = 15;
        }

        // El calculo de la poscion de un label es igual al del control, se diferencian en la separacion solamente.
        internal override Point calculaPosicion(FullLabel label)
        {
            return calculaPosicion((Control)label);
        }

        // Devuelve la poscion basandose en la location del ultimo control y la separacion dado por el alignment.
        internal override Point calculaPosicion(Control edit)
        {
            if ((posicionYInferiorUltimoControl() +
                this.separacionVertical +
                edit.Size.Height) > this.tamañoDisponible.Height)
                return posicionEnOtraColumna(edit);
            else
                return new Point(ultimoControlAñadido.Location.X, posicionYInferiorUltimoControl() + getSeparacion(edit));
        }

        internal override void acomodarControlesEnAgrupador(ImgGroup grouper)
        {
            // calculamos el perfil a partir del cual agregar controles para que quede centrado
            // es la mitad del grouper - la mitad del primer control, eso hace que quede centrado.
            int perfilX = grouper.Size.Width / 2 - (grouper.Controls[0].Size.Width / 2);
            Point nextLocation = new Point(perfilX, 30);

            foreach (Control control in grouper.Controls)
            {
                control.Location = nextLocation;
                nextLocation.Y = control.Location.Y + this.separacionVertical * 7;
            }
        }

        #endregion

        #region Metodos privados para soporte

        private int getSeparacion(Control control)
        {
            // Si estamos agregando un label, la separacion es cuadruple proque el ultimo control es un edit sino 
            // si estamos agregando un grouper la separacion es 10 veces la normal sino la separacion es simple.
            return (control.GetType() == typeof(FullLabel)) ? this.separacionVertical * 4
                : (control.GetType() == typeof(ImgGroup)) ? this.separacionVertical * 10 : this.separacionVertical - 5;
        }


        private Point posicionEnOtraColumna(Control control)
        {
            if (posicionXUltimoControl() + this.separacionHorizontal + control.Size.Width > this.tamañoDisponible.Width)
                throw new Exception("No hay espacio suficiente para agregar el control en el panel");
            else
            {
                Point posicionControl = new Point();
                posicionControl.X = this.puntoInicio.X + this.ultimoControlAñadido.Size.Width + this.separacionHorizontal;
                posicionControl.Y = this.puntoInicio.Y;
                return posicionControl;
            }
        }

        #endregion
    }
}
