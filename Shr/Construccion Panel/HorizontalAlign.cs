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
    class HorizontalAlign : Alignment
    {
        public HorizontalAlign( Size tamaño)
                        : base(tamaño)
        {
        }

        internal override void pickLastControl(FullLabel label, Control edit)
        {
        }

        internal override Point calculaPosicion(Control control)
        {
            return new Point(1, 1);
        }

        internal override Point calculaPosicion(FullLabel control)
        {
            return new Point(1, 1);
        }

        internal override void cargaSeparaciones()
        {
        }
    }
}
