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
    // Clase para Administrar   : Vendedores
    //----------------------------------------------------------------------------
    // © 1996-2023 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    #region Entidad: Vendedor
    /// <summary>
    /// Clase que representa la Entidad: Vendedor
    /// </summary>
    public sealed partial class EVendedor : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Vendedores
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EVendedor(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Vendedor
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EVendedor(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Vendedor
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EVendedor(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EVendedor.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["vnd_cd6_cod"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_cd6_cod");
            l_drTemp["vnd_des_apellido"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_des_apellido");
            l_drTemp["vnd_des_nombre"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_des_nombre");
            l_drTemp["vnd_nom_usuario"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_nom_usuario");
            l_drTemp["vnd_tel_tel1"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_tel_tel1");
            l_drTemp["vnd_tel_celular"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_tel_celular");
            l_drTemp["vnd_tel_tel2"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_tel_tel2");
            l_drTemp["vnd_fec_fecnacim"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_fec_fecnacim", true);
            l_drTemp["vnd_ede_direccion"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_ede_direccion");
            l_drTemp["vnd_cd6_codsuperv"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_cd6_codsuperv");
            l_drTemp["vnd_rcd_codtvend"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_rcd_codtvend");
            l_drTemp["vnd_txt_horarios"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_txt_horarios");
            l_drTemp["vnd_cd1_historico"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_cd1_historico");
            l_drTemp["vnd_cd1_vemayor"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_cd1_vemayor");
            l_drTemp["vnd_des_tipovnd"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_des_tipovnd");
            l_drTemp["vnd_ede_nya"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_ede_nya");
            l_drTemp["vnd_nom_superv"]= XMLRuts.ExtractXAttr(l_xndData, "vnd_nom_superv");

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
        private EVendedor(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Vendedor
        /// </summary>
        /// <returns>Entidad vacia: Vendedor</returns>
        public static EVendedor NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EVendedor.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["vnd_cd6_cod"]= "";
            l_drTemp["vnd_des_apellido"]= "";
            l_drTemp["vnd_des_nombre"]= "";
            l_drTemp["vnd_nom_usuario"]= "";
            l_drTemp["vnd_tel_tel1"]= "";
            l_drTemp["vnd_tel_celular"]= "";
            l_drTemp["vnd_tel_tel2"]= "";
            l_drTemp["vnd_fec_fecnacim"]= DateTimeRuts.Empty;
            l_drTemp["vnd_ede_direccion"]= "";
            l_drTemp["vnd_cd6_codsuperv"]= "";
            l_drTemp["vnd_rcd_codtvend"]= "";
            l_drTemp["vnd_txt_horarios"]= "";
            l_drTemp["vnd_cd1_historico"]= "";
            l_drTemp["vnd_cd1_vemayor"]= "";
            l_drTemp["vnd_des_tipovnd"]= "";
            l_drTemp["vnd_ede_nya"]= "";
            l_drTemp["vnd_nom_superv"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EVendedor l_entRet= new EVendedor(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Vendedor
        /// </summary>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_strApellido">Apellido</param>
        /// <param name="p_strNombre">Nombre</param>
        /// <param name="p_strUsuario">Usuario Sistema</param>
        /// <param name="p_strTel1">Telefono1</param>
        /// <param name="p_strCelular">Celular</param>
        /// <param name="p_strTel2">Telefono2</param>
        /// <param name="p_dtFecnacim">Fecha Nacimiento</param>
        /// <param name="p_strDireccion">Dirección</param>
        /// <param name="p_strCodsuperv">Supervisor</param>
        /// <param name="p_strCodtvend">Tipo Vendedor</param>
        /// <param name="p_strHorarios">Horarios</param>
        /// <param name="p_strHistorico">Es Historico</param>
        /// <returns>Entidad: Vendedor</returns>
        public static EVendedor NewFilled(string p_strCod,
                                          string p_strApellido,
                                          string p_strNombre,
                                          string p_strUsuario,
                                          string p_strTel1,
                                          string p_strCelular,
                                          string p_strTel2,
                                          DateTime p_dtFecnacim,
                                          string p_strDireccion,
                                          string p_strCodsuperv,
                                          string p_strCodtvend,
                                          string p_strHorarios,
                                          string p_strHistorico)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EVendedor.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["vnd_cd6_cod"]= p_strCod;
            l_drTemp["vnd_des_apellido"]= p_strApellido;
            l_drTemp["vnd_des_nombre"]= p_strNombre;
            l_drTemp["vnd_nom_usuario"]= p_strUsuario;
            l_drTemp["vnd_tel_tel1"]= p_strTel1;
            l_drTemp["vnd_tel_celular"]= p_strCelular;
            l_drTemp["vnd_tel_tel2"]= p_strTel2;
            l_drTemp["vnd_fec_fecnacim"]= p_dtFecnacim;
            l_drTemp["vnd_ede_direccion"]= p_strDireccion;
            l_drTemp["vnd_cd6_codsuperv"]= p_strCodsuperv;
            l_drTemp["vnd_rcd_codtvend"]= p_strCodtvend;
            l_drTemp["vnd_txt_horarios"]= p_strHorarios;
            l_drTemp["vnd_cd1_historico"]= p_strHistorico;
            l_drTemp["vnd_cd1_vemayor"]= "";
            l_drTemp["vnd_des_tipovnd"]= "";
            l_drTemp["vnd_ede_nya"]= "";
            l_drTemp["vnd_nom_superv"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EVendedor l_entRet= new EVendedor(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Tipo Vendedor
        /// </summary>
        public static string FrmtCodtvend(string p_strCodtvend)
        {
            if (p_strCodtvend.Trim().Length > 2)
                p_strCodtvend= p_strCodtvend.Trim().Substring(0,2);

            return p_strCodtvend.Trim().PadLeft(2).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[21];

                l_dcStruct[0]= new DataColumn("vnd_cd6_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("vnd_des_apellido", typeof(string));
                l_dcStruct[2]= new DataColumn("vnd_des_nombre", typeof(string));
                l_dcStruct[3]= new DataColumn("vnd_nom_usuario", typeof(string));
                l_dcStruct[4]= new DataColumn("vnd_ede_nya", typeof(string));
                l_dcStruct[5]= new DataColumn("vnd_tel_tel1", typeof(string));
                l_dcStruct[6]= new DataColumn("vnd_tel_celular", typeof(string));
                l_dcStruct[7]= new DataColumn("vnd_tel_tel2", typeof(string));
                l_dcStruct[8]= new DataColumn("vnd_fec_fecnacim", typeof(DateTime));
                l_dcStruct[9]= new DataColumn("vnd_ede_direccion", typeof(string));
                l_dcStruct[10]= new DataColumn("vnd_cd6_codsuperv", typeof(string));
                l_dcStruct[11]= new DataColumn("vnd_nom_superv", typeof(string));
                l_dcStruct[12]= new DataColumn("vnd_rcd_codtvend", typeof(string));
                l_dcStruct[13]= new DataColumn("vnd_cd1_vemayor", typeof(string));
                l_dcStruct[14]= new DataColumn("vnd_des_tipovnd", typeof(string));
                l_dcStruct[15]= new DataColumn("vnd_txt_horarios", typeof(string));
                l_dcStruct[16]= new DataColumn("vnd_cd1_historico", typeof(string));
                EVendedor.FillFixedFields(ref l_dcStruct, 17);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Código
        /// </summary>
        public static string CodCmp
        {
           get {return "vnd_cd6_cod";}
        }

        /// <summary>
        /// Código
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["vnd_cd6_cod"];}
            set {
                if (value.Trim().Length > 6) value= value.Trim().Substring(0,6);
                InternalData["vnd_cd6_cod"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Apellido
        /// </summary>
        public static string ApellidoCmp
        {
           get {return "vnd_des_apellido";}
        }

        /// <summary>
        /// Apellido
        /// </summary>
        public string Apellido
        {
            get {return ((string) InternalData["vnd_des_apellido"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["vnd_des_apellido"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public static string NombreCmp
        {
           get {return "vnd_des_nombre";}
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public string Nombre
        {
            get {return ((string) InternalData["vnd_des_nombre"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["vnd_des_nombre"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Usuario Sistema
        /// </summary>
        public static string UsuarioCmp
        {
           get {return "vnd_nom_usuario";}
        }

        /// <summary>
        /// Usuario Sistema
        /// </summary>
        public string Usuario
        {
            get {return ((string) InternalData["vnd_nom_usuario"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["vnd_nom_usuario"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Telefono1
        /// </summary>
        public static string Tel1Cmp
        {
           get {return "vnd_tel_tel1";}
        }

        /// <summary>
        /// Telefono1
        /// </summary>
        public string Tel1
        {
            get {return ((string) InternalData["vnd_tel_tel1"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["vnd_tel_tel1"]= value.Trim();
            }
        }

        /// <summary>
        /// Celular
        /// </summary>
        public static string CelularCmp
        {
           get {return "vnd_tel_celular";}
        }

        /// <summary>
        /// Celular
        /// </summary>
        public string Celular
        {
            get {return ((string) InternalData["vnd_tel_celular"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["vnd_tel_celular"]= value.Trim();
            }
        }

        /// <summary>
        /// Telefono2
        /// </summary>
        public static string Tel2Cmp
        {
           get {return "vnd_tel_tel2";}
        }

        /// <summary>
        /// Telefono2
        /// </summary>
        public string Tel2
        {
            get {return ((string) InternalData["vnd_tel_tel2"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["vnd_tel_tel2"]= value.Trim();
            }
        }

        /// <summary>
        /// Fecha Nacimiento
        /// </summary>
        public static string FecnacimCmp
        {
           get {return "vnd_fec_fecnacim";}
        }

        /// <summary>
        /// Fecha Nacimiento
        /// </summary>
        public DateTime Fecnacim
        {
            get {return (DateTime) InternalData["vnd_fec_fecnacim"];}
            set {InternalData["vnd_fec_fecnacim"]= value;}
        }

        /// <summary>
        /// Dirección
        /// </summary>
        public static string DireccionCmp
        {
           get {return "vnd_ede_direccion";}
        }

        /// <summary>
        /// Dirección
        /// </summary>
        public string Direccion
        {
            get {return ((string) InternalData["vnd_ede_direccion"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["vnd_ede_direccion"]= value.Trim();
            }
        }

        /// <summary>
        /// Supervisor
        /// </summary>
        public static string CodsupervCmp
        {
           get {return "vnd_cd6_codsuperv";}
        }

        /// <summary>
        /// Supervisor
        /// </summary>
        public string Codsuperv
        {
            get {return (string) InternalData["vnd_cd6_codsuperv"];}
            set {InternalData["vnd_cd6_codsuperv"]= value;}
        }

        /// <summary>
        /// Tipo Vendedor
        /// </summary>
        public static string CodtvendCmp
        {
           get {return "vnd_rcd_codtvend";}
        }

        /// <summary>
        /// Tipo Vendedor
        /// </summary>
        public string Codtvend
        {
            get {return (string) InternalData["vnd_rcd_codtvend"];}
            set {InternalData["vnd_rcd_codtvend"]= EVendedor.FrmtCodtvend(value);}
        }

        /// <summary>
        /// Horarios
        /// </summary>
        public static string HorariosCmp
        {
           get {return "vnd_txt_horarios";}
        }

        /// <summary>
        /// Horarios
        /// </summary>
        public string Horarios
        {
            get {return (string) InternalData["vnd_txt_horarios"];}
            set {InternalData["vnd_txt_horarios"]= value;}
        }

        /// <summary>
        /// Es Historico
        /// </summary>
        public static string HistoricoCmp
        {
           get {return "vnd_cd1_historico";}
        }

        /// <summary>
        /// Es Historico
        /// </summary>
        public string Historico
        {
            get {return ((string) InternalData["vnd_cd1_historico"]).Trim();}
            set {
                if (value.Trim().Length > 1) value= value.Trim().Substring(0,1);
                InternalData["vnd_cd1_historico"]= value.Trim();
            }
        }

        /// <summary>
        /// Ve Mayoristas
        /// </summary>
        public string Vnd_cd1_vemayor
        {
            get {return (string) InternalData["vnd_cd1_vemayor"];}
            set {InternalData["vnd_cd1_vemayor"]= value;}
        }

        /// <summary>
        /// Tipo vendedor
        /// </summary>
        public string Vnd_des_tipovnd
        {
            get {return (string) InternalData["vnd_des_tipovnd"];}
            set {InternalData["vnd_des_tipovnd"]= value;}
        }

        /// <summary>
        /// Nombre Completo
        /// </summary>
        public string Vnd_ede_nya
        {
            get {return (string) InternalData["vnd_ede_nya"];}
            set {InternalData["vnd_ede_nya"]= value;}
        }

        /// <summary>
        /// Supervisor
        /// </summary>
        public string Vnd_nom_superv
        {
            get {return (string) InternalData["vnd_nom_superv"];}
            set {InternalData["vnd_nom_superv"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EVendedor] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EVendedor] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EVendedor", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_cd6_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_des_apellido", Apellido));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_des_nombre", Nombre));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_nom_usuario", Usuario));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_tel_tel1", Tel1));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_tel_celular", Celular));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_tel_tel2", Tel2));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_fec_fecnacim", Fecnacim));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_ede_direccion", Direccion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_cd6_codsuperv", Codsuperv));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_rcd_codtvend", Codtvend));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_txt_horarios", Horarios));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_cd1_historico", Historico));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_cd1_vemayor", Vnd_cd1_vemayor));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_des_tipovnd", Vnd_des_tipovnd));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_ede_nya", Vnd_ede_nya));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "vnd_nom_superv", Vnd_nom_superv));

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

    #region Lista-Entidad: Vendedores
    /// <summary>
    /// Clase que representa la Lista-Entidad: Vendedores
    /// </summary>
    public sealed partial class LEVendedores : ListaEntidades, IEnumerable<EVendedor>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Vendedores
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEVendedores(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEVendedores(string p_strXMLData) :
            base(EVendedor.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EVendedor(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEVendedores(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Vendedores
        /// </summary>
        /// <returns>Lista-Entidad vacia: Vendedores</returns>
        public static LEVendedores NewEmpty()
        {
            return new LEVendedores(EVendedor.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEVendedor">Entidad a agregar</param>
        public void AddEntity(EVendedor p_entEVendedor)
        {
            base.AddEntity(p_entEVendedor);
        }

        /// <summary>
        /// Remueve una entidad [Vendedor] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "vnd_cd6_cod = " + Ruts.Co(p_strCod);

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
        /// Verifca si una entidad [Vendedor] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EVendedor l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Vendedores
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EVendedor> GetEnumerator() 
        {
            EVendedor l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EVendedor(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Vendedores
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EVendedor l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Vendedores
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETVendedores GetAsLET()
        {
            // Llenamos la lista tipada
            LETVendedores l_lentRet= new LETVendedores();

            foreach (EVendedor l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Vendedores>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EVendedor> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EVendedor>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Vendedor] por indice
        /// </summary>
        public new EVendedor this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Vendedor con los datos de la fila
                return new EVendedor(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Vendedor] por clave
        /// </summary>
        public EVendedor this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "vnd_cd6_cod = " + Ruts.Co(p_strCod);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Vendedor con los datos de la fila
                if (l_drData == null) return null;
                return new EVendedor(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEVendedores", null);

                foreach (EVendedor l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Vendedores
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Vendedores
    /// </summary>
    public sealed partial class LETVendedores : LET<EVendedor>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Vendedores
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEVendedores GetAsLE()
        {
            // Llenamos la lista
            LEVendedores l_lentRet= LEVendedores.NewEmpty();

            foreach (EVendedor l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Vendedor] por clave
        /// </summary>
        public EVendedor this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EVendedor l_entItem in this) {
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
