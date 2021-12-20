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
    // Fecha                    : 19/07/2021 08:58
    // Sistema                  : Carm
    // Clase para Administrar   : Supervisores
    //----------------------------------------------------------------------------
    // © 1996-2021 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    #region Entidad: Supervisor
    /// <summary>
    /// Clase que representa la Entidad: Supervisor
    /// </summary>
    public sealed partial class ESupervisor : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Supervisores
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ESupervisor(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Supervisor
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ESupervisor(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Supervisor
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ESupervisor(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ESupervisor.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["sup_cd6_cod"]= XMLRuts.ExtractXAttr(l_xndData, "sup_cd6_cod");
            l_drTemp["sup_nom_apellido"]= XMLRuts.ExtractXAttr(l_xndData, "sup_nom_apellido");
            l_drTemp["sup_nom_nombre"]= XMLRuts.ExtractXAttr(l_xndData, "sup_nom_nombre");
            l_drTemp["sup_nom_usuario"]= XMLRuts.ExtractXAttr(l_xndData, "sup_nom_usuario");
            l_drTemp["sup_tel_tel"]= XMLRuts.ExtractXAttr(l_xndData, "sup_tel_tel");
            l_drTemp["sup_tel_cel"]= XMLRuts.ExtractXAttr(l_xndData, "sup_tel_cel");
            l_drTemp["sup_ede_nya"]= XMLRuts.ExtractXAttr(l_xndData, "sup_ede_nya");

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
        private ESupervisor(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Supervisor
        /// </summary>
        /// <returns>Entidad vacia: Supervisor</returns>
        public static ESupervisor NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ESupervisor.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["sup_cd6_cod"]= "";
            l_drTemp["sup_nom_apellido"]= "";
            l_drTemp["sup_nom_nombre"]= "";
            l_drTemp["sup_nom_usuario"]= "";
            l_drTemp["sup_tel_tel"]= "";
            l_drTemp["sup_tel_cel"]= "";
            l_drTemp["sup_ede_nya"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ESupervisor l_entRet= new ESupervisor(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Supervisor
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strApellido">Apellido</param>
        /// <param name="p_strNombre">Nombre</param>
        /// <param name="p_strUsuario">Usuario del Sistema</param>
        /// <param name="p_strTel">Télefono</param>
        /// <param name="p_strCel">Celular</param>
        /// <returns>Entidad: Supervisor</returns>
        public static ESupervisor NewFilled(string p_strCod,
                                            string p_strApellido,
                                            string p_strNombre,
                                            string p_strUsuario,
                                            string p_strTel,
                                            string p_strCel)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ESupervisor.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["sup_cd6_cod"]= p_strCod;
            l_drTemp["sup_nom_apellido"]= p_strApellido;
            l_drTemp["sup_nom_nombre"]= p_strNombre;
            l_drTemp["sup_nom_usuario"]= p_strUsuario;
            l_drTemp["sup_tel_tel"]= p_strTel;
            l_drTemp["sup_tel_cel"]= p_strCel;
            l_drTemp["sup_ede_nya"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ESupervisor l_entRet= new ESupervisor(l_dtTemp);
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
                DataColumn[] l_dcStruct= new DataColumn[11];

                l_dcStruct[0]= new DataColumn("sup_cd6_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("sup_nom_apellido", typeof(string));
                l_dcStruct[2]= new DataColumn("sup_nom_nombre", typeof(string));
                l_dcStruct[3]= new DataColumn("sup_nom_usuario", typeof(string));
                l_dcStruct[4]= new DataColumn("sup_ede_nya", typeof(string));
                l_dcStruct[5]= new DataColumn("sup_tel_tel", typeof(string));
                l_dcStruct[6]= new DataColumn("sup_tel_cel", typeof(string));
                ESupervisor.FillFixedFields(ref l_dcStruct, 7);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código
        /// </summary>
        public static string CodCmp
        {
           get {return "sup_cd6_cod";}
        }

        /// <summary>
        /// Código
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["sup_cd6_cod"];}
            set {
                if (value.Trim().Length > 6) value= value.Trim().Substring(0,6);
                InternalData["sup_cd6_cod"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Apellido
        /// </summary>
        public static string ApellidoCmp
        {
           get {return "sup_nom_apellido";}
        }

        /// <summary>
        /// Apellido
        /// </summary>
        public string Apellido
        {
            get {return ((string) InternalData["sup_nom_apellido"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["sup_nom_apellido"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public static string NombreCmp
        {
           get {return "sup_nom_nombre";}
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public string Nombre
        {
            get {return ((string) InternalData["sup_nom_nombre"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["sup_nom_nombre"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Usuario del Sistema
        /// </summary>
        public static string UsuarioCmp
        {
           get {return "sup_nom_usuario";}
        }

        /// <summary>
        /// Usuario del Sistema
        /// </summary>
        public string Usuario
        {
            get {return ((string) InternalData["sup_nom_usuario"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["sup_nom_usuario"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Télefono
        /// </summary>
        public static string TelCmp
        {
           get {return "sup_tel_tel";}
        }

        /// <summary>
        /// Télefono
        /// </summary>
        public string Tel
        {
            get {return ((string) InternalData["sup_tel_tel"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["sup_tel_tel"]= value.Trim();
            }
        }

        /// <summary>
        /// Celular
        /// </summary>
        public static string CelCmp
        {
           get {return "sup_tel_cel";}
        }

        /// <summary>
        /// Celular
        /// </summary>
        public string Cel
        {
            get {return ((string) InternalData["sup_tel_cel"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["sup_tel_cel"]= value.Trim();
            }
        }

        /// <summary>
        /// Nom y Apellido
        /// </summary>
        public string Sup_ede_nya
        {
            get {return (string) InternalData["sup_ede_nya"];}
            set {InternalData["sup_ede_nya"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ESupervisor] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ESupervisor] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ESupervisor", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "sup_cd6_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "sup_nom_apellido", Apellido));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "sup_nom_nombre", Nombre));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "sup_nom_usuario", Usuario));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "sup_tel_tel", Tel));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "sup_tel_cel", Cel));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "sup_ede_nya", Sup_ede_nya));

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

    #region Lista-Entidad: Supervisores
    /// <summary>
    /// Clase que representa la Lista-Entidad: Supervisores
    /// </summary>
    public sealed partial class LESupervisores : ListaEntidades, IEnumerable<ESupervisor>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Supervisores
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LESupervisores(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LESupervisores(string p_strXMLData) :
            base(ESupervisor.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ESupervisor(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LESupervisores(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Supervisores
        /// </summary>
        /// <returns>Lista-Entidad vacia: Supervisores</returns>
        public static LESupervisores NewEmpty()
        {
            return new LESupervisores(ESupervisor.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entESupervisor">Entidad a agregar</param>
        public void AddEntity(ESupervisor p_entESupervisor)
        {
            base.AddEntity(p_entESupervisor);
        }

        /// <summary>
        /// Remueve una entidad [Supervisor] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "sup_cd6_cod = " + Ruts.Co(p_strCod);

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
        /// Verifca si una entidad [Supervisor] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (ESupervisor l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Supervisores
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ESupervisor> GetEnumerator() 
        {
            ESupervisor l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ESupervisor(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Supervisores
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ESupervisor l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Supervisores
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETSupervisores GetAsLET()
        {
            // Llenamos la lista tipada
            LETSupervisores l_lentRet= new LETSupervisores();

            foreach (ESupervisor l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Supervisores>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ESupervisor> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ESupervisor>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Supervisor] por indice
        /// </summary>
        public new ESupervisor this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Supervisor con los datos de la fila
                return new ESupervisor(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Supervisor] por clave
        /// </summary>
        public ESupervisor this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "sup_cd6_cod = " + Ruts.Co(p_strCod);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Supervisor con los datos de la fila
                if (l_drData == null) return null;
                return new ESupervisor(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LESupervisores", null);

                foreach (ESupervisor l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Supervisores
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Supervisores
    /// </summary>
    public sealed partial class LETSupervisores : LET<ESupervisor>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Supervisores
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LESupervisores GetAsLE()
        {
            // Llenamos la lista
            LESupervisores l_lentRet= LESupervisores.NewEmpty();

            foreach (ESupervisor l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Supervisor] por clave
        /// </summary>
        public ESupervisor this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (ESupervisor l_entItem in this) {
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
}
