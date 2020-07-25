#region Usings
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetRoutines;
using Carm;
#endregion

namespace Carm.Bel
{
    //----------------------------------------------------------------------------
    //                         TNG Software BEL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 25/07/2020 18:37
    // Sistema                  : Carm
    // Clase para Administrar   : Planes
    //----------------------------------------------------------------------------
    // © 1996-2020 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    #region Entidad: PlnServicio
    /// <summary>
    /// Clase que representa la Entidad: PlnServicio
    /// </summary>
    public sealed partial class EPlnServicio : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: PlnServicios
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EPlnServicio(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: PlnServicio
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EPlnServicio(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: PlnServicio
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EPlnServicio(string p_strXML,
                            bool p_bEsNueva)
        {
            // Fijamos la condicion de entidad nueva
            base.m_bNew= p_bEsNueva;

            // Obtenemos el Nodo de datos del XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXML;
            XmlNode l_xndData= l_xdocData.ChildNodes[0];

            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EPlnServicio.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["pls_cod_codplan"]= XMLRuts.ExtractXAttr(l_xndData, "pls_cod_codplan");
            l_drTemp["pls_cod_codservicio"]= XMLRuts.ExtractXAttr(l_xndData, "pls_cod_codservicio");
            l_drTemp["pls_nro_cprestlibres"]= XMLRuts.ExtractXAttr(l_xndData, "pls_nro_cprestlibres", 0);
            l_drTemp["pls_imp_valorprestacion"]= XMLRuts.ExtractXAttr(l_xndData, "pls_imp_valorprestacion", (decimal) 1);
            l_drTemp["pls_des_plan"]= XMLRuts.ExtractXAttr(l_xndData, "pls_des_plan");
            l_drTemp["pls_des_serv"]= XMLRuts.ExtractXAttr(l_xndData, "pls_des_serv");

            // Llenamos los campos fijos
            XML2FixedFields(ref l_drTemp, l_xndData);

            // Llamamos al metodo fijo
            fNewFromXML(ref l_drTemp, l_xndData);

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de los datos
            l_dtTemp.Rows.Add(l_drTemp);
            SetInternalData(l_dtTemp, l_dtTemp.Rows[0]);
        }

        /// <summary>
        /// Constructor 
        /// Privado para crear clases vacias
        /// </summary>
        /// <param name="p_dtDatos">DataTable con 1 registro con los datos de la entidad</param>
        private EPlnServicio(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: PlnServicio
        /// </summary>
        /// <returns>Entidad vacia: PlnServicio</returns>
        public static EPlnServicio NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EPlnServicio.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["pls_cod_codplan"]= "";
            l_drTemp["pls_cod_codservicio"]= "";
            l_drTemp["pls_nro_cprestlibres"]= 0;
            l_drTemp["pls_imp_valorprestacion"]= 1;
            l_drTemp["pls_des_plan"]= "";
            l_drTemp["pls_des_serv"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EPlnServicio l_entRet= new EPlnServicio(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: PlnServicio
        /// </summary>
        /// <param name="p_strCodplan">Código de Plan</param>
        /// <param name="p_strCodservicio">Código de Servicio</param>
        /// <param name="p_iCprestlibres">Cant. Prestaciones Libres</param>
        /// <param name="p_dcValorprestacion">Valor Prestación</param>
        /// <returns>Entidad: PlnServicio</returns>
        public static EPlnServicio NewFilled(string p_strCodplan,
                                             string p_strCodservicio,
                                             int p_iCprestlibres,
                                             decimal p_dcValorprestacion)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EPlnServicio.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["pls_cod_codplan"]= p_strCodplan;
            l_drTemp["pls_cod_codservicio"]= p_strCodservicio;
            l_drTemp["pls_nro_cprestlibres"]= p_iCprestlibres;
            l_drTemp["pls_imp_valorprestacion"]= p_dcValorprestacion;
            l_drTemp["pls_des_plan"]= "";
            l_drTemp["pls_des_serv"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EPlnServicio l_entRet= new EPlnServicio(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Código de Plan
        /// </summary>
        public static string FrmtCodplan(string p_strCodplan)
        {
            if (p_strCodplan.Trim().Length > 4)
                p_strCodplan= p_strCodplan.Trim().Substring(0,4);

            return p_strCodplan.Trim().PadLeft(4).ToUpper();
        }

        /// <summary>
        /// Formatea una string: Código de Servicio
        /// </summary>
        public static string FrmtCodservicio(string p_strCodservicio)
        {
            if (p_strCodservicio.Trim().Length > 4)
                p_strCodservicio= p_strCodservicio.Trim().Substring(0,4);

            return p_strCodservicio.Trim().PadLeft(4).ToUpper();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la estructura de la tabla interna de la entidad
        /// </summary>
        public static DataColumn[] Struct
        {
            get {
                // Creamos el vector de DataColumns y lo llenamos
                DataColumn[] l_dcStruct= new DataColumn[10];

                l_dcStruct[0]= new DataColumn("pls_cod_codplan", typeof(string));
                l_dcStruct[1]= new DataColumn("pls_des_plan", typeof(string));
                l_dcStruct[2]= new DataColumn("pls_cod_codservicio", typeof(string));
                l_dcStruct[3]= new DataColumn("pls_des_serv", typeof(string));
                l_dcStruct[4]= new DataColumn("pls_nro_cprestlibres", typeof(int));
                l_dcStruct[5]= new DataColumn("pls_imp_valorprestacion", typeof(decimal));
                EPlnServicio.FillFixedFields(ref l_dcStruct, 6);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código de Plan
        /// </summary>
        public static string CodplanCmp
        {
           get {return "pls_cod_codplan";}
        }

        /// <summary>
        /// Código de Plan
        /// </summary>
        public string Codplan
        {
            get {return (string) InternalData["pls_cod_codplan"];}
            set {InternalData["pls_cod_codplan"]= EPlnServicio.FrmtCodplan(value);}
        }

        /// <summary>
        /// Código de Servicio
        /// </summary>
        public static string CodservicioCmp
        {
           get {return "pls_cod_codservicio";}
        }

        /// <summary>
        /// Código de Servicio
        /// </summary>
        public string Codservicio
        {
            get {return (string) InternalData["pls_cod_codservicio"];}
            set {InternalData["pls_cod_codservicio"]= EPlnServicio.FrmtCodservicio(value);}
        }

        /// <summary>
        /// Cant. Prestaciones Libres
        /// </summary>
        public static string CprestlibresCmp
        {
           get {return "pls_nro_cprestlibres";}
        }

        /// <summary>
        /// Cant. Prestaciones Libres
        /// </summary>
        public int Cprestlibres
        {
            get {return (int) InternalData["pls_nro_cprestlibres"];}
            set {InternalData["pls_nro_cprestlibres"]= value;}
        }

        /// <summary>
        /// Valor Prestación
        /// </summary>
        public static string ValorprestacionCmp
        {
           get {return "pls_imp_valorprestacion";}
        }

        /// <summary>
        /// Valor Prestación
        /// </summary>
        public decimal Valorprestacion
        {
            get {return (decimal) InternalData["pls_imp_valorprestacion"];}
            set {InternalData["pls_imp_valorprestacion"]= value;}
        }

        /// <summary>
        /// Plan
        /// </summary>
        public string Pls_des_plan
        {
            get {return (string) InternalData["pls_des_plan"];}
            set {InternalData["pls_des_plan"]= value;}
        }

        /// <summary>
        /// Servicio
        /// </summary>
        public string Pls_des_serv
        {
            get {return (string) InternalData["pls_des_serv"];}
            set {InternalData["pls_des_serv"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EPlnServicio] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EPlnServicio] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EPlnServicio", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "pls_cod_codplan", Codplan));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "pls_cod_codservicio", Codservicio));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "pls_nro_cprestlibres", Cprestlibres));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "pls_imp_valorprestacion", Valorprestacion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "pls_des_plan", Pls_des_plan));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "pls_des_serv", Pls_des_serv));

                // Asignamos los campos fijos
                FixedFields2XML(l_xdocData, ref l_xndEntidad);

                // Llamamos al metodo fijo
                fAddXMLData(ref l_xdocData, ref l_xndEntidad);

                // Armamos el documento y lo devolvemos
                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad: PlnServicios
    /// <summary>
    /// Clase que representa la Lista-Entidad: PlnServicios
    /// </summary>
    public sealed partial class LEPlnServicios : ListaEntidades, IEnumerable<EPlnServicio>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: PlnServicios
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEPlnServicios(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEPlnServicios(string p_strXMLData) :
            base(EPlnServicio.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EPlnServicio(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEPlnServicios(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: PlnServicios
        /// </summary>
        /// <returns>Lista-Entidad vacia: PlnServicios</returns>
        public static LEPlnServicios NewEmpty()
        {
            return new LEPlnServicios(EPlnServicio.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEPlnServicio">Entidad a agregar</param>
        public void AddEntity(EPlnServicio p_entEPlnServicio)
        {
            base.AddEntity(p_entEPlnServicio);
        }

        /// <summary>
        /// Remueve una entidad [PlnServicio] por clave
        /// </summary>
        public int RemoveEntity(string p_strCodplan,
                                string p_strCodservicio)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "pls_cod_codplan = " + Ruts.Co(EPlnServicio.FrmtCodplan(p_strCodplan)) + " and " + 
                "pls_cod_codservicio = " + Ruts.Co(p_strCodservicio);

            if (m_dtDatos.DefaultView.Count == 1) {
                // La borramos
                m_dtDatos.Rows.Remove(m_dtDatos.DefaultView[0].Row);
                l_iRet= 1;
            }

            // Quito el filtro
            m_dtDatos.DefaultView.RowFilter= "";
            return l_iRet;
        }

        /// <summary>
        /// Verifca si una entidad [PlnServicio] esta en la lista
        /// </summary>
        public bool Contains(string p_strCodplan,
                             string p_strCodservicio)
        {
            using (EPlnServicio l_entTemp= this[p_strCodplan,
                                                p_strCodservicio])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: PlnServicios
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EPlnServicio> GetEnumerator() 
        {
            EPlnServicio l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EPlnServicio(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: PlnServicios
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EPlnServicio l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: PlnServicios
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETPlnServicios GetAsLET()
        {
            // Llenamos la lista tipada
            LETPlnServicios l_lentRet= new LETPlnServicios();

            foreach (EPlnServicio l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<PlnServicios>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EPlnServicio> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EPlnServicio>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [PlnServicio] por indice
        /// </summary>
        public new EPlnServicio this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad PlnServicio con los datos de la fila
                return new EPlnServicio(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [PlnServicio] por clave
        /// </summary>
        public EPlnServicio this[string p_strCodplan,
                                 string p_strCodservicio]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "pls_cod_codplan = " + Ruts.Co(EPlnServicio.FrmtCodplan(p_strCodplan)) + " and " + 
                    "pls_cod_codservicio = " + Ruts.Co(p_strCodservicio);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad PlnServicio con los datos de la fila
                if (l_drData == null) return null;
                return new EPlnServicio(l_drData);
            }
        }

        /// <summary>
        /// Devuelve la ListaEntidad como XML en string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la ListaEntidad como XML
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                // Construimos el XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEPlnServicios", null);

                foreach (EPlnServicio l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: PlnServicios
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: PlnServicios
    /// </summary>
    public sealed partial class LETPlnServicios : LET<EPlnServicio>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: PlnServicios
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEPlnServicios GetAsLE()
        {
            // Llenamos la lista
            LEPlnServicios l_lentRet= LEPlnServicios.NewEmpty();

            foreach (EPlnServicio l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [PlnServicio] por clave
        /// </summary>
        public EPlnServicio this[string p_strCodplan,
                                 string p_strCodservicio]
        {
            get {
                // Buscamos la entidad
                foreach (EPlnServicio l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Codplan == EPlnServicio.FrmtCodplan(p_strCodplan)) &&
                        (l_entItem.Codservicio == p_strCodservicio))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Plan
    /// <summary>
    /// Clase que representa la Entidad: Plan
    /// </summary>
    public sealed partial class EPlan : Entidad
    {
        #region Miembros de la clase
            private LEPlnServicios m_lentPlnServicios= null;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Planes
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EPlan(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Plan
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EPlan(string p_strXML) :
            this(p_strXML, false)
        {
            // Creamos las listas-entidad hijas vacias
            m_lentPlnServicios= LEPlnServicios.NewEmpty();
        }

        /// <summary>
        /// Construye una entidad desde un XML: Plan
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EPlan(string p_strXML,
                     bool p_bEsNueva,
                     bool p_bInitChilds= false)
        {
            // Fijamos la condicion de entidad nueva
            base.m_bNew= p_bEsNueva;

            // Obtenemos el Nodo de datos del XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXML;
            XmlNode l_xndData= l_xdocData.ChildNodes[0];

            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EPlan.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["pln_cod_cod"]= XMLRuts.ExtractXAttr(l_xndData, "pln_cod_cod");
            l_drTemp["pln_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "pln_des_des");
            l_drTemp["pln_cod_codplanavalon"]= XMLRuts.ExtractXAttr(l_xndData, "pln_cod_codplanavalon");
            l_drTemp["pln_d80_tcontratoavalon"]= XMLRuts.ExtractXAttr(l_xndData, "pln_d80_tcontratoavalon");
            l_drTemp["pln_des_marca"]= XMLRuts.ExtractXAttr(l_xndData, "pln_des_marca");

            // Llenamos los campos fijos
            XML2FixedFields(ref l_drTemp, l_xndData);

            // Llamamos al metodo fijo
            fNewFromXML(ref l_drTemp, l_xndData);

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de los datos
            l_dtTemp.Rows.Add(l_drTemp);
            SetInternalData(l_dtTemp, l_dtTemp.Rows[0]);

            if (!p_bInitChilds) return;

            // Creamos las listas-entidad hijas vacias
            m_lentPlnServicios= LEPlnServicios.NewEmpty();
        }

        /// <summary>
        /// Constructor 
        /// Privado para crear clases vacias
        /// </summary>
        /// <param name="p_dtDatos">DataTable con 1 registro con los datos de la entidad</param>
        private EPlan(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
            // Creamos las listas-entidad hijas vacias
            m_lentPlnServicios= LEPlnServicios.NewEmpty();
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Plan
        /// </summary>
        /// <returns>Entidad vacia: Plan</returns>
        public static EPlan NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EPlan.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["pln_cod_cod"]= "";
            l_drTemp["pln_des_des"]= "";
            l_drTemp["pln_cod_codplanavalon"]= "";
            l_drTemp["pln_d80_tcontratoavalon"]= "";
            l_drTemp["pln_des_marca"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EPlan l_entRet= new EPlan(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Plan
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strDes">Descripción</param>
        /// <param name="p_strCodplanavalon">Cod Plan Avalon</param>
        /// <param name="p_strTcontratoavalon">Lista de T Contratos Avalon</param>
        /// <returns>Entidad: Plan</returns>
        public static EPlan NewFilled(string p_strCod,
                                      string p_strDes,
                                      string p_strCodplanavalon,
                                      string p_strTcontratoavalon)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EPlan.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["pln_cod_cod"]= p_strCod;
            l_drTemp["pln_des_des"]= p_strDes;
            l_drTemp["pln_cod_codplanavalon"]= p_strCodplanavalon;
            l_drTemp["pln_d80_tcontratoavalon"]= p_strTcontratoavalon;
            l_drTemp["pln_des_marca"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EPlan l_entRet= new EPlan(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Código
        /// </summary>
        public static string FrmtCod(string p_strCod)
        {
            if (p_strCod.Trim().Length > 4)
                p_strCod= p_strCod.Trim().Substring(0,4);

            return p_strCod.Trim().PadLeft(4).ToUpper();
        }

        /// <summary>
        /// Formatea una string: Cod Plan Avalon
        /// </summary>
        public static string FrmtCodplanavalon(string p_strCodplanavalon)
        {
            if (p_strCodplanavalon.Trim().Length > 4)
                p_strCodplanavalon= p_strCodplanavalon.Trim().Substring(0,4);

            return p_strCodplanavalon.Trim().PadLeft(4).ToUpper();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la estructura de la tabla interna de la entidad
        /// </summary>
        public static DataColumn[] Struct
        {
            get {
                // Creamos el vector de DataColumns y lo llenamos
                DataColumn[] l_dcStruct= new DataColumn[9];

                l_dcStruct[0]= new DataColumn("pln_cod_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("pln_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("pln_cod_codplanavalon", typeof(string));
                l_dcStruct[3]= new DataColumn("pln_d80_tcontratoavalon", typeof(string));
                EPlan.FillFixedFields(ref l_dcStruct, 4);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código
        /// </summary>
        public static string CodCmp
        {
           get {return "pln_cod_cod";}
        }

        /// <summary>
        /// Código
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["pln_cod_cod"];}
            set {InternalData["pln_cod_cod"]= EPlan.FrmtCod(value);}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public static string DesCmp
        {
           get {return "pln_des_des";}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["pln_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["pln_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Cod Plan Avalon
        /// </summary>
        public static string CodplanavalonCmp
        {
           get {return "pln_cod_codplanavalon";}
        }

        /// <summary>
        /// Cod Plan Avalon
        /// </summary>
        public string Codplanavalon
        {
            get {return (string) InternalData["pln_cod_codplanavalon"];}
            set {InternalData["pln_cod_codplanavalon"]= EPlan.FrmtCodplanavalon(value);}
        }

        /// <summary>
        /// Lista de T Contratos Avalon
        /// </summary>
        public static string TcontratoavalonCmp
        {
           get {return "pln_d80_tcontratoavalon";}
        }

        /// <summary>
        /// Lista de T Contratos Avalon
        /// </summary>
        public string Tcontratoavalon
        {
            get {return ((string) InternalData["pln_d80_tcontratoavalon"]).Trim();}
            set {
                if (value.Trim().Length > 80) value= value.Trim().Substring(0,80);
                InternalData["pln_d80_tcontratoavalon"]= value.Trim();
            }
        }

        /// <summary>
        /// Servicios de los Planes
        /// </summary>
        public LEPlnServicios PlnServicios
        {
            get {return m_lentPlnServicios;}
            set {m_lentPlnServicios= value;}
        }

        /// <summary>
        /// Marca
        /// </summary>
        public string Pln_des_marca
        {
            get {return (string) InternalData["pln_des_marca"];}
            set {InternalData["pln_des_marca"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EPlan] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EPlan] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EPlan", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "pln_cod_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "pln_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "pln_cod_codplanavalon", Codplanavalon));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "pln_d80_tcontratoavalon", Tcontratoavalon));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "pln_des_marca", Pln_des_marca));

                // Asignamos los campos fijos
                FixedFields2XML(l_xdocData, ref l_xndEntidad);

                // Llamamos al metodo fijo
                fAddXMLData(ref l_xdocData, ref l_xndEntidad);

                // Armamos el documento y lo devolvemos
                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad: Planes
    /// <summary>
    /// Clase que representa la Lista-Entidad: Planes
    /// </summary>
    public sealed partial class LEPlanes : ListaEntidades, IEnumerable<EPlan>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Planes
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEPlanes(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEPlanes(string p_strXMLData) :
            base(EPlan.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EPlan(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEPlanes(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Planes
        /// </summary>
        /// <returns>Lista-Entidad vacia: Planes</returns>
        public static LEPlanes NewEmpty()
        {
            return new LEPlanes(EPlan.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEPlan">Entidad a agregar</param>
        public void AddEntity(EPlan p_entEPlan)
        {
            base.AddEntity(p_entEPlan);
        }

        /// <summary>
        /// Remueve una entidad [Plan] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "pln_cod_cod = " + Ruts.Co(EPlan.FrmtCod(p_strCod));

            if (m_dtDatos.DefaultView.Count == 1) {
                // La borramos
                m_dtDatos.Rows.Remove(m_dtDatos.DefaultView[0].Row);
                l_iRet= 1;
            }

            // Quito el filtro
            m_dtDatos.DefaultView.RowFilter= "";
            return l_iRet;
        }

        /// <summary>
        /// Verifca si una entidad [Plan] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EPlan l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Planes
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EPlan> GetEnumerator() 
        {
            EPlan l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EPlan(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Planes
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EPlan l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Planes
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETPlanes GetAsLET()
        {
            // Llenamos la lista tipada
            LETPlanes l_lentRet= new LETPlanes();

            foreach (EPlan l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Planes>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EPlan> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EPlan>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Plan] por indice
        /// </summary>
        public new EPlan this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Plan con los datos de la fila
                return new EPlan(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Plan] por clave
        /// </summary>
        public EPlan this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "pln_cod_cod = " + Ruts.Co(EPlan.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Plan con los datos de la fila
                if (l_drData == null) return null;
                return new EPlan(l_drData);
            }
        }

        /// <summary>
        /// Devuelve la ListaEntidad como XML en string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la ListaEntidad como XML
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                // Construimos el XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEPlanes", null);

                foreach (EPlan l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Planes
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Planes
    /// </summary>
    public sealed partial class LETPlanes : LET<EPlan>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Planes
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEPlanes GetAsLE()
        {
            // Llenamos la lista
            LEPlanes l_lentRet= LEPlanes.NewEmpty();

            foreach (EPlan l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Plan] por clave
        /// </summary>
        public EPlan this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EPlan l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == EPlan.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion
}
