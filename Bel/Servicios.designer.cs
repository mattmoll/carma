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
    // Clase para Administrar   : Servicios
    //----------------------------------------------------------------------------
    // © 1996-2020 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    #region Entidad: Servicio
    /// <summary>
    /// Clase que representa la Entidad: Servicio
    /// </summary>
    public sealed partial class EServicio : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Servicios
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EServicio(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Servicio
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EServicio(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Servicio
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EServicio(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EServicio.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["srv_cod_cod"]= XMLRuts.ExtractXAttr(l_xndData, "srv_cod_cod");
            l_drTemp["srv_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "srv_des_des");
            l_drTemp["srv_xld_explicacion"]= XMLRuts.ExtractXAttr(l_xndData, "srv_xld_explicacion");

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
        private EServicio(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Servicio
        /// </summary>
        /// <returns>Entidad vacia: Servicio</returns>
        public static EServicio NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EServicio.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["srv_cod_cod"]= "";
            l_drTemp["srv_des_des"]= "";
            l_drTemp["srv_xld_explicacion"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EServicio l_entRet= new EServicio(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Servicio
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strDes">Descripción</param>
        /// <param name="p_strExplicacion">Descripcion Extendida</param>
        /// <returns>Entidad: Servicio</returns>
        public static EServicio NewFilled(string p_strCod,
                                          string p_strDes,
                                          string p_strExplicacion)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EServicio.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["srv_cod_cod"]= p_strCod;
            l_drTemp["srv_des_des"]= p_strDes;
            l_drTemp["srv_xld_explicacion"]= p_strExplicacion;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EServicio l_entRet= new EServicio(l_dtTemp);
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
                DataColumn[] l_dcStruct= new DataColumn[7];

                l_dcStruct[0]= new DataColumn("srv_cod_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("srv_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("srv_xld_explicacion", typeof(string));
                EServicio.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código
        /// </summary>
        public static string CodCmp
        {
           get {return "srv_cod_cod";}
        }

        /// <summary>
        /// Código
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["srv_cod_cod"];}
            set {InternalData["srv_cod_cod"]= EServicio.FrmtCod(value);}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public static string DesCmp
        {
           get {return "srv_des_des";}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["srv_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["srv_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Descripcion Extendida
        /// </summary>
        public static string ExplicacionCmp
        {
           get {return "srv_xld_explicacion";}
        }

        /// <summary>
        /// Descripcion Extendida
        /// </summary>
        public string Explicacion
        {
            get {return ((string) InternalData["srv_xld_explicacion"]).Trim();}
            set {
                if (value.Trim().Length > 240) value= value.Trim().Substring(0,240);
                InternalData["srv_xld_explicacion"]= value.Trim();
            }
        }

        /// <summary>
        /// Devuelve la entidad [EServicio] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EServicio] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EServicio", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "srv_cod_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "srv_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "srv_xld_explicacion", Explicacion));

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

    #region Lista-Entidad: Servicios
    /// <summary>
    /// Clase que representa la Lista-Entidad: Servicios
    /// </summary>
    public sealed partial class LEServicios : ListaEntidades, IEnumerable<EServicio>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Servicios
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEServicios(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEServicios(string p_strXMLData) :
            base(EServicio.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EServicio(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEServicios(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Servicios
        /// </summary>
        /// <returns>Lista-Entidad vacia: Servicios</returns>
        public static LEServicios NewEmpty()
        {
            return new LEServicios(EServicio.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEServicio">Entidad a agregar</param>
        public void AddEntity(EServicio p_entEServicio)
        {
            base.AddEntity(p_entEServicio);
        }

        /// <summary>
        /// Remueve una entidad [Servicio] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "srv_cod_cod = " + Ruts.Co(EServicio.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [Servicio] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EServicio l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Servicios
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EServicio> GetEnumerator() 
        {
            EServicio l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EServicio(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Servicios
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EServicio l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Servicios
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETServicios GetAsLET()
        {
            // Llenamos la lista tipada
            LETServicios l_lentRet= new LETServicios();

            foreach (EServicio l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Servicios>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EServicio> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EServicio>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Servicio] por indice
        /// </summary>
        public new EServicio this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Servicio con los datos de la fila
                return new EServicio(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Servicio] por clave
        /// </summary>
        public EServicio this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "srv_cod_cod = " + Ruts.Co(EServicio.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Servicio con los datos de la fila
                if (l_drData == null) return null;
                return new EServicio(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEServicios", null);

                foreach (EServicio l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Servicios
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Servicios
    /// </summary>
    public sealed partial class LETServicios : LET<EServicio>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Servicios
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEServicios GetAsLE()
        {
            // Llenamos la lista
            LEServicios l_lentRet= LEServicios.NewEmpty();

            foreach (EServicio l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Servicio] por clave
        /// </summary>
        public EServicio this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EServicio l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == EServicio.FrmtCod(p_strCod))
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
