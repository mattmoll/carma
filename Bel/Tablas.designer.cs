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
    // Fecha                    : 05/01/2023 21:08
    // Sistema                  : Carm
    // Clase para Administrar   : Tablas
    //----------------------------------------------------------------------------
    // © 1996-2023 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    #region Entidad: CategoriaLlamada
    /// <summary>
    /// Clase que representa la Entidad: CategoriaLlamada
    /// </summary>
    public sealed partial class ECategoriaLlamada : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: CategoriasLlamada
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ECategoriaLlamada(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CategoriaLlamada
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ECategoriaLlamada(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CategoriaLlamada
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ECategoriaLlamada(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ECategoriaLlamada.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ctl_rcd_cod"]= XMLRuts.ExtractXAttr(l_xndData, "ctl_rcd_cod");
            l_drTemp["ctl_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "ctl_des_des");
            l_drTemp["ctl_cd1_tipo"]= XMLRuts.ExtractXAttr(l_xndData, "ctl_cd1_tipo");

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
        private ECategoriaLlamada(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: CategoriaLlamada
        /// </summary>
        /// <returns>Entidad vacia: CategoriaLlamada</returns>
        public static ECategoriaLlamada NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECategoriaLlamada.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ctl_rcd_cod"]= "";
            l_drTemp["ctl_des_des"]= "";
            l_drTemp["ctl_cd1_tipo"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECategoriaLlamada l_entRet= new ECategoriaLlamada(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: CategoriaLlamada
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_strDes">Categoría</param>
        /// <param name="p_strTipo">Tipo de llamada</param>
        /// <returns>Entidad: CategoriaLlamada</returns>
        public static ECategoriaLlamada NewFilled(string p_strCod,
                                                  string p_strDes,
                                                  string p_strTipo)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECategoriaLlamada.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ctl_rcd_cod"]= p_strCod;
            l_drTemp["ctl_des_des"]= p_strDes;
            l_drTemp["ctl_cd1_tipo"]= p_strTipo;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECategoriaLlamada l_entRet= new ECategoriaLlamada(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Codigo
        /// </summary>
        public static string FrmtCod(string p_strCod)
        {
            if (p_strCod.Trim().Length > 2)
                p_strCod= p_strCod.Trim().Substring(0,2);

            return p_strCod.Trim().PadLeft(2).ToUpper();
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

                l_dcStruct[0]= new DataColumn("ctl_rcd_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("ctl_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("ctl_cd1_tipo", typeof(string));
                ECategoriaLlamada.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public static string CodCmp
        {
           get {return "ctl_rcd_cod";}
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["ctl_rcd_cod"];}
            set {InternalData["ctl_rcd_cod"]= ECategoriaLlamada.FrmtCod(value);}
        }

        /// <summary>
        /// Categoría
        /// </summary>
        public static string DesCmp
        {
           get {return "ctl_des_des";}
        }

        /// <summary>
        /// Categoría
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["ctl_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["ctl_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Tipo de llamada
        /// </summary>
        public static string TipoCmp
        {
           get {return "ctl_cd1_tipo";}
        }

        /// <summary>
        /// Tipo de llamada
        /// </summary>
        public string Tipo
        {
            get {return (string) InternalData["ctl_cd1_tipo"];}
            set {InternalData["ctl_cd1_tipo"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ECategoriaLlamada] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ECategoriaLlamada] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ECategoriaLlamada", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ctl_rcd_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ctl_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ctl_cd1_tipo", Tipo));

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

    #region Lista-Entidad: CategoriasLlamada
    /// <summary>
    /// Clase que representa la Lista-Entidad: CategoriasLlamada
    /// </summary>
    public sealed partial class LECategoriasLlamada : ListaEntidades, IEnumerable<ECategoriaLlamada>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: CategoriasLlamada
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECategoriasLlamada(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECategoriasLlamada(string p_strXMLData) :
            base(ECategoriaLlamada.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ECategoriaLlamada(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LECategoriasLlamada(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: CategoriasLlamada
        /// </summary>
        /// <returns>Lista-Entidad vacia: CategoriasLlamada</returns>
        public static LECategoriasLlamada NewEmpty()
        {
            return new LECategoriasLlamada(ECategoriaLlamada.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entECategoriaLlamada">Entidad a agregar</param>
        public void AddEntity(ECategoriaLlamada p_entECategoriaLlamada)
        {
            base.AddEntity(p_entECategoriaLlamada);
        }

        /// <summary>
        /// Remueve una entidad [CategoriaLlamada] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "ctl_rcd_cod = " + Ruts.Co(ECategoriaLlamada.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [CategoriaLlamada] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (ECategoriaLlamada l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: CategoriasLlamada
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ECategoriaLlamada> GetEnumerator() 
        {
            ECategoriaLlamada l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ECategoriaLlamada(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: CategoriasLlamada
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ECategoriaLlamada l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: CategoriasLlamada
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETCategoriasLlamada GetAsLET()
        {
            // Llenamos la lista tipada
            LETCategoriasLlamada l_lentRet= new LETCategoriasLlamada();

            foreach (ECategoriaLlamada l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<CategoriasLlamada>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ECategoriaLlamada> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ECategoriaLlamada>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CategoriaLlamada] por indice
        /// </summary>
        public new ECategoriaLlamada this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad CategoriaLlamada con los datos de la fila
                return new ECategoriaLlamada(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [CategoriaLlamada] por clave
        /// </summary>
        public ECategoriaLlamada this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "ctl_rcd_cod = " + Ruts.Co(ECategoriaLlamada.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad CategoriaLlamada con los datos de la fila
                if (l_drData == null) return null;
                return new ECategoriaLlamada(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LECategoriasLlamada", null);

                foreach (ECategoriaLlamada l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: CategoriasLlamada
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: CategoriasLlamada
    /// </summary>
    public sealed partial class LETCategoriasLlamada : LET<ECategoriaLlamada>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: CategoriasLlamada
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LECategoriasLlamada GetAsLE()
        {
            // Llenamos la lista
            LECategoriasLlamada l_lentRet= LECategoriasLlamada.NewEmpty();

            foreach (ECategoriaLlamada l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CategoriaLlamada] por clave
        /// </summary>
        public ECategoriaLlamada this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (ECategoriaLlamada l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == ECategoriaLlamada.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: ConversionColor
    /// <summary>
    /// Clase que representa la Entidad: ConversionColor
    /// </summary>
    public sealed partial class EConversionColor : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: ConversionColores
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EConversionColor(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: ConversionColor
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EConversionColor(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: ConversionColor
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EConversionColor(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EConversionColor.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["con_cod_cod"]= XMLRuts.ExtractXAttr(l_xndData, "con_cod_cod");
            l_drTemp["con_des_coloraconvertir"]= XMLRuts.ExtractXAttr(l_xndData, "con_des_coloraconvertir");
            l_drTemp["con_cd1_colorconvertido"]= XMLRuts.ExtractXAttr(l_xndData, "con_cd1_colorconvertido");

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
        private EConversionColor(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: ConversionColor
        /// </summary>
        /// <returns>Entidad vacia: ConversionColor</returns>
        public static EConversionColor NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EConversionColor.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["con_cod_cod"]= "";
            l_drTemp["con_des_coloraconvertir"]= "";
            l_drTemp["con_cd1_colorconvertido"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EConversionColor l_entRet= new EConversionColor(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: ConversionColor
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strColoraconvertir">Color a Convertir</param>
        /// <param name="p_strColorconvertido">Color Convertido</param>
        /// <returns>Entidad: ConversionColor</returns>
        public static EConversionColor NewFilled(string p_strCod,
                                                 string p_strColoraconvertir,
                                                 string p_strColorconvertido)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EConversionColor.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["con_cod_cod"]= p_strCod;
            l_drTemp["con_des_coloraconvertir"]= p_strColoraconvertir;
            l_drTemp["con_cd1_colorconvertido"]= p_strColorconvertido;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EConversionColor l_entRet= new EConversionColor(l_dtTemp);
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

                l_dcStruct[0]= new DataColumn("con_cod_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("con_des_coloraconvertir", typeof(string));
                l_dcStruct[2]= new DataColumn("con_cd1_colorconvertido", typeof(string));
                EConversionColor.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código
        /// </summary>
        public static string CodCmp
        {
           get {return "con_cod_cod";}
        }

        /// <summary>
        /// Código
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["con_cod_cod"];}
            set {InternalData["con_cod_cod"]= EConversionColor.FrmtCod(value);}
        }

        /// <summary>
        /// Color a Convertir
        /// </summary>
        public static string ColoraconvertirCmp
        {
           get {return "con_des_coloraconvertir";}
        }

        /// <summary>
        /// Color a Convertir
        /// </summary>
        public string Coloraconvertir
        {
            get {return ((string) InternalData["con_des_coloraconvertir"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["con_des_coloraconvertir"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Color Convertido
        /// </summary>
        public static string ColorconvertidoCmp
        {
           get {return "con_cd1_colorconvertido";}
        }

        /// <summary>
        /// Color Convertido
        /// </summary>
        public string Colorconvertido
        {
            get {return (string) InternalData["con_cd1_colorconvertido"];}
            set {InternalData["con_cd1_colorconvertido"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EConversionColor] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EConversionColor] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EConversionColor", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "con_cod_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "con_des_coloraconvertir", Coloraconvertir));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "con_cd1_colorconvertido", Colorconvertido));

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

    #region Lista-Entidad: ConversionColores
    /// <summary>
    /// Clase que representa la Lista-Entidad: ConversionColores
    /// </summary>
    public sealed partial class LEConversionColores : ListaEntidades, IEnumerable<EConversionColor>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: ConversionColores
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEConversionColores(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEConversionColores(string p_strXMLData) :
            base(EConversionColor.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EConversionColor(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEConversionColores(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: ConversionColores
        /// </summary>
        /// <returns>Lista-Entidad vacia: ConversionColores</returns>
        public static LEConversionColores NewEmpty()
        {
            return new LEConversionColores(EConversionColor.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEConversionColor">Entidad a agregar</param>
        public void AddEntity(EConversionColor p_entEConversionColor)
        {
            base.AddEntity(p_entEConversionColor);
        }

        /// <summary>
        /// Remueve una entidad [ConversionColor] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "con_cod_cod = " + Ruts.Co(EConversionColor.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [ConversionColor] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EConversionColor l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: ConversionColores
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EConversionColor> GetEnumerator() 
        {
            EConversionColor l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EConversionColor(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: ConversionColores
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EConversionColor l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: ConversionColores
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETConversionColores GetAsLET()
        {
            // Llenamos la lista tipada
            LETConversionColores l_lentRet= new LETConversionColores();

            foreach (EConversionColor l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<ConversionColores>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EConversionColor> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EConversionColor>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [ConversionColor] por indice
        /// </summary>
        public new EConversionColor this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad ConversionColor con los datos de la fila
                return new EConversionColor(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [ConversionColor] por clave
        /// </summary>
        public EConversionColor this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "con_cod_cod = " + Ruts.Co(EConversionColor.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad ConversionColor con los datos de la fila
                if (l_drData == null) return null;
                return new EConversionColor(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEConversionColores", null);

                foreach (EConversionColor l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: ConversionColores
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: ConversionColores
    /// </summary>
    public sealed partial class LETConversionColores : LET<EConversionColor>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: ConversionColores
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEConversionColores GetAsLE()
        {
            // Llenamos la lista
            LEConversionColores l_lentRet= LEConversionColores.NewEmpty();

            foreach (EConversionColor l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [ConversionColor] por clave
        /// </summary>
        public EConversionColor this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EConversionColor l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == EConversionColor.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Franquicia
    /// <summary>
    /// Clase que representa la Entidad: Franquicia
    /// </summary>
    public sealed partial class EFranquicia : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Franquicias
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EFranquicia(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Franquicia
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EFranquicia(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Franquicia
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EFranquicia(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EFranquicia.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["frq_cod_cod"]= XMLRuts.ExtractXAttr(l_xndData, "frq_cod_cod");
            l_drTemp["frq_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "frq_des_des");

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
        private EFranquicia(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Franquicia
        /// </summary>
        /// <returns>Entidad vacia: Franquicia</returns>
        public static EFranquicia NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EFranquicia.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["frq_cod_cod"]= "";
            l_drTemp["frq_des_des"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EFranquicia l_entRet= new EFranquicia(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Franquicia
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_strDes">Descripcion</param>
        /// <returns>Entidad: Franquicia</returns>
        public static EFranquicia NewFilled(string p_strCod,
                                            string p_strDes)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EFranquicia.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["frq_cod_cod"]= p_strCod;
            l_drTemp["frq_des_des"]= p_strDes;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EFranquicia l_entRet= new EFranquicia(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Codigo
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
                DataColumn[] l_dcStruct= new DataColumn[6];

                l_dcStruct[0]= new DataColumn("frq_cod_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("frq_des_des", typeof(string));
                EFranquicia.FillFixedFields(ref l_dcStruct, 2);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public static string CodCmp
        {
           get {return "frq_cod_cod";}
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["frq_cod_cod"];}
            set {InternalData["frq_cod_cod"]= EFranquicia.FrmtCod(value);}
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public static string DesCmp
        {
           get {return "frq_des_des";}
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["frq_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["frq_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Devuelve la entidad [EFranquicia] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EFranquicia] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EFranquicia", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "frq_cod_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "frq_des_des", Des));

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

    #region Lista-Entidad: Franquicias
    /// <summary>
    /// Clase que representa la Lista-Entidad: Franquicias
    /// </summary>
    public sealed partial class LEFranquicias : ListaEntidades, IEnumerable<EFranquicia>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Franquicias
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEFranquicias(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEFranquicias(string p_strXMLData) :
            base(EFranquicia.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EFranquicia(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEFranquicias(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Franquicias
        /// </summary>
        /// <returns>Lista-Entidad vacia: Franquicias</returns>
        public static LEFranquicias NewEmpty()
        {
            return new LEFranquicias(EFranquicia.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEFranquicia">Entidad a agregar</param>
        public void AddEntity(EFranquicia p_entEFranquicia)
        {
            base.AddEntity(p_entEFranquicia);
        }

        /// <summary>
        /// Remueve una entidad [Franquicia] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "frq_cod_cod = " + Ruts.Co(EFranquicia.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [Franquicia] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EFranquicia l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Franquicias
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EFranquicia> GetEnumerator() 
        {
            EFranquicia l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EFranquicia(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Franquicias
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EFranquicia l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Franquicias
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETFranquicias GetAsLET()
        {
            // Llenamos la lista tipada
            LETFranquicias l_lentRet= new LETFranquicias();

            foreach (EFranquicia l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Franquicias>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EFranquicia> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EFranquicia>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Franquicia] por indice
        /// </summary>
        public new EFranquicia this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Franquicia con los datos de la fila
                return new EFranquicia(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Franquicia] por clave
        /// </summary>
        public EFranquicia this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "frq_cod_cod = " + Ruts.Co(EFranquicia.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Franquicia con los datos de la fila
                if (l_drData == null) return null;
                return new EFranquicia(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEFranquicias", null);

                foreach (EFranquicia l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Franquicias
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Franquicias
    /// </summary>
    public sealed partial class LETFranquicias : LET<EFranquicia>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Franquicias
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEFranquicias GetAsLE()
        {
            // Llenamos la lista
            LEFranquicias l_lentRet= LEFranquicias.NewEmpty();

            foreach (EFranquicia l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Franquicia] por clave
        /// </summary>
        public EFranquicia this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EFranquicia l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == EFranquicia.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: ListaDePrecios
    /// <summary>
    /// Clase que representa la Entidad: ListaDePrecios
    /// </summary>
    public sealed partial class EListaDePrecios : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: ListasDePrecios
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EListaDePrecios(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: ListaDePrecios
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EListaDePrecios(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: ListaDePrecios
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EListaDePrecios(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EListaDePrecios.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["lpr_cod_cod"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_cod_cod");
            l_drTemp["lpr_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_des_des");
            l_drTemp["lpr_cod_codplan"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_cod_codplan");
            l_drTemp["lpr_rcd_codmarca"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_rcd_codmarca");
            l_drTemp["lpr_imp_precio1p"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_imp_precio1p", (decimal) 0);
            l_drTemp["lpr_imp_precio2p"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_imp_precio2p", (decimal) 0);
            l_drTemp["lpr_imp_precio3p"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_imp_precio3p", (decimal) 0);
            l_drTemp["lpr_imp_precio4p"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_imp_precio4p", (decimal) 0);
            l_drTemp["lpr_imp_precio5p"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_imp_precio5p", (decimal) 0);
            l_drTemp["lpr_imp_precio6p"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_imp_precio6p", (decimal) 0);
            l_drTemp["lpr_imp_precio7p"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_imp_precio7p", (decimal) 0);
            l_drTemp["lpr_imp_precio8p"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_imp_precio8p", (decimal) 0);
            l_drTemp["lpr_imp_precio9p"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_imp_precio9p", (decimal) 0);
            l_drTemp["lpr_imp_precio10p"]= XMLRuts.ExtractXAttr(l_xndData, "lpr_imp_precio10p", (decimal) 0);
            l_drTemp["des_marca"]= XMLRuts.ExtractXAttr(l_xndData, "des_marca");
            l_drTemp["des_plan"]= XMLRuts.ExtractXAttr(l_xndData, "des_plan");

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
        private EListaDePrecios(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: ListaDePrecios
        /// </summary>
        /// <returns>Entidad vacia: ListaDePrecios</returns>
        public static EListaDePrecios NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EListaDePrecios.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["lpr_cod_cod"]= "";
            l_drTemp["lpr_des_des"]= "";
            l_drTemp["lpr_cod_codplan"]= "";
            l_drTemp["lpr_rcd_codmarca"]= "";
            l_drTemp["lpr_imp_precio1p"]= 0;
            l_drTemp["lpr_imp_precio2p"]= 0;
            l_drTemp["lpr_imp_precio3p"]= 0;
            l_drTemp["lpr_imp_precio4p"]= 0;
            l_drTemp["lpr_imp_precio5p"]= 0;
            l_drTemp["lpr_imp_precio6p"]= 0;
            l_drTemp["lpr_imp_precio7p"]= 0;
            l_drTemp["lpr_imp_precio8p"]= 0;
            l_drTemp["lpr_imp_precio9p"]= 0;
            l_drTemp["lpr_imp_precio10p"]= 0;
            l_drTemp["des_marca"]= "";
            l_drTemp["des_plan"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EListaDePrecios l_entRet= new EListaDePrecios(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: ListaDePrecios
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strDes">Descripción</param>
        /// <param name="p_strCodplan">Plan</param>
        /// <param name="p_strCodmarca">Marca</param>
        /// <param name="p_dcPrecio1p">Precio 1 P</param>
        /// <param name="p_dcPrecio2p">Precio 2 P</param>
        /// <param name="p_dcPrecio3p">Precio 3 P</param>
        /// <param name="p_dcPrecio4p">Precio 4 P</param>
        /// <param name="p_dcPrecio5p">Precio 5 P</param>
        /// <param name="p_dcPrecio6p">Precio 6 P</param>
        /// <param name="p_dcPrecio7p">Precio 7 P</param>
        /// <param name="p_dcPrecio8p">Precio 8 P</param>
        /// <param name="p_dcPrecio9p">Precio 9 P</param>
        /// <param name="p_dcPrecio10p">Precio 10 P</param>
        /// <returns>Entidad: ListaDePrecios</returns>
        public static EListaDePrecios NewFilled(string p_strCod,
                                                string p_strDes,
                                                string p_strCodplan,
                                                string p_strCodmarca,
                                                decimal p_dcPrecio1p,
                                                decimal p_dcPrecio2p,
                                                decimal p_dcPrecio3p,
                                                decimal p_dcPrecio4p,
                                                decimal p_dcPrecio5p,
                                                decimal p_dcPrecio6p,
                                                decimal p_dcPrecio7p,
                                                decimal p_dcPrecio8p,
                                                decimal p_dcPrecio9p,
                                                decimal p_dcPrecio10p)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EListaDePrecios.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["lpr_cod_cod"]= p_strCod;
            l_drTemp["lpr_des_des"]= p_strDes;
            l_drTemp["lpr_cod_codplan"]= p_strCodplan;
            l_drTemp["lpr_rcd_codmarca"]= p_strCodmarca;
            l_drTemp["lpr_imp_precio1p"]= p_dcPrecio1p;
            l_drTemp["lpr_imp_precio2p"]= p_dcPrecio2p;
            l_drTemp["lpr_imp_precio3p"]= p_dcPrecio3p;
            l_drTemp["lpr_imp_precio4p"]= p_dcPrecio4p;
            l_drTemp["lpr_imp_precio5p"]= p_dcPrecio5p;
            l_drTemp["lpr_imp_precio6p"]= p_dcPrecio6p;
            l_drTemp["lpr_imp_precio7p"]= p_dcPrecio7p;
            l_drTemp["lpr_imp_precio8p"]= p_dcPrecio8p;
            l_drTemp["lpr_imp_precio9p"]= p_dcPrecio9p;
            l_drTemp["lpr_imp_precio10p"]= p_dcPrecio10p;
            l_drTemp["des_marca"]= "";
            l_drTemp["des_plan"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EListaDePrecios l_entRet= new EListaDePrecios(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Plan
        /// </summary>
        public static string FrmtCodplan(string p_strCodplan)
        {
            if (p_strCodplan.Trim().Length > 4)
                p_strCodplan= p_strCodplan.Trim().Substring(0,4);

            return p_strCodplan.Trim().PadLeft(4).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[20];

                l_dcStruct[0]= new DataColumn("lpr_cod_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("lpr_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("des_marca", typeof(string));
                l_dcStruct[3]= new DataColumn("des_plan", typeof(string));
                l_dcStruct[4]= new DataColumn("lpr_cod_codplan", typeof(string));
                l_dcStruct[5]= new DataColumn("lpr_rcd_codmarca", typeof(string));
                l_dcStruct[6]= new DataColumn("lpr_imp_precio1p", typeof(decimal));
                l_dcStruct[7]= new DataColumn("lpr_imp_precio2p", typeof(decimal));
                l_dcStruct[8]= new DataColumn("lpr_imp_precio3p", typeof(decimal));
                l_dcStruct[9]= new DataColumn("lpr_imp_precio4p", typeof(decimal));
                l_dcStruct[10]= new DataColumn("lpr_imp_precio5p", typeof(decimal));
                l_dcStruct[11]= new DataColumn("lpr_imp_precio6p", typeof(decimal));
                l_dcStruct[12]= new DataColumn("lpr_imp_precio7p", typeof(decimal));
                l_dcStruct[13]= new DataColumn("lpr_imp_precio8p", typeof(decimal));
                l_dcStruct[14]= new DataColumn("lpr_imp_precio9p", typeof(decimal));
                l_dcStruct[15]= new DataColumn("lpr_imp_precio10p", typeof(decimal));
                EListaDePrecios.FillFixedFields(ref l_dcStruct, 16);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código
        /// </summary>
        public static string CodCmp
        {
           get {return "lpr_cod_cod";}
        }

        /// <summary>
        /// Código
        /// </summary>
        public string Cod
        {
            get {return ((string) InternalData["lpr_cod_cod"]).Trim();}
            set {
                if (value.Trim().Length > 4) value= value.Trim().Substring(0,4);
                InternalData["lpr_cod_cod"]= value.Trim();
            }
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public static string DesCmp
        {
           get {return "lpr_des_des";}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["lpr_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["lpr_des_des"]= value.Trim();
            }
        }

        /// <summary>
        /// Plan
        /// </summary>
        public static string CodplanCmp
        {
           get {return "lpr_cod_codplan";}
        }

        /// <summary>
        /// Plan
        /// </summary>
        public string Codplan
        {
            get {return (string) InternalData["lpr_cod_codplan"];}
            set {InternalData["lpr_cod_codplan"]= EListaDePrecios.FrmtCodplan(value);}
        }

        /// <summary>
        /// Marca
        /// </summary>
        public static string CodmarcaCmp
        {
           get {return "lpr_rcd_codmarca";}
        }

        /// <summary>
        /// Marca
        /// </summary>
        public string Codmarca
        {
            get {return (string) InternalData["lpr_rcd_codmarca"];}
            set {InternalData["lpr_rcd_codmarca"]= value;}
        }

        /// <summary>
        /// Precio 1 P
        /// </summary>
        public static string Precio1pCmp
        {
           get {return "lpr_imp_precio1p";}
        }

        /// <summary>
        /// Precio 1 P
        /// </summary>
        public decimal Precio1p
        {
            get {return (decimal) InternalData["lpr_imp_precio1p"];}
            set {InternalData["lpr_imp_precio1p"]= value;}
        }

        /// <summary>
        /// Precio 2 P
        /// </summary>
        public static string Precio2pCmp
        {
           get {return "lpr_imp_precio2p";}
        }

        /// <summary>
        /// Precio 2 P
        /// </summary>
        public decimal Precio2p
        {
            get {return (decimal) InternalData["lpr_imp_precio2p"];}
            set {InternalData["lpr_imp_precio2p"]= value;}
        }

        /// <summary>
        /// Precio 3 P
        /// </summary>
        public static string Precio3pCmp
        {
           get {return "lpr_imp_precio3p";}
        }

        /// <summary>
        /// Precio 3 P
        /// </summary>
        public decimal Precio3p
        {
            get {return (decimal) InternalData["lpr_imp_precio3p"];}
            set {InternalData["lpr_imp_precio3p"]= value;}
        }

        /// <summary>
        /// Precio 4 P
        /// </summary>
        public static string Precio4pCmp
        {
           get {return "lpr_imp_precio4p";}
        }

        /// <summary>
        /// Precio 4 P
        /// </summary>
        public decimal Precio4p
        {
            get {return (decimal) InternalData["lpr_imp_precio4p"];}
            set {InternalData["lpr_imp_precio4p"]= value;}
        }

        /// <summary>
        /// Precio 5 P
        /// </summary>
        public static string Precio5pCmp
        {
           get {return "lpr_imp_precio5p";}
        }

        /// <summary>
        /// Precio 5 P
        /// </summary>
        public decimal Precio5p
        {
            get {return (decimal) InternalData["lpr_imp_precio5p"];}
            set {InternalData["lpr_imp_precio5p"]= value;}
        }

        /// <summary>
        /// Precio 6 P
        /// </summary>
        public static string Precio6pCmp
        {
           get {return "lpr_imp_precio6p";}
        }

        /// <summary>
        /// Precio 6 P
        /// </summary>
        public decimal Precio6p
        {
            get {return (decimal) InternalData["lpr_imp_precio6p"];}
            set {InternalData["lpr_imp_precio6p"]= value;}
        }

        /// <summary>
        /// Precio 7 P
        /// </summary>
        public static string Precio7pCmp
        {
           get {return "lpr_imp_precio7p";}
        }

        /// <summary>
        /// Precio 7 P
        /// </summary>
        public decimal Precio7p
        {
            get {return (decimal) InternalData["lpr_imp_precio7p"];}
            set {InternalData["lpr_imp_precio7p"]= value;}
        }

        /// <summary>
        /// Precio 8 P
        /// </summary>
        public static string Precio8pCmp
        {
           get {return "lpr_imp_precio8p";}
        }

        /// <summary>
        /// Precio 8 P
        /// </summary>
        public decimal Precio8p
        {
            get {return (decimal) InternalData["lpr_imp_precio8p"];}
            set {InternalData["lpr_imp_precio8p"]= value;}
        }

        /// <summary>
        /// Precio 9 P
        /// </summary>
        public static string Precio9pCmp
        {
           get {return "lpr_imp_precio9p";}
        }

        /// <summary>
        /// Precio 9 P
        /// </summary>
        public decimal Precio9p
        {
            get {return (decimal) InternalData["lpr_imp_precio9p"];}
            set {InternalData["lpr_imp_precio9p"]= value;}
        }

        /// <summary>
        /// Precio 10 P
        /// </summary>
        public static string Precio10pCmp
        {
           get {return "lpr_imp_precio10p";}
        }

        /// <summary>
        /// Precio 10 P
        /// </summary>
        public decimal Precio10p
        {
            get {return (decimal) InternalData["lpr_imp_precio10p"];}
            set {InternalData["lpr_imp_precio10p"]= value;}
        }

        /// <summary>
        /// Marca
        /// </summary>
        public string Des_marca
        {
            get {return (string) InternalData["des_marca"];}
            set {InternalData["des_marca"]= value;}
        }

        /// <summary>
        /// Plan
        /// </summary>
        public string Des_plan
        {
            get {return (string) InternalData["des_plan"];}
            set {InternalData["des_plan"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EListaDePrecios] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EListaDePrecios] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EListaDePrecios", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_cod_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_cod_codplan", Codplan));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_rcd_codmarca", Codmarca));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_imp_precio1p", Precio1p));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_imp_precio2p", Precio2p));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_imp_precio3p", Precio3p));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_imp_precio4p", Precio4p));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_imp_precio5p", Precio5p));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_imp_precio6p", Precio6p));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_imp_precio7p", Precio7p));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_imp_precio8p", Precio8p));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_imp_precio9p", Precio9p));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lpr_imp_precio10p", Precio10p));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "des_marca", Des_marca));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "des_plan", Des_plan));

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

    #region Lista-Entidad: ListasDePrecios
    /// <summary>
    /// Clase que representa la Lista-Entidad: ListasDePrecios
    /// </summary>
    public sealed partial class LEListasDePrecios : ListaEntidades, IEnumerable<EListaDePrecios>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: ListasDePrecios
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEListasDePrecios(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEListasDePrecios(string p_strXMLData) :
            base(EListaDePrecios.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EListaDePrecios(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEListasDePrecios(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: ListasDePrecios
        /// </summary>
        /// <returns>Lista-Entidad vacia: ListasDePrecios</returns>
        public static LEListasDePrecios NewEmpty()
        {
            return new LEListasDePrecios(EListaDePrecios.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEListaDePrecios">Entidad a agregar</param>
        public void AddEntity(EListaDePrecios p_entEListaDePrecios)
        {
            base.AddEntity(p_entEListaDePrecios);
        }

        /// <summary>
        /// Remueve una entidad [ListaDePrecios] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "lpr_cod_cod = " + Ruts.Co(p_strCod);

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
        /// Verifca si una entidad [ListaDePrecios] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EListaDePrecios l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: ListasDePrecios
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EListaDePrecios> GetEnumerator() 
        {
            EListaDePrecios l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EListaDePrecios(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: ListasDePrecios
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EListaDePrecios l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: ListasDePrecios
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETListasDePrecios GetAsLET()
        {
            // Llenamos la lista tipada
            LETListasDePrecios l_lentRet= new LETListasDePrecios();

            foreach (EListaDePrecios l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<ListasDePrecios>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EListaDePrecios> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EListaDePrecios>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [ListaDePrecios] por indice
        /// </summary>
        public new EListaDePrecios this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad ListaDePrecios con los datos de la fila
                return new EListaDePrecios(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [ListaDePrecios] por clave
        /// </summary>
        public EListaDePrecios this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "lpr_cod_cod = " + Ruts.Co(p_strCod);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad ListaDePrecios con los datos de la fila
                if (l_drData == null) return null;
                return new EListaDePrecios(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEListasDePrecios", null);

                foreach (EListaDePrecios l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: ListasDePrecios
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: ListasDePrecios
    /// </summary>
    public sealed partial class LETListasDePrecios : LET<EListaDePrecios>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: ListasDePrecios
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEListasDePrecios GetAsLE()
        {
            // Llenamos la lista
            LEListasDePrecios l_lentRet= LEListasDePrecios.NewEmpty();

            foreach (EListaDePrecios l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [ListaDePrecios] por clave
        /// </summary>
        public EListaDePrecios this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EListaDePrecios l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == p_strCod)
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Localidad
    /// <summary>
    /// Clase que representa la Entidad: Localidad
    /// </summary>
    public sealed partial class ELocalidad : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Localidades
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ELocalidad(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Localidad
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ELocalidad(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Localidad
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ELocalidad(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ELocalidad.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["loc_ecd_codpost"]= XMLRuts.ExtractXAttr(l_xndData, "loc_ecd_codpost");
            l_drTemp["loc_ede_nombre"]= XMLRuts.ExtractXAttr(l_xndData, "loc_ede_nombre");
            l_drTemp["loc_rcd_codzona"]= XMLRuts.ExtractXAttr(l_xndData, "loc_rcd_codzona");
            l_drTemp["loc_ede_partido"]= XMLRuts.ExtractXAttr(l_xndData, "loc_ede_partido");
            l_drTemp["loc_des_provincia"]= XMLRuts.ExtractXAttr(l_xndData, "loc_des_provincia");
            l_drTemp["loc_ede_nomgoogle"]= XMLRuts.ExtractXAttr(l_xndData, "loc_ede_nomgoogle");
            l_drTemp["loc_cd1_directa"]= XMLRuts.ExtractXAttr(l_xndData, "loc_cd1_directa");
            l_drTemp["loc_des_zona"]= XMLRuts.ExtractXAttr(l_xndData, "loc_des_zona");

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
        private ELocalidad(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Localidad
        /// </summary>
        /// <returns>Entidad vacia: Localidad</returns>
        public static ELocalidad NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ELocalidad.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["loc_ecd_codpost"]= "";
            l_drTemp["loc_ede_nombre"]= "";
            l_drTemp["loc_rcd_codzona"]= "";
            l_drTemp["loc_ede_partido"]= "";
            l_drTemp["loc_des_provincia"]= "";
            l_drTemp["loc_ede_nomgoogle"]= "";
            l_drTemp["loc_cd1_directa"]= "";
            l_drTemp["loc_des_zona"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ELocalidad l_entRet= new ELocalidad(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Localidad
        /// </summary>
        /// <param name="p_strCodpost">Código postal</param>
        /// <param name="p_strNombre">Nombre</param>
        /// <param name="p_strCodzona">Zona</param>
        /// <param name="p_strPartido">Partido</param>
        /// <param name="p_strProvincia">Provincia</param>
        /// <param name="p_strNomgoogle">Nombre en google</param>
        /// <param name="p_strDirecta">Busqueda Directa</param>
        /// <returns>Entidad: Localidad</returns>
        public static ELocalidad NewFilled(string p_strCodpost,
                                           string p_strNombre,
                                           string p_strCodzona,
                                           string p_strPartido,
                                           string p_strProvincia,
                                           string p_strNomgoogle,
                                           string p_strDirecta)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ELocalidad.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["loc_ecd_codpost"]= p_strCodpost;
            l_drTemp["loc_ede_nombre"]= p_strNombre;
            l_drTemp["loc_rcd_codzona"]= p_strCodzona;
            l_drTemp["loc_ede_partido"]= p_strPartido;
            l_drTemp["loc_des_provincia"]= p_strProvincia;
            l_drTemp["loc_ede_nomgoogle"]= p_strNomgoogle;
            l_drTemp["loc_cd1_directa"]= p_strDirecta;
            l_drTemp["loc_des_zona"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ELocalidad l_entRet= new ELocalidad(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Código postal
        /// </summary>
        public static string FrmtCodpost(string p_strCodpost)
        {
            if (p_strCodpost.Trim().Length > 8)
                p_strCodpost= p_strCodpost.Trim().Substring(0,8);

            return p_strCodpost.Trim().PadLeft(8).ToUpper();
        }

        /// <summary>
        /// Formatea una string: Zona
        /// </summary>
        public static string FrmtCodzona(string p_strCodzona)
        {
            if (p_strCodzona.Trim().Length > 2)
                p_strCodzona= p_strCodzona.Trim().Substring(0,2);

            return p_strCodzona.Trim().PadLeft(2).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[12];

                l_dcStruct[0]= new DataColumn("loc_ecd_codpost", typeof(string));
                l_dcStruct[1]= new DataColumn("loc_ede_nombre", typeof(string));
                l_dcStruct[2]= new DataColumn("loc_rcd_codzona", typeof(string));
                l_dcStruct[3]= new DataColumn("loc_des_zona", typeof(string));
                l_dcStruct[4]= new DataColumn("loc_ede_partido", typeof(string));
                l_dcStruct[5]= new DataColumn("loc_des_provincia", typeof(string));
                l_dcStruct[6]= new DataColumn("loc_ede_nomgoogle", typeof(string));
                l_dcStruct[7]= new DataColumn("loc_cd1_directa", typeof(string));
                ELocalidad.FillFixedFields(ref l_dcStruct, 8);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código postal
        /// </summary>
        public static string CodpostCmp
        {
           get {return "loc_ecd_codpost";}
        }

        /// <summary>
        /// Código postal
        /// </summary>
        public string Codpost
        {
            get {return (string) InternalData["loc_ecd_codpost"];}
            set {InternalData["loc_ecd_codpost"]= ELocalidad.FrmtCodpost(value);}
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public static string NombreCmp
        {
           get {return "loc_ede_nombre";}
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public string Nombre
        {
            get {return ((string) InternalData["loc_ede_nombre"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["loc_ede_nombre"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Zona
        /// </summary>
        public static string CodzonaCmp
        {
           get {return "loc_rcd_codzona";}
        }

        /// <summary>
        /// Zona
        /// </summary>
        public string Codzona
        {
            get {return (string) InternalData["loc_rcd_codzona"];}
            set {InternalData["loc_rcd_codzona"]= ELocalidad.FrmtCodzona(value);}
        }

        /// <summary>
        /// Partido
        /// </summary>
        public static string PartidoCmp
        {
           get {return "loc_ede_partido";}
        }

        /// <summary>
        /// Partido
        /// </summary>
        public string Partido
        {
            get {return ((string) InternalData["loc_ede_partido"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["loc_ede_partido"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Provincia
        /// </summary>
        public static string ProvinciaCmp
        {
           get {return "loc_des_provincia";}
        }

        /// <summary>
        /// Provincia
        /// </summary>
        public string Provincia
        {
            get {return ((string) InternalData["loc_des_provincia"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["loc_des_provincia"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Nombre en google
        /// </summary>
        public static string NomgoogleCmp
        {
           get {return "loc_ede_nomgoogle";}
        }

        /// <summary>
        /// Nombre en google
        /// </summary>
        public string Nomgoogle
        {
            get {return ((string) InternalData["loc_ede_nomgoogle"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["loc_ede_nomgoogle"]= value.Trim();
            }
        }

        /// <summary>
        /// Busqueda Directa
        /// </summary>
        public static string DirectaCmp
        {
           get {return "loc_cd1_directa";}
        }

        /// <summary>
        /// Busqueda Directa
        /// </summary>
        public string Directa
        {
            get {return (string) InternalData["loc_cd1_directa"];}
            set {InternalData["loc_cd1_directa"]= value;}
        }

        /// <summary>
        /// Zona
        /// </summary>
        public string Loc_des_zona
        {
            get {return (string) InternalData["loc_des_zona"];}
            set {InternalData["loc_des_zona"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ELocalidad] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ELocalidad] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ELocalidad", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "loc_ecd_codpost", Codpost));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "loc_ede_nombre", Nombre));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "loc_rcd_codzona", Codzona));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "loc_ede_partido", Partido));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "loc_des_provincia", Provincia));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "loc_ede_nomgoogle", Nomgoogle));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "loc_cd1_directa", Directa));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "loc_des_zona", Loc_des_zona));

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

    #region Lista-Entidad: Localidades
    /// <summary>
    /// Clase que representa la Lista-Entidad: Localidades
    /// </summary>
    public sealed partial class LELocalidades : ListaEntidades, IEnumerable<ELocalidad>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Localidades
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LELocalidades(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LELocalidades(string p_strXMLData) :
            base(ELocalidad.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ELocalidad(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LELocalidades(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Localidades
        /// </summary>
        /// <returns>Lista-Entidad vacia: Localidades</returns>
        public static LELocalidades NewEmpty()
        {
            return new LELocalidades(ELocalidad.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entELocalidad">Entidad a agregar</param>
        public void AddEntity(ELocalidad p_entELocalidad)
        {
            base.AddEntity(p_entELocalidad);
        }

        /// <summary>
        /// Remueve una entidad [Localidad] por clave
        /// </summary>
        public int RemoveEntity(string p_strCodpost)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "loc_ecd_codpost = " + Ruts.Co(ELocalidad.FrmtCodpost(p_strCodpost));

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
        /// Verifca si una entidad [Localidad] esta en la lista
        /// </summary>
        public bool Contains(string p_strCodpost)
        {
            using (ELocalidad l_entTemp= this[p_strCodpost])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Localidades
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ELocalidad> GetEnumerator() 
        {
            ELocalidad l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ELocalidad(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Localidades
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ELocalidad l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Localidades
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETLocalidades GetAsLET()
        {
            // Llenamos la lista tipada
            LETLocalidades l_lentRet= new LETLocalidades();

            foreach (ELocalidad l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Localidades>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ELocalidad> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ELocalidad>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Localidad] por indice
        /// </summary>
        public new ELocalidad this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Localidad con los datos de la fila
                return new ELocalidad(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Localidad] por clave
        /// </summary>
        public ELocalidad this[string p_strCodpost]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "loc_ecd_codpost = " + Ruts.Co(ELocalidad.FrmtCodpost(p_strCodpost));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Localidad con los datos de la fila
                if (l_drData == null) return null;
                return new ELocalidad(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LELocalidades", null);

                foreach (ELocalidad l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Localidades
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Localidades
    /// </summary>
    public sealed partial class LETLocalidades : LET<ELocalidad>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Localidades
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LELocalidades GetAsLE()
        {
            // Llenamos la lista
            LELocalidades l_lentRet= LELocalidades.NewEmpty();

            foreach (ELocalidad l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Localidad] por clave
        /// </summary>
        public ELocalidad this[string p_strCodpost]
        {
            get {
                // Buscamos la entidad
                foreach (ELocalidad l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Codpost == ELocalidad.FrmtCodpost(p_strCodpost))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: LogCliente
    /// <summary>
    /// Clase que representa la Entidad: LogCliente
    /// </summary>
    public sealed partial class ELogCliente : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: LogClientes
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ELogCliente(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: LogCliente
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ELogCliente(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: LogCliente
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ELogCliente(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ELogCliente.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["lgc_nro_nro"]= XMLRuts.ExtractXAttr(l_xndData, "lgc_nro_nro", 0);
            l_drTemp["lgc_nro_nrocliente"]= XMLRuts.ExtractXAttr(l_xndData, "lgc_nro_nrocliente", 0);
            l_drTemp["lgc_nro_nroavalon"]= XMLRuts.ExtractXAttr(l_xndData, "lgc_nro_nroavalon", 0);
            l_drTemp["lgc_ede_rsocial"]= XMLRuts.ExtractXAttr(l_xndData, "lgc_ede_rsocial");
            l_drTemp["lgc_des_nomfantasia"]= XMLRuts.ExtractXAttr(l_xndData, "lgc_des_nomfantasia");
            l_drTemp["lgc_des_accion"]= XMLRuts.ExtractXAttr(l_xndData, "lgc_des_accion");
            l_drTemp["lgc_nom_usuario"]= XMLRuts.ExtractXAttr(l_xndData, "lgc_nom_usuario");
            l_drTemp["lgc_fyh_fecha"]= XMLRuts.ExtractXAttr(l_xndData, "lgc_fyh_fecha", true);

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
        private ELogCliente(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: LogCliente
        /// </summary>
        /// <returns>Entidad vacia: LogCliente</returns>
        public static ELogCliente NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ELogCliente.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["lgc_nro_nro"]= 0;
            l_drTemp["lgc_nro_nrocliente"]= 0;
            l_drTemp["lgc_nro_nroavalon"]= 0;
            l_drTemp["lgc_ede_rsocial"]= "";
            l_drTemp["lgc_des_nomfantasia"]= "";
            l_drTemp["lgc_des_accion"]= "";
            l_drTemp["lgc_nom_usuario"]= "";
            l_drTemp["lgc_fyh_fecha"]= DateTimeRuts.Empty;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ELogCliente l_entRet= new ELogCliente(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: LogCliente
        /// </summary>
        /// <param name="p_iNro">Numero</param>
        /// <param name="p_iNrocliente">Número Cliente</param>
        /// <param name="p_iNroavalon">Número Avalon</param>
        /// <param name="p_strRsocial">Razon Social</param>
        /// <param name="p_strNomfantasia">Nombre Fantasia</param>
        /// <param name="p_strAccion">Acción</param>
        /// <param name="p_strUsuario">Usuario</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <returns>Entidad: LogCliente</returns>
        public static ELogCliente NewFilled(int p_iNro,
                                            int p_iNrocliente,
                                            int p_iNroavalon,
                                            string p_strRsocial,
                                            string p_strNomfantasia,
                                            string p_strAccion,
                                            string p_strUsuario,
                                            DateTime p_dtFecha)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ELogCliente.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["lgc_nro_nro"]= p_iNro;
            l_drTemp["lgc_nro_nrocliente"]= p_iNrocliente;
            l_drTemp["lgc_nro_nroavalon"]= p_iNroavalon;
            l_drTemp["lgc_ede_rsocial"]= p_strRsocial;
            l_drTemp["lgc_des_nomfantasia"]= p_strNomfantasia;
            l_drTemp["lgc_des_accion"]= p_strAccion;
            l_drTemp["lgc_nom_usuario"]= p_strUsuario;
            l_drTemp["lgc_fyh_fecha"]= p_dtFecha;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ELogCliente l_entRet= new ELogCliente(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores
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
                DataColumn[] l_dcStruct= new DataColumn[12];

                l_dcStruct[0]= new DataColumn("lgc_nro_nro", typeof(int));
                l_dcStruct[1]= new DataColumn("lgc_nro_nrocliente", typeof(int));
                l_dcStruct[2]= new DataColumn("lgc_nro_nroavalon", typeof(int));
                l_dcStruct[3]= new DataColumn("lgc_ede_rsocial", typeof(string));
                l_dcStruct[4]= new DataColumn("lgc_des_nomfantasia", typeof(string));
                l_dcStruct[5]= new DataColumn("lgc_des_accion", typeof(string));
                l_dcStruct[6]= new DataColumn("lgc_nom_usuario", typeof(string));
                l_dcStruct[7]= new DataColumn("lgc_fyh_fecha", typeof(DateTime));
                ELogCliente.FillFixedFields(ref l_dcStruct, 8);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Numero
        /// </summary>
        public static string NroCmp
        {
           get {return "lgc_nro_nro";}
        }

        /// <summary>
        /// Numero
        /// </summary>
        public int Nro
        {
            get {return (int) InternalData["lgc_nro_nro"];}
            set {InternalData["lgc_nro_nro"]= value;}
        }

        /// <summary>
        /// Número Cliente
        /// </summary>
        public static string NroclienteCmp
        {
           get {return "lgc_nro_nrocliente";}
        }

        /// <summary>
        /// Número Cliente
        /// </summary>
        public int Nrocliente
        {
            get {return (int) InternalData["lgc_nro_nrocliente"];}
            set {InternalData["lgc_nro_nrocliente"]= value;}
        }

        /// <summary>
        /// Número Avalon
        /// </summary>
        public static string NroavalonCmp
        {
           get {return "lgc_nro_nroavalon";}
        }

        /// <summary>
        /// Número Avalon
        /// </summary>
        public int Nroavalon
        {
            get {return (int) InternalData["lgc_nro_nroavalon"];}
            set {InternalData["lgc_nro_nroavalon"]= value;}
        }

        /// <summary>
        /// Razon Social
        /// </summary>
        public static string RsocialCmp
        {
           get {return "lgc_ede_rsocial";}
        }

        /// <summary>
        /// Razon Social
        /// </summary>
        public string Rsocial
        {
            get {return ((string) InternalData["lgc_ede_rsocial"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["lgc_ede_rsocial"]= value.Trim();
            }
        }

        /// <summary>
        /// Nombre Fantasia
        /// </summary>
        public static string NomfantasiaCmp
        {
           get {return "lgc_des_nomfantasia";}
        }

        /// <summary>
        /// Nombre Fantasia
        /// </summary>
        public string Nomfantasia
        {
            get {return ((string) InternalData["lgc_des_nomfantasia"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["lgc_des_nomfantasia"]= value.Trim();
            }
        }

        /// <summary>
        /// Acción
        /// </summary>
        public static string AccionCmp
        {
           get {return "lgc_des_accion";}
        }

        /// <summary>
        /// Acción
        /// </summary>
        public string Accion
        {
            get {return ((string) InternalData["lgc_des_accion"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["lgc_des_accion"]= value.Trim();
            }
        }

        /// <summary>
        /// Usuario
        /// </summary>
        public static string UsuarioCmp
        {
           get {return "lgc_nom_usuario";}
        }

        /// <summary>
        /// Usuario
        /// </summary>
        public string Usuario
        {
            get {return ((string) InternalData["lgc_nom_usuario"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["lgc_nom_usuario"]= value.Trim();
            }
        }

        /// <summary>
        /// Fecha
        /// </summary>
        public static string FechaCmp
        {
           get {return "lgc_fyh_fecha";}
        }

        /// <summary>
        /// Fecha
        /// </summary>
        public DateTime Fecha
        {
            get {return (DateTime) InternalData["lgc_fyh_fecha"];}
            set {InternalData["lgc_fyh_fecha"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ELogCliente] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ELogCliente] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ELogCliente", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lgc_nro_nro", Nro));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lgc_nro_nrocliente", Nrocliente));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lgc_nro_nroavalon", Nroavalon));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lgc_ede_rsocial", Rsocial));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lgc_des_nomfantasia", Nomfantasia));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lgc_des_accion", Accion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lgc_nom_usuario", Usuario));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "lgc_fyh_fecha", Fecha));

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

    #region Lista-Entidad: LogClientes
    /// <summary>
    /// Clase que representa la Lista-Entidad: LogClientes
    /// </summary>
    public sealed partial class LELogClientes : ListaEntidades, IEnumerable<ELogCliente>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: LogClientes
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LELogClientes(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LELogClientes(string p_strXMLData) :
            base(ELogCliente.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ELogCliente(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LELogClientes(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: LogClientes
        /// </summary>
        /// <returns>Lista-Entidad vacia: LogClientes</returns>
        public static LELogClientes NewEmpty()
        {
            return new LELogClientes(ELogCliente.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entELogCliente">Entidad a agregar</param>
        public void AddEntity(ELogCliente p_entELogCliente)
        {
            base.AddEntity(p_entELogCliente);
        }

        /// <summary>
        /// Remueve una entidad [LogCliente] por clave
        /// </summary>
        public int RemoveEntity(int p_iNro)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "lgc_nro_nro = " + Ruts.Nu(p_iNro);

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
        /// Verifca si una entidad [LogCliente] esta en la lista
        /// </summary>
        public bool Contains(int p_iNro)
        {
            using (ELogCliente l_entTemp= this[p_iNro])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: LogClientes
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ELogCliente> GetEnumerator() 
        {
            ELogCliente l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ELogCliente(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: LogClientes
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ELogCliente l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: LogClientes
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETLogClientes GetAsLET()
        {
            // Llenamos la lista tipada
            LETLogClientes l_lentRet= new LETLogClientes();

            foreach (ELogCliente l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<LogClientes>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ELogCliente> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ELogCliente>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [LogCliente] por indice
        /// </summary>
        public new ELogCliente this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad LogCliente con los datos de la fila
                return new ELogCliente(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [LogCliente] por clave
        /// </summary>
        public ELogCliente this[int p_iNro]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "lgc_nro_nro = " + Ruts.Nu(p_iNro);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad LogCliente con los datos de la fila
                if (l_drData == null) return null;
                return new ELogCliente(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LELogClientes", null);

                foreach (ELogCliente l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: LogClientes
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: LogClientes
    /// </summary>
    public sealed partial class LETLogClientes : LET<ELogCliente>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: LogClientes
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LELogClientes GetAsLE()
        {
            // Llenamos la lista
            LELogClientes l_lentRet= LELogClientes.NewEmpty();

            foreach (ELogCliente l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------


        /// <summary>
        /// Indexer para acceder a cada entidad [LogCliente] por indice
        /// </summary>
        public ELogCliente this[long p_lIndice]
        {
            get {return base[(int) p_lIndice];}
        }
        /// <summary>
        /// Indexer para acceder a cada entidad [LogCliente] por clave
        /// </summary>
        public new ELogCliente this[int p_iNro]
        {
            get {
                // Buscamos la entidad
                foreach (ELogCliente l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Nro == p_iNro)
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Marca
    /// <summary>
    /// Clase que representa la Entidad: Marca
    /// </summary>
    public sealed partial class EMarca : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Marcas
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EMarca(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Marca
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EMarca(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Marca
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EMarca(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EMarca.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mrc_rcd_cod"]= XMLRuts.ExtractXAttr(l_xndData, "mrc_rcd_cod");
            l_drTemp["mrc_ede_des"]= XMLRuts.ExtractXAttr(l_xndData, "mrc_ede_des");
            l_drTemp["mrc_ecd_codlocalidad"]= XMLRuts.ExtractXAttr(l_xndData, "mrc_ecd_codlocalidad");
            l_drTemp["des_localidad"]= XMLRuts.ExtractXAttr(l_xndData, "des_localidad");

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
        private EMarca(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Marca
        /// </summary>
        /// <returns>Entidad vacia: Marca</returns>
        public static EMarca NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMarca.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mrc_rcd_cod"]= "";
            l_drTemp["mrc_ede_des"]= "";
            l_drTemp["mrc_ecd_codlocalidad"]= "";
            l_drTemp["des_localidad"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMarca l_entRet= new EMarca(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Marca
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_strDes">Descripcion</param>
        /// <param name="p_strCodlocalidad">Localidad</param>
        /// <returns>Entidad: Marca</returns>
        public static EMarca NewFilled(string p_strCod,
                                       string p_strDes,
                                       string p_strCodlocalidad)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMarca.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mrc_rcd_cod"]= p_strCod;
            l_drTemp["mrc_ede_des"]= p_strDes;
            l_drTemp["mrc_ecd_codlocalidad"]= p_strCodlocalidad;
            l_drTemp["des_localidad"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMarca l_entRet= new EMarca(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Localidad
        /// </summary>
        public static string FrmtCodlocalidad(string p_strCodlocalidad)
        {
            if (p_strCodlocalidad.Trim().Length > 8)
                p_strCodlocalidad= p_strCodlocalidad.Trim().Substring(0,8);

            return p_strCodlocalidad.Trim().PadLeft(8).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[8];

                l_dcStruct[0]= new DataColumn("mrc_rcd_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("mrc_ede_des", typeof(string));
                l_dcStruct[2]= new DataColumn("mrc_ecd_codlocalidad", typeof(string));
                l_dcStruct[3]= new DataColumn("des_localidad", typeof(string));
                EMarca.FillFixedFields(ref l_dcStruct, 4);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public static string CodCmp
        {
           get {return "mrc_rcd_cod";}
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public string Cod
        {
            get {return ((string) InternalData["mrc_rcd_cod"]).Trim();}
            set {
                if (value.Trim().Length > 2) value= value.Trim().Substring(0,2);
                InternalData["mrc_rcd_cod"]= value.Trim();
            }
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public static string DesCmp
        {
           get {return "mrc_ede_des";}
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["mrc_ede_des"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["mrc_ede_des"]= value.Trim();
            }
        }

        /// <summary>
        /// Localidad
        /// </summary>
        public static string CodlocalidadCmp
        {
           get {return "mrc_ecd_codlocalidad";}
        }

        /// <summary>
        /// Localidad
        /// </summary>
        public string Codlocalidad
        {
            get {return (string) InternalData["mrc_ecd_codlocalidad"];}
            set {InternalData["mrc_ecd_codlocalidad"]= EMarca.FrmtCodlocalidad(value);}
        }

        /// <summary>
        /// Localidad
        /// </summary>
        public string Des_localidad
        {
            get {return (string) InternalData["des_localidad"];}
            set {InternalData["des_localidad"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EMarca] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EMarca] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EMarca", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mrc_rcd_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mrc_ede_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mrc_ecd_codlocalidad", Codlocalidad));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "des_localidad", Des_localidad));

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

    #region Lista-Entidad: Marcas
    /// <summary>
    /// Clase que representa la Lista-Entidad: Marcas
    /// </summary>
    public sealed partial class LEMarcas : ListaEntidades, IEnumerable<EMarca>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Marcas
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMarcas(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMarcas(string p_strXMLData) :
            base(EMarca.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EMarca(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEMarcas(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Marcas
        /// </summary>
        /// <returns>Lista-Entidad vacia: Marcas</returns>
        public static LEMarcas NewEmpty()
        {
            return new LEMarcas(EMarca.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEMarca">Entidad a agregar</param>
        public void AddEntity(EMarca p_entEMarca)
        {
            base.AddEntity(p_entEMarca);
        }

        /// <summary>
        /// Remueve una entidad [Marca] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "mrc_rcd_cod = " + Ruts.Co(p_strCod);

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
        /// Verifca si una entidad [Marca] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EMarca l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Marcas
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EMarca> GetEnumerator() 
        {
            EMarca l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EMarca(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Marcas
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EMarca l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Marcas
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETMarcas GetAsLET()
        {
            // Llenamos la lista tipada
            LETMarcas l_lentRet= new LETMarcas();

            foreach (EMarca l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Marcas>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EMarca> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EMarca>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Marca] por indice
        /// </summary>
        public new EMarca this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Marca con los datos de la fila
                return new EMarca(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Marca] por clave
        /// </summary>
        public EMarca this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "mrc_rcd_cod = " + Ruts.Co(p_strCod);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Marca con los datos de la fila
                if (l_drData == null) return null;
                return new EMarca(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEMarcas", null);

                foreach (EMarca l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Marcas
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Marcas
    /// </summary>
    public sealed partial class LETMarcas : LET<EMarca>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Marcas
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEMarcas GetAsLE()
        {
            // Llenamos la lista
            LEMarcas l_lentRet= LEMarcas.NewEmpty();

            foreach (EMarca l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Marca] por clave
        /// </summary>
        public EMarca this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EMarca l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == p_strCod)
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: MotivosLlamada
    /// <summary>
    /// Clase que representa la Entidad: MotivosLlamada
    /// </summary>
    public sealed partial class EMotivosLlamada : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: MotivosLlamada
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EMotivosLlamada(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: MotivosLlamada
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EMotivosLlamada(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: MotivosLlamada
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EMotivosLlamada(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EMotivosLlamada.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mot_cod_cod"]= XMLRuts.ExtractXAttr(l_xndData, "mot_cod_cod");
            l_drTemp["mot_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "mot_des_des");
            l_drTemp["mot_rcd_codcategoria"]= XMLRuts.ExtractXAttr(l_xndData, "mot_rcd_codcategoria");
            l_drTemp["mot_cd1_esreclamo"]= XMLRuts.ExtractXAttr(l_xndData, "mot_cd1_esreclamo");
            l_drTemp["mot_des_categ"]= XMLRuts.ExtractXAttr(l_xndData, "mot_des_categ");

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
        private EMotivosLlamada(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: MotivosLlamada
        /// </summary>
        /// <returns>Entidad vacia: MotivosLlamada</returns>
        public static EMotivosLlamada NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMotivosLlamada.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mot_cod_cod"]= "";
            l_drTemp["mot_des_des"]= "";
            l_drTemp["mot_rcd_codcategoria"]= "";
            l_drTemp["mot_cd1_esreclamo"]= "";
            l_drTemp["mot_des_categ"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMotivosLlamada l_entRet= new EMotivosLlamada(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: MotivosLlamada
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strDes">Motivo</param>
        /// <param name="p_strCodcategoria">Categoria</param>
        /// <param name="p_strEsreclamo">Reclamo</param>
        /// <returns>Entidad: MotivosLlamada</returns>
        public static EMotivosLlamada NewFilled(string p_strCod,
                                                string p_strDes,
                                                string p_strCodcategoria,
                                                string p_strEsreclamo)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMotivosLlamada.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mot_cod_cod"]= p_strCod;
            l_drTemp["mot_des_des"]= p_strDes;
            l_drTemp["mot_rcd_codcategoria"]= p_strCodcategoria;
            l_drTemp["mot_cd1_esreclamo"]= p_strEsreclamo;
            l_drTemp["mot_des_categ"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMotivosLlamada l_entRet= new EMotivosLlamada(l_dtTemp);
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
        /// Formatea una string: Categoria
        /// </summary>
        public static string FrmtCodcategoria(string p_strCodcategoria)
        {
            if (p_strCodcategoria.Trim().Length > 2)
                p_strCodcategoria= p_strCodcategoria.Trim().Substring(0,2);

            return p_strCodcategoria.Trim().PadLeft(2).ToUpper();
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

                l_dcStruct[0]= new DataColumn("mot_cod_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("mot_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("mot_des_categ", typeof(string));
                l_dcStruct[3]= new DataColumn("mot_rcd_codcategoria", typeof(string));
                l_dcStruct[4]= new DataColumn("mot_cd1_esreclamo", typeof(string));
                EMotivosLlamada.FillFixedFields(ref l_dcStruct, 5);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código
        /// </summary>
        public static string CodCmp
        {
           get {return "mot_cod_cod";}
        }

        /// <summary>
        /// Código
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["mot_cod_cod"];}
            set {InternalData["mot_cod_cod"]= EMotivosLlamada.FrmtCod(value);}
        }

        /// <summary>
        /// Motivo
        /// </summary>
        public static string DesCmp
        {
           get {return "mot_des_des";}
        }

        /// <summary>
        /// Motivo
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["mot_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["mot_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Categoria
        /// </summary>
        public static string CodcategoriaCmp
        {
           get {return "mot_rcd_codcategoria";}
        }

        /// <summary>
        /// Categoria
        /// </summary>
        public string Codcategoria
        {
            get {return (string) InternalData["mot_rcd_codcategoria"];}
            set {InternalData["mot_rcd_codcategoria"]= EMotivosLlamada.FrmtCodcategoria(value);}
        }

        /// <summary>
        /// Reclamo
        /// </summary>
        public static string EsreclamoCmp
        {
           get {return "mot_cd1_esreclamo";}
        }

        /// <summary>
        /// Reclamo
        /// </summary>
        public string Esreclamo
        {
            get {return (string) InternalData["mot_cd1_esreclamo"];}
            set {InternalData["mot_cd1_esreclamo"]= value;}
        }

        /// <summary>
        /// Categoria
        /// </summary>
        public string Mot_des_categ
        {
            get {return (string) InternalData["mot_des_categ"];}
            set {InternalData["mot_des_categ"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EMotivosLlamada] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EMotivosLlamada] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EMotivosLlamada", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mot_cod_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mot_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mot_rcd_codcategoria", Codcategoria));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mot_cd1_esreclamo", Esreclamo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mot_des_categ", Mot_des_categ));

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

    #region Lista-Entidad: MotivosLlamadas
    /// <summary>
    /// Clase que representa la Lista-Entidad: MotivosLlamadas
    /// </summary>
    public sealed partial class LEMotivosLlamadas : ListaEntidades, IEnumerable<EMotivosLlamada>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: MotivosLlamada
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMotivosLlamadas(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMotivosLlamadas(string p_strXMLData) :
            base(EMotivosLlamada.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EMotivosLlamada(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEMotivosLlamadas(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: MotivosLlamadas
        /// </summary>
        /// <returns>Lista-Entidad vacia: MotivosLlamada</returns>
        public static LEMotivosLlamadas NewEmpty()
        {
            return new LEMotivosLlamadas(EMotivosLlamada.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEMotivosLlamada">Entidad a agregar</param>
        public void AddEntity(EMotivosLlamada p_entEMotivosLlamada)
        {
            base.AddEntity(p_entEMotivosLlamada);
        }

        /// <summary>
        /// Remueve una entidad [MotivosLlamada] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "mot_cod_cod = " + Ruts.Co(EMotivosLlamada.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [MotivosLlamada] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EMotivosLlamada l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: MotivosLlamadas
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EMotivosLlamada> GetEnumerator() 
        {
            EMotivosLlamada l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EMotivosLlamada(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: MotivosLlamadas
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EMotivosLlamada l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: MotivosLlamadas
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETMotivosLlamadas GetAsLET()
        {
            // Llenamos la lista tipada
            LETMotivosLlamadas l_lentRet= new LETMotivosLlamadas();

            foreach (EMotivosLlamada l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<MotivosLlamadas>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EMotivosLlamada> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EMotivosLlamada>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [MotivosLlamada] por indice
        /// </summary>
        public new EMotivosLlamada this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad MotivosLlamada con los datos de la fila
                return new EMotivosLlamada(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [MotivosLlamada] por clave
        /// </summary>
        public EMotivosLlamada this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "mot_cod_cod = " + Ruts.Co(EMotivosLlamada.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad MotivosLlamada con los datos de la fila
                if (l_drData == null) return null;
                return new EMotivosLlamada(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEMotivosLlamadas", null);

                foreach (EMotivosLlamada l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: MotivosLlamadas
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: MotivosLlamadas
    /// </summary>
    public sealed partial class LETMotivosLlamadas : LET<EMotivosLlamada>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: MotivosLlamadas
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEMotivosLlamadas GetAsLE()
        {
            // Llenamos la lista
            LEMotivosLlamadas l_lentRet= LEMotivosLlamadas.NewEmpty();

            foreach (EMotivosLlamada l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [MotivosLlamada] por clave
        /// </summary>
        public EMotivosLlamada this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EMotivosLlamada l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == EMotivosLlamada.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Parentesco
    /// <summary>
    /// Clase que representa la Entidad: Parentesco
    /// </summary>
    public sealed partial class EParentesco : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Parentescos
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EParentesco(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Parentesco
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EParentesco(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Parentesco
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EParentesco(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EParentesco.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["prt_rcd_cod"]= XMLRuts.ExtractXAttr(l_xndData, "prt_rcd_cod");
            l_drTemp["prt_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "prt_des_des");

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
        private EParentesco(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Parentesco
        /// </summary>
        /// <returns>Entidad vacia: Parentesco</returns>
        public static EParentesco NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EParentesco.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["prt_rcd_cod"]= "";
            l_drTemp["prt_des_des"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EParentesco l_entRet= new EParentesco(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Parentesco
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_strDes">Descripcion</param>
        /// <returns>Entidad: Parentesco</returns>
        public static EParentesco NewFilled(string p_strCod,
                                            string p_strDes)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EParentesco.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["prt_rcd_cod"]= p_strCod;
            l_drTemp["prt_des_des"]= p_strDes;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EParentesco l_entRet= new EParentesco(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores
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
                DataColumn[] l_dcStruct= new DataColumn[6];

                l_dcStruct[0]= new DataColumn("prt_rcd_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("prt_des_des", typeof(string));
                EParentesco.FillFixedFields(ref l_dcStruct, 2);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public static string CodCmp
        {
           get {return "prt_rcd_cod";}
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public string Cod
        {
            get {return ((string) InternalData["prt_rcd_cod"]).Trim();}
            set {
                if (value.Trim().Length > 2) value= value.Trim().Substring(0,2);
                InternalData["prt_rcd_cod"]= value.Trim();
            }
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public static string DesCmp
        {
           get {return "prt_des_des";}
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["prt_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["prt_des_des"]= value.Trim();
            }
        }

        /// <summary>
        /// Devuelve la entidad [EParentesco] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EParentesco] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EParentesco", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "prt_rcd_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "prt_des_des", Des));

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

    #region Lista-Entidad: Parentescos
    /// <summary>
    /// Clase que representa la Lista-Entidad: Parentescos
    /// </summary>
    public sealed partial class LEParentescos : ListaEntidades, IEnumerable<EParentesco>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Parentescos
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEParentescos(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEParentescos(string p_strXMLData) :
            base(EParentesco.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EParentesco(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEParentescos(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Parentescos
        /// </summary>
        /// <returns>Lista-Entidad vacia: Parentescos</returns>
        public static LEParentescos NewEmpty()
        {
            return new LEParentescos(EParentesco.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEParentesco">Entidad a agregar</param>
        public void AddEntity(EParentesco p_entEParentesco)
        {
            base.AddEntity(p_entEParentesco);
        }

        /// <summary>
        /// Remueve una entidad [Parentesco] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "prt_rcd_cod = " + Ruts.Co(p_strCod);

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
        /// Verifca si una entidad [Parentesco] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EParentesco l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Parentescos
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EParentesco> GetEnumerator() 
        {
            EParentesco l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EParentesco(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Parentescos
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EParentesco l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Parentescos
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETParentescos GetAsLET()
        {
            // Llenamos la lista tipada
            LETParentescos l_lentRet= new LETParentescos();

            foreach (EParentesco l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Parentescos>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EParentesco> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EParentesco>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Parentesco] por indice
        /// </summary>
        public new EParentesco this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Parentesco con los datos de la fila
                return new EParentesco(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Parentesco] por clave
        /// </summary>
        public EParentesco this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "prt_rcd_cod = " + Ruts.Co(p_strCod);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Parentesco con los datos de la fila
                if (l_drData == null) return null;
                return new EParentesco(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEParentescos", null);

                foreach (EParentesco l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Parentescos
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Parentescos
    /// </summary>
    public sealed partial class LETParentescos : LET<EParentesco>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Parentescos
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEParentescos GetAsLE()
        {
            // Llenamos la lista
            LEParentescos l_lentRet= LEParentescos.NewEmpty();

            foreach (EParentesco l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Parentesco] por clave
        /// </summary>
        public EParentesco this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EParentesco l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == p_strCod)
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: PrecioServicio
    /// <summary>
    /// Clase que representa la Entidad: PrecioServicio
    /// </summary>
    public sealed partial class EPrecioServicio : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: PreciosServicios
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EPrecioServicio(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: PrecioServicio
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EPrecioServicio(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: PrecioServicio
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EPrecioServicio(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EPrecioServicio.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["prs_cd1_color"]= XMLRuts.ExtractXAttr(l_xndData, "prs_cd1_color");
            l_drTemp["prs_fec_fecha"]= XMLRuts.ExtractXAttr(l_xndData, "prs_fec_fecha", true);
            l_drTemp["prs_imp_precio"]= XMLRuts.ExtractXAttr(l_xndData, "prs_imp_precio", (decimal) 0);
            l_drTemp["prs_imp_coseguro"]= XMLRuts.ExtractXAttr(l_xndData, "prs_imp_coseguro", (decimal) 0);

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
        private EPrecioServicio(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: PrecioServicio
        /// </summary>
        /// <returns>Entidad vacia: PrecioServicio</returns>
        public static EPrecioServicio NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EPrecioServicio.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["prs_cd1_color"]= "";
            l_drTemp["prs_fec_fecha"]= DateTimeRuts.Empty;
            l_drTemp["prs_imp_precio"]= 0;
            l_drTemp["prs_imp_coseguro"]= 0;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EPrecioServicio l_entRet= new EPrecioServicio(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: PrecioServicio
        /// </summary>
        /// <param name="p_strColor">Color</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_dcPrecio">Precio</param>
        /// <param name="p_dcCoseguro">coseguro</param>
        /// <returns>Entidad: PrecioServicio</returns>
        public static EPrecioServicio NewFilled(string p_strColor,
                                                DateTime p_dtFecha,
                                                decimal p_dcPrecio,
                                                decimal p_dcCoseguro)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EPrecioServicio.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["prs_cd1_color"]= p_strColor;
            l_drTemp["prs_fec_fecha"]= p_dtFecha;
            l_drTemp["prs_imp_precio"]= p_dcPrecio;
            l_drTemp["prs_imp_coseguro"]= p_dcCoseguro;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EPrecioServicio l_entRet= new EPrecioServicio(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores
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
                DataColumn[] l_dcStruct= new DataColumn[8];

                l_dcStruct[0]= new DataColumn("prs_cd1_color", typeof(string));
                l_dcStruct[1]= new DataColumn("prs_fec_fecha", typeof(DateTime));
                l_dcStruct[2]= new DataColumn("prs_imp_precio", typeof(decimal));
                l_dcStruct[3]= new DataColumn("prs_imp_coseguro", typeof(decimal));
                EPrecioServicio.FillFixedFields(ref l_dcStruct, 4);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Color
        /// </summary>
        public static string ColorCmp
        {
           get {return "prs_cd1_color";}
        }

        /// <summary>
        /// Color
        /// </summary>
        public string Color
        {
            get {return (string) InternalData["prs_cd1_color"];}
            set {InternalData["prs_cd1_color"]= value;}
        }

        /// <summary>
        /// Fecha
        /// </summary>
        public static string FechaCmp
        {
           get {return "prs_fec_fecha";}
        }

        /// <summary>
        /// Fecha
        /// </summary>
        public DateTime Fecha
        {
            get {return (DateTime) InternalData["prs_fec_fecha"];}
            set {InternalData["prs_fec_fecha"]= value;}
        }

        /// <summary>
        /// Precio
        /// </summary>
        public static string PrecioCmp
        {
           get {return "prs_imp_precio";}
        }

        /// <summary>
        /// Precio
        /// </summary>
        public decimal Precio
        {
            get {return (decimal) InternalData["prs_imp_precio"];}
            set {InternalData["prs_imp_precio"]= value;}
        }

        /// <summary>
        /// coseguro
        /// </summary>
        public static string CoseguroCmp
        {
           get {return "prs_imp_coseguro";}
        }

        /// <summary>
        /// coseguro
        /// </summary>
        public decimal Coseguro
        {
            get {return (decimal) InternalData["prs_imp_coseguro"];}
            set {InternalData["prs_imp_coseguro"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EPrecioServicio] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EPrecioServicio] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EPrecioServicio", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "prs_cd1_color", Color));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "prs_fec_fecha", Fecha));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "prs_imp_precio", Precio));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "prs_imp_coseguro", Coseguro));

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

    #region Lista-Entidad: PreciosServicios
    /// <summary>
    /// Clase que representa la Lista-Entidad: PreciosServicios
    /// </summary>
    public sealed partial class LEPreciosServicios : ListaEntidades, IEnumerable<EPrecioServicio>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: PreciosServicios
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEPreciosServicios(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEPreciosServicios(string p_strXMLData) :
            base(EPrecioServicio.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EPrecioServicio(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEPreciosServicios(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: PreciosServicios
        /// </summary>
        /// <returns>Lista-Entidad vacia: PreciosServicios</returns>
        public static LEPreciosServicios NewEmpty()
        {
            return new LEPreciosServicios(EPrecioServicio.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEPrecioServicio">Entidad a agregar</param>
        public void AddEntity(EPrecioServicio p_entEPrecioServicio)
        {
            base.AddEntity(p_entEPrecioServicio);
        }

        /// <summary>
        /// Remueve una entidad [PrecioServicio] por clave
        /// </summary>
        public int RemoveEntity(string p_strColor,
                                DateTime p_dtFecha)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "prs_cd1_color = " + Ruts.Co(p_strColor) + " and " + 
                "convert(prs_fec_fecha,'System.String') = '" + p_dtFecha + "'";

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
        /// Verifca si una entidad [PrecioServicio] esta en la lista
        /// </summary>
        public bool Contains(string p_strColor,
                             DateTime p_dtFecha)
        {
            using (EPrecioServicio l_entTemp= this[p_strColor,
                                                   p_dtFecha])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: PreciosServicios
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EPrecioServicio> GetEnumerator() 
        {
            EPrecioServicio l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EPrecioServicio(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: PreciosServicios
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EPrecioServicio l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: PreciosServicios
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETPreciosServicios GetAsLET()
        {
            // Llenamos la lista tipada
            LETPreciosServicios l_lentRet= new LETPreciosServicios();

            foreach (EPrecioServicio l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<PreciosServicios>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EPrecioServicio> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EPrecioServicio>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [PrecioServicio] por indice
        /// </summary>
        public new EPrecioServicio this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad PrecioServicio con los datos de la fila
                return new EPrecioServicio(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [PrecioServicio] por clave
        /// </summary>
        public EPrecioServicio this[string p_strColor,
                                    DateTime p_dtFecha]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "prs_cd1_color = " + Ruts.Co(p_strColor) + " and " + 
                    "convert(prs_fec_fecha,'System.String') = '" + p_dtFecha + "'";

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad PrecioServicio con los datos de la fila
                if (l_drData == null) return null;
                return new EPrecioServicio(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEPreciosServicios", null);

                foreach (EPrecioServicio l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: PreciosServicios
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: PreciosServicios
    /// </summary>
    public sealed partial class LETPreciosServicios : LET<EPrecioServicio>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: PreciosServicios
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEPreciosServicios GetAsLE()
        {
            // Llenamos la lista
            LEPreciosServicios l_lentRet= LEPreciosServicios.NewEmpty();

            foreach (EPrecioServicio l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [PrecioServicio] por clave
        /// </summary>
        public EPrecioServicio this[string p_strColor,
                                    DateTime p_dtFecha]
        {
            get {
                // Buscamos la entidad
                foreach (EPrecioServicio l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Color == p_strColor) &&
                        (l_entItem.Fecha == p_dtFecha))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: ResEntrevista
    /// <summary>
    /// Clase que representa la Entidad: ResEntrevista
    /// </summary>
    public sealed partial class EResEntrevista : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: ResEntrevista
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EResEntrevista(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: ResEntrevista
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EResEntrevista(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: ResEntrevista
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EResEntrevista(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EResEntrevista.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ren_rcd_cod"]= XMLRuts.ExtractXAttr(l_xndData, "ren_rcd_cod");
            l_drTemp["ren_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "ren_des_des");
            l_drTemp["ren_cd1_codfiltro"]= XMLRuts.ExtractXAttr(l_xndData, "ren_cd1_codfiltro");

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
        private EResEntrevista(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: ResEntrevista
        /// </summary>
        /// <returns>Entidad vacia: ResEntrevista</returns>
        public static EResEntrevista NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EResEntrevista.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ren_rcd_cod"]= "";
            l_drTemp["ren_des_des"]= "";
            l_drTemp["ren_cd1_codfiltro"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EResEntrevista l_entRet= new EResEntrevista(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: ResEntrevista
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strDes">Descripción</param>
        /// <param name="p_strCodfiltro">Genera Contrato</param>
        /// <returns>Entidad: ResEntrevista</returns>
        public static EResEntrevista NewFilled(string p_strCod,
                                               string p_strDes,
                                               string p_strCodfiltro)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EResEntrevista.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ren_rcd_cod"]= p_strCod;
            l_drTemp["ren_des_des"]= p_strDes;
            l_drTemp["ren_cd1_codfiltro"]= p_strCodfiltro;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EResEntrevista l_entRet= new EResEntrevista(l_dtTemp);
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
            if (p_strCod.Trim().Length > 2)
                p_strCod= p_strCod.Trim().Substring(0,2);

            return p_strCod.Trim().PadLeft(2).ToUpper();
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

                l_dcStruct[0]= new DataColumn("ren_rcd_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("ren_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("ren_cd1_codfiltro", typeof(string));
                EResEntrevista.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código
        /// </summary>
        public static string CodCmp
        {
           get {return "ren_rcd_cod";}
        }

        /// <summary>
        /// Código
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["ren_rcd_cod"];}
            set {InternalData["ren_rcd_cod"]= EResEntrevista.FrmtCod(value);}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public static string DesCmp
        {
           get {return "ren_des_des";}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["ren_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["ren_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Genera Contrato
        /// </summary>
        public static string CodfiltroCmp
        {
           get {return "ren_cd1_codfiltro";}
        }

        /// <summary>
        /// Genera Contrato
        /// </summary>
        public string Codfiltro
        {
            get {return (string) InternalData["ren_cd1_codfiltro"];}
            set {InternalData["ren_cd1_codfiltro"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EResEntrevista] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EResEntrevista] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EResEntrevista", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ren_rcd_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ren_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ren_cd1_codfiltro", Codfiltro));

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

    #region Lista-Entidad: ResEntrevistas
    /// <summary>
    /// Clase que representa la Lista-Entidad: ResEntrevistas
    /// </summary>
    public sealed partial class LEResEntrevistas : ListaEntidades, IEnumerable<EResEntrevista>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: ResEntrevista
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEResEntrevistas(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEResEntrevistas(string p_strXMLData) :
            base(EResEntrevista.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EResEntrevista(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEResEntrevistas(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: ResEntrevistas
        /// </summary>
        /// <returns>Lista-Entidad vacia: ResEntrevista</returns>
        public static LEResEntrevistas NewEmpty()
        {
            return new LEResEntrevistas(EResEntrevista.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEResEntrevista">Entidad a agregar</param>
        public void AddEntity(EResEntrevista p_entEResEntrevista)
        {
            base.AddEntity(p_entEResEntrevista);
        }

        /// <summary>
        /// Remueve una entidad [ResEntrevista] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "ren_rcd_cod = " + Ruts.Co(EResEntrevista.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [ResEntrevista] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EResEntrevista l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: ResEntrevistas
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EResEntrevista> GetEnumerator() 
        {
            EResEntrevista l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EResEntrevista(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: ResEntrevistas
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EResEntrevista l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: ResEntrevistas
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETResEntrevistas GetAsLET()
        {
            // Llenamos la lista tipada
            LETResEntrevistas l_lentRet= new LETResEntrevistas();

            foreach (EResEntrevista l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<ResEntrevistas>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EResEntrevista> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EResEntrevista>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [ResEntrevista] por indice
        /// </summary>
        public new EResEntrevista this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad ResEntrevista con los datos de la fila
                return new EResEntrevista(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [ResEntrevista] por clave
        /// </summary>
        public EResEntrevista this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "ren_rcd_cod = " + Ruts.Co(EResEntrevista.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad ResEntrevista con los datos de la fila
                if (l_drData == null) return null;
                return new EResEntrevista(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEResEntrevistas", null);

                foreach (EResEntrevista l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: ResEntrevistas
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: ResEntrevistas
    /// </summary>
    public sealed partial class LETResEntrevistas : LET<EResEntrevista>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: ResEntrevistas
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEResEntrevistas GetAsLE()
        {
            // Llenamos la lista
            LEResEntrevistas l_lentRet= LEResEntrevistas.NewEmpty();

            foreach (EResEntrevista l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [ResEntrevista] por clave
        /// </summary>
        public EResEntrevista this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EResEntrevista l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == EResEntrevista.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Rubro
    /// <summary>
    /// Clase que representa la Entidad: Rubro
    /// </summary>
    public sealed partial class ERubro : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Rubros
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ERubro(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Rubro
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ERubro(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Rubro
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ERubro(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ERubro.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["rbr_rcd_cod"]= XMLRuts.ExtractXAttr(l_xndData, "rbr_rcd_cod");
            l_drTemp["rbr_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "rbr_des_des");

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
        private ERubro(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Rubro
        /// </summary>
        /// <returns>Entidad vacia: Rubro</returns>
        public static ERubro NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ERubro.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["rbr_rcd_cod"]= "";
            l_drTemp["rbr_des_des"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ERubro l_entRet= new ERubro(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Rubro
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strDes">Descripción</param>
        /// <returns>Entidad: Rubro</returns>
        public static ERubro NewFilled(string p_strCod,
                                       string p_strDes)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ERubro.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["rbr_rcd_cod"]= p_strCod;
            l_drTemp["rbr_des_des"]= p_strDes;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ERubro l_entRet= new ERubro(l_dtTemp);
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
            if (p_strCod.Trim().Length > 2)
                p_strCod= p_strCod.Trim().Substring(0,2);

            return p_strCod.Trim().PadLeft(2).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[6];

                l_dcStruct[0]= new DataColumn("rbr_rcd_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("rbr_des_des", typeof(string));
                ERubro.FillFixedFields(ref l_dcStruct, 2);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código
        /// </summary>
        public static string CodCmp
        {
           get {return "rbr_rcd_cod";}
        }

        /// <summary>
        /// Código
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["rbr_rcd_cod"];}
            set {InternalData["rbr_rcd_cod"]= ERubro.FrmtCod(value);}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public static string DesCmp
        {
           get {return "rbr_des_des";}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["rbr_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["rbr_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Devuelve la entidad [ERubro] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ERubro] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ERubro", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "rbr_rcd_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "rbr_des_des", Des));

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

    #region Lista-Entidad: Rubros
    /// <summary>
    /// Clase que representa la Lista-Entidad: Rubros
    /// </summary>
    public sealed partial class LERubros : ListaEntidades, IEnumerable<ERubro>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Rubros
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LERubros(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LERubros(string p_strXMLData) :
            base(ERubro.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ERubro(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LERubros(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Rubros
        /// </summary>
        /// <returns>Lista-Entidad vacia: Rubros</returns>
        public static LERubros NewEmpty()
        {
            return new LERubros(ERubro.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entERubro">Entidad a agregar</param>
        public void AddEntity(ERubro p_entERubro)
        {
            base.AddEntity(p_entERubro);
        }

        /// <summary>
        /// Remueve una entidad [Rubro] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "rbr_rcd_cod = " + Ruts.Co(ERubro.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [Rubro] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (ERubro l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Rubros
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ERubro> GetEnumerator() 
        {
            ERubro l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ERubro(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Rubros
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ERubro l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Rubros
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETRubros GetAsLET()
        {
            // Llenamos la lista tipada
            LETRubros l_lentRet= new LETRubros();

            foreach (ERubro l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Rubros>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ERubro> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ERubro>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Rubro] por indice
        /// </summary>
        public new ERubro this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Rubro con los datos de la fila
                return new ERubro(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Rubro] por clave
        /// </summary>
        public ERubro this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "rbr_rcd_cod = " + Ruts.Co(ERubro.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Rubro con los datos de la fila
                if (l_drData == null) return null;
                return new ERubro(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LERubros", null);

                foreach (ERubro l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Rubros
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Rubros
    /// </summary>
    public sealed partial class LETRubros : LET<ERubro>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Rubros
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LERubros GetAsLE()
        {
            // Llenamos la lista
            LERubros l_lentRet= LERubros.NewEmpty();

            foreach (ERubro l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Rubro] por clave
        /// </summary>
        public ERubro this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (ERubro l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == ERubro.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: SituacionIVA
    /// <summary>
    /// Clase que representa la Entidad: SituacionIVA
    /// </summary>
    public sealed partial class ESituacionIVA : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: SituacionesIVA
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ESituacionIVA(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: SituacionIVA
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ESituacionIVA(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: SituacionIVA
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ESituacionIVA(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ESituacionIVA.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["siv_rcd_codigo"]= XMLRuts.ExtractXAttr(l_xndData, "siv_rcd_codigo");
            l_drTemp["siv_des_descripcion"]= XMLRuts.ExtractXAttr(l_xndData, "siv_des_descripcion");
            l_drTemp["siv_cd1_discrimina"]= XMLRuts.ExtractXAttr(l_xndData, "siv_cd1_discrimina");

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
        private ESituacionIVA(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: SituacionIVA
        /// </summary>
        /// <returns>Entidad vacia: SituacionIVA</returns>
        public static ESituacionIVA NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ESituacionIVA.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["siv_rcd_codigo"]= "";
            l_drTemp["siv_des_descripcion"]= "";
            l_drTemp["siv_cd1_discrimina"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ESituacionIVA l_entRet= new ESituacionIVA(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: SituacionIVA
        /// </summary>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_strDescripcion">Descripcion</param>
        /// <param name="p_strDiscrimina">Discrimina</param>
        /// <returns>Entidad: SituacionIVA</returns>
        public static ESituacionIVA NewFilled(string p_strCodigo,
                                              string p_strDescripcion,
                                              string p_strDiscrimina)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ESituacionIVA.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["siv_rcd_codigo"]= p_strCodigo;
            l_drTemp["siv_des_descripcion"]= p_strDescripcion;
            l_drTemp["siv_cd1_discrimina"]= p_strDiscrimina;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ESituacionIVA l_entRet= new ESituacionIVA(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores
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

                l_dcStruct[0]= new DataColumn("siv_rcd_codigo", typeof(string));
                l_dcStruct[1]= new DataColumn("siv_des_descripcion", typeof(string));
                l_dcStruct[2]= new DataColumn("siv_cd1_discrimina", typeof(string));
                ESituacionIVA.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public static string CodigoCmp
        {
           get {return "siv_rcd_codigo";}
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public string Codigo
        {
            get {return ((string) InternalData["siv_rcd_codigo"]).Trim();}
            set {
                if (value.Trim().Length > 2) value= value.Trim().Substring(0,2);
                InternalData["siv_rcd_codigo"]= value.Trim();
            }
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public static string DescripcionCmp
        {
           get {return "siv_des_descripcion";}
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public string Descripcion
        {
            get {return ((string) InternalData["siv_des_descripcion"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["siv_des_descripcion"]= value.Trim();
            }
        }

        /// <summary>
        /// Discrimina
        /// </summary>
        public static string DiscriminaCmp
        {
           get {return "siv_cd1_discrimina";}
        }

        /// <summary>
        /// Discrimina
        /// </summary>
        public string Discrimina
        {
            get {return ((string) InternalData["siv_cd1_discrimina"]).Trim();}
            set {
                if (value.Trim().Length > 1) value= value.Trim().Substring(0,1);
                InternalData["siv_cd1_discrimina"]= value.Trim();
            }
        }

        /// <summary>
        /// Devuelve la entidad [ESituacionIVA] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ESituacionIVA] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ESituacionIVA", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "siv_rcd_codigo", Codigo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "siv_des_descripcion", Descripcion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "siv_cd1_discrimina", Discrimina));

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

    #region Lista-Entidad: SituacionesIVAs
    /// <summary>
    /// Clase que representa la Lista-Entidad: SituacionesIVAs
    /// </summary>
    public sealed partial class LESituacionesIVAs : ListaEntidades, IEnumerable<ESituacionIVA>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: SituacionesIVA
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LESituacionesIVAs(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LESituacionesIVAs(string p_strXMLData) :
            base(ESituacionIVA.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ESituacionIVA(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LESituacionesIVAs(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: SituacionesIVAs
        /// </summary>
        /// <returns>Lista-Entidad vacia: SituacionesIVA</returns>
        public static LESituacionesIVAs NewEmpty()
        {
            return new LESituacionesIVAs(ESituacionIVA.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entESituacionIVA">Entidad a agregar</param>
        public void AddEntity(ESituacionIVA p_entESituacionIVA)
        {
            base.AddEntity(p_entESituacionIVA);
        }

        /// <summary>
        /// Remueve una entidad [SituacionIVA] por clave
        /// </summary>
        public int RemoveEntity(string p_strCodigo)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "siv_rcd_codigo = " + Ruts.Co(p_strCodigo);

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
        /// Verifca si una entidad [SituacionIVA] esta en la lista
        /// </summary>
        public bool Contains(string p_strCodigo)
        {
            using (ESituacionIVA l_entTemp= this[p_strCodigo])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: SituacionesIVAs
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ESituacionIVA> GetEnumerator() 
        {
            ESituacionIVA l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ESituacionIVA(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: SituacionesIVAs
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ESituacionIVA l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: SituacionesIVAs
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETSituacionesIVAs GetAsLET()
        {
            // Llenamos la lista tipada
            LETSituacionesIVAs l_lentRet= new LETSituacionesIVAs();

            foreach (ESituacionIVA l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<SituacionesIVAs>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ESituacionIVA> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ESituacionIVA>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [SituacionIVA] por indice
        /// </summary>
        public new ESituacionIVA this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad SituacionIVA con los datos de la fila
                return new ESituacionIVA(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [SituacionIVA] por clave
        /// </summary>
        public ESituacionIVA this[string p_strCodigo]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "siv_rcd_codigo = " + Ruts.Co(p_strCodigo);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad SituacionIVA con los datos de la fila
                if (l_drData == null) return null;
                return new ESituacionIVA(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LESituacionesIVAs", null);

                foreach (ESituacionIVA l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: SituacionesIVAs
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: SituacionesIVAs
    /// </summary>
    public sealed partial class LETSituacionesIVAs : LET<ESituacionIVA>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: SituacionesIVAs
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LESituacionesIVAs GetAsLE()
        {
            // Llenamos la lista
            LESituacionesIVAs l_lentRet= LESituacionesIVAs.NewEmpty();

            foreach (ESituacionIVA l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [SituacionIVA] por clave
        /// </summary>
        public ESituacionIVA this[string p_strCodigo]
        {
            get {
                // Buscamos la entidad
                foreach (ESituacionIVA l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Codigo == p_strCodigo)
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: TipoVendedor
    /// <summary>
    /// Clase que representa la Entidad: TipoVendedor
    /// </summary>
    public sealed partial class ETipoVendedor : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: TipoVend
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ETipoVendedor(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: TipoVendedor
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ETipoVendedor(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: TipoVendedor
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ETipoVendedor(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ETipoVendedor.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tvn_rcd_cod"]= XMLRuts.ExtractXAttr(l_xndData, "tvn_rcd_cod");
            l_drTemp["tvn_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "tvn_des_des");
            l_drTemp["tvn_cd1_vemayor"]= XMLRuts.ExtractXAttr(l_xndData, "tvn_cd1_vemayor");

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
        private ETipoVendedor(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: TipoVendedor
        /// </summary>
        /// <returns>Entidad vacia: TipoVendedor</returns>
        public static ETipoVendedor NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ETipoVendedor.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tvn_rcd_cod"]= "";
            l_drTemp["tvn_des_des"]= "";
            l_drTemp["tvn_cd1_vemayor"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ETipoVendedor l_entRet= new ETipoVendedor(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: TipoVendedor
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_strDes">Descripcion</param>
        /// <param name="p_strVemayor">Ve Mayoristas</param>
        /// <returns>Entidad: TipoVendedor</returns>
        public static ETipoVendedor NewFilled(string p_strCod,
                                              string p_strDes,
                                              string p_strVemayor)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ETipoVendedor.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tvn_rcd_cod"]= p_strCod;
            l_drTemp["tvn_des_des"]= p_strDes;
            l_drTemp["tvn_cd1_vemayor"]= p_strVemayor;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ETipoVendedor l_entRet= new ETipoVendedor(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Codigo
        /// </summary>
        public static string FrmtCod(string p_strCod)
        {
            if (p_strCod.Trim().Length > 2)
                p_strCod= p_strCod.Trim().Substring(0,2);

            return p_strCod.Trim().PadLeft(2).ToUpper();
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

                l_dcStruct[0]= new DataColumn("tvn_rcd_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("tvn_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("tvn_cd1_vemayor", typeof(string));
                ETipoVendedor.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public static string CodCmp
        {
           get {return "tvn_rcd_cod";}
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["tvn_rcd_cod"];}
            set {InternalData["tvn_rcd_cod"]= ETipoVendedor.FrmtCod(value);}
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public static string DesCmp
        {
           get {return "tvn_des_des";}
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["tvn_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["tvn_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Ve Mayoristas
        /// </summary>
        public static string VemayorCmp
        {
           get {return "tvn_cd1_vemayor";}
        }

        /// <summary>
        /// Ve Mayoristas
        /// </summary>
        public string Vemayor
        {
            get {return (string) InternalData["tvn_cd1_vemayor"];}
            set {InternalData["tvn_cd1_vemayor"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ETipoVendedor] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ETipoVendedor] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ETipoVendedor", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tvn_rcd_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tvn_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tvn_cd1_vemayor", Vemayor));

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

    #region Lista-Entidad: TipoVendedores
    /// <summary>
    /// Clase que representa la Lista-Entidad: TipoVendedores
    /// </summary>
    public sealed partial class LETipoVendedores : ListaEntidades, IEnumerable<ETipoVendedor>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: TipoVend
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LETipoVendedores(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LETipoVendedores(string p_strXMLData) :
            base(ETipoVendedor.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ETipoVendedor(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LETipoVendedores(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: TipoVendedores
        /// </summary>
        /// <returns>Lista-Entidad vacia: TipoVend</returns>
        public static LETipoVendedores NewEmpty()
        {
            return new LETipoVendedores(ETipoVendedor.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entETipoVendedor">Entidad a agregar</param>
        public void AddEntity(ETipoVendedor p_entETipoVendedor)
        {
            base.AddEntity(p_entETipoVendedor);
        }

        /// <summary>
        /// Remueve una entidad [TipoVendedor] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "tvn_rcd_cod = " + Ruts.Co(ETipoVendedor.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [TipoVendedor] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (ETipoVendedor l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: TipoVendedores
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ETipoVendedor> GetEnumerator() 
        {
            ETipoVendedor l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ETipoVendedor(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: TipoVendedores
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ETipoVendedor l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: TipoVendedores
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETTipoVendedores GetAsLET()
        {
            // Llenamos la lista tipada
            LETTipoVendedores l_lentRet= new LETTipoVendedores();

            foreach (ETipoVendedor l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<TipoVendedores>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ETipoVendedor> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ETipoVendedor>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [TipoVendedor] por indice
        /// </summary>
        public new ETipoVendedor this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad TipoVendedor con los datos de la fila
                return new ETipoVendedor(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [TipoVendedor] por clave
        /// </summary>
        public ETipoVendedor this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "tvn_rcd_cod = " + Ruts.Co(ETipoVendedor.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad TipoVendedor con los datos de la fila
                if (l_drData == null) return null;
                return new ETipoVendedor(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LETipoVendedores", null);

                foreach (ETipoVendedor l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: TipoVendedores
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: TipoVendedores
    /// </summary>
    public sealed partial class LETTipoVendedores : LET<ETipoVendedor>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: TipoVendedores
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LETipoVendedores GetAsLE()
        {
            // Llenamos la lista
            LETipoVendedores l_lentRet= LETipoVendedores.NewEmpty();

            foreach (ETipoVendedor l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [TipoVendedor] por clave
        /// </summary>
        public ETipoVendedor this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (ETipoVendedor l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == ETipoVendedor.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: TipoCont
    /// <summary>
    /// Clase que representa la Entidad: TipoCont
    /// </summary>
    public sealed partial class ETipoCont : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: TipoCont
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ETipoCont(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: TipoCont
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ETipoCont(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: TipoCont
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ETipoCont(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ETipoCont.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tcn_rcd_cod"]= XMLRuts.ExtractXAttr(l_xndData, "tcn_rcd_cod");
            l_drTemp["tcn_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "tcn_des_des");
            l_drTemp["tcn_cd1_modo"]= XMLRuts.ExtractXAttr(l_xndData, "tcn_cd1_modo");
            l_drTemp["tcn_rcd_tcontratoavalon"]= XMLRuts.ExtractXAttr(l_xndData, "tcn_rcd_tcontratoavalon");

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
        private ETipoCont(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: TipoCont
        /// </summary>
        /// <returns>Entidad vacia: TipoCont</returns>
        public static ETipoCont NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ETipoCont.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tcn_rcd_cod"]= "";
            l_drTemp["tcn_des_des"]= "";
            l_drTemp["tcn_cd1_modo"]= "";
            l_drTemp["tcn_rcd_tcontratoavalon"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ETipoCont l_entRet= new ETipoCont(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: TipoCont
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strDes">Descripción</param>
        /// <param name="p_strModo">Modo Venta</param>
        /// <param name="p_strTcontratoavalon">Tipo Contrato Avalon</param>
        /// <returns>Entidad: TipoCont</returns>
        public static ETipoCont NewFilled(string p_strCod,
                                          string p_strDes,
                                          string p_strModo,
                                          string p_strTcontratoavalon)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ETipoCont.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tcn_rcd_cod"]= p_strCod;
            l_drTemp["tcn_des_des"]= p_strDes;
            l_drTemp["tcn_cd1_modo"]= p_strModo;
            l_drTemp["tcn_rcd_tcontratoavalon"]= p_strTcontratoavalon;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ETipoCont l_entRet= new ETipoCont(l_dtTemp);
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
            if (p_strCod.Trim().Length > 2)
                p_strCod= p_strCod.Trim().Substring(0,2);

            return p_strCod.Trim().PadLeft(2).ToUpper();
        }

        /// <summary>
        /// Formatea una string: Tipo Contrato Avalon
        /// </summary>
        public static string FrmtTcontratoavalon(string p_strTcontratoavalon)
        {
            if (p_strTcontratoavalon.Trim().Length > 2)
                p_strTcontratoavalon= p_strTcontratoavalon.Trim().Substring(0,2);

            return p_strTcontratoavalon.Trim().PadLeft(2).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[8];

                l_dcStruct[0]= new DataColumn("tcn_rcd_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("tcn_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("tcn_cd1_modo", typeof(string));
                l_dcStruct[3]= new DataColumn("tcn_rcd_tcontratoavalon", typeof(string));
                ETipoCont.FillFixedFields(ref l_dcStruct, 4);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código
        /// </summary>
        public static string CodCmp
        {
           get {return "tcn_rcd_cod";}
        }

        /// <summary>
        /// Código
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["tcn_rcd_cod"];}
            set {InternalData["tcn_rcd_cod"]= ETipoCont.FrmtCod(value);}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public static string DesCmp
        {
           get {return "tcn_des_des";}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["tcn_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["tcn_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Modo Venta
        /// </summary>
        public static string ModoCmp
        {
           get {return "tcn_cd1_modo";}
        }

        /// <summary>
        /// Modo Venta
        /// </summary>
        public string Modo
        {
            get {return (string) InternalData["tcn_cd1_modo"];}
            set {InternalData["tcn_cd1_modo"]= value;}
        }

        /// <summary>
        /// Tipo Contrato Avalon
        /// </summary>
        public static string TcontratoavalonCmp
        {
           get {return "tcn_rcd_tcontratoavalon";}
        }

        /// <summary>
        /// Tipo Contrato Avalon
        /// </summary>
        public string Tcontratoavalon
        {
            get {return (string) InternalData["tcn_rcd_tcontratoavalon"];}
            set {InternalData["tcn_rcd_tcontratoavalon"]= ETipoCont.FrmtTcontratoavalon(value);}
        }

        /// <summary>
        /// Devuelve la entidad [ETipoCont] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ETipoCont] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ETipoCont", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tcn_rcd_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tcn_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tcn_cd1_modo", Modo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tcn_rcd_tcontratoavalon", Tcontratoavalon));

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

    #region Lista-Entidad: TipoConts
    /// <summary>
    /// Clase que representa la Lista-Entidad: TipoConts
    /// </summary>
    public sealed partial class LETipoConts : ListaEntidades, IEnumerable<ETipoCont>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: TipoCont
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LETipoConts(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LETipoConts(string p_strXMLData) :
            base(ETipoCont.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ETipoCont(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LETipoConts(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: TipoConts
        /// </summary>
        /// <returns>Lista-Entidad vacia: TipoCont</returns>
        public static LETipoConts NewEmpty()
        {
            return new LETipoConts(ETipoCont.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entETipoCont">Entidad a agregar</param>
        public void AddEntity(ETipoCont p_entETipoCont)
        {
            base.AddEntity(p_entETipoCont);
        }

        /// <summary>
        /// Remueve una entidad [TipoCont] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "tcn_rcd_cod = " + Ruts.Co(ETipoCont.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [TipoCont] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (ETipoCont l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: TipoConts
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ETipoCont> GetEnumerator() 
        {
            ETipoCont l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ETipoCont(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: TipoConts
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ETipoCont l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: TipoConts
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETTipoConts GetAsLET()
        {
            // Llenamos la lista tipada
            LETTipoConts l_lentRet= new LETTipoConts();

            foreach (ETipoCont l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<TipoConts>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ETipoCont> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ETipoCont>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [TipoCont] por indice
        /// </summary>
        public new ETipoCont this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad TipoCont con los datos de la fila
                return new ETipoCont(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [TipoCont] por clave
        /// </summary>
        public ETipoCont this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "tcn_rcd_cod = " + Ruts.Co(ETipoCont.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad TipoCont con los datos de la fila
                if (l_drData == null) return null;
                return new ETipoCont(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LETipoConts", null);

                foreach (ETipoCont l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: TipoConts
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: TipoConts
    /// </summary>
    public sealed partial class LETTipoConts : LET<ETipoCont>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: TipoConts
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LETipoConts GetAsLE()
        {
            // Llenamos la lista
            LETipoConts l_lentRet= LETipoConts.NewEmpty();

            foreach (ETipoCont l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [TipoCont] por clave
        /// </summary>
        public ETipoCont this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (ETipoCont l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == ETipoCont.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: TipoInst
    /// <summary>
    /// Clase que representa la Entidad: TipoInst
    /// </summary>
    public sealed partial class ETipoInst : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: TipoInst
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ETipoInst(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: TipoInst
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ETipoInst(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: TipoInst
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ETipoInst(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ETipoInst.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tin_cod_cod"]= XMLRuts.ExtractXAttr(l_xndData, "tin_cod_cod");
            l_drTemp["tin_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "tin_des_des");
            l_drTemp["tin_rcd_codrubro"]= XMLRuts.ExtractXAttr(l_xndData, "tin_rcd_codrubro");
            l_drTemp["tin_cd1_mayorista"]= XMLRuts.ExtractXAttr(l_xndData, "tin_cd1_mayorista");
            l_drTemp["tin_des_rubro"]= XMLRuts.ExtractXAttr(l_xndData, "tin_des_rubro");

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
        private ETipoInst(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: TipoInst
        /// </summary>
        /// <returns>Entidad vacia: TipoInst</returns>
        public static ETipoInst NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ETipoInst.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tin_cod_cod"]= "";
            l_drTemp["tin_des_des"]= "";
            l_drTemp["tin_rcd_codrubro"]= "";
            l_drTemp["tin_cd1_mayorista"]= "";
            l_drTemp["tin_des_rubro"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ETipoInst l_entRet= new ETipoInst(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: TipoInst
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strDes">Descripción</param>
        /// <param name="p_strCodrubro">Rubro</param>
        /// <param name="p_strMayorista">Mayorista</param>
        /// <returns>Entidad: TipoInst</returns>
        public static ETipoInst NewFilled(string p_strCod,
                                          string p_strDes,
                                          string p_strCodrubro,
                                          string p_strMayorista)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ETipoInst.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tin_cod_cod"]= p_strCod;
            l_drTemp["tin_des_des"]= p_strDes;
            l_drTemp["tin_rcd_codrubro"]= p_strCodrubro;
            l_drTemp["tin_cd1_mayorista"]= p_strMayorista;
            l_drTemp["tin_des_rubro"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ETipoInst l_entRet= new ETipoInst(l_dtTemp);
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
        /// Formatea una string: Rubro
        /// </summary>
        public static string FrmtCodrubro(string p_strCodrubro)
        {
            if (p_strCodrubro.Trim().Length > 2)
                p_strCodrubro= p_strCodrubro.Trim().Substring(0,2);

            return p_strCodrubro.Trim().PadLeft(2).ToUpper();
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

                l_dcStruct[0]= new DataColumn("tin_cod_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("tin_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("tin_rcd_codrubro", typeof(string));
                l_dcStruct[3]= new DataColumn("tin_des_rubro", typeof(string));
                l_dcStruct[4]= new DataColumn("tin_cd1_mayorista", typeof(string));
                ETipoInst.FillFixedFields(ref l_dcStruct, 5);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código
        /// </summary>
        public static string CodCmp
        {
           get {return "tin_cod_cod";}
        }

        /// <summary>
        /// Código
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["tin_cod_cod"];}
            set {InternalData["tin_cod_cod"]= ETipoInst.FrmtCod(value);}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public static string DesCmp
        {
           get {return "tin_des_des";}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["tin_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["tin_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Rubro
        /// </summary>
        public static string CodrubroCmp
        {
           get {return "tin_rcd_codrubro";}
        }

        /// <summary>
        /// Rubro
        /// </summary>
        public string Codrubro
        {
            get {return (string) InternalData["tin_rcd_codrubro"];}
            set {InternalData["tin_rcd_codrubro"]= ETipoInst.FrmtCodrubro(value);}
        }

        /// <summary>
        /// Mayorista
        /// </summary>
        public static string MayoristaCmp
        {
           get {return "tin_cd1_mayorista";}
        }

        /// <summary>
        /// Mayorista
        /// </summary>
        public string Mayorista
        {
            get {return (string) InternalData["tin_cd1_mayorista"];}
            set {InternalData["tin_cd1_mayorista"]= value;}
        }

        /// <summary>
        /// Rubro
        /// </summary>
        public string Tin_des_rubro
        {
            get {return (string) InternalData["tin_des_rubro"];}
            set {InternalData["tin_des_rubro"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ETipoInst] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ETipoInst] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ETipoInst", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tin_cod_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tin_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tin_rcd_codrubro", Codrubro));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tin_cd1_mayorista", Mayorista));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tin_des_rubro", Tin_des_rubro));

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

    #region Lista-Entidad: TipoInsts
    /// <summary>
    /// Clase que representa la Lista-Entidad: TipoInsts
    /// </summary>
    public sealed partial class LETipoInsts : ListaEntidades, IEnumerable<ETipoInst>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: TipoInst
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LETipoInsts(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LETipoInsts(string p_strXMLData) :
            base(ETipoInst.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ETipoInst(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LETipoInsts(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: TipoInsts
        /// </summary>
        /// <returns>Lista-Entidad vacia: TipoInst</returns>
        public static LETipoInsts NewEmpty()
        {
            return new LETipoInsts(ETipoInst.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entETipoInst">Entidad a agregar</param>
        public void AddEntity(ETipoInst p_entETipoInst)
        {
            base.AddEntity(p_entETipoInst);
        }

        /// <summary>
        /// Remueve una entidad [TipoInst] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "tin_cod_cod = " + Ruts.Co(ETipoInst.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [TipoInst] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (ETipoInst l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: TipoInsts
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ETipoInst> GetEnumerator() 
        {
            ETipoInst l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ETipoInst(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: TipoInsts
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ETipoInst l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: TipoInsts
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETTipoInsts GetAsLET()
        {
            // Llenamos la lista tipada
            LETTipoInsts l_lentRet= new LETTipoInsts();

            foreach (ETipoInst l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<TipoInsts>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ETipoInst> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ETipoInst>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [TipoInst] por indice
        /// </summary>
        public new ETipoInst this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad TipoInst con los datos de la fila
                return new ETipoInst(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [TipoInst] por clave
        /// </summary>
        public ETipoInst this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "tin_cod_cod = " + Ruts.Co(ETipoInst.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad TipoInst con los datos de la fila
                if (l_drData == null) return null;
                return new ETipoInst(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LETipoInsts", null);

                foreach (ETipoInst l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: TipoInsts
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: TipoInsts
    /// </summary>
    public sealed partial class LETTipoInsts : LET<ETipoInst>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: TipoInsts
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LETipoInsts GetAsLE()
        {
            // Llenamos la lista
            LETipoInsts l_lentRet= LETipoInsts.NewEmpty();

            foreach (ETipoInst l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [TipoInst] por clave
        /// </summary>
        public ETipoInst this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (ETipoInst l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == ETipoInst.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Zona
    /// <summary>
    /// Clase que representa la Entidad: Zona
    /// </summary>
    public sealed partial class EZona : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Zonas
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EZona(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Zona
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EZona(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Zona
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EZona(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EZona.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["zns_rcd_cod"]= XMLRuts.ExtractXAttr(l_xndData, "zns_rcd_cod");
            l_drTemp["zns_des_nombre"]= XMLRuts.ExtractXAttr(l_xndData, "zns_des_nombre");
            l_drTemp["zns_txt_geoloc"]= XMLRuts.ExtractXAttr(l_xndData, "zns_txt_geoloc");

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
        private EZona(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Zona
        /// </summary>
        /// <returns>Entidad vacia: Zona</returns>
        public static EZona NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EZona.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["zns_rcd_cod"]= "";
            l_drTemp["zns_des_nombre"]= "";
            l_drTemp["zns_txt_geoloc"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EZona l_entRet= new EZona(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Zona
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strNombre">Nombre de la zona</param>
        /// <param name="p_strGeoloc">Geolocalización</param>
        /// <returns>Entidad: Zona</returns>
        public static EZona NewFilled(string p_strCod,
                                      string p_strNombre,
                                      string p_strGeoloc)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EZona.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["zns_rcd_cod"]= p_strCod;
            l_drTemp["zns_des_nombre"]= p_strNombre;
            l_drTemp["zns_txt_geoloc"]= p_strGeoloc;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EZona l_entRet= new EZona(l_dtTemp);
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
            if (p_strCod.Trim().Length > 2)
                p_strCod= p_strCod.Trim().Substring(0,2);

            return p_strCod.Trim().PadLeft(2).ToUpper();
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

                l_dcStruct[0]= new DataColumn("zns_rcd_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("zns_des_nombre", typeof(string));
                l_dcStruct[2]= new DataColumn("zns_txt_geoloc", typeof(string));
                EZona.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código
        /// </summary>
        public static string CodCmp
        {
           get {return "zns_rcd_cod";}
        }

        /// <summary>
        /// Código
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["zns_rcd_cod"];}
            set {InternalData["zns_rcd_cod"]= EZona.FrmtCod(value);}
        }

        /// <summary>
        /// Nombre de la zona
        /// </summary>
        public static string NombreCmp
        {
           get {return "zns_des_nombre";}
        }

        /// <summary>
        /// Nombre de la zona
        /// </summary>
        public string Nombre
        {
            get {return ((string) InternalData["zns_des_nombre"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["zns_des_nombre"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Geolocalización
        /// </summary>
        public static string GeolocCmp
        {
           get {return "zns_txt_geoloc";}
        }

        /// <summary>
        /// Geolocalización
        /// </summary>
        public string Geoloc
        {
            get {return (string) InternalData["zns_txt_geoloc"];}
            set {InternalData["zns_txt_geoloc"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EZona] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EZona] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EZona", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "zns_rcd_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "zns_des_nombre", Nombre));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "zns_txt_geoloc", Geoloc));

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

    #region Lista-Entidad: Zonas
    /// <summary>
    /// Clase que representa la Lista-Entidad: Zonas
    /// </summary>
    public sealed partial class LEZonas : ListaEntidades, IEnumerable<EZona>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Zonas
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEZonas(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEZonas(string p_strXMLData) :
            base(EZona.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EZona(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEZonas(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Zonas
        /// </summary>
        /// <returns>Lista-Entidad vacia: Zonas</returns>
        public static LEZonas NewEmpty()
        {
            return new LEZonas(EZona.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEZona">Entidad a agregar</param>
        public void AddEntity(EZona p_entEZona)
        {
            base.AddEntity(p_entEZona);
        }

        /// <summary>
        /// Remueve una entidad [Zona] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "zns_rcd_cod = " + Ruts.Co(EZona.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [Zona] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EZona l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Zonas
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EZona> GetEnumerator() 
        {
            EZona l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EZona(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Zonas
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EZona l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Zonas
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETZonas GetAsLET()
        {
            // Llenamos la lista tipada
            LETZonas l_lentRet= new LETZonas();

            foreach (EZona l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Zonas>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EZona> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EZona>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Zona] por indice
        /// </summary>
        public new EZona this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Zona con los datos de la fila
                return new EZona(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Zona] por clave
        /// </summary>
        public EZona this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "zns_rcd_cod = " + Ruts.Co(EZona.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Zona con los datos de la fila
                if (l_drData == null) return null;
                return new EZona(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEZonas", null);

                foreach (EZona l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Zonas
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Zonas
    /// </summary>
    public sealed partial class LETZonas : LET<EZona>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Zonas
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEZonas GetAsLE()
        {
            // Llenamos la lista
            LEZonas l_lentRet= LEZonas.NewEmpty();

            foreach (EZona l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Zona] por clave
        /// </summary>
        public EZona this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EZona l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == EZona.FrmtCod(p_strCod))
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
