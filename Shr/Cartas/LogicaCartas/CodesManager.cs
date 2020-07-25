using System;
using System.Collections.Generic;
using System.Text;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using Carm.Bll;
using WeifenLuo.WinFormsUI.Docking;
using Carm.Shr;
using System.Reflection;
using System.Runtime.Remoting;


namespace Carm.Shr
{
    class CodesManager
    {
        StatMsg m_smResult = new StatMsg();
        private readonly string m_strNameSpaceForms;

        // Este diccionario tiene cada código de la tabla asociado a su strategy correspondiente para conseguir la string.
        Dictionary<string, Strategy> m_dicDiccionario; 

        // Constructor que llena el diccionario.
        public CodesManager()
        {
            // Inicializamos el path readonly para encontrar los forms.
            m_strNameSpaceForms = "Carm.Shr";

            // Conseguimos la lista de codigos.
            Bel.LECodigos l_leCodigos = Bll.Tablas.CdgUpFull(false, m_smResult);
            if (AppRuts.MsgRuts_AnalizeError(null, m_smResult)) return;

            // Creamos el diccionario con el tamaño de la lista de codigos y llamamos al metodo que lo llena.
            m_dicDiccionario = new Dictionary<string, Strategy>(l_leCodigos.Count);
            cargarDiccionario(l_leCodigos);
        }

        // Metodo que recibe una lista de strings con codigos de la tabla de codigos y devuelve una lista de strings con las 
        // equvialencias de aplciar la estrategia correspondiente.
        public Equivalencia dameEquivalencia(CodigoCarta p_ccCodigo, Bel.ECliente p_eCliente)
        {
            Strategy l_sEstrategiaResolucion;

            string l_strClaveDic = "";

            // Si es un codigo variable la clave para el diccionario es fija y sino es el codigo del CodigoCarta.
            if (p_ccCodigo.esCodigoVariable)
                l_strClaveDic = "<//CodVar//>";
            else
                l_strClaveDic = p_ccCodigo.codigo;
            
            // Conseguimos la estrategia a aplicar para cada codigo y le inyectamos el cliente.
            l_sEstrategiaResolucion = m_dicDiccionario[l_strClaveDic];
            l_sEstrategiaResolucion.inyectDescripcionCodigo(p_ccCodigo.descripcionCodigo);
            l_sEstrategiaResolucion.inyectClient(p_eCliente);
            
            // Devolvemos la equivalencia con el codigo y el resultado de aplicar la estrategia (Strategy.dameString)
            return(new Equivalencia(p_ccCodigo, l_sEstrategiaResolucion.dameString()));
        }

        // Metodo con el switch del tipo de strategy a aplicar para cada codigo que carga el diccionario.
        private void cargarDiccionario(Bel.LECodigos p_leCodigos)
        {
            foreach (Bel.ECodigo l_eCod in p_leCodigos)
            {
                switch (l_eCod.Tipostrategy.Trim())
                {
                    case "S": { m_dicDiccionario.Add(l_eCod.Cod, new StrategyCampoSimple(l_eCod, p_leCodigos));break;}
                    case "F": { m_dicDiccionario.Add(l_eCod.Cod, new StrategyFechaActual(l_eCod)); break;}
                    case "E": { m_dicDiccionario.Add(l_eCod.Cod, new StrategyEmisor(l_eCod)); break; }
                    case "M": { m_dicDiccionario.Add(l_eCod.Cod, new StrategyEmailVend(l_eCod)); break; }
                    case "R": { m_dicDiccionario.Add(l_eCod.Cod, new StrategyReservador(l_eCod)); break; }
                    case "V": { m_dicDiccionario.Add(l_eCod.Cod, creaStrategyConVentana(l_eCod));break;}
                }

                if (AppRuts.MsgRuts_AnalizeError(null, m_smResult)) return;
            }
        }


        // Metodo que tiene la creacion del Strategy Con Ventana inyectando la ventana que corresponda segun el código.
        private StrategyConVentana creaStrategyConVentana(Bel.ECodigo p_eCod)
        {
            // Aca tengo un ejemplo de Instanciacion de clase a partir de una string, me evita un switch

            StrategyConVentana l_stgConVentana = new StrategyConVentana(p_eCod);

            string l_strFullNameClass = String.Format("{0}.{1}",
                                                      m_strNameSpaceForms,
                                                      p_eCod.Claseventana);

            Assembly l_asmAssembly = Assembly.GetExecutingAssembly();

            try
            {
                ObjectHandle ManipularObjeto = AppDomain.CurrentDomain.CreateInstance(l_asmAssembly.FullName, l_strFullNameClass);
                FormBase l_fbForm = (FormBase)ManipularObjeto.Unwrap();
                l_stgConVentana.inyectFormulario(l_fbForm);
            }
            catch (Exception e)
            {
                m_smResult.BllError(e.ToString());
            }

            return l_stgConVentana;
        }


    }
}
