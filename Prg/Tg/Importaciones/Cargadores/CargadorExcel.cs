using System;
using System.Data;
using TNGS.NetControls;
using TNGS.NetRoutines;

namespace Carm.Tg
{
    public abstract class CargadorExcel
    {
        // Firmas obligatorias para cualquiera cargador especifico.
        public abstract void llenarListaCampos(CDList cdlListaCampos);
        public abstract void fillVariablesTipadas(ref ListaEntidades p_leListaEntidades, ref Entidad p_eEntidad);
        public abstract void fillAttribute(Entidad p_eEntidad, int p_iValor, string p_strValor, DateTime p_dtValor, Decimal p_dValor, DataRowView p_drvItem);
        public abstract void valoresFijosAndAdd(ListaEntidades p_leListaEntidades, Entidad p_eEntidad, bool esGrabacion);
        public abstract void captionamos(ListaEntidades p_leListaEntidades);
        public abstract ListaEntidades importarYDevolverRechazados(ListaEntidades p_leListaEntidades, StatMsg p_smResult);

    }
}
