using System;
using System.Collections.Generic;
using System.Text;
using TNGS.NetRoutines;
using Carm.Bll;

namespace Carm.Shr
{
    public class StrategyFechaActual : Strategy
    {
        StatMsg m_smResult = new StatMsg();

        // Llamamos al constructor del padre.
        public StrategyFechaActual(Bel.ECodigo p_eCodigo) : base(p_eCodigo) { }

        // Redefinimos el metodo dameString para que devuelve la fecha actual
        override public string dameString()
        {
            return DateTime.Today.Date.ToString("dd/MM/yyyy");
        }
    }
}
