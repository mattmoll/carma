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
    // Clase para Administrar   : Clientes
    //----------------------------------------------------------------------------
    // © 1996-2020 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    #region Entidad: CliContacto
    /// <summary>
    /// Clase que representa la Entidad: CliContacto
    /// </summary>
    public sealed partial class ECliContacto : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: CliContactos
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ECliContacto(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CliContacto
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ECliContacto(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CliContacto
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ECliContacto(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ECliContacto.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["clc_nro_numcliente"]= XMLRuts.ExtractXAttr(l_xndData, "clc_nro_numcliente", 1);
            l_drTemp["clc_nro_numcontacto"]= XMLRuts.ExtractXAttr(l_xndData, "clc_nro_numcontacto", 1);
            l_drTemp["clc_des_nombre"]= XMLRuts.ExtractXAttr(l_xndData, "clc_des_nombre");
            l_drTemp["clc_des_cargo"]= XMLRuts.ExtractXAttr(l_xndData, "clc_des_cargo");
            l_drTemp["clc_des_titulo"]= XMLRuts.ExtractXAttr(l_xndData, "clc_des_titulo");
            l_drTemp["clc_tel_celular"]= XMLRuts.ExtractXAttr(l_xndData, "clc_tel_celular");
            l_drTemp["clc_tel_telefono1"]= XMLRuts.ExtractXAttr(l_xndData, "clc_tel_telefono1");
            l_drTemp["clc_tel_telefono2"]= XMLRuts.ExtractXAttr(l_xndData, "clc_tel_telefono2");
            l_drTemp["clc_tel_interno"]= XMLRuts.ExtractXAttr(l_xndData, "clc_tel_interno");
            l_drTemp["clc_xld_email"]= XMLRuts.ExtractXAttr(l_xndData, "clc_xld_email");
            l_drTemp["clc_des_secretaria"]= XMLRuts.ExtractXAttr(l_xndData, "clc_des_secretaria");
            l_drTemp["clc_cd1_activo"]= XMLRuts.ExtractXAttr(l_xndData, "clc_cd1_activo");
            l_drTemp["clc_des_rsocial"]= XMLRuts.ExtractXAttr(l_xndData, "clc_des_rsocial");

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
        private ECliContacto(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: CliContacto
        /// </summary>
        /// <returns>Entidad vacia: CliContacto</returns>
        public static ECliContacto NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliContacto.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["clc_nro_numcliente"]= 1;
            l_drTemp["clc_nro_numcontacto"]= 1;
            l_drTemp["clc_des_nombre"]= "";
            l_drTemp["clc_des_cargo"]= "";
            l_drTemp["clc_des_titulo"]= "";
            l_drTemp["clc_tel_celular"]= "";
            l_drTemp["clc_tel_telefono1"]= "";
            l_drTemp["clc_tel_telefono2"]= "";
            l_drTemp["clc_tel_interno"]= "";
            l_drTemp["clc_xld_email"]= "";
            l_drTemp["clc_des_secretaria"]= "";
            l_drTemp["clc_cd1_activo"]= "";
            l_drTemp["clc_des_rsocial"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliContacto l_entRet= new ECliContacto(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: CliContacto
        /// </summary>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_strNombre">Apellido y Nombre</param>
        /// <param name="p_strCargo">Cargo</param>
        /// <param name="p_strTitulo">Título</param>
        /// <param name="p_strCelular">Celular</param>
        /// <param name="p_strTelefono1">Teléfono 1</param>
        /// <param name="p_strTelefono2">Teléfono 2</param>
        /// <param name="p_strInterno">Interno</param>
        /// <param name="p_strEmail">Email</param>
        /// <param name="p_strSecretaria">Secretaria</param>
        /// <returns>Entidad: CliContacto</returns>
        public static ECliContacto NewFilled(int p_iNumcliente,
                                             int p_iNumcontacto,
                                             string p_strNombre,
                                             string p_strCargo,
                                             string p_strTitulo,
                                             string p_strCelular,
                                             string p_strTelefono1,
                                             string p_strTelefono2,
                                             string p_strInterno,
                                             string p_strEmail,
                                             string p_strSecretaria)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliContacto.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["clc_nro_numcliente"]= p_iNumcliente;
            l_drTemp["clc_nro_numcontacto"]= p_iNumcontacto;
            l_drTemp["clc_des_nombre"]= p_strNombre;
            l_drTemp["clc_des_cargo"]= p_strCargo;
            l_drTemp["clc_des_titulo"]= p_strTitulo;
            l_drTemp["clc_tel_celular"]= p_strCelular;
            l_drTemp["clc_tel_telefono1"]= p_strTelefono1;
            l_drTemp["clc_tel_telefono2"]= p_strTelefono2;
            l_drTemp["clc_tel_interno"]= p_strInterno;
            l_drTemp["clc_xld_email"]= p_strEmail;
            l_drTemp["clc_des_secretaria"]= p_strSecretaria;
            l_drTemp["clc_cd1_activo"]= "";
            l_drTemp["clc_des_rsocial"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliContacto l_entRet= new ECliContacto(l_dtTemp);
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
                DataColumn[] l_dcStruct= new DataColumn[17];

                l_dcStruct[0]= new DataColumn("clc_nro_numcliente", typeof(int));
                l_dcStruct[1]= new DataColumn("clc_des_rsocial", typeof(string));
                l_dcStruct[2]= new DataColumn("clc_nro_numcontacto", typeof(int));
                l_dcStruct[3]= new DataColumn("clc_des_nombre", typeof(string));
                l_dcStruct[4]= new DataColumn("clc_des_cargo", typeof(string));
                l_dcStruct[5]= new DataColumn("clc_des_titulo", typeof(string));
                l_dcStruct[6]= new DataColumn("clc_cd1_activo", typeof(string));
                l_dcStruct[7]= new DataColumn("clc_tel_celular", typeof(string));
                l_dcStruct[8]= new DataColumn("clc_tel_telefono1", typeof(string));
                l_dcStruct[9]= new DataColumn("clc_tel_telefono2", typeof(string));
                l_dcStruct[10]= new DataColumn("clc_tel_interno", typeof(string));
                l_dcStruct[11]= new DataColumn("clc_xld_email", typeof(string));
                l_dcStruct[12]= new DataColumn("clc_des_secretaria", typeof(string));
                ECliContacto.FillFixedFields(ref l_dcStruct, 13);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Número de cliente
        /// </summary>
        public static string NumclienteCmp
        {
           get {return "clc_nro_numcliente";}
        }

        /// <summary>
        /// Número de cliente
        /// </summary>
        public int Numcliente
        {
            get {return (int) InternalData["clc_nro_numcliente"];}
            set {InternalData["clc_nro_numcliente"]= value;}
        }

        /// <summary>
        /// Número
        /// </summary>
        public static string NumcontactoCmp
        {
           get {return "clc_nro_numcontacto";}
        }

        /// <summary>
        /// Número
        /// </summary>
        public int Numcontacto
        {
            get {return (int) InternalData["clc_nro_numcontacto"];}
            set {InternalData["clc_nro_numcontacto"]= value;}
        }

        /// <summary>
        /// Apellido y Nombre
        /// </summary>
        public static string NombreCmp
        {
           get {return "clc_des_nombre";}
        }

        /// <summary>
        /// Apellido y Nombre
        /// </summary>
        public string Nombre
        {
            get {return ((string) InternalData["clc_des_nombre"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["clc_des_nombre"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Cargo
        /// </summary>
        public static string CargoCmp
        {
           get {return "clc_des_cargo";}
        }

        /// <summary>
        /// Cargo
        /// </summary>
        public string Cargo
        {
            get {return ((string) InternalData["clc_des_cargo"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["clc_des_cargo"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Título
        /// </summary>
        public static string TituloCmp
        {
           get {return "clc_des_titulo";}
        }

        /// <summary>
        /// Título
        /// </summary>
        public string Titulo
        {
            get {return ((string) InternalData["clc_des_titulo"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["clc_des_titulo"]= value.Trim();
            }
        }

        /// <summary>
        /// Celular
        /// </summary>
        public static string CelularCmp
        {
           get {return "clc_tel_celular";}
        }

        /// <summary>
        /// Celular
        /// </summary>
        public string Celular
        {
            get {return ((string) InternalData["clc_tel_celular"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["clc_tel_celular"]= value.Trim();
            }
        }

        /// <summary>
        /// Teléfono 1
        /// </summary>
        public static string Telefono1Cmp
        {
           get {return "clc_tel_telefono1";}
        }

        /// <summary>
        /// Teléfono 1
        /// </summary>
        public string Telefono1
        {
            get {return ((string) InternalData["clc_tel_telefono1"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["clc_tel_telefono1"]= value.Trim();
            }
        }

        /// <summary>
        /// Teléfono 2
        /// </summary>
        public static string Telefono2Cmp
        {
           get {return "clc_tel_telefono2";}
        }

        /// <summary>
        /// Teléfono 2
        /// </summary>
        public string Telefono2
        {
            get {return ((string) InternalData["clc_tel_telefono2"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["clc_tel_telefono2"]= value.Trim();
            }
        }

        /// <summary>
        /// Interno
        /// </summary>
        public static string InternoCmp
        {
           get {return "clc_tel_interno";}
        }

        /// <summary>
        /// Interno
        /// </summary>
        public string Interno
        {
            get {return ((string) InternalData["clc_tel_interno"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["clc_tel_interno"]= value.Trim();
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        public static string EmailCmp
        {
           get {return "clc_xld_email";}
        }

        /// <summary>
        /// Email
        /// </summary>
        public string Email
        {
            get {return ((string) InternalData["clc_xld_email"]).Trim();}
            set {
                if (value.Trim().Length > 240) value= value.Trim().Substring(0,240);
                InternalData["clc_xld_email"]= value.Trim();
            }
        }

        /// <summary>
        /// Secretaria
        /// </summary>
        public static string SecretariaCmp
        {
           get {return "clc_des_secretaria";}
        }

        /// <summary>
        /// Secretaria
        /// </summary>
        public string Secretaria
        {
            get {return ((string) InternalData["clc_des_secretaria"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["clc_des_secretaria"]= value.Trim();
            }
        }

        /// <summary>
        /// Activo
        /// </summary>
        public string Clc_cd1_activo
        {
            get {return (string) InternalData["clc_cd1_activo"];}
            set {InternalData["clc_cd1_activo"]= value;}
        }

        /// <summary>
        /// Razon Social
        /// </summary>
        public string Clc_des_rsocial
        {
            get {return (string) InternalData["clc_des_rsocial"];}
            set {InternalData["clc_des_rsocial"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliContacto] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliContacto] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ECliContacto", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clc_nro_numcliente", Numcliente));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clc_nro_numcontacto", Numcontacto));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clc_des_nombre", Nombre));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clc_des_cargo", Cargo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clc_des_titulo", Titulo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clc_tel_celular", Celular));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clc_tel_telefono1", Telefono1));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clc_tel_telefono2", Telefono2));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clc_tel_interno", Interno));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clc_xld_email", Email));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clc_des_secretaria", Secretaria));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clc_cd1_activo", Clc_cd1_activo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clc_des_rsocial", Clc_des_rsocial));

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

    #region Lista-Entidad: CliContactos
    /// <summary>
    /// Clase que representa la Lista-Entidad: CliContactos
    /// </summary>
    public sealed partial class LECliContactos : ListaEntidades, IEnumerable<ECliContacto>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: CliContactos
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECliContactos(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECliContactos(string p_strXMLData) :
            base(ECliContacto.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ECliContacto(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LECliContactos(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: CliContactos
        /// </summary>
        /// <returns>Lista-Entidad vacia: CliContactos</returns>
        public static LECliContactos NewEmpty()
        {
            return new LECliContactos(ECliContacto.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entECliContacto">Entidad a agregar</param>
        public void AddEntity(ECliContacto p_entECliContacto)
        {
            base.AddEntity(p_entECliContacto);
        }

        /// <summary>
        /// Remueve una entidad [CliContacto] por clave
        /// </summary>
        public int RemoveEntity(int p_iNumcliente,
                                int p_iNumcontacto)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "clc_nro_numcliente = " + Ruts.Nu(p_iNumcliente) + " and " + 
                "clc_nro_numcontacto = " + Ruts.Nu(p_iNumcontacto);

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
        /// Verifca si una entidad [CliContacto] esta en la lista
        /// </summary>
        public bool Contains(int p_iNumcliente,
                             int p_iNumcontacto)
        {
            using (ECliContacto l_entTemp= this[p_iNumcliente,
                                                p_iNumcontacto])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: CliContactos
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ECliContacto> GetEnumerator() 
        {
            ECliContacto l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ECliContacto(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: CliContactos
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ECliContacto l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: CliContactos
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETCliContactos GetAsLET()
        {
            // Llenamos la lista tipada
            LETCliContactos l_lentRet= new LETCliContactos();

            foreach (ECliContacto l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<CliContactos>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ECliContacto> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ECliContacto>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CliContacto] por indice
        /// </summary>
        public new ECliContacto this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad CliContacto con los datos de la fila
                return new ECliContacto(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [CliContacto] por clave
        /// </summary>
        public ECliContacto this[int p_iNumcliente,
                                 int p_iNumcontacto]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "clc_nro_numcliente = " + Ruts.Nu(p_iNumcliente) + " and " + 
                    "clc_nro_numcontacto = " + Ruts.Nu(p_iNumcontacto);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad CliContacto con los datos de la fila
                if (l_drData == null) return null;
                return new ECliContacto(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LECliContactos", null);

                foreach (ECliContacto l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: CliContactos
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: CliContactos
    /// </summary>
    public sealed partial class LETCliContactos : LET<ECliContacto>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: CliContactos
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LECliContactos GetAsLE()
        {
            // Llenamos la lista
            LECliContactos l_lentRet= LECliContactos.NewEmpty();

            foreach (ECliContacto l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CliContacto] por clave
        /// </summary>
        public ECliContacto this[int p_iNumcliente,
                                 int p_iNumcontacto]
        {
            get {
                // Buscamos la entidad
                foreach (ECliContacto l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Numcliente == p_iNumcliente) &&
                        (l_entItem.Numcontacto == p_iNumcontacto))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: CliEntrevista
    /// <summary>
    /// Clase que representa la Entidad: CliEntrevista
    /// </summary>
    public sealed partial class ECliEntrevista : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: CliEntrevistas
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ECliEntrevista(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CliEntrevista
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ECliEntrevista(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CliEntrevista
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ECliEntrevista(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ECliEntrevista.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cle_nro_numcliente"]= XMLRuts.ExtractXAttr(l_xndData, "cle_nro_numcliente", 1);
            l_drTemp["cle_nro_numentrev"]= XMLRuts.ExtractXAttr(l_xndData, "cle_nro_numentrev", 1);
            l_drTemp["cle_fyh_fcoordinada"]= XMLRuts.ExtractXAttr(l_xndData, "cle_fyh_fcoordinada", true);
            l_drTemp["cle_fyh_frealizada"]= XMLRuts.ExtractXAttr(l_xndData, "cle_fyh_frealizada", true);
            l_drTemp["cle_cd6_codvend"]= XMLRuts.ExtractXAttr(l_xndData, "cle_cd6_codvend");
            l_drTemp["cle_ede_motcambiof"]= XMLRuts.ExtractXAttr(l_xndData, "cle_ede_motcambiof");
            l_drTemp["cle_des_nombre"]= XMLRuts.ExtractXAttr(l_xndData, "cle_des_nombre");
            l_drTemp["cle_tel_telefono"]= XMLRuts.ExtractXAttr(l_xndData, "cle_tel_telefono");
            l_drTemp["cle_des_cargo"]= XMLRuts.ExtractXAttr(l_xndData, "cle_des_cargo");
            l_drTemp["cle_des_titulo"]= XMLRuts.ExtractXAttr(l_xndData, "cle_des_titulo");
            l_drTemp["cle_tel_celular"]= XMLRuts.ExtractXAttr(l_xndData, "cle_tel_celular");
            l_drTemp["cle_xld_email"]= XMLRuts.ExtractXAttr(l_xndData, "cle_xld_email");
            l_drTemp["cle_xld_direccion"]= XMLRuts.ExtractXAttr(l_xndData, "cle_xld_direccion");
            l_drTemp["cle_txt_observaciones"]= XMLRuts.ExtractXAttr(l_xndData, "cle_txt_observaciones");
            l_drTemp["cle_rcd_codresultado"]= XMLRuts.ExtractXAttr(l_xndData, "cle_rcd_codresultado");
            l_drTemp["cle_ede_informe"]= XMLRuts.ExtractXAttr(l_xndData, "cle_ede_informe");
            l_drTemp["cle_des_secretaria"]= XMLRuts.ExtractXAttr(l_xndData, "cle_des_secretaria");
            l_drTemp["cle_cd1_borrada"]= XMLRuts.ExtractXAttr(l_xndData, "cle_cd1_borrada");
            l_drTemp["cle_cd1_pend"]= XMLRuts.ExtractXAttr(l_xndData, "cle_cd1_pend");
            l_drTemp["cle_des_rsocial"]= XMLRuts.ExtractXAttr(l_xndData, "cle_des_rsocial");
            l_drTemp["cle_des_vend"]= XMLRuts.ExtractXAttr(l_xndData, "cle_des_vend");

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
        private ECliEntrevista(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: CliEntrevista
        /// </summary>
        /// <returns>Entidad vacia: CliEntrevista</returns>
        public static ECliEntrevista NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliEntrevista.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cle_nro_numcliente"]= 1;
            l_drTemp["cle_nro_numentrev"]= 1;
            l_drTemp["cle_fyh_fcoordinada"]= DateTimeRuts.Empty;
            l_drTemp["cle_fyh_frealizada"]= DateTimeRuts.Empty;
            l_drTemp["cle_cd6_codvend"]= "";
            l_drTemp["cle_ede_motcambiof"]= "";
            l_drTemp["cle_des_nombre"]= "";
            l_drTemp["cle_tel_telefono"]= "";
            l_drTemp["cle_des_cargo"]= "";
            l_drTemp["cle_des_titulo"]= "";
            l_drTemp["cle_tel_celular"]= "";
            l_drTemp["cle_xld_email"]= "";
            l_drTemp["cle_xld_direccion"]= "";
            l_drTemp["cle_txt_observaciones"]= "";
            l_drTemp["cle_rcd_codresultado"]= "";
            l_drTemp["cle_ede_informe"]= "";
            l_drTemp["cle_des_secretaria"]= "";
            l_drTemp["cle_cd1_borrada"]= "";
            l_drTemp["cle_cd1_pend"]= "";
            l_drTemp["cle_des_rsocial"]= "";
            l_drTemp["cle_des_vend"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliEntrevista l_entRet= new ECliEntrevista(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: CliEntrevista
        /// </summary>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumentrev">Número</param>
        /// <param name="p_dtFcoordinada">Fecha coordinada</param>
        /// <param name="p_dtFrealizada">Fecha realizada</param>
        /// <param name="p_strCodvend">Código de Vendedor</param>
        /// <param name="p_strMotcambiof">Motivo cambio fecha</param>
        /// <param name="p_strNombre">Nombre</param>
        /// <param name="p_strTelefono">Teléfono</param>
        /// <param name="p_strCargo">Cargo</param>
        /// <param name="p_strTitulo">Título</param>
        /// <param name="p_strCelular">Celular</param>
        /// <param name="p_strEmail">Email</param>
        /// <param name="p_strDireccion">Dirección</param>
        /// <param name="p_strObservaciones">Observaciones</param>
        /// <param name="p_strCodresultado">Código de resultado</param>
        /// <param name="p_strInforme">Informe</param>
        /// <param name="p_strSecretaria">Secretaria</param>
        /// <returns>Entidad: CliEntrevista</returns>
        public static ECliEntrevista NewFilled(int p_iNumcliente,
                                               int p_iNumentrev,
                                               DateTime p_dtFcoordinada,
                                               DateTime p_dtFrealizada,
                                               string p_strCodvend,
                                               string p_strMotcambiof,
                                               string p_strNombre,
                                               string p_strTelefono,
                                               string p_strCargo,
                                               string p_strTitulo,
                                               string p_strCelular,
                                               string p_strEmail,
                                               string p_strDireccion,
                                               string p_strObservaciones,
                                               string p_strCodresultado,
                                               string p_strInforme,
                                               string p_strSecretaria)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliEntrevista.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cle_nro_numcliente"]= p_iNumcliente;
            l_drTemp["cle_nro_numentrev"]= p_iNumentrev;
            l_drTemp["cle_fyh_fcoordinada"]= p_dtFcoordinada;
            l_drTemp["cle_fyh_frealizada"]= p_dtFrealizada;
            l_drTemp["cle_cd6_codvend"]= p_strCodvend;
            l_drTemp["cle_ede_motcambiof"]= p_strMotcambiof;
            l_drTemp["cle_des_nombre"]= p_strNombre;
            l_drTemp["cle_tel_telefono"]= p_strTelefono;
            l_drTemp["cle_des_cargo"]= p_strCargo;
            l_drTemp["cle_des_titulo"]= p_strTitulo;
            l_drTemp["cle_tel_celular"]= p_strCelular;
            l_drTemp["cle_xld_email"]= p_strEmail;
            l_drTemp["cle_xld_direccion"]= p_strDireccion;
            l_drTemp["cle_txt_observaciones"]= p_strObservaciones;
            l_drTemp["cle_rcd_codresultado"]= p_strCodresultado;
            l_drTemp["cle_ede_informe"]= p_strInforme;
            l_drTemp["cle_des_secretaria"]= p_strSecretaria;
            l_drTemp["cle_cd1_borrada"]= "";
            l_drTemp["cle_cd1_pend"]= "";
            l_drTemp["cle_des_rsocial"]= "";
            l_drTemp["cle_des_vend"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliEntrevista l_entRet= new ECliEntrevista(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Código de resultado
        /// </summary>
        public static string FrmtCodresultado(string p_strCodresultado)
        {
            if (p_strCodresultado.Trim().Length > 2)
                p_strCodresultado= p_strCodresultado.Trim().Substring(0,2);

            return p_strCodresultado.Trim().PadLeft(2).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[25];

                l_dcStruct[0]= new DataColumn("cle_nro_numcliente", typeof(int));
                l_dcStruct[1]= new DataColumn("cle_nro_numentrev", typeof(int));
                l_dcStruct[2]= new DataColumn("cle_cd1_pend", typeof(string));
                l_dcStruct[3]= new DataColumn("cle_des_rsocial", typeof(string));
                l_dcStruct[4]= new DataColumn("cle_fyh_fcoordinada", typeof(DateTime));
                l_dcStruct[5]= new DataColumn("cle_fyh_frealizada", typeof(DateTime));
                l_dcStruct[6]= new DataColumn("cle_cd6_codvend", typeof(string));
                l_dcStruct[7]= new DataColumn("cle_des_vend", typeof(string));
                l_dcStruct[8]= new DataColumn("cle_ede_motcambiof", typeof(string));
                l_dcStruct[9]= new DataColumn("cle_des_nombre", typeof(string));
                l_dcStruct[10]= new DataColumn("cle_cd1_borrada", typeof(string));
                l_dcStruct[11]= new DataColumn("cle_tel_telefono", typeof(string));
                l_dcStruct[12]= new DataColumn("cle_des_cargo", typeof(string));
                l_dcStruct[13]= new DataColumn("cle_des_titulo", typeof(string));
                l_dcStruct[14]= new DataColumn("cle_tel_celular", typeof(string));
                l_dcStruct[15]= new DataColumn("cle_xld_email", typeof(string));
                l_dcStruct[16]= new DataColumn("cle_xld_direccion", typeof(string));
                l_dcStruct[17]= new DataColumn("cle_txt_observaciones", typeof(string));
                l_dcStruct[18]= new DataColumn("cle_rcd_codresultado", typeof(string));
                l_dcStruct[19]= new DataColumn("cle_ede_informe", typeof(string));
                l_dcStruct[20]= new DataColumn("cle_des_secretaria", typeof(string));
                ECliEntrevista.FillFixedFields(ref l_dcStruct, 21);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Número de cliente
        /// </summary>
        public static string NumclienteCmp
        {
           get {return "cle_nro_numcliente";}
        }

        /// <summary>
        /// Número de cliente
        /// </summary>
        public int Numcliente
        {
            get {return (int) InternalData["cle_nro_numcliente"];}
            set {InternalData["cle_nro_numcliente"]= value;}
        }

        /// <summary>
        /// Número
        /// </summary>
        public static string NumentrevCmp
        {
           get {return "cle_nro_numentrev";}
        }

        /// <summary>
        /// Número
        /// </summary>
        public int Numentrev
        {
            get {return (int) InternalData["cle_nro_numentrev"];}
            set {InternalData["cle_nro_numentrev"]= value;}
        }

        /// <summary>
        /// Fecha coordinada
        /// </summary>
        public static string FcoordinadaCmp
        {
           get {return "cle_fyh_fcoordinada";}
        }

        /// <summary>
        /// Fecha coordinada
        /// </summary>
        public DateTime Fcoordinada
        {
            get {return (DateTime) InternalData["cle_fyh_fcoordinada"];}
            set {InternalData["cle_fyh_fcoordinada"]= value;}
        }

        /// <summary>
        /// Fecha realizada
        /// </summary>
        public static string FrealizadaCmp
        {
           get {return "cle_fyh_frealizada";}
        }

        /// <summary>
        /// Fecha realizada
        /// </summary>
        public DateTime Frealizada
        {
            get {return (DateTime) InternalData["cle_fyh_frealizada"];}
            set {InternalData["cle_fyh_frealizada"]= value;}
        }

        /// <summary>
        /// Código de Vendedor
        /// </summary>
        public static string CodvendCmp
        {
           get {return "cle_cd6_codvend";}
        }

        /// <summary>
        /// Código de Vendedor
        /// </summary>
        public string Codvend
        {
            get {return (string) InternalData["cle_cd6_codvend"];}
            set {InternalData["cle_cd6_codvend"]= value;}
        }

        /// <summary>
        /// Motivo cambio fecha
        /// </summary>
        public static string MotcambiofCmp
        {
           get {return "cle_ede_motcambiof";}
        }

        /// <summary>
        /// Motivo cambio fecha
        /// </summary>
        public string Motcambiof
        {
            get {return ((string) InternalData["cle_ede_motcambiof"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["cle_ede_motcambiof"]= value.Trim();
            }
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public static string NombreCmp
        {
           get {return "cle_des_nombre";}
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public string Nombre
        {
            get {return ((string) InternalData["cle_des_nombre"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cle_des_nombre"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Teléfono
        /// </summary>
        public static string TelefonoCmp
        {
           get {return "cle_tel_telefono";}
        }

        /// <summary>
        /// Teléfono
        /// </summary>
        public string Telefono
        {
            get {return ((string) InternalData["cle_tel_telefono"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cle_tel_telefono"]= value.Trim();
            }
        }

        /// <summary>
        /// Cargo
        /// </summary>
        public static string CargoCmp
        {
           get {return "cle_des_cargo";}
        }

        /// <summary>
        /// Cargo
        /// </summary>
        public string Cargo
        {
            get {return ((string) InternalData["cle_des_cargo"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cle_des_cargo"]= value.Trim();
            }
        }

        /// <summary>
        /// Título
        /// </summary>
        public static string TituloCmp
        {
           get {return "cle_des_titulo";}
        }

        /// <summary>
        /// Título
        /// </summary>
        public string Titulo
        {
            get {return ((string) InternalData["cle_des_titulo"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cle_des_titulo"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Celular
        /// </summary>
        public static string CelularCmp
        {
           get {return "cle_tel_celular";}
        }

        /// <summary>
        /// Celular
        /// </summary>
        public string Celular
        {
            get {return ((string) InternalData["cle_tel_celular"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cle_tel_celular"]= value.Trim();
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        public static string EmailCmp
        {
           get {return "cle_xld_email";}
        }

        /// <summary>
        /// Email
        /// </summary>
        public string Email
        {
            get {return ((string) InternalData["cle_xld_email"]).Trim();}
            set {
                if (value.Trim().Length > 240) value= value.Trim().Substring(0,240);
                InternalData["cle_xld_email"]= value.Trim();
            }
        }

        /// <summary>
        /// Dirección
        /// </summary>
        public static string DireccionCmp
        {
           get {return "cle_xld_direccion";}
        }

        /// <summary>
        /// Dirección
        /// </summary>
        public string Direccion
        {
            get {return ((string) InternalData["cle_xld_direccion"]).Trim();}
            set {
                if (value.Trim().Length > 240) value= value.Trim().Substring(0,240);
                InternalData["cle_xld_direccion"]= value.Trim();
            }
        }

        /// <summary>
        /// Observaciones
        /// </summary>
        public static string ObservacionesCmp
        {
           get {return "cle_txt_observaciones";}
        }

        /// <summary>
        /// Observaciones
        /// </summary>
        public string Observaciones
        {
            get {return (string) InternalData["cle_txt_observaciones"];}
            set {InternalData["cle_txt_observaciones"]= value;}
        }

        /// <summary>
        /// Código de resultado
        /// </summary>
        public static string CodresultadoCmp
        {
           get {return "cle_rcd_codresultado";}
        }

        /// <summary>
        /// Código de resultado
        /// </summary>
        public string Codresultado
        {
            get {return (string) InternalData["cle_rcd_codresultado"];}
            set {InternalData["cle_rcd_codresultado"]= ECliEntrevista.FrmtCodresultado(value);}
        }

        /// <summary>
        /// Informe
        /// </summary>
        public static string InformeCmp
        {
           get {return "cle_ede_informe";}
        }

        /// <summary>
        /// Informe
        /// </summary>
        public string Informe
        {
            get {return ((string) InternalData["cle_ede_informe"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["cle_ede_informe"]= value.Trim();
            }
        }

        /// <summary>
        /// Secretaria
        /// </summary>
        public static string SecretariaCmp
        {
           get {return "cle_des_secretaria";}
        }

        /// <summary>
        /// Secretaria
        /// </summary>
        public string Secretaria
        {
            get {return ((string) InternalData["cle_des_secretaria"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cle_des_secretaria"]= value.Trim();
            }
        }

        /// <summary>
        /// Borrada
        /// </summary>
        public string Cle_cd1_borrada
        {
            get {return (string) InternalData["cle_cd1_borrada"];}
            set {InternalData["cle_cd1_borrada"]= value;}
        }

        /// <summary>
        /// Pendiente
        /// </summary>
        public string Cle_cd1_pend
        {
            get {return (string) InternalData["cle_cd1_pend"];}
            set {InternalData["cle_cd1_pend"]= value;}
        }

        /// <summary>
        /// Razon social
        /// </summary>
        public string Cle_des_rsocial
        {
            get {return (string) InternalData["cle_des_rsocial"];}
            set {InternalData["cle_des_rsocial"]= value;}
        }

        /// <summary>
        /// Vendedor
        /// </summary>
        public string Cle_des_vend
        {
            get {return (string) InternalData["cle_des_vend"];}
            set {InternalData["cle_des_vend"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliEntrevista] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliEntrevista] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ECliEntrevista", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_nro_numcliente", Numcliente));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_nro_numentrev", Numentrev));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_fyh_fcoordinada", Fcoordinada));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_fyh_frealizada", Frealizada));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_cd6_codvend", Codvend));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_ede_motcambiof", Motcambiof));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_des_nombre", Nombre));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_tel_telefono", Telefono));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_des_cargo", Cargo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_des_titulo", Titulo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_tel_celular", Celular));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_xld_email", Email));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_xld_direccion", Direccion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_txt_observaciones", Observaciones));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_rcd_codresultado", Codresultado));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_ede_informe", Informe));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_des_secretaria", Secretaria));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_cd1_borrada", Cle_cd1_borrada));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_cd1_pend", Cle_cd1_pend));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_des_rsocial", Cle_des_rsocial));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cle_des_vend", Cle_des_vend));

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

    #region Lista-Entidad: CliEntrevistas
    /// <summary>
    /// Clase que representa la Lista-Entidad: CliEntrevistas
    /// </summary>
    public sealed partial class LECliEntrevistas : ListaEntidades, IEnumerable<ECliEntrevista>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: CliEntrevistas
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECliEntrevistas(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECliEntrevistas(string p_strXMLData) :
            base(ECliEntrevista.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ECliEntrevista(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LECliEntrevistas(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: CliEntrevistas
        /// </summary>
        /// <returns>Lista-Entidad vacia: CliEntrevistas</returns>
        public static LECliEntrevistas NewEmpty()
        {
            return new LECliEntrevistas(ECliEntrevista.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entECliEntrevista">Entidad a agregar</param>
        public void AddEntity(ECliEntrevista p_entECliEntrevista)
        {
            base.AddEntity(p_entECliEntrevista);
        }

        /// <summary>
        /// Remueve una entidad [CliEntrevista] por clave
        /// </summary>
        public int RemoveEntity(int p_iNumcliente,
                                int p_iNumentrev)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "cle_nro_numcliente = " + Ruts.Nu(p_iNumcliente) + " and " + 
                "cle_nro_numentrev = " + Ruts.Nu(p_iNumentrev);

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
        /// Verifca si una entidad [CliEntrevista] esta en la lista
        /// </summary>
        public bool Contains(int p_iNumcliente,
                             int p_iNumentrev)
        {
            using (ECliEntrevista l_entTemp= this[p_iNumcliente,
                                                  p_iNumentrev])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: CliEntrevistas
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ECliEntrevista> GetEnumerator() 
        {
            ECliEntrevista l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ECliEntrevista(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: CliEntrevistas
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ECliEntrevista l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: CliEntrevistas
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETCliEntrevistas GetAsLET()
        {
            // Llenamos la lista tipada
            LETCliEntrevistas l_lentRet= new LETCliEntrevistas();

            foreach (ECliEntrevista l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<CliEntrevistas>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ECliEntrevista> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ECliEntrevista>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CliEntrevista] por indice
        /// </summary>
        public new ECliEntrevista this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad CliEntrevista con los datos de la fila
                return new ECliEntrevista(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [CliEntrevista] por clave
        /// </summary>
        public ECliEntrevista this[int p_iNumcliente,
                                   int p_iNumentrev]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "cle_nro_numcliente = " + Ruts.Nu(p_iNumcliente) + " and " + 
                    "cle_nro_numentrev = " + Ruts.Nu(p_iNumentrev);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad CliEntrevista con los datos de la fila
                if (l_drData == null) return null;
                return new ECliEntrevista(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LECliEntrevistas", null);

                foreach (ECliEntrevista l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: CliEntrevistas
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: CliEntrevistas
    /// </summary>
    public sealed partial class LETCliEntrevistas : LET<ECliEntrevista>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: CliEntrevistas
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LECliEntrevistas GetAsLE()
        {
            // Llenamos la lista
            LECliEntrevistas l_lentRet= LECliEntrevistas.NewEmpty();

            foreach (ECliEntrevista l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CliEntrevista] por clave
        /// </summary>
        public ECliEntrevista this[int p_iNumcliente,
                                   int p_iNumentrev]
        {
            get {
                // Buscamos la entidad
                foreach (ECliEntrevista l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Numcliente == p_iNumcliente) &&
                        (l_entItem.Numentrev == p_iNumentrev))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: CliLlamada
    /// <summary>
    /// Clase que representa la Entidad: CliLlamada
    /// </summary>
    public sealed partial class ECliLlamada : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: CliLlamadas
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ECliLlamada(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CliLlamada
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ECliLlamada(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CliLlamada
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ECliLlamada(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ECliLlamada.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cll_nro_numcliente"]= XMLRuts.ExtractXAttr(l_xndData, "cll_nro_numcliente", 1);
            l_drTemp["cll_nro_numllamada"]= XMLRuts.ExtractXAttr(l_xndData, "cll_nro_numllamada", 1);
            l_drTemp["cll_cod_codmotivo"]= XMLRuts.ExtractXAttr(l_xndData, "cll_cod_codmotivo");
            l_drTemp["cll_fyh_frealizada"]= XMLRuts.ExtractXAttr(l_xndData, "cll_fyh_frealizada", true);
            l_drTemp["cll_txt_resultado"]= XMLRuts.ExtractXAttr(l_xndData, "cll_txt_resultado");
            l_drTemp["cll_nom_codusuario"]= XMLRuts.ExtractXAttr(l_xndData, "cll_nom_codusuario");
            l_drTemp["cll_cd1_baja"]= XMLRuts.ExtractXAttr(l_xndData, "cll_cd1_baja");
            l_drTemp["cll_nro_numcontacto"]= XMLRuts.ExtractXAttr(l_xndData, "cll_nro_numcontacto", 1);
            l_drTemp["cll_txt_obsprogramada"]= XMLRuts.ExtractXAttr(l_xndData, "cll_txt_obsprogramada");
            l_drTemp["cll_imp_abonoanterior"]= XMLRuts.ExtractXAttr(l_xndData, "cll_imp_abonoanterior", (decimal) 0);
            l_drTemp["cll_imp_abonorecuperado"]= XMLRuts.ExtractXAttr(l_xndData, "cll_imp_abonorecuperado", (decimal) 0);
            l_drTemp["cll_nom_programador"]= XMLRuts.ExtractXAttr(l_xndData, "cll_nom_programador");
            l_drTemp["cll_imp_ajuste"]= XMLRuts.ExtractXAttr(l_xndData, "cll_imp_ajuste", (decimal) 0);
            l_drTemp["cll_des_motivo"]= XMLRuts.ExtractXAttr(l_xndData, "cll_des_motivo");
            l_drTemp["cll_ede_rsocial"]= XMLRuts.ExtractXAttr(l_xndData, "cll_ede_rsocial");
            l_drTemp["cll_nom_contac"]= XMLRuts.ExtractXAttr(l_xndData, "cll_nom_contac");

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
        private ECliLlamada(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: CliLlamada
        /// </summary>
        /// <returns>Entidad vacia: CliLlamada</returns>
        public static ECliLlamada NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliLlamada.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cll_nro_numcliente"]= 1;
            l_drTemp["cll_nro_numllamada"]= 1;
            l_drTemp["cll_cod_codmotivo"]= "";
            l_drTemp["cll_fyh_frealizada"]= DateTimeRuts.Empty;
            l_drTemp["cll_txt_resultado"]= "";
            l_drTemp["cll_nom_codusuario"]= "";
            l_drTemp["cll_cd1_baja"]= "";
            l_drTemp["cll_nro_numcontacto"]= 1;
            l_drTemp["cll_txt_obsprogramada"]= "";
            l_drTemp["cll_imp_abonoanterior"]= 0;
            l_drTemp["cll_imp_abonorecuperado"]= 0;
            l_drTemp["cll_nom_programador"]= "";
            l_drTemp["cll_imp_ajuste"]= 0;
            l_drTemp["cll_des_motivo"]= "";
            l_drTemp["cll_ede_rsocial"]= "";
            l_drTemp["cll_nom_contac"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliLlamada l_entRet= new ECliLlamada(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: CliLlamada
        /// </summary>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_strCodmotivo">Código de motivo</param>
        /// <param name="p_dtFrealizada">Fecha Realizada</param>
        /// <param name="p_strResultado">Resultado</param>
        /// <param name="p_strCodusuario">Código del usuario</param>
        /// <param name="p_strBaja">Produjo Baja</param>
        /// <param name="p_iNumcontacto">Número de contacto</param>
        /// <param name="p_strObsprogramada">Observación</param>
        /// <param name="p_dcAbonoanterior">Abono Anterior</param>
        /// <param name="p_dcAbonorecuperado">Abono Recuperador</param>
        /// <param name="p_strProgramador">Usuario Programador</param>
        /// <param name="p_dcAjuste">Ajuste</param>
        /// <returns>Entidad: CliLlamada</returns>
        public static ECliLlamada NewFilled(int p_iNumcliente,
                                            int p_iNumllamada,
                                            string p_strCodmotivo,
                                            DateTime p_dtFrealizada,
                                            string p_strResultado,
                                            string p_strCodusuario,
                                            string p_strBaja,
                                            int p_iNumcontacto,
                                            string p_strObsprogramada,
                                            decimal p_dcAbonoanterior,
                                            decimal p_dcAbonorecuperado,
                                            string p_strProgramador,
                                            decimal p_dcAjuste)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliLlamada.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cll_nro_numcliente"]= p_iNumcliente;
            l_drTemp["cll_nro_numllamada"]= p_iNumllamada;
            l_drTemp["cll_cod_codmotivo"]= p_strCodmotivo;
            l_drTemp["cll_fyh_frealizada"]= p_dtFrealizada;
            l_drTemp["cll_txt_resultado"]= p_strResultado;
            l_drTemp["cll_nom_codusuario"]= p_strCodusuario;
            l_drTemp["cll_cd1_baja"]= p_strBaja;
            l_drTemp["cll_nro_numcontacto"]= p_iNumcontacto;
            l_drTemp["cll_txt_obsprogramada"]= p_strObsprogramada;
            l_drTemp["cll_imp_abonoanterior"]= p_dcAbonoanterior;
            l_drTemp["cll_imp_abonorecuperado"]= p_dcAbonorecuperado;
            l_drTemp["cll_nom_programador"]= p_strProgramador;
            l_drTemp["cll_imp_ajuste"]= p_dcAjuste;
            l_drTemp["cll_des_motivo"]= "";
            l_drTemp["cll_ede_rsocial"]= "";
            l_drTemp["cll_nom_contac"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliLlamada l_entRet= new ECliLlamada(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Código de motivo
        /// </summary>
        public static string FrmtCodmotivo(string p_strCodmotivo)
        {
            if (p_strCodmotivo.Trim().Length > 4)
                p_strCodmotivo= p_strCodmotivo.Trim().Substring(0,4);

            return p_strCodmotivo.Trim().PadLeft(4).ToUpper();
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

                l_dcStruct[0]= new DataColumn("cll_nro_numcliente", typeof(int));
                l_dcStruct[1]= new DataColumn("cll_ede_rsocial", typeof(string));
                l_dcStruct[2]= new DataColumn("cll_nro_numllamada", typeof(int));
                l_dcStruct[3]= new DataColumn("cll_cod_codmotivo", typeof(string));
                l_dcStruct[4]= new DataColumn("cll_des_motivo", typeof(string));
                l_dcStruct[5]= new DataColumn("cll_fyh_frealizada", typeof(DateTime));
                l_dcStruct[6]= new DataColumn("cll_txt_resultado", typeof(string));
                l_dcStruct[7]= new DataColumn("cll_nom_codusuario", typeof(string));
                l_dcStruct[8]= new DataColumn("cll_cd1_baja", typeof(string));
                l_dcStruct[9]= new DataColumn("cll_nro_numcontacto", typeof(int));
                l_dcStruct[10]= new DataColumn("cll_nom_contac", typeof(string));
                l_dcStruct[11]= new DataColumn("cll_txt_obsprogramada", typeof(string));
                l_dcStruct[12]= new DataColumn("cll_imp_abonoanterior", typeof(decimal));
                l_dcStruct[13]= new DataColumn("cll_imp_abonorecuperado", typeof(decimal));
                l_dcStruct[14]= new DataColumn("cll_nom_programador", typeof(string));
                l_dcStruct[15]= new DataColumn("cll_imp_ajuste", typeof(decimal));
                ECliLlamada.FillFixedFields(ref l_dcStruct, 16);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Número de cliente
        /// </summary>
        public static string NumclienteCmp
        {
           get {return "cll_nro_numcliente";}
        }

        /// <summary>
        /// Número de cliente
        /// </summary>
        public int Numcliente
        {
            get {return (int) InternalData["cll_nro_numcliente"];}
            set {InternalData["cll_nro_numcliente"]= value;}
        }

        /// <summary>
        /// Número de llamada
        /// </summary>
        public static string NumllamadaCmp
        {
           get {return "cll_nro_numllamada";}
        }

        /// <summary>
        /// Número de llamada
        /// </summary>
        public int Numllamada
        {
            get {return (int) InternalData["cll_nro_numllamada"];}
            set {InternalData["cll_nro_numllamada"]= value;}
        }

        /// <summary>
        /// Código de motivo
        /// </summary>
        public static string CodmotivoCmp
        {
           get {return "cll_cod_codmotivo";}
        }

        /// <summary>
        /// Código de motivo
        /// </summary>
        public string Codmotivo
        {
            get {return (string) InternalData["cll_cod_codmotivo"];}
            set {InternalData["cll_cod_codmotivo"]= ECliLlamada.FrmtCodmotivo(value);}
        }

        /// <summary>
        /// Fecha Realizada
        /// </summary>
        public static string FrealizadaCmp
        {
           get {return "cll_fyh_frealizada";}
        }

        /// <summary>
        /// Fecha Realizada
        /// </summary>
        public DateTime Frealizada
        {
            get {return (DateTime) InternalData["cll_fyh_frealizada"];}
            set {InternalData["cll_fyh_frealizada"]= value;}
        }

        /// <summary>
        /// Resultado
        /// </summary>
        public static string ResultadoCmp
        {
           get {return "cll_txt_resultado";}
        }

        /// <summary>
        /// Resultado
        /// </summary>
        public string Resultado
        {
            get {return (string) InternalData["cll_txt_resultado"];}
            set {InternalData["cll_txt_resultado"]= value;}
        }

        /// <summary>
        /// Código del usuario
        /// </summary>
        public static string CodusuarioCmp
        {
           get {return "cll_nom_codusuario";}
        }

        /// <summary>
        /// Código del usuario
        /// </summary>
        public string Codusuario
        {
            get {return ((string) InternalData["cll_nom_codusuario"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["cll_nom_codusuario"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Produjo Baja
        /// </summary>
        public static string BajaCmp
        {
           get {return "cll_cd1_baja";}
        }

        /// <summary>
        /// Produjo Baja
        /// </summary>
        public string Baja
        {
            get {return (string) InternalData["cll_cd1_baja"];}
            set {InternalData["cll_cd1_baja"]= value;}
        }

        /// <summary>
        /// Número de contacto
        /// </summary>
        public static string NumcontactoCmp
        {
           get {return "cll_nro_numcontacto";}
        }

        /// <summary>
        /// Número de contacto
        /// </summary>
        public int Numcontacto
        {
            get {return (int) InternalData["cll_nro_numcontacto"];}
            set {InternalData["cll_nro_numcontacto"]= value;}
        }

        /// <summary>
        /// Observación
        /// </summary>
        public static string ObsprogramadaCmp
        {
           get {return "cll_txt_obsprogramada";}
        }

        /// <summary>
        /// Observación
        /// </summary>
        public string Obsprogramada
        {
            get {return (string) InternalData["cll_txt_obsprogramada"];}
            set {InternalData["cll_txt_obsprogramada"]= value;}
        }

        /// <summary>
        /// Abono Anterior
        /// </summary>
        public static string AbonoanteriorCmp
        {
           get {return "cll_imp_abonoanterior";}
        }

        /// <summary>
        /// Abono Anterior
        /// </summary>
        public decimal Abonoanterior
        {
            get {return (decimal) InternalData["cll_imp_abonoanterior"];}
            set {InternalData["cll_imp_abonoanterior"]= value;}
        }

        /// <summary>
        /// Abono Recuperador
        /// </summary>
        public static string AbonorecuperadoCmp
        {
           get {return "cll_imp_abonorecuperado";}
        }

        /// <summary>
        /// Abono Recuperador
        /// </summary>
        public decimal Abonorecuperado
        {
            get {return (decimal) InternalData["cll_imp_abonorecuperado"];}
            set {InternalData["cll_imp_abonorecuperado"]= value;}
        }

        /// <summary>
        /// Usuario Programador
        /// </summary>
        public static string ProgramadorCmp
        {
           get {return "cll_nom_programador";}
        }

        /// <summary>
        /// Usuario Programador
        /// </summary>
        public string Programador
        {
            get {return ((string) InternalData["cll_nom_programador"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["cll_nom_programador"]= value.Trim();
            }
        }

        /// <summary>
        /// Ajuste
        /// </summary>
        public static string AjusteCmp
        {
           get {return "cll_imp_ajuste";}
        }

        /// <summary>
        /// Ajuste
        /// </summary>
        public decimal Ajuste
        {
            get {return (decimal) InternalData["cll_imp_ajuste"];}
            set {InternalData["cll_imp_ajuste"]= value;}
        }

        /// <summary>
        /// Motivo
        /// </summary>
        public string Cll_des_motivo
        {
            get {return (string) InternalData["cll_des_motivo"];}
            set {InternalData["cll_des_motivo"]= value;}
        }

        /// <summary>
        /// Razón Social
        /// </summary>
        public string Cll_ede_rsocial
        {
            get {return (string) InternalData["cll_ede_rsocial"];}
            set {InternalData["cll_ede_rsocial"]= value;}
        }

        /// <summary>
        /// Contacto
        /// </summary>
        public string Cll_nom_contac
        {
            get {return (string) InternalData["cll_nom_contac"];}
            set {InternalData["cll_nom_contac"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliLlamada] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliLlamada] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ECliLlamada", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_nro_numcliente", Numcliente));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_nro_numllamada", Numllamada));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_cod_codmotivo", Codmotivo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_fyh_frealizada", Frealizada));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_txt_resultado", Resultado));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_nom_codusuario", Codusuario));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_cd1_baja", Baja));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_nro_numcontacto", Numcontacto));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_txt_obsprogramada", Obsprogramada));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_imp_abonoanterior", Abonoanterior));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_imp_abonorecuperado", Abonorecuperado));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_nom_programador", Programador));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_imp_ajuste", Ajuste));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_des_motivo", Cll_des_motivo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_ede_rsocial", Cll_ede_rsocial));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cll_nom_contac", Cll_nom_contac));

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

    #region Lista-Entidad: CliLlamadas
    /// <summary>
    /// Clase que representa la Lista-Entidad: CliLlamadas
    /// </summary>
    public sealed partial class LECliLlamadas : ListaEntidades, IEnumerable<ECliLlamada>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: CliLlamadas
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECliLlamadas(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECliLlamadas(string p_strXMLData) :
            base(ECliLlamada.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ECliLlamada(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LECliLlamadas(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: CliLlamadas
        /// </summary>
        /// <returns>Lista-Entidad vacia: CliLlamadas</returns>
        public static LECliLlamadas NewEmpty()
        {
            return new LECliLlamadas(ECliLlamada.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entECliLlamada">Entidad a agregar</param>
        public void AddEntity(ECliLlamada p_entECliLlamada)
        {
            base.AddEntity(p_entECliLlamada);
        }

        /// <summary>
        /// Remueve una entidad [CliLlamada] por clave
        /// </summary>
        public int RemoveEntity(int p_iNumcliente,
                                int p_iNumllamada)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "cll_nro_numcliente = " + Ruts.Nu(p_iNumcliente) + " and " + 
                "cll_nro_numllamada = " + Ruts.Nu(p_iNumllamada);

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
        /// Verifca si una entidad [CliLlamada] esta en la lista
        /// </summary>
        public bool Contains(int p_iNumcliente,
                             int p_iNumllamada)
        {
            using (ECliLlamada l_entTemp= this[p_iNumcliente,
                                               p_iNumllamada])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: CliLlamadas
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ECliLlamada> GetEnumerator() 
        {
            ECliLlamada l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ECliLlamada(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: CliLlamadas
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ECliLlamada l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: CliLlamadas
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETCliLlamadas GetAsLET()
        {
            // Llenamos la lista tipada
            LETCliLlamadas l_lentRet= new LETCliLlamadas();

            foreach (ECliLlamada l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<CliLlamadas>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ECliLlamada> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ECliLlamada>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CliLlamada] por indice
        /// </summary>
        public new ECliLlamada this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad CliLlamada con los datos de la fila
                return new ECliLlamada(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [CliLlamada] por clave
        /// </summary>
        public ECliLlamada this[int p_iNumcliente,
                                int p_iNumllamada]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "cll_nro_numcliente = " + Ruts.Nu(p_iNumcliente) + " and " + 
                    "cll_nro_numllamada = " + Ruts.Nu(p_iNumllamada);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad CliLlamada con los datos de la fila
                if (l_drData == null) return null;
                return new ECliLlamada(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LECliLlamadas", null);

                foreach (ECliLlamada l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: CliLlamadas
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: CliLlamadas
    /// </summary>
    public sealed partial class LETCliLlamadas : LET<ECliLlamada>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: CliLlamadas
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LECliLlamadas GetAsLE()
        {
            // Llenamos la lista
            LECliLlamadas l_lentRet= LECliLlamadas.NewEmpty();

            foreach (ECliLlamada l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CliLlamada] por clave
        /// </summary>
        public ECliLlamada this[int p_iNumcliente,
                                int p_iNumllamada]
        {
            get {
                // Buscamos la entidad
                foreach (ECliLlamada l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Numcliente == p_iNumcliente) &&
                        (l_entItem.Numllamada == p_iNumllamada))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: CliNota
    /// <summary>
    /// Clase que representa la Entidad: CliNota
    /// </summary>
    public sealed partial class ECliNota : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: CliNotas
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ECliNota(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CliNota
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ECliNota(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CliNota
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ECliNota(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ECliNota.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cln_nro_numcliente"]= XMLRuts.ExtractXAttr(l_xndData, "cln_nro_numcliente", 1);
            l_drTemp["cln_fyh_fechayhora"]= XMLRuts.ExtractXAttr(l_xndData, "cln_fyh_fechayhora", true);
            l_drTemp["cln_des_titulo"]= XMLRuts.ExtractXAttr(l_xndData, "cln_des_titulo");
            l_drTemp["cln_xld_texto"]= XMLRuts.ExtractXAttr(l_xndData, "cln_xld_texto");
            l_drTemp["cln_cd1_tipo"]= XMLRuts.ExtractXAttr(l_xndData, "cln_cd1_tipo");
            l_drTemp["cln_nom_escritor"]= XMLRuts.ExtractXAttr(l_xndData, "cln_nom_escritor");
            l_drTemp["cln_nom_removedor"]= XMLRuts.ExtractXAttr(l_xndData, "cln_nom_removedor");
            l_drTemp["cln_fyh_fyhremovida"]= XMLRuts.ExtractXAttr(l_xndData, "cln_fyh_fyhremovida", true);
            l_drTemp["cln_cd1_borrada"]= XMLRuts.ExtractXAttr(l_xndData, "cln_cd1_borrada");

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
        private ECliNota(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: CliNota
        /// </summary>
        /// <returns>Entidad vacia: CliNota</returns>
        public static ECliNota NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliNota.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cln_nro_numcliente"]= 1;
            l_drTemp["cln_fyh_fechayhora"]= DateTimeRuts.Empty;
            l_drTemp["cln_des_titulo"]= "";
            l_drTemp["cln_xld_texto"]= "";
            l_drTemp["cln_cd1_tipo"]= "";
            l_drTemp["cln_nom_escritor"]= "";
            l_drTemp["cln_nom_removedor"]= "";
            l_drTemp["cln_fyh_fyhremovida"]= DateTimeRuts.Empty;
            l_drTemp["cln_cd1_borrada"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliNota l_entRet= new ECliNota(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: CliNota
        /// </summary>
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_strTitulo">Título</param>
        /// <param name="p_strTexto">Texto</param>
        /// <param name="p_strTipo">Tipo</param>
        /// <param name="p_strEscritor">Usuario Escritor</param>
        /// <param name="p_strRemovedor">Usuario Removedor</param>
        /// <param name="p_dtFyhremovida">Fecha y Hora Removida</param>
        /// <returns>Entidad: CliNota</returns>
        public static ECliNota NewFilled(int p_iNumcliente,
                                         DateTime p_dtFechayhora,
                                         string p_strTitulo,
                                         string p_strTexto,
                                         string p_strTipo,
                                         string p_strEscritor,
                                         string p_strRemovedor,
                                         DateTime p_dtFyhremovida)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliNota.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cln_nro_numcliente"]= p_iNumcliente;
            l_drTemp["cln_fyh_fechayhora"]= p_dtFechayhora;
            l_drTemp["cln_des_titulo"]= p_strTitulo;
            l_drTemp["cln_xld_texto"]= p_strTexto;
            l_drTemp["cln_cd1_tipo"]= p_strTipo;
            l_drTemp["cln_nom_escritor"]= p_strEscritor;
            l_drTemp["cln_nom_removedor"]= p_strRemovedor;
            l_drTemp["cln_fyh_fyhremovida"]= p_dtFyhremovida;
            l_drTemp["cln_cd1_borrada"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliNota l_entRet= new ECliNota(l_dtTemp);
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
                DataColumn[] l_dcStruct= new DataColumn[13];

                l_dcStruct[0]= new DataColumn("cln_nro_numcliente", typeof(int));
                l_dcStruct[1]= new DataColumn("cln_fyh_fechayhora", typeof(DateTime));
                l_dcStruct[2]= new DataColumn("cln_des_titulo", typeof(string));
                l_dcStruct[3]= new DataColumn("cln_xld_texto", typeof(string));
                l_dcStruct[4]= new DataColumn("cln_cd1_tipo", typeof(string));
                l_dcStruct[5]= new DataColumn("cln_cd1_borrada", typeof(string));
                l_dcStruct[6]= new DataColumn("cln_nom_escritor", typeof(string));
                l_dcStruct[7]= new DataColumn("cln_nom_removedor", typeof(string));
                l_dcStruct[8]= new DataColumn("cln_fyh_fyhremovida", typeof(DateTime));
                ECliNota.FillFixedFields(ref l_dcStruct, 9);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Numero del Cliente
        /// </summary>
        public static string NumclienteCmp
        {
           get {return "cln_nro_numcliente";}
        }

        /// <summary>
        /// Numero del Cliente
        /// </summary>
        public int Numcliente
        {
            get {return (int) InternalData["cln_nro_numcliente"];}
            set {InternalData["cln_nro_numcliente"]= value;}
        }

        /// <summary>
        /// Fecha y Hora
        /// </summary>
        public static string FechayhoraCmp
        {
           get {return "cln_fyh_fechayhora";}
        }

        /// <summary>
        /// Fecha y Hora
        /// </summary>
        public DateTime Fechayhora
        {
            get {return (DateTime) InternalData["cln_fyh_fechayhora"];}
            set {InternalData["cln_fyh_fechayhora"]= value;}
        }

        /// <summary>
        /// Título
        /// </summary>
        public static string TituloCmp
        {
           get {return "cln_des_titulo";}
        }

        /// <summary>
        /// Título
        /// </summary>
        public string Titulo
        {
            get {return ((string) InternalData["cln_des_titulo"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cln_des_titulo"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Texto
        /// </summary>
        public static string TextoCmp
        {
           get {return "cln_xld_texto";}
        }

        /// <summary>
        /// Texto
        /// </summary>
        public string Texto
        {
            get {return ((string) InternalData["cln_xld_texto"]).Trim();}
            set {
                if (value.Trim().Length > 240) value= value.Trim().Substring(0,240);
                InternalData["cln_xld_texto"]= value.Trim();
            }
        }

        /// <summary>
        /// Tipo
        /// </summary>
        public static string TipoCmp
        {
           get {return "cln_cd1_tipo";}
        }

        /// <summary>
        /// Tipo
        /// </summary>
        public string Tipo
        {
            get {return (string) InternalData["cln_cd1_tipo"];}
            set {InternalData["cln_cd1_tipo"]= value;}
        }

        /// <summary>
        /// Usuario Escritor
        /// </summary>
        public static string EscritorCmp
        {
           get {return "cln_nom_escritor";}
        }

        /// <summary>
        /// Usuario Escritor
        /// </summary>
        public string Escritor
        {
            get {return ((string) InternalData["cln_nom_escritor"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["cln_nom_escritor"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Usuario Removedor
        /// </summary>
        public static string RemovedorCmp
        {
           get {return "cln_nom_removedor";}
        }

        /// <summary>
        /// Usuario Removedor
        /// </summary>
        public string Removedor
        {
            get {return ((string) InternalData["cln_nom_removedor"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["cln_nom_removedor"]= value.Trim();
            }
        }

        /// <summary>
        /// Fecha y Hora Removida
        /// </summary>
        public static string FyhremovidaCmp
        {
           get {return "cln_fyh_fyhremovida";}
        }

        /// <summary>
        /// Fecha y Hora Removida
        /// </summary>
        public DateTime Fyhremovida
        {
            get {return (DateTime) InternalData["cln_fyh_fyhremovida"];}
            set {InternalData["cln_fyh_fyhremovida"]= value;}
        }

        /// <summary>
        /// Borrada
        /// </summary>
        public string Cln_cd1_borrada
        {
            get {return (string) InternalData["cln_cd1_borrada"];}
            set {InternalData["cln_cd1_borrada"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliNota] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliNota] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ECliNota", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cln_nro_numcliente", Numcliente));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cln_fyh_fechayhora", Fechayhora));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cln_des_titulo", Titulo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cln_xld_texto", Texto));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cln_cd1_tipo", Tipo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cln_nom_escritor", Escritor));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cln_nom_removedor", Removedor));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cln_fyh_fyhremovida", Fyhremovida));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cln_cd1_borrada", Cln_cd1_borrada));

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

    #region Lista-Entidad: CliNotas
    /// <summary>
    /// Clase que representa la Lista-Entidad: CliNotas
    /// </summary>
    public sealed partial class LECliNotas : ListaEntidades, IEnumerable<ECliNota>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: CliNotas
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECliNotas(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECliNotas(string p_strXMLData) :
            base(ECliNota.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ECliNota(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LECliNotas(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: CliNotas
        /// </summary>
        /// <returns>Lista-Entidad vacia: CliNotas</returns>
        public static LECliNotas NewEmpty()
        {
            return new LECliNotas(ECliNota.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entECliNota">Entidad a agregar</param>
        public void AddEntity(ECliNota p_entECliNota)
        {
            base.AddEntity(p_entECliNota);
        }

        /// <summary>
        /// Remueve una entidad [CliNota] por clave
        /// </summary>
        public int RemoveEntity(int p_iNumcliente,
                                DateTime p_dtFechayhora)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "cln_nro_numcliente = " + Ruts.Nu(p_iNumcliente) + " and " + 
                "convert(cln_fyh_fechayhora,'System.String') = '" + p_dtFechayhora + "'";

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
        /// Verifca si una entidad [CliNota] esta en la lista
        /// </summary>
        public bool Contains(int p_iNumcliente,
                             DateTime p_dtFechayhora)
        {
            using (ECliNota l_entTemp= this[p_iNumcliente,
                                            p_dtFechayhora])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: CliNotas
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ECliNota> GetEnumerator() 
        {
            ECliNota l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ECliNota(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: CliNotas
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ECliNota l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: CliNotas
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETCliNotas GetAsLET()
        {
            // Llenamos la lista tipada
            LETCliNotas l_lentRet= new LETCliNotas();

            foreach (ECliNota l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<CliNotas>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ECliNota> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ECliNota>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CliNota] por indice
        /// </summary>
        public new ECliNota this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad CliNota con los datos de la fila
                return new ECliNota(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [CliNota] por clave
        /// </summary>
        public ECliNota this[int p_iNumcliente,
                             DateTime p_dtFechayhora]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "cln_nro_numcliente = " + Ruts.Nu(p_iNumcliente) + " and " + 
                    "convert(cln_fyh_fechayhora,'System.String') = '" + p_dtFechayhora + "'";

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad CliNota con los datos de la fila
                if (l_drData == null) return null;
                return new ECliNota(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LECliNotas", null);

                foreach (ECliNota l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: CliNotas
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: CliNotas
    /// </summary>
    public sealed partial class LETCliNotas : LET<ECliNota>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: CliNotas
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LECliNotas GetAsLE()
        {
            // Llenamos la lista
            LECliNotas l_lentRet= LECliNotas.NewEmpty();

            foreach (ECliNota l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CliNota] por clave
        /// </summary>
        public ECliNota this[int p_iNumcliente,
                             DateTime p_dtFechayhora]
        {
            get {
                // Buscamos la entidad
                foreach (ECliNota l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Numcliente == p_iNumcliente) &&
                        (l_entItem.Fechayhora == p_dtFechayhora))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: CliServicio
    /// <summary>
    /// Clase que representa la Entidad: CliServicio
    /// </summary>
    public sealed partial class ECliServicio : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: CliServicios
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ECliServicio(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CliServicio
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ECliServicio(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CliServicio
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ECliServicio(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ECliServicio.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cls_nro_numcliente"]= XMLRuts.ExtractXAttr(l_xndData, "cls_nro_numcliente", 0);
            l_drTemp["cls_nro_item"]= XMLRuts.ExtractXAttr(l_xndData, "cls_nro_item", 1);
            l_drTemp["cls_cod_codservicio"]= XMLRuts.ExtractXAttr(l_xndData, "cls_cod_codservicio");
            l_drTemp["cls_imp_coseguro"]= XMLRuts.ExtractXAttr(l_xndData, "cls_imp_coseguro", (decimal) 0);
            l_drTemp["cls_imp_valorprestacion"]= XMLRuts.ExtractXAttr(l_xndData, "cls_imp_valorprestacion", (decimal) 0);
            l_drTemp["cls_nro_cantestprestaciones"]= XMLRuts.ExtractXAttr(l_xndData, "cls_nro_cantestprestaciones", 0);
            l_drTemp["cls_des_serv"]= XMLRuts.ExtractXAttr(l_xndData, "cls_des_serv");

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
        private ECliServicio(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: CliServicio
        /// </summary>
        /// <returns>Entidad vacia: CliServicio</returns>
        public static ECliServicio NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliServicio.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cls_nro_numcliente"]= 0;
            l_drTemp["cls_nro_item"]= 1;
            l_drTemp["cls_cod_codservicio"]= "";
            l_drTemp["cls_imp_coseguro"]= 0;
            l_drTemp["cls_imp_valorprestacion"]= 0;
            l_drTemp["cls_nro_cantestprestaciones"]= 0;
            l_drTemp["cls_des_serv"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliServicio l_entRet= new ECliServicio(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: CliServicio
        /// </summary>
        /// <param name="p_iNumcliente">Número Cliente</param>
        /// <param name="p_iItem">Item</param>
        /// <param name="p_strCodservicio">Código de Servicio</param>
        /// <param name="p_dcCoseguro">Coseguro</param>
        /// <param name="p_dcValorprestacion">Valor Prestación</param>
        /// <param name="p_iCantestprestaciones">Cant. Estimada Prestaciones</param>
        /// <returns>Entidad: CliServicio</returns>
        public static ECliServicio NewFilled(int p_iNumcliente,
                                             int p_iItem,
                                             string p_strCodservicio,
                                             decimal p_dcCoseguro,
                                             decimal p_dcValorprestacion,
                                             int p_iCantestprestaciones)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliServicio.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cls_nro_numcliente"]= p_iNumcliente;
            l_drTemp["cls_nro_item"]= p_iItem;
            l_drTemp["cls_cod_codservicio"]= p_strCodservicio;
            l_drTemp["cls_imp_coseguro"]= p_dcCoseguro;
            l_drTemp["cls_imp_valorprestacion"]= p_dcValorprestacion;
            l_drTemp["cls_nro_cantestprestaciones"]= p_iCantestprestaciones;
            l_drTemp["cls_des_serv"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliServicio l_entRet= new ECliServicio(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

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
                DataColumn[] l_dcStruct= new DataColumn[11];

                l_dcStruct[0]= new DataColumn("cls_nro_numcliente", typeof(int));
                l_dcStruct[1]= new DataColumn("cls_nro_item", typeof(int));
                l_dcStruct[2]= new DataColumn("cls_cod_codservicio", typeof(string));
                l_dcStruct[3]= new DataColumn("cls_des_serv", typeof(string));
                l_dcStruct[4]= new DataColumn("cls_imp_coseguro", typeof(decimal));
                l_dcStruct[5]= new DataColumn("cls_imp_valorprestacion", typeof(decimal));
                l_dcStruct[6]= new DataColumn("cls_nro_cantestprestaciones", typeof(int));
                ECliServicio.FillFixedFields(ref l_dcStruct, 7);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Número Cliente
        /// </summary>
        public static string NumclienteCmp
        {
           get {return "cls_nro_numcliente";}
        }

        /// <summary>
        /// Número Cliente
        /// </summary>
        public int Numcliente
        {
            get {return (int) InternalData["cls_nro_numcliente"];}
            set {InternalData["cls_nro_numcliente"]= value;}
        }

        /// <summary>
        /// Item
        /// </summary>
        public static string ItemCmp
        {
           get {return "cls_nro_item";}
        }

        /// <summary>
        /// Item
        /// </summary>
        public int Item
        {
            get {return (int) InternalData["cls_nro_item"];}
            set {InternalData["cls_nro_item"]= value;}
        }

        /// <summary>
        /// Código de Servicio
        /// </summary>
        public static string CodservicioCmp
        {
           get {return "cls_cod_codservicio";}
        }

        /// <summary>
        /// Código de Servicio
        /// </summary>
        public string Codservicio
        {
            get {return (string) InternalData["cls_cod_codservicio"];}
            set {InternalData["cls_cod_codservicio"]= ECliServicio.FrmtCodservicio(value);}
        }

        /// <summary>
        /// Coseguro
        /// </summary>
        public static string CoseguroCmp
        {
           get {return "cls_imp_coseguro";}
        }

        /// <summary>
        /// Coseguro
        /// </summary>
        public decimal Coseguro
        {
            get {return (decimal) InternalData["cls_imp_coseguro"];}
            set {InternalData["cls_imp_coseguro"]= value;}
        }

        /// <summary>
        /// Valor Prestación
        /// </summary>
        public static string ValorprestacionCmp
        {
           get {return "cls_imp_valorprestacion";}
        }

        /// <summary>
        /// Valor Prestación
        /// </summary>
        public decimal Valorprestacion
        {
            get {return (decimal) InternalData["cls_imp_valorprestacion"];}
            set {InternalData["cls_imp_valorprestacion"]= value;}
        }

        /// <summary>
        /// Cant. Estimada Prestaciones
        /// </summary>
        public static string CantestprestacionesCmp
        {
           get {return "cls_nro_cantestprestaciones";}
        }

        /// <summary>
        /// Cant. Estimada Prestaciones
        /// </summary>
        public int Cantestprestaciones
        {
            get {return (int) InternalData["cls_nro_cantestprestaciones"];}
            set {InternalData["cls_nro_cantestprestaciones"]= value;}
        }

        /// <summary>
        /// Servicio
        /// </summary>
        public string Cls_des_serv
        {
            get {return (string) InternalData["cls_des_serv"];}
            set {InternalData["cls_des_serv"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliServicio] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliServicio] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ECliServicio", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cls_nro_numcliente", Numcliente));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cls_nro_item", Item));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cls_cod_codservicio", Codservicio));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cls_imp_coseguro", Coseguro));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cls_imp_valorprestacion", Valorprestacion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cls_nro_cantestprestaciones", Cantestprestaciones));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cls_des_serv", Cls_des_serv));

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

    #region Lista-Entidad: CliServicios
    /// <summary>
    /// Clase que representa la Lista-Entidad: CliServicios
    /// </summary>
    public sealed partial class LECliServicios : ListaEntidades, IEnumerable<ECliServicio>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: CliServicios
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECliServicios(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECliServicios(string p_strXMLData) :
            base(ECliServicio.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ECliServicio(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LECliServicios(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: CliServicios
        /// </summary>
        /// <returns>Lista-Entidad vacia: CliServicios</returns>
        public static LECliServicios NewEmpty()
        {
            return new LECliServicios(ECliServicio.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entECliServicio">Entidad a agregar</param>
        public void AddEntity(ECliServicio p_entECliServicio)
        {
            base.AddEntity(p_entECliServicio);
        }

        /// <summary>
        /// Remueve una entidad [CliServicio] por clave
        /// </summary>
        public int RemoveEntity(int p_iNumcliente,
                                int p_iItem)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "cls_nro_numcliente = " + Ruts.Nu(p_iNumcliente) + " and " + 
                "cls_nro_item = " + Ruts.Nu(p_iItem);

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
        /// Verifca si una entidad [CliServicio] esta en la lista
        /// </summary>
        public bool Contains(int p_iNumcliente,
                             int p_iItem)
        {
            using (ECliServicio l_entTemp= this[p_iNumcliente,
                                                p_iItem])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: CliServicios
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ECliServicio> GetEnumerator() 
        {
            ECliServicio l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ECliServicio(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: CliServicios
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ECliServicio l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: CliServicios
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETCliServicios GetAsLET()
        {
            // Llenamos la lista tipada
            LETCliServicios l_lentRet= new LETCliServicios();

            foreach (ECliServicio l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<CliServicios>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ECliServicio> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ECliServicio>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CliServicio] por indice
        /// </summary>
        public new ECliServicio this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad CliServicio con los datos de la fila
                return new ECliServicio(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [CliServicio] por clave
        /// </summary>
        public ECliServicio this[int p_iNumcliente,
                                 int p_iItem]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "cls_nro_numcliente = " + Ruts.Nu(p_iNumcliente) + " and " + 
                    "cls_nro_item = " + Ruts.Nu(p_iItem);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad CliServicio con los datos de la fila
                if (l_drData == null) return null;
                return new ECliServicio(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LECliServicios", null);

                foreach (ECliServicio l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: CliServicios
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: CliServicios
    /// </summary>
    public sealed partial class LETCliServicios : LET<ECliServicio>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: CliServicios
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LECliServicios GetAsLE()
        {
            // Llenamos la lista
            LECliServicios l_lentRet= LECliServicios.NewEmpty();

            foreach (ECliServicio l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CliServicio] por clave
        /// </summary>
        public ECliServicio this[int p_iNumcliente,
                                 int p_iItem]
        {
            get {
                // Buscamos la entidad
                foreach (ECliServicio l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Numcliente == p_iNumcliente) &&
                        (l_entItem.Item == p_iItem))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: CliVenta
    /// <summary>
    /// Clase que representa la Entidad: CliVenta
    /// </summary>
    public sealed partial class ECliVenta : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: CliVentas
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ECliVenta(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CliVenta
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ECliVenta(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: CliVenta
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ECliVenta(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ECliVenta.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["clv_nro_numcliente"]= XMLRuts.ExtractXAttr(l_xndData, "clv_nro_numcliente", 0);
            l_drTemp["clv_fyh_fecha"]= XMLRuts.ExtractXAttr(l_xndData, "clv_fyh_fecha", true);
            l_drTemp["clv_cd6_codvendedor"]= XMLRuts.ExtractXAttr(l_xndData, "clv_cd6_codvendedor");
            l_drTemp["clv_rcd_codtipocontrato"]= XMLRuts.ExtractXAttr(l_xndData, "clv_rcd_codtipocontrato");
            l_drTemp["clv_imp_abono"]= XMLRuts.ExtractXAttr(l_xndData, "clv_imp_abono", (decimal) 0);
            l_drTemp["clv_nro_cantcapitas"]= XMLRuts.ExtractXAttr(l_xndData, "clv_nro_cantcapitas", 0);
            l_drTemp["clv_imp_valorcapita"]= XMLRuts.ExtractXAttr(l_xndData, "clv_imp_valorcapita", (decimal) 0);
            l_drTemp["clv_des_destcon"]= XMLRuts.ExtractXAttr(l_xndData, "clv_des_destcon");
            l_drTemp["vnd_des_desvend"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_des_desvend");

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
        private ECliVenta(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: CliVenta
        /// </summary>
        /// <returns>Entidad vacia: CliVenta</returns>
        public static ECliVenta NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliVenta.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["clv_nro_numcliente"]= 0;
            l_drTemp["clv_fyh_fecha"]= DateTimeRuts.Empty;
            l_drTemp["clv_cd6_codvendedor"]= "";
            l_drTemp["clv_rcd_codtipocontrato"]= "";
            l_drTemp["clv_imp_abono"]= 0;
            l_drTemp["clv_nro_cantcapitas"]= 0;
            l_drTemp["clv_imp_valorcapita"]= 0;
            l_drTemp["clv_des_destcon"]= "";
            l_drTemp["vnd_des_desvend"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliVenta l_entRet= new ECliVenta(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: CliVenta
        /// </summary>
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_strCodvendedor">Vendedor</param>
        /// <param name="p_strCodtipocontrato">Tipo Contrato</param>
        /// <param name="p_dcAbono">Abono</param>
        /// <param name="p_iCantcapitas">Capitas</param>
        /// <param name="p_dcValorcapita">Valor Capita</param>
        /// <returns>Entidad: CliVenta</returns>
        public static ECliVenta NewFilled(int p_iNumcliente,
                                          DateTime p_dtFecha,
                                          string p_strCodvendedor,
                                          string p_strCodtipocontrato,
                                          decimal p_dcAbono,
                                          int p_iCantcapitas,
                                          decimal p_dcValorcapita)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliVenta.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["clv_nro_numcliente"]= p_iNumcliente;
            l_drTemp["clv_fyh_fecha"]= p_dtFecha;
            l_drTemp["clv_cd6_codvendedor"]= p_strCodvendedor;
            l_drTemp["clv_rcd_codtipocontrato"]= p_strCodtipocontrato;
            l_drTemp["clv_imp_abono"]= p_dcAbono;
            l_drTemp["clv_nro_cantcapitas"]= p_iCantcapitas;
            l_drTemp["clv_imp_valorcapita"]= p_dcValorcapita;
            l_drTemp["clv_des_destcon"]= "";
            l_drTemp["vnd_des_desvend"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliVenta l_entRet= new ECliVenta(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Tipo Contrato
        /// </summary>
        public static string FrmtCodtipocontrato(string p_strCodtipocontrato)
        {
            if (p_strCodtipocontrato.Trim().Length > 2)
                p_strCodtipocontrato= p_strCodtipocontrato.Trim().Substring(0,2);

            return p_strCodtipocontrato.Trim().PadLeft(2).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[13];

                l_dcStruct[0]= new DataColumn("clv_nro_numcliente", typeof(int));
                l_dcStruct[1]= new DataColumn("clv_fyh_fecha", typeof(DateTime));
                l_dcStruct[2]= new DataColumn("vnd_des_desvend", typeof(string));
                l_dcStruct[3]= new DataColumn("clv_cd6_codvendedor", typeof(string));
                l_dcStruct[4]= new DataColumn("clv_des_destcon", typeof(string));
                l_dcStruct[5]= new DataColumn("clv_rcd_codtipocontrato", typeof(string));
                l_dcStruct[6]= new DataColumn("clv_imp_abono", typeof(decimal));
                l_dcStruct[7]= new DataColumn("clv_nro_cantcapitas", typeof(int));
                l_dcStruct[8]= new DataColumn("clv_imp_valorcapita", typeof(decimal));
                ECliVenta.FillFixedFields(ref l_dcStruct, 9);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Numero Cliente
        /// </summary>
        public static string NumclienteCmp
        {
           get {return "clv_nro_numcliente";}
        }

        /// <summary>
        /// Numero Cliente
        /// </summary>
        public int Numcliente
        {
            get {return (int) InternalData["clv_nro_numcliente"];}
            set {InternalData["clv_nro_numcliente"]= value;}
        }

        /// <summary>
        /// Fecha Venta
        /// </summary>
        public static string FechaCmp
        {
           get {return "clv_fyh_fecha";}
        }

        /// <summary>
        /// Fecha Venta
        /// </summary>
        public DateTime Fecha
        {
            get {return (DateTime) InternalData["clv_fyh_fecha"];}
            set {InternalData["clv_fyh_fecha"]= value;}
        }

        /// <summary>
        /// Vendedor
        /// </summary>
        public static string CodvendedorCmp
        {
           get {return "clv_cd6_codvendedor";}
        }

        /// <summary>
        /// Vendedor
        /// </summary>
        public string Codvendedor
        {
            get {return (string) InternalData["clv_cd6_codvendedor"];}
            set {InternalData["clv_cd6_codvendedor"]= value;}
        }

        /// <summary>
        /// Tipo Contrato
        /// </summary>
        public static string CodtipocontratoCmp
        {
           get {return "clv_rcd_codtipocontrato";}
        }

        /// <summary>
        /// Tipo Contrato
        /// </summary>
        public string Codtipocontrato
        {
            get {return (string) InternalData["clv_rcd_codtipocontrato"];}
            set {InternalData["clv_rcd_codtipocontrato"]= ECliVenta.FrmtCodtipocontrato(value);}
        }

        /// <summary>
        /// Abono
        /// </summary>
        public static string AbonoCmp
        {
           get {return "clv_imp_abono";}
        }

        /// <summary>
        /// Abono
        /// </summary>
        public decimal Abono
        {
            get {return (decimal) InternalData["clv_imp_abono"];}
            set {InternalData["clv_imp_abono"]= value;}
        }

        /// <summary>
        /// Capitas
        /// </summary>
        public static string CantcapitasCmp
        {
           get {return "clv_nro_cantcapitas";}
        }

        /// <summary>
        /// Capitas
        /// </summary>
        public int Cantcapitas
        {
            get {return (int) InternalData["clv_nro_cantcapitas"];}
            set {InternalData["clv_nro_cantcapitas"]= value;}
        }

        /// <summary>
        /// Valor Capita
        /// </summary>
        public static string ValorcapitaCmp
        {
           get {return "clv_imp_valorcapita";}
        }

        /// <summary>
        /// Valor Capita
        /// </summary>
        public decimal Valorcapita
        {
            get {return (decimal) InternalData["clv_imp_valorcapita"];}
            set {InternalData["clv_imp_valorcapita"]= value;}
        }

        /// <summary>
        /// T. Contrato
        /// </summary>
        public string Clv_des_destcon
        {
            get {return (string) InternalData["clv_des_destcon"];}
            set {InternalData["clv_des_destcon"]= value;}
        }

        /// <summary>
        /// Vendedor
        /// </summary>
        public string Vnd_des_desvend
        {
            get {return (string) InternalData["vnd_des_desvend"];}
            set {InternalData["vnd_des_desvend"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliVenta] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliVenta] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ECliVenta", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clv_nro_numcliente", Numcliente));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clv_fyh_fecha", Fecha));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clv_cd6_codvendedor", Codvendedor));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clv_rcd_codtipocontrato", Codtipocontrato));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clv_imp_abono", Abono));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clv_nro_cantcapitas", Cantcapitas));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clv_imp_valorcapita", Valorcapita));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "clv_des_destcon", Clv_des_destcon));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_des_desvend", Vnd_des_desvend));

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

    #region Lista-Entidad: CliVentas
    /// <summary>
    /// Clase que representa la Lista-Entidad: CliVentas
    /// </summary>
    public sealed partial class LECliVentas : ListaEntidades, IEnumerable<ECliVenta>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: CliVentas
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECliVentas(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECliVentas(string p_strXMLData) :
            base(ECliVenta.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ECliVenta(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LECliVentas(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: CliVentas
        /// </summary>
        /// <returns>Lista-Entidad vacia: CliVentas</returns>
        public static LECliVentas NewEmpty()
        {
            return new LECliVentas(ECliVenta.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entECliVenta">Entidad a agregar</param>
        public void AddEntity(ECliVenta p_entECliVenta)
        {
            base.AddEntity(p_entECliVenta);
        }

        /// <summary>
        /// Remueve una entidad [CliVenta] por clave
        /// </summary>
        public int RemoveEntity(int p_iNumcliente,
                                DateTime p_dtFecha)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "clv_nro_numcliente = " + Ruts.Nu(p_iNumcliente) + " and " + 
                "convert(clv_fyh_fecha,'System.String') = '" + p_dtFecha + "'";

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
        /// Verifca si una entidad [CliVenta] esta en la lista
        /// </summary>
        public bool Contains(int p_iNumcliente,
                             DateTime p_dtFecha)
        {
            using (ECliVenta l_entTemp= this[p_iNumcliente,
                                             p_dtFecha])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: CliVentas
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ECliVenta> GetEnumerator() 
        {
            ECliVenta l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ECliVenta(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: CliVentas
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ECliVenta l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: CliVentas
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETCliVentas GetAsLET()
        {
            // Llenamos la lista tipada
            LETCliVentas l_lentRet= new LETCliVentas();

            foreach (ECliVenta l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<CliVentas>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ECliVenta> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ECliVenta>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CliVenta] por indice
        /// </summary>
        public new ECliVenta this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad CliVenta con los datos de la fila
                return new ECliVenta(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [CliVenta] por clave
        /// </summary>
        public ECliVenta this[int p_iNumcliente,
                              DateTime p_dtFecha]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "clv_nro_numcliente = " + Ruts.Nu(p_iNumcliente) + " and " + 
                    "convert(clv_fyh_fecha,'System.String') = '" + p_dtFecha + "'";

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad CliVenta con los datos de la fila
                if (l_drData == null) return null;
                return new ECliVenta(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LECliVentas", null);

                foreach (ECliVenta l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: CliVentas
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: CliVentas
    /// </summary>
    public sealed partial class LETCliVentas : LET<ECliVenta>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: CliVentas
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LECliVentas GetAsLE()
        {
            // Llenamos la lista
            LECliVentas l_lentRet= LECliVentas.NewEmpty();

            foreach (ECliVenta l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [CliVenta] por clave
        /// </summary>
        public ECliVenta this[int p_iNumcliente,
                              DateTime p_dtFecha]
        {
            get {
                // Buscamos la entidad
                foreach (ECliVenta l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Numcliente == p_iNumcliente) &&
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

    #region Entidad: Cliente
    /// <summary>
    /// Clase que representa la Entidad: Cliente
    /// </summary>
    public sealed partial class ECliente : Entidad
    {
        #region Miembros de la clase
            private LECliContactos m_lentCliContactos= null;
            private LECliEntrevistas m_lentCliEntrevistas= null;
            private LECliLlamadas m_lentCliLlamadas= null;
            private LECliNotas m_lentCliNotas= null;
            private LECliServicios m_lentCliServicios= null;
            private LECliVentas m_lentCliVentas= null;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Clientes
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ECliente(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Cliente
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ECliente(string p_strXML) :
            this(p_strXML, false)
        {
            // Creamos las listas-entidad hijas vacias
            m_lentCliContactos= LECliContactos.NewEmpty();
            m_lentCliEntrevistas= LECliEntrevistas.NewEmpty();
            m_lentCliLlamadas= LECliLlamadas.NewEmpty();
            m_lentCliNotas= LECliNotas.NewEmpty();
            m_lentCliServicios= LECliServicios.NewEmpty();
            m_lentCliVentas= LECliVentas.NewEmpty();
        }

        /// <summary>
        /// Construye una entidad desde un XML: Cliente
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ECliente(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ECliente.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cli_nro_numero"]= XMLRuts.ExtractXAttr(l_xndData, "cli_nro_numero", 1);
            l_drTemp["cli_ede_rsocial"]= XMLRuts.ExtractXAttr(l_xndData, "cli_ede_rsocial");
            l_drTemp["cli_des_nombrefant"]= XMLRuts.ExtractXAttr(l_xndData, "cli_des_nombrefant");
            l_drTemp["cli_cod_codtinst"]= XMLRuts.ExtractXAttr(l_xndData, "cli_cod_codtinst");
            l_drTemp["cli_cod_codfrq"]= XMLRuts.ExtractXAttr(l_xndData, "cli_cod_codfrq");
            l_drTemp["cli_cd1_alta"]= XMLRuts.ExtractXAttr(l_xndData, "cli_cd1_alta");
            l_drTemp["cli_tel_telefono1"]= XMLRuts.ExtractXAttr(l_xndData, "cli_tel_telefono1");
            l_drTemp["cli_tel_celular"]= XMLRuts.ExtractXAttr(l_xndData, "cli_tel_celular");
            l_drTemp["cli_tel_telefono2"]= XMLRuts.ExtractXAttr(l_xndData, "cli_tel_telefono2");
            l_drTemp["cli_tel_fax"]= XMLRuts.ExtractXAttr(l_xndData, "cli_tel_fax");
            l_drTemp["cli_ede_direccion"]= XMLRuts.ExtractXAttr(l_xndData, "cli_ede_direccion");
            l_drTemp["cli_nro_altura"]= XMLRuts.ExtractXAttr(l_xndData, "cli_nro_altura", 0);
            l_drTemp["cli_rde_piso"]= XMLRuts.ExtractXAttr(l_xndData, "cli_rde_piso");
            l_drTemp["cli_rde_oficina"]= XMLRuts.ExtractXAttr(l_xndData, "cli_rde_oficina");
            l_drTemp["cli_ecd_codlocalidad"]= XMLRuts.ExtractXAttr(l_xndData, "cli_ecd_codlocalidad");
            l_drTemp["cli_des_cuil"]= XMLRuts.ExtractXAttr(l_xndData, "cli_des_cuil");
            l_drTemp["cli_xld_url"]= XMLRuts.ExtractXAttr(l_xndData, "cli_xld_url");
            l_drTemp["cli_cd6_codvend"]= XMLRuts.ExtractXAttr(l_xndData, "cli_cd6_codvend");
            l_drTemp["cli_cd1_extension"]= XMLRuts.ExtractXAttr(l_xndData, "cli_cd1_extension");
            l_drTemp["cli_ede_horarios"]= XMLRuts.ExtractXAttr(l_xndData, "cli_ede_horarios");
            l_drTemp["cli_fec_fingsima"]= XMLRuts.ExtractXAttr(l_xndData, "cli_fec_fingsima", true);
            l_drTemp["cli_nro_cantempleados"]= XMLRuts.ExtractXAttr(l_xndData, "cli_nro_cantempleados", 0);
            l_drTemp["cli_txt_cobertura"]= XMLRuts.ExtractXAttr(l_xndData, "cli_txt_cobertura");
            l_drTemp["cli_nom_cargador"]= XMLRuts.ExtractXAttr(l_xndData, "cli_nom_cargador");
            l_drTemp["cli_txt_observacion"]= XMLRuts.ExtractXAttr(l_xndData, "cli_txt_observacion");
            l_drTemp["cli_xld_email"]= XMLRuts.ExtractXAttr(l_xndData, "cli_xld_email");
            l_drTemp["cli_nro_nroavalon"]= XMLRuts.ExtractXAttr(l_xndData, "cli_nro_nroavalon", 0);
            l_drTemp["cli_imp_abono"]= XMLRuts.ExtractXAttr(l_xndData, "cli_imp_abono", (decimal) 0);
            l_drTemp["cli_rcd_codtipocont"]= XMLRuts.ExtractXAttr(l_xndData, "cli_rcd_codtipocont");
            l_drTemp["cli_imp_deuda"]= XMLRuts.ExtractXAttr(l_xndData, "cli_imp_deuda", (decimal) 0);
            l_drTemp["cli_cd1_esmayo"]= XMLRuts.ExtractXAttr(l_xndData, "cli_cd1_esmayo");
            l_drTemp["cli_des_frq"]= XMLRuts.ExtractXAttr(l_xndData, "cli_des_frq");
            l_drTemp["cli_des_loc"]= XMLRuts.ExtractXAttr(l_xndData, "cli_des_loc");
            l_drTemp["cli_des_prov"]= XMLRuts.ExtractXAttr(l_xndData, "cli_des_prov");
            l_drTemp["cli_des_tinst"]= XMLRuts.ExtractXAttr(l_xndData, "cli_des_tinst");
            l_drTemp["cli_des_zona"]= XMLRuts.ExtractXAttr(l_xndData, "cli_des_zona");
            l_drTemp["cli_ede_partido"]= XMLRuts.ExtractXAttr(l_xndData, "cli_ede_partido");
            l_drTemp["cli_rcd_codzona"]= XMLRuts.ExtractXAttr(l_xndData, "cli_rcd_codzona");

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
            m_lentCliContactos= LECliContactos.NewEmpty();
            m_lentCliEntrevistas= LECliEntrevistas.NewEmpty();
            m_lentCliLlamadas= LECliLlamadas.NewEmpty();
            m_lentCliNotas= LECliNotas.NewEmpty();
            m_lentCliServicios= LECliServicios.NewEmpty();
            m_lentCliVentas= LECliVentas.NewEmpty();
        }

        /// <summary>
        /// Constructor 
        /// Privado para crear clases vacias
        /// </summary>
        /// <param name="p_dtDatos">DataTable con 1 registro con los datos de la entidad</param>
        private ECliente(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
            // Creamos las listas-entidad hijas vacias
            m_lentCliContactos= LECliContactos.NewEmpty();
            m_lentCliEntrevistas= LECliEntrevistas.NewEmpty();
            m_lentCliLlamadas= LECliLlamadas.NewEmpty();
            m_lentCliNotas= LECliNotas.NewEmpty();
            m_lentCliServicios= LECliServicios.NewEmpty();
            m_lentCliVentas= LECliVentas.NewEmpty();
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Cliente
        /// </summary>
        /// <returns>Entidad vacia: Cliente</returns>
        public static ECliente NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliente.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cli_nro_numero"]= 1;
            l_drTemp["cli_ede_rsocial"]= "";
            l_drTemp["cli_des_nombrefant"]= "";
            l_drTemp["cli_cod_codtinst"]= "";
            l_drTemp["cli_cod_codfrq"]= "";
            l_drTemp["cli_cd1_alta"]= "";
            l_drTemp["cli_tel_telefono1"]= "";
            l_drTemp["cli_tel_celular"]= "";
            l_drTemp["cli_tel_telefono2"]= "";
            l_drTemp["cli_tel_fax"]= "";
            l_drTemp["cli_ede_direccion"]= "";
            l_drTemp["cli_nro_altura"]= 0;
            l_drTemp["cli_rde_piso"]= "";
            l_drTemp["cli_rde_oficina"]= "";
            l_drTemp["cli_ecd_codlocalidad"]= "";
            l_drTemp["cli_des_cuil"]= "";
            l_drTemp["cli_xld_url"]= "";
            l_drTemp["cli_cd6_codvend"]= "";
            l_drTemp["cli_cd1_extension"]= "";
            l_drTemp["cli_ede_horarios"]= "";
            l_drTemp["cli_fec_fingsima"]= DateTimeRuts.Empty;
            l_drTemp["cli_nro_cantempleados"]= 0;
            l_drTemp["cli_txt_cobertura"]= "";
            l_drTemp["cli_nom_cargador"]= "";
            l_drTemp["cli_txt_observacion"]= "";
            l_drTemp["cli_xld_email"]= "";
            l_drTemp["cli_nro_nroavalon"]= 0;
            l_drTemp["cli_imp_abono"]= 0;
            l_drTemp["cli_rcd_codtipocont"]= "";
            l_drTemp["cli_imp_deuda"]= 0;
            l_drTemp["cli_cd1_esmayo"]= "";
            l_drTemp["cli_des_frq"]= "";
            l_drTemp["cli_des_loc"]= "";
            l_drTemp["cli_des_prov"]= "";
            l_drTemp["cli_des_tinst"]= "";
            l_drTemp["cli_des_zona"]= "";
            l_drTemp["cli_ede_partido"]= "";
            l_drTemp["cli_rcd_codzona"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliente l_entRet= new ECliente(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Cliente
        /// </summary>
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_strRsocial">Razón social</param>
        /// <param name="p_strNombrefant">Nombre de fantasía</param>
        /// <param name="p_strCodtinst">Tipo de Institucion</param>
        /// <param name="p_strCodfrq">Franquicia</param>
        /// <param name="p_strAlta">Alta en Avalon</param>
        /// <param name="p_strTelefono1">Teléfono 1</param>
        /// <param name="p_strCelular">Celular</param>
        /// <param name="p_strTelefono2">Teléfono 2</param>
        /// <param name="p_strFax">Fax</param>
        /// <param name="p_strDireccion">Dirección</param>
        /// <param name="p_iAltura">Altura</param>
        /// <param name="p_strPiso">Piso</param>
        /// <param name="p_strOficina">Oficina</param>
        /// <param name="p_strCodlocalidad">Código de localidad</param>
        /// <param name="p_strCuil">Cuil</param>
        /// <param name="p_strUrl">Url</param>
        /// <param name="p_strCodvend">Código de vendedor</param>
        /// <param name="p_strExtension">Extensión</param>
        /// <param name="p_strHorarios">Horarios</param>
        /// <param name="p_dtFingsima">Fecha de ingreso</param>
        /// <param name="p_iCantempleados">Cantidad de Empleados</param>
        /// <param name="p_strCobertura">Cobertura</param>
        /// <param name="p_strCargador">Usuario Cargador</param>
        /// <param name="p_strObservacion">Observacion</param>
        /// <param name="p_strEmail">E-Mail</param>
        /// <param name="p_iNroavalon">Número Avalon</param>
        /// <param name="p_dcAbono">Abono</param>
        /// <param name="p_strCodtipocont">Tipo Contrato</param>
        /// <param name="p_dcDeuda">Deuda</param>
        /// <returns>Entidad: Cliente</returns>
        public static ECliente NewFilled(int p_iNumero,
                                         string p_strRsocial,
                                         string p_strNombrefant,
                                         string p_strCodtinst,
                                         string p_strCodfrq,
                                         string p_strAlta,
                                         string p_strTelefono1,
                                         string p_strCelular,
                                         string p_strTelefono2,
                                         string p_strFax,
                                         string p_strDireccion,
                                         int p_iAltura,
                                         string p_strPiso,
                                         string p_strOficina,
                                         string p_strCodlocalidad,
                                         string p_strCuil,
                                         string p_strUrl,
                                         string p_strCodvend,
                                         string p_strExtension,
                                         string p_strHorarios,
                                         DateTime p_dtFingsima,
                                         int p_iCantempleados,
                                         string p_strCobertura,
                                         string p_strCargador,
                                         string p_strObservacion,
                                         string p_strEmail,
                                         int p_iNroavalon,
                                         decimal p_dcAbono,
                                         string p_strCodtipocont,
                                         decimal p_dcDeuda)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECliente.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cli_nro_numero"]= p_iNumero;
            l_drTemp["cli_ede_rsocial"]= p_strRsocial;
            l_drTemp["cli_des_nombrefant"]= p_strNombrefant;
            l_drTemp["cli_cod_codtinst"]= p_strCodtinst;
            l_drTemp["cli_cod_codfrq"]= p_strCodfrq;
            l_drTemp["cli_cd1_alta"]= p_strAlta;
            l_drTemp["cli_tel_telefono1"]= p_strTelefono1;
            l_drTemp["cli_tel_celular"]= p_strCelular;
            l_drTemp["cli_tel_telefono2"]= p_strTelefono2;
            l_drTemp["cli_tel_fax"]= p_strFax;
            l_drTemp["cli_ede_direccion"]= p_strDireccion;
            l_drTemp["cli_nro_altura"]= p_iAltura;
            l_drTemp["cli_rde_piso"]= p_strPiso;
            l_drTemp["cli_rde_oficina"]= p_strOficina;
            l_drTemp["cli_ecd_codlocalidad"]= p_strCodlocalidad;
            l_drTemp["cli_des_cuil"]= p_strCuil;
            l_drTemp["cli_xld_url"]= p_strUrl;
            l_drTemp["cli_cd6_codvend"]= p_strCodvend;
            l_drTemp["cli_cd1_extension"]= p_strExtension;
            l_drTemp["cli_ede_horarios"]= p_strHorarios;
            l_drTemp["cli_fec_fingsima"]= p_dtFingsima;
            l_drTemp["cli_nro_cantempleados"]= p_iCantempleados;
            l_drTemp["cli_txt_cobertura"]= p_strCobertura;
            l_drTemp["cli_nom_cargador"]= p_strCargador;
            l_drTemp["cli_txt_observacion"]= p_strObservacion;
            l_drTemp["cli_xld_email"]= p_strEmail;
            l_drTemp["cli_nro_nroavalon"]= p_iNroavalon;
            l_drTemp["cli_imp_abono"]= p_dcAbono;
            l_drTemp["cli_rcd_codtipocont"]= p_strCodtipocont;
            l_drTemp["cli_imp_deuda"]= p_dcDeuda;
            l_drTemp["cli_cd1_esmayo"]= "";
            l_drTemp["cli_des_frq"]= "";
            l_drTemp["cli_des_loc"]= "";
            l_drTemp["cli_des_prov"]= "";
            l_drTemp["cli_des_tinst"]= "";
            l_drTemp["cli_des_zona"]= "";
            l_drTemp["cli_ede_partido"]= "";
            l_drTemp["cli_rcd_codzona"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECliente l_entRet= new ECliente(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Tipo de Institucion
        /// </summary>
        public static string FrmtCodtinst(string p_strCodtinst)
        {
            if (p_strCodtinst.Trim().Length > 4)
                p_strCodtinst= p_strCodtinst.Trim().Substring(0,4);

            return p_strCodtinst.Trim().PadLeft(4).ToUpper();
        }

        /// <summary>
        /// Formatea una string: Franquicia
        /// </summary>
        public static string FrmtCodfrq(string p_strCodfrq)
        {
            if (p_strCodfrq.Trim().Length > 4)
                p_strCodfrq= p_strCodfrq.Trim().Substring(0,4);

            return p_strCodfrq.Trim().PadLeft(4).ToUpper();
        }

        /// <summary>
        /// Formatea una string: Código de localidad
        /// </summary>
        public static string FrmtCodlocalidad(string p_strCodlocalidad)
        {
            if (p_strCodlocalidad.Trim().Length > 8)
                p_strCodlocalidad= p_strCodlocalidad.Trim().Substring(0,8);

            return p_strCodlocalidad.Trim().PadLeft(8).ToUpper();
        }

        /// <summary>
        /// Formatea una string: Tipo Contrato
        /// </summary>
        public static string FrmtCodtipocont(string p_strCodtipocont)
        {
            if (p_strCodtipocont.Trim().Length > 2)
                p_strCodtipocont= p_strCodtipocont.Trim().Substring(0,2);

            return p_strCodtipocont.Trim().PadLeft(2).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[42];

                l_dcStruct[0]= new DataColumn("cli_nro_numero", typeof(int));
                l_dcStruct[1]= new DataColumn("cli_ede_rsocial", typeof(string));
                l_dcStruct[2]= new DataColumn("cli_des_nombrefant", typeof(string));
                l_dcStruct[3]= new DataColumn("cli_des_tinst", typeof(string));
                l_dcStruct[4]= new DataColumn("cli_cod_codtinst", typeof(string));
                l_dcStruct[5]= new DataColumn("cli_cd1_esmayo", typeof(string));
                l_dcStruct[6]= new DataColumn("cli_cod_codfrq", typeof(string));
                l_dcStruct[7]= new DataColumn("cli_des_frq", typeof(string));
                l_dcStruct[8]= new DataColumn("cli_cd1_alta", typeof(string));
                l_dcStruct[9]= new DataColumn("cli_tel_telefono1", typeof(string));
                l_dcStruct[10]= new DataColumn("cli_tel_celular", typeof(string));
                l_dcStruct[11]= new DataColumn("cli_tel_telefono2", typeof(string));
                l_dcStruct[12]= new DataColumn("cli_tel_fax", typeof(string));
                l_dcStruct[13]= new DataColumn("cli_ede_direccion", typeof(string));
                l_dcStruct[14]= new DataColumn("cli_nro_altura", typeof(int));
                l_dcStruct[15]= new DataColumn("cli_rde_piso", typeof(string));
                l_dcStruct[16]= new DataColumn("cli_rde_oficina", typeof(string));
                l_dcStruct[17]= new DataColumn("cli_ecd_codlocalidad", typeof(string));
                l_dcStruct[18]= new DataColumn("cli_des_loc", typeof(string));
                l_dcStruct[19]= new DataColumn("cli_des_prov", typeof(string));
                l_dcStruct[20]= new DataColumn("cli_des_zona", typeof(string));
                l_dcStruct[21]= new DataColumn("cli_ede_partido", typeof(string));
                l_dcStruct[22]= new DataColumn("cli_rcd_codzona", typeof(string));
                l_dcStruct[23]= new DataColumn("cli_des_cuil", typeof(string));
                l_dcStruct[24]= new DataColumn("cli_xld_url", typeof(string));
                l_dcStruct[25]= new DataColumn("cli_cd6_codvend", typeof(string));
                l_dcStruct[26]= new DataColumn("cli_cd1_extension", typeof(string));
                l_dcStruct[27]= new DataColumn("cli_ede_horarios", typeof(string));
                l_dcStruct[28]= new DataColumn("cli_fec_fingsima", typeof(DateTime));
                l_dcStruct[29]= new DataColumn("cli_nro_cantempleados", typeof(int));
                l_dcStruct[30]= new DataColumn("cli_txt_cobertura", typeof(string));
                l_dcStruct[31]= new DataColumn("cli_nom_cargador", typeof(string));
                l_dcStruct[32]= new DataColumn("cli_txt_observacion", typeof(string));
                l_dcStruct[33]= new DataColumn("cli_xld_email", typeof(string));
                l_dcStruct[34]= new DataColumn("cli_nro_nroavalon", typeof(int));
                l_dcStruct[35]= new DataColumn("cli_imp_abono", typeof(decimal));
                l_dcStruct[36]= new DataColumn("cli_rcd_codtipocont", typeof(string));
                l_dcStruct[37]= new DataColumn("cli_imp_deuda", typeof(decimal));
                ECliente.FillFixedFields(ref l_dcStruct, 38);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Número de cliente
        /// </summary>
        public static string NumeroCmp
        {
           get {return "cli_nro_numero";}
        }

        /// <summary>
        /// Número de cliente
        /// </summary>
        public int Numero
        {
            get {return (int) InternalData["cli_nro_numero"];}
            set {InternalData["cli_nro_numero"]= value;}
        }

        /// <summary>
        /// Razón social
        /// </summary>
        public static string RsocialCmp
        {
           get {return "cli_ede_rsocial";}
        }

        /// <summary>
        /// Razón social
        /// </summary>
        public string Rsocial
        {
            get {return ((string) InternalData["cli_ede_rsocial"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["cli_ede_rsocial"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Nombre de fantasía
        /// </summary>
        public static string NombrefantCmp
        {
           get {return "cli_des_nombrefant";}
        }

        /// <summary>
        /// Nombre de fantasía
        /// </summary>
        public string Nombrefant
        {
            get {return ((string) InternalData["cli_des_nombrefant"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cli_des_nombrefant"]= value.Trim();
            }
        }

        /// <summary>
        /// Tipo de Institucion
        /// </summary>
        public static string CodtinstCmp
        {
           get {return "cli_cod_codtinst";}
        }

        /// <summary>
        /// Tipo de Institucion
        /// </summary>
        public string Codtinst
        {
            get {return (string) InternalData["cli_cod_codtinst"];}
            set {InternalData["cli_cod_codtinst"]= ECliente.FrmtCodtinst(value);}
        }

        /// <summary>
        /// Franquicia
        /// </summary>
        public static string CodfrqCmp
        {
           get {return "cli_cod_codfrq";}
        }

        /// <summary>
        /// Franquicia
        /// </summary>
        public string Codfrq
        {
            get {return (string) InternalData["cli_cod_codfrq"];}
            set {InternalData["cli_cod_codfrq"]= ECliente.FrmtCodfrq(value);}
        }

        /// <summary>
        /// Alta en Avalon
        /// </summary>
        public static string AltaCmp
        {
           get {return "cli_cd1_alta";}
        }

        /// <summary>
        /// Alta en Avalon
        /// </summary>
        public string Alta
        {
            get {return (string) InternalData["cli_cd1_alta"];}
            set {InternalData["cli_cd1_alta"]= value;}
        }

        /// <summary>
        /// Teléfono 1
        /// </summary>
        public static string Telefono1Cmp
        {
           get {return "cli_tel_telefono1";}
        }

        /// <summary>
        /// Teléfono 1
        /// </summary>
        public string Telefono1
        {
            get {return ((string) InternalData["cli_tel_telefono1"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cli_tel_telefono1"]= value.Trim();
            }
        }

        /// <summary>
        /// Celular
        /// </summary>
        public static string CelularCmp
        {
           get {return "cli_tel_celular";}
        }

        /// <summary>
        /// Celular
        /// </summary>
        public string Celular
        {
            get {return ((string) InternalData["cli_tel_celular"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cli_tel_celular"]= value.Trim();
            }
        }

        /// <summary>
        /// Teléfono 2
        /// </summary>
        public static string Telefono2Cmp
        {
           get {return "cli_tel_telefono2";}
        }

        /// <summary>
        /// Teléfono 2
        /// </summary>
        public string Telefono2
        {
            get {return ((string) InternalData["cli_tel_telefono2"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cli_tel_telefono2"]= value.Trim();
            }
        }

        /// <summary>
        /// Fax
        /// </summary>
        public static string FaxCmp
        {
           get {return "cli_tel_fax";}
        }

        /// <summary>
        /// Fax
        /// </summary>
        public string Fax
        {
            get {return ((string) InternalData["cli_tel_fax"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cli_tel_fax"]= value.Trim();
            }
        }

        /// <summary>
        /// Dirección
        /// </summary>
        public static string DireccionCmp
        {
           get {return "cli_ede_direccion";}
        }

        /// <summary>
        /// Dirección
        /// </summary>
        public string Direccion
        {
            get {return ((string) InternalData["cli_ede_direccion"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["cli_ede_direccion"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Altura
        /// </summary>
        public static string AlturaCmp
        {
           get {return "cli_nro_altura";}
        }

        /// <summary>
        /// Altura
        /// </summary>
        public int Altura
        {
            get {return (int) InternalData["cli_nro_altura"];}
            set {InternalData["cli_nro_altura"]= value;}
        }

        /// <summary>
        /// Piso
        /// </summary>
        public static string PisoCmp
        {
           get {return "cli_rde_piso";}
        }

        /// <summary>
        /// Piso
        /// </summary>
        public string Piso
        {
            get {return ((string) InternalData["cli_rde_piso"]).Trim();}
            set {
                if (value.Trim().Length > 15) value= value.Trim().Substring(0,15);
                InternalData["cli_rde_piso"]= value.Trim();
            }
        }

        /// <summary>
        /// Oficina
        /// </summary>
        public static string OficinaCmp
        {
           get {return "cli_rde_oficina";}
        }

        /// <summary>
        /// Oficina
        /// </summary>
        public string Oficina
        {
            get {return ((string) InternalData["cli_rde_oficina"]).Trim();}
            set {
                if (value.Trim().Length > 15) value= value.Trim().Substring(0,15);
                InternalData["cli_rde_oficina"]= value.Trim();
            }
        }

        /// <summary>
        /// Código de localidad
        /// </summary>
        public static string CodlocalidadCmp
        {
           get {return "cli_ecd_codlocalidad";}
        }

        /// <summary>
        /// Código de localidad
        /// </summary>
        public string Codlocalidad
        {
            get {return (string) InternalData["cli_ecd_codlocalidad"];}
            set {InternalData["cli_ecd_codlocalidad"]= ECliente.FrmtCodlocalidad(value);}
        }

        /// <summary>
        /// Cuil
        /// </summary>
        public static string CuilCmp
        {
           get {return "cli_des_cuil";}
        }

        /// <summary>
        /// Cuil
        /// </summary>
        public string Cuil
        {
            get {return ((string) InternalData["cli_des_cuil"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cli_des_cuil"]= value.Trim();
            }
        }

        /// <summary>
        /// Url
        /// </summary>
        public static string UrlCmp
        {
           get {return "cli_xld_url";}
        }

        /// <summary>
        /// Url
        /// </summary>
        public string Url
        {
            get {return ((string) InternalData["cli_xld_url"]).Trim();}
            set {
                if (value.Trim().Length > 240) value= value.Trim().Substring(0,240);
                InternalData["cli_xld_url"]= value.Trim();
            }
        }

        /// <summary>
        /// Código de vendedor
        /// </summary>
        public static string CodvendCmp
        {
           get {return "cli_cd6_codvend";}
        }

        /// <summary>
        /// Código de vendedor
        /// </summary>
        public string Codvend
        {
            get {return (string) InternalData["cli_cd6_codvend"];}
            set {InternalData["cli_cd6_codvend"]= value;}
        }

        /// <summary>
        /// Extensión
        /// </summary>
        public static string ExtensionCmp
        {
           get {return "cli_cd1_extension";}
        }

        /// <summary>
        /// Extensión
        /// </summary>
        public string Extension
        {
            get {return ((string) InternalData["cli_cd1_extension"]).Trim();}
            set {
                if (value.Trim().Length > 1) value= value.Trim().Substring(0,1);
                InternalData["cli_cd1_extension"]= value.Trim();
            }
        }

        /// <summary>
        /// Horarios
        /// </summary>
        public static string HorariosCmp
        {
           get {return "cli_ede_horarios";}
        }

        /// <summary>
        /// Horarios
        /// </summary>
        public string Horarios
        {
            get {return ((string) InternalData["cli_ede_horarios"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["cli_ede_horarios"]= value.Trim();
            }
        }

        /// <summary>
        /// Fecha de ingreso
        /// </summary>
        public static string FingsimaCmp
        {
           get {return "cli_fec_fingsima";}
        }

        /// <summary>
        /// Fecha de ingreso
        /// </summary>
        public DateTime Fingsima
        {
            get {return (DateTime) InternalData["cli_fec_fingsima"];}
            set {InternalData["cli_fec_fingsima"]= value;}
        }

        /// <summary>
        /// Cantidad de Empleados
        /// </summary>
        public static string CantempleadosCmp
        {
           get {return "cli_nro_cantempleados";}
        }

        /// <summary>
        /// Cantidad de Empleados
        /// </summary>
        public int Cantempleados
        {
            get {return (int) InternalData["cli_nro_cantempleados"];}
            set {InternalData["cli_nro_cantempleados"]= value;}
        }

        /// <summary>
        /// Cobertura
        /// </summary>
        public static string CoberturaCmp
        {
           get {return "cli_txt_cobertura";}
        }

        /// <summary>
        /// Cobertura
        /// </summary>
        public string Cobertura
        {
            get {return (string) InternalData["cli_txt_cobertura"];}
            set {InternalData["cli_txt_cobertura"]= value;}
        }

        /// <summary>
        /// Usuario Cargador
        /// </summary>
        public static string CargadorCmp
        {
           get {return "cli_nom_cargador";}
        }

        /// <summary>
        /// Usuario Cargador
        /// </summary>
        public string Cargador
        {
            get {return ((string) InternalData["cli_nom_cargador"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["cli_nom_cargador"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Observacion
        /// </summary>
        public static string ObservacionCmp
        {
           get {return "cli_txt_observacion";}
        }

        /// <summary>
        /// Observacion
        /// </summary>
        public string Observacion
        {
            get {return (string) InternalData["cli_txt_observacion"];}
            set {InternalData["cli_txt_observacion"]= value;}
        }

        /// <summary>
        /// E-Mail
        /// </summary>
        public static string EmailCmp
        {
           get {return "cli_xld_email";}
        }

        /// <summary>
        /// E-Mail
        /// </summary>
        public string Email
        {
            get {return ((string) InternalData["cli_xld_email"]).Trim();}
            set {
                if (value.Trim().Length > 240) value= value.Trim().Substring(0,240);
                InternalData["cli_xld_email"]= value.Trim();
            }
        }

        /// <summary>
        /// Número Avalon
        /// </summary>
        public static string NroavalonCmp
        {
           get {return "cli_nro_nroavalon";}
        }

        /// <summary>
        /// Número Avalon
        /// </summary>
        public int Nroavalon
        {
            get {return (int) InternalData["cli_nro_nroavalon"];}
            set {InternalData["cli_nro_nroavalon"]= value;}
        }

        /// <summary>
        /// Abono
        /// </summary>
        public static string AbonoCmp
        {
           get {return "cli_imp_abono";}
        }

        /// <summary>
        /// Abono
        /// </summary>
        public decimal Abono
        {
            get {return (decimal) InternalData["cli_imp_abono"];}
            set {InternalData["cli_imp_abono"]= value;}
        }

        /// <summary>
        /// Tipo Contrato
        /// </summary>
        public static string CodtipocontCmp
        {
           get {return "cli_rcd_codtipocont";}
        }

        /// <summary>
        /// Tipo Contrato
        /// </summary>
        public string Codtipocont
        {
            get {return (string) InternalData["cli_rcd_codtipocont"];}
            set {InternalData["cli_rcd_codtipocont"]= ECliente.FrmtCodtipocont(value);}
        }

        /// <summary>
        /// Deuda
        /// </summary>
        public static string DeudaCmp
        {
           get {return "cli_imp_deuda";}
        }

        /// <summary>
        /// Deuda
        /// </summary>
        public decimal Deuda
        {
            get {return (decimal) InternalData["cli_imp_deuda"];}
            set {InternalData["cli_imp_deuda"]= value;}
        }

        /// <summary>
        /// Contactos de los Clientes
        /// </summary>
        public LECliContactos CliContactos
        {
            get {return m_lentCliContactos;}
            set {m_lentCliContactos= value;}
        }

        /// <summary>
        /// Entrevistas con los Clientes
        /// </summary>
        public LECliEntrevistas CliEntrevistas
        {
            get {return m_lentCliEntrevistas;}
            set {m_lentCliEntrevistas= value;}
        }

        /// <summary>
        /// Llamadas de los Clientes
        /// </summary>
        public LECliLlamadas CliLlamadas
        {
            get {return m_lentCliLlamadas;}
            set {m_lentCliLlamadas= value;}
        }

        /// <summary>
        /// Notas de los Clientes
        /// </summary>
        public LECliNotas CliNotas
        {
            get {return m_lentCliNotas;}
            set {m_lentCliNotas= value;}
        }

        /// <summary>
        /// Servicios de los Clientes
        /// </summary>
        public LECliServicios CliServicios
        {
            get {return m_lentCliServicios;}
            set {m_lentCliServicios= value;}
        }

        /// <summary>
        /// Ventas de los Clientes
        /// </summary>
        public LECliVentas CliVentas
        {
            get {return m_lentCliVentas;}
            set {m_lentCliVentas= value;}
        }

        /// <summary>
        /// Mayorista
        /// </summary>
        public string Cli_cd1_esmayo
        {
            get {return (string) InternalData["cli_cd1_esmayo"];}
            set {InternalData["cli_cd1_esmayo"]= value;}
        }

        /// <summary>
        /// Franquicia
        /// </summary>
        public string Cli_des_frq
        {
            get {return (string) InternalData["cli_des_frq"];}
            set {InternalData["cli_des_frq"]= value;}
        }

        /// <summary>
        /// Localidad
        /// </summary>
        public string Cli_des_loc
        {
            get {return (string) InternalData["cli_des_loc"];}
            set {InternalData["cli_des_loc"]= value;}
        }

        /// <summary>
        /// Provincia
        /// </summary>
        public string Cli_des_prov
        {
            get {return (string) InternalData["cli_des_prov"];}
            set {InternalData["cli_des_prov"]= value;}
        }

        /// <summary>
        /// T Institucion
        /// </summary>
        public string Cli_des_tinst
        {
            get {return (string) InternalData["cli_des_tinst"];}
            set {InternalData["cli_des_tinst"]= value;}
        }

        /// <summary>
        /// Zona
        /// </summary>
        public string Cli_des_zona
        {
            get {return (string) InternalData["cli_des_zona"];}
            set {InternalData["cli_des_zona"]= value;}
        }

        /// <summary>
        /// Partido
        /// </summary>
        public string Cli_ede_partido
        {
            get {return (string) InternalData["cli_ede_partido"];}
            set {InternalData["cli_ede_partido"]= value;}
        }

        /// <summary>
        /// Zona
        /// </summary>
        public string Cli_rcd_codzona
        {
            get {return (string) InternalData["cli_rcd_codzona"];}
            set {InternalData["cli_rcd_codzona"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliente] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ECliente] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ECliente", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_nro_numero", Numero));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_ede_rsocial", Rsocial));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_des_nombrefant", Nombrefant));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_cod_codtinst", Codtinst));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_cod_codfrq", Codfrq));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_cd1_alta", Alta));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_tel_telefono1", Telefono1));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_tel_celular", Celular));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_tel_telefono2", Telefono2));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_tel_fax", Fax));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_ede_direccion", Direccion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_nro_altura", Altura));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_rde_piso", Piso));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_rde_oficina", Oficina));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_ecd_codlocalidad", Codlocalidad));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_des_cuil", Cuil));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_xld_url", Url));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_cd6_codvend", Codvend));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_cd1_extension", Extension));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_ede_horarios", Horarios));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_fec_fingsima", Fingsima));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_nro_cantempleados", Cantempleados));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_txt_cobertura", Cobertura));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_nom_cargador", Cargador));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_txt_observacion", Observacion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_xld_email", Email));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_nro_nroavalon", Nroavalon));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_imp_abono", Abono));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_rcd_codtipocont", Codtipocont));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_imp_deuda", Deuda));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_cd1_esmayo", Cli_cd1_esmayo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_des_frq", Cli_des_frq));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_des_loc", Cli_des_loc));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_des_prov", Cli_des_prov));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_des_tinst", Cli_des_tinst));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_des_zona", Cli_des_zona));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_ede_partido", Cli_ede_partido));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cli_rcd_codzona", Cli_rcd_codzona));

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

    #region Lista-Entidad: Clientes
    /// <summary>
    /// Clase que representa la Lista-Entidad: Clientes
    /// </summary>
    public sealed partial class LEClientes : ListaEntidades, IEnumerable<ECliente>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Clientes
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEClientes(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEClientes(string p_strXMLData) :
            base(ECliente.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ECliente(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEClientes(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Clientes
        /// </summary>
        /// <returns>Lista-Entidad vacia: Clientes</returns>
        public static LEClientes NewEmpty()
        {
            return new LEClientes(ECliente.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entECliente">Entidad a agregar</param>
        public void AddEntity(ECliente p_entECliente)
        {
            base.AddEntity(p_entECliente);
        }

        /// <summary>
        /// Remueve una entidad [Cliente] por clave
        /// </summary>
        public int RemoveEntity(int p_iNumero)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "cli_nro_numero = " + Ruts.Nu(p_iNumero);

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
        /// Verifca si una entidad [Cliente] esta en la lista
        /// </summary>
        public bool Contains(int p_iNumero)
        {
            using (ECliente l_entTemp= this[p_iNumero])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Clientes
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ECliente> GetEnumerator() 
        {
            ECliente l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ECliente(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Clientes
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ECliente l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Clientes
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETClientes GetAsLET()
        {
            // Llenamos la lista tipada
            LETClientes l_lentRet= new LETClientes();

            foreach (ECliente l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Clientes>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ECliente> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ECliente>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Cliente] por indice
        /// </summary>
        public new ECliente this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Cliente con los datos de la fila
                return new ECliente(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Cliente] por clave
        /// </summary>
        public ECliente this[int p_iNumero]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "cli_nro_numero = " + Ruts.Nu(p_iNumero);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Cliente con los datos de la fila
                if (l_drData == null) return null;
                return new ECliente(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEClientes", null);

                foreach (ECliente l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Clientes
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Clientes
    /// </summary>
    public sealed partial class LETClientes : LET<ECliente>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Clientes
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEClientes GetAsLE()
        {
            // Llenamos la lista
            LEClientes l_lentRet= LEClientes.NewEmpty();

            foreach (ECliente l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------


        /// <summary>
        /// Indexer para acceder a cada entidad [Cliente] por indice
        /// </summary>
        public ECliente this[long p_lIndice]
        {
            get {return base[(int) p_lIndice];}
        }
        /// <summary>
        /// Indexer para acceder a cada entidad [Cliente] por clave
        /// </summary>
        public new ECliente this[int p_iNumero]
        {
            get {
                // Buscamos la entidad
                foreach (ECliente l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Numero == p_iNumero)
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
