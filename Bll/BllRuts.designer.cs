#region Usings
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using Carm;
using Carm.Bel;
#endregion

namespace Carm.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 03/01/2023 23:43
    // Sistema                  : Carm
    // Clase para Administrar   : 
    //----------------------------------------------------------------------------
    // © 1996-2023 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************
    /// <summary>
    /// Rutinas de apoyo a la Bll
    /// </summary>
    internal static partial class BllRuts
    {
        //---------------------------------------------------------------
        // Metodos públicos de la clase 
        //---------------------------------------------------------------

        #region Funciones Generales

        /// <summary>
        /// Devuelve la fecha del server (con Hora)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Fecha del server</returns>
        public static DateTime GetDBNow(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            // Llamamos al metodo basico
            DateTime l_dtRet= GetDBNow(p_dbcAccess, false, p_smResult);
            if (p_smResult.NOk) return DateTimeRuts.Empty;

            // Terminamos
            return l_dtRet;
        }

        /// <summary>
        /// Devuelve la fecha del server (con opcion para devolver solo la fecha)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyDate">Solo devolver la fecha</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Fecha del server</returns>
        public static DateTime GetDBNow(DBConn p_dbcAccess,
                                        bool p_bOnlyDate,
                                        StatMsg p_smResult)
        {
            try {
                // Recuperamos la fecha del server
                return AppRuts.GetDBNow(p_dbcAccess, p_bOnlyDate, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return DateTimeRuts.Empty;
            }
        }

        #endregion

        #region Funciones de Captions

        /// <summary>
        /// Completa los captions de las columnas standard
        /// </summary>
        /// <param name="p_lentDatos">ListaEntidad a completar</param>
        public static void FillStdCaptions(ref ListaEntidades p_lentDatos)
        {
            // Limpiamos los captions
            p_lentDatos.ClearCaptions();

            // Cambiamos el caption de cada columna
            foreach (DataColumn l_dcInfo in p_lentDatos.InternalData.Table.Columns)
                p_lentDatos.ChangeCaption(l_dcInfo.ColumnName, GetColCaption(l_dcInfo.ColumnName));
        }

        #endregion

        //---------------------------------------------------------------
        // Metodos privados de la clase 
        //---------------------------------------------------------------

        #region Funciones de Captions

        /// <summary>
        /// Devuelve el caption standard de un campo
        /// </summary>
        /// <param name="p_strColumn">Nombre de la columna</param>
        private static string GetColCaption(string p_strColumn)
        {
            // Vemos si el codigo fijo lo resuelve
            string l_strCaption= fGetColCaption(p_strColumn);
            if (l_strCaption.Length != 0) return l_strCaption;

            // Devolvemos el caption según el campo
            switch (p_strColumn) {
                // ****************************************
                // Tabla: CategoriasLlamada   
                case "ctl_rcd_cod"                     : {return "V1CodigoCN1";}
                case "ctl_des_des"                     : {return "V1CategoríaCN1";}
                case "ctl_cd1_tipo"                    : {return "V1Tipo de llamadaCN2";}

                // ****************************************
                // Tabla: CliContactos        
                case "clc_nro_numcliente"              : {return "V1Número de clienteNN3";}
                case "clc_nro_numcontacto"             : {return "V1NúmeroNN3";}
                case "clc_des_nombre"                  : {return "V1Apellido y NombreCN1";}
                case "clc_des_cargo"                   : {return "V1CargoCN1";}
                case "clc_des_titulo"                  : {return "V1TítuloCN1";}
                case "clc_tel_celular"                 : {return "V1CelularCN1";}
                case "clc_tel_telefono1"               : {return "V1Teléfono 1CN1";}
                case "clc_tel_telefono2"               : {return "V1Teléfono 2CN1";}
                case "clc_tel_interno"                 : {return "V1InternoCN1";}
                case "clc_xld_email"                   : {return "V1EmailCN1";}
                case "clc_des_secretaria"              : {return "V1SecretariaCN1";}
                case "clc_cd1_activo"                  : {return "V1ActivoCN2";}
                case "clc_des_rsocial"                 : {return "V1Razon SocialCN1";}

                // ****************************************
                // Tabla: CliEntrevistas      
                case "cle_nro_numcliente"              : {return "V1Número de clienteNN3";}
                case "cle_nro_numentrev"               : {return "V1NúmeroNN3";}
                case "cle_fyh_fcoordinada"             : {return "V1Fecha coordinadaDN2";}
                case "cle_fyh_frealizada"              : {return "V1Fecha realizadaDN2";}
                case "cle_cd6_codvend"                 : {return "V1Código de VendedorCN1";}
                case "cle_ede_motcambiof"              : {return "V1Motivo cambio fechaCN1";}
                case "cle_des_nombre"                  : {return "V1NombreCN1";}
                case "cle_tel_telefono"                : {return "V1TeléfonoCN1";}
                case "cle_des_cargo"                   : {return "V1CargoCN1";}
                case "cle_des_titulo"                  : {return "V1TítuloCN1";}
                case "cle_tel_celular"                 : {return "V1CelularCN1";}
                case "cle_xld_email"                   : {return "V1EmailCN1";}
                case "cle_xld_direccion"               : {return "V1DirecciónCN1";}
                case "cle_txt_observaciones"           : {return "V1ObservacionesCN1";}
                case "cle_rcd_codresultado"            : {return "V1Código de resultadoCN1";}
                case "cle_ede_informe"                 : {return "V1InformeCN1";}
                case "cle_des_secretaria"              : {return "V1SecretariaCN1";}
                case "cle_cd1_borrada"                 : {return "V1BorradaCN2";}
                case "cle_cd1_pend"                    : {return "V1PendienteCN2";}
                case "cle_des_rsocial"                 : {return "V1Razon socialCN1";}
                case "cle_des_vend"                    : {return "V1VendedorCN1";}

                // ****************************************
                // Tabla: CliGrupoFamiliar    
                case "cgf_nro_numcliente"              : {return "V1Nro ClienteNN3";}
                case "cgf_nro_numintegrante"           : {return "V1Nro Integrante GFNN3";}
                case "cgf_ede_apellido"                : {return "V1ApellidoCN1";}
                case "cgf_ede_nombre"                  : {return "V1NombreCN1";}
                case "cgf_rcd_codparentesco"           : {return "V1ParentescoCN1";}
                case "cgf_d20_dni"                     : {return "V1DNICN1";}
                case "cgf_fec_fechanacimiento"         : {return "V1Fecha NacimientoFN2";}
                case "cgf_ede_obrasocial"              : {return "V1Obra SocialCN1";}
                case "des_parentesco"                  : {return "V1ParentescoCN1";}

                // ****************************************
                // Tabla: CliLlamadas         
                case "cll_nro_numcliente"              : {return "V1Número de clienteNN3";}
                case "cll_nro_numllamada"              : {return "V1Número de llamadaNN3";}
                case "cll_cod_codmotivo"               : {return "V1Código de motivoCN1";}
                case "cll_fyh_frealizada"              : {return "V1Fecha RealizadaDN2";}
                case "cll_txt_resultado"               : {return "V1ResultadoCN1";}
                case "cll_nom_codusuario"              : {return "V1Código del usuarioCN1";}
                case "cll_cd1_baja"                    : {return "V1Produjo BajaCN2";}
                case "cll_nro_numcontacto"             : {return "V1Número de contactoNN3";}
                case "cll_txt_obsprogramada"           : {return "V1ObservaciónCN1";}
                case "cll_imp_abonoanterior"           : {return "V1Abono Anterior2N3";}
                case "cll_imp_abonorecuperado"         : {return "V1Abono Recuperador2N3";}
                case "cll_nom_programador"             : {return "V1Usuario ProgramadorCN1";}
                case "cll_imp_ajuste"                  : {return "V1Ajuste2N3";}
                case "cll_des_motivo"                  : {return "V1MotivoCN1";}
                case "cll_ede_rsocial"                 : {return "V1Razón SocialCN1";}

                // ****************************************
                // Tabla: CliNotas            
                case "cln_nro_numcliente"              : {return "V1Numero del ClienteNN3";}
                case "cln_fyh_fechayhora"              : {return "V1Fecha y HoraDN2";}
                case "cln_des_titulo"                  : {return "V1TítuloCN1";}
                case "cln_xld_texto"                   : {return "V1TextoCN1";}
                case "cln_cd1_tipo"                    : {return "V1TipoCN2";}
                case "cln_nom_escritor"                : {return "V1Usuario EscritorCN1";}
                case "cln_nom_removedor"               : {return "V1Usuario RemovedorCN1";}
                case "cln_fyh_fyhremovida"             : {return "V1Fecha y Hora RemovidaDN2";}
                case "cln_cd1_borrada"                 : {return "V1BorradaCN2";}

                // ****************************************
                // Tabla: CliServicios        
                case "cls_nro_numcliente"              : {return "V1Número ClienteNN3";}
                case "cls_nro_item"                    : {return "V1ItemNN3";}
                case "cls_cod_codservicio"             : {return "V1Código de ServicioCN1";}
                case "cls_imp_coseguro"                : {return "V1Coseguro2N3";}
                case "cls_imp_valorprestacion"         : {return "V1Valor Prestación2N3";}
                case "cls_nro_cantestprestaciones"     : {return "V1Cant. Estimada PrestacionesNN3";}
                case "cls_des_serv"                    : {return "V1ServicioCN1";}

                // ****************************************
                // Tabla: CliVentas           
                case "clv_nro_numcliente"              : {return "V1Numero ClienteNN3";}
                case "clv_fyh_fecha"                   : {return "V1Fecha VentaDN2";}
                case "clv_cd6_codvendedor"             : {return "V1VendedorCN1";}
                case "clv_rcd_codtipocontrato"         : {return "V1Tipo ContratoCN1";}
                case "clv_imp_abono"                   : {return "V1Abono2N3";}
                case "clv_nro_cantcapitas"             : {return "V1CapitasNN3";}
                case "clv_imp_valorcapita"             : {return "V1Valor Capita2N3";}
                case "clv_des_destcon"                 : {return "V1T. ContratoCN1";}
                case "vnd_des_desvend"                 : {return "V1VendedorCN1";}

                // ****************************************
                // Tabla: Clientes            
                case "cli_nro_numero"                  : {return "V1Número de clienteNN3";}
                case "cli_ede_rsocial"                 : {return "V1Razón socialCN1";}
                case "cli_des_nombrefant"              : {return "V1Nombre de fantasíaCN1";}
                case "cli_cod_codtinst"                : {return "V1Tipo de InstitucionCN1";}
                case "cli_cod_codfrq"                  : {return "V1FranquiciaCN1";}
                case "cli_cd1_alta"                    : {return "V1Alta en AvalonCN2";}
                case "cli_tel_telefono1"               : {return "V1Teléfono 1CN1";}
                case "cli_tel_celular"                 : {return "V1CelularCN1";}
                case "cli_tel_telefono2"               : {return "V1Teléfono 2CN1";}
                case "cli_tel_fax"                     : {return "V1FaxCN1";}
                case "cli_ede_direccion"               : {return "V1DirecciónCN1";}
                case "cli_nro_altura"                  : {return "V1AlturaNN3";}
                case "cli_rde_piso"                    : {return "V1PisoCN1";}
                case "cli_rde_oficina"                 : {return "V1OficinaCN1";}
                case "cli_ecd_codlocalidad"            : {return "V1Código de localidadCN1";}
                case "cli_des_cuil"                    : {return "V1CuilCN1";}
                case "cli_xld_url"                     : {return "V1UrlCN1";}
                case "cli_cd6_codvend"                 : {return "V1Código de vendedorCN1";}
                case "cli_fec_fechaingreso"            : {return "V1Fecha de ingresoFN2";}
                case "cli_nro_cantempleados"           : {return "V1Cantidad de EmpleadosNN3";}
                case "cli_txt_cobertura"               : {return "V1CoberturaCN1";}
                case "cli_nom_cargador"                : {return "V1Usuario CargadorCN1";}
                case "cli_txt_observacion"             : {return "V1ObservacionCN1";}
                case "cli_xld_email"                   : {return "V1E-MailCN1";}
                case "cli_nro_nroavalon"               : {return "V1Número AvalonNN3";}
                case "cli_imp_abono"                   : {return "V1Abono2N3";}
                case "cli_rcd_codtipocont"             : {return "V1Tipo ContratoCN1";}
                case "cli_imp_deuda"                   : {return "V1Deuda2N3";}
                case "cli_cd1_sexo"                    : {return "V1SexoCN2";}
                case "cli_des_tarjetacred"             : {return "V1Tarjeta de CréditoCN1";}
                case "cli_cd1_fueclienteantes"         : {return "V1Fue Cliente AntesCN2";}
                case "cli_ede_titular"                 : {return "V1TitularCN1";}
                case "cli_ede_direccioncobertura"      : {return "V1Direccion CoberturaCN1";}
                case "cli_nro_alturacobertura"         : {return "V1Altura CoberturaNN3";}
                case "cli_rde_pisocobertura"           : {return "V1Piso CoberturaCN1";}
                case "cli_rde_oficinacobertura"        : {return "V1Oficina CoberturaCN1";}
                case "cli_ecd_codloccobertura"         : {return "V1Localidad CoberturaCN1";}
                case "cli_rcd_codmarca"                : {return "V1MarcaCN1";}
                case "cli_rcd_tipocliente"             : {return "V1Tipo ClienteCN1";}
                case "cli_fec_fechanacimiento"         : {return "V1Fecha nacimientoFN2";}
                case "cli_rcd_situacioniva"            : {return "V1Situacion IVACN1";}
                case "cli_xde_apellido"                : {return "V1ApellidoCN1";}
                case "cli_ede_nombre"                  : {return "V1NombreCN1";}
                case "cli_rcd_codrubro"                : {return "V1RubroCN1";}
                case "cli_fec_fecultimocontacto"       : {return "V1Fecha Último ContactoFN2";}
                case "cli_fec_fechaproxcontacto"       : {return "V1Fecha Próximo ContactoFN2";}
                case "cli_cd1_rellamar"                : {return "V1Volver a LlamarCN2";}
                case "cli_des_frq"                     : {return "V1FranquiciaCN1";}
                case "cli_des_loc"                     : {return "V1LocalidadCN1";}
                case "cli_des_prov"                    : {return "V1ProvinciaCN1";}
                case "cli_des_tinst"                   : {return "V1T InstitucionCN1";}
                case "cli_des_zona"                    : {return "V1ZonaCN1";}
                case "cli_ede_partido"                 : {return "V1PartidoCN1";}
                case "cli_rcd_codzona"                 : {return "V1ZonaCN1";}

                // ****************************************
                // Tabla: ConversionColores   
                case "con_cod_cod"                     : {return "V1CódigoCN1";}
                case "con_des_coloraconvertir"         : {return "V1Color a ConvertirCN1";}
                case "con_cd1_colorconvertido"         : {return "V1Color ConvertidoCN2";}

                // ****************************************
                // Tabla: Franquicias         
                case "frq_cod_cod"                     : {return "V1CodigoCN1";}
                case "frq_des_des"                     : {return "V1DescripcionCN1";}

                // ****************************************
                // Tabla: Localidades         
                case "loc_ecd_codpost"                 : {return "V1Código postalCN1";}
                case "loc_ede_nombre"                  : {return "V1NombreCN1";}
                case "loc_rcd_codzona"                 : {return "V1ZonaCN1";}
                case "loc_ede_partido"                 : {return "V1PartidoCN1";}
                case "loc_des_provincia"               : {return "V1ProvinciaCN1";}
                case "loc_ede_nomgoogle"               : {return "V1Nombre en googleCN1";}
                case "loc_cd1_directa"                 : {return "V1Busqueda DirectaCN2";}
                case "loc_des_zona"                    : {return "V1ZonaCN1";}

                // ****************************************
                // Tabla: LogClientes         
                case "lgc_nro_nro"                     : {return "V1NumeroNN3";}
                case "lgc_nro_nrocliente"              : {return "V1Número ClienteNN3";}
                case "lgc_nro_nroavalon"               : {return "V1Número AvalonNN3";}
                case "lgc_ede_rsocial"                 : {return "V1Razon SocialCN1";}
                case "lgc_des_nomfantasia"             : {return "V1Nombre FantasiaCN1";}
                case "lgc_des_accion"                  : {return "V1AcciónCN1";}
                case "lgc_nom_usuario"                 : {return "V1UsuarioCN1";}
                case "lgc_fyh_fecha"                   : {return "V1FechaDN2";}

                // ****************************************
                // Tabla: Marcas              
                case "mrc_rcd_cod"                     : {return "V1CodigoCN1";}
                case "mrc_ede_des"                     : {return "V1DescripcionCN1";}
                case "mrc_ecd_codlocalidad"            : {return "V1LocalidadCN1";}
                case "des_localidad"                   : {return "V1LocalidadCN1";}

                // ****************************************
                // Tabla: MotivosLlamada      
                case "mot_cod_cod"                     : {return "V1CódigoCN1";}
                case "mot_des_des"                     : {return "V1MotivoCN1";}
                case "mot_rcd_codcategoria"            : {return "V1CategoriaCN1";}
                case "mot_cd1_esreclamo"               : {return "V1ReclamoCN2";}
                case "mot_des_categ"                   : {return "V1CategoriaCN1";}

                // ****************************************
                // Tabla: Parametros          
                case "par_xcd_codigo"                  : {return "V1CódigoCN1";}
                case "par_des_descripcion"             : {return "V1DescripciónCN1";}
                case "par_xde_valor"                   : {return "V1ValorCN1";}
                case "par_est_editable"                : {return "V1EditableCN2";}
                case "par_est_sololectura"             : {return "V1Sólo lecturaCN2";}
                case "par_rob_detalle"                 : {return "V1DetalleCN1";}

                // ****************************************
                // Tabla: Parentescos         
                case "prt_rcd_cod"                     : {return "V1CodigoCN1";}
                case "prt_des_des"                     : {return "V1DescripcionCN1";}

                // ****************************************
                // Tabla: Planes              
                case "pln_cod_cod"                     : {return "V1CódigoCN1";}
                case "pln_des_des"                     : {return "V1DescripciónCN1";}
                case "pln_cod_codplanavalon"           : {return "V1Cod Plan AvalonCN1";}
                case "pln_d80_tcontratoavalon"         : {return "V1Lista de T Contratos AvalonCN1";}

                // ****************************************
                // Tabla: PlnServicios        
                case "pls_cod_codplan"                 : {return "V1Código de PlanCN1";}
                case "pls_cod_codservicio"             : {return "V1Código de ServicioCN1";}
                case "pls_nro_cprestlibres"            : {return "V1Cant. Prestaciones LibresNN3";}
                case "pls_imp_valorprestacion"         : {return "V1Valor Prestación2N3";}
                case "pls_des_plan"                    : {return "V1PlanCN1";}
                case "pls_des_serv"                    : {return "V1ServicioCN1";}

                // ****************************************
                // Tabla: PreciosServicios    
                case "prs_cd1_color"                   : {return "V1ColorCN2";}
                case "prs_fec_fecha"                   : {return "V1FechaFN2";}
                case "prs_imp_precio"                  : {return "V1Precio2N3";}
                case "prs_imp_coseguro"                : {return "V1coseguro2N3";}

                // ****************************************
                // Tabla: ResEntrevista       
                case "ren_rcd_cod"                     : {return "V1CódigoCN1";}
                case "ren_des_des"                     : {return "V1DescripciónCN1";}
                case "ren_cd1_codfiltro"               : {return "V1Genera ContratoCN2";}

                // ****************************************
                // Tabla: Rubros              
                case "rbr_rcd_cod"                     : {return "V1CódigoCN1";}
                case "rbr_des_des"                     : {return "V1DescripciónCN1";}

                // ****************************************
                // Tabla: Servicios           
                case "srv_cod_cod"                     : {return "V1CódigoCN1";}
                case "srv_des_des"                     : {return "V1DescripciónCN1";}
                case "srv_xld_explicacion"             : {return "V1Descripcion ExtendidaCN1";}

                // ****************************************
                // Tabla: SituacionesIVA      
                case "siv_rcd_codigo"                  : {return "V1CodigoCN1";}
                case "siv_des_descripcion"             : {return "V1DescripcionCN1";}
                case "siv_cd1_discrimina"              : {return "V1DiscriminaCN2";}

                // ****************************************
                // Tabla: Supervisores        
                case "sup_cd6_cod"                     : {return "V1CódigoCN1";}
                case "sup_nom_apellido"                : {return "V1ApellidoCN1";}
                case "sup_nom_nombre"                  : {return "V1NombreCN1";}
                case "sup_nom_usuario"                 : {return "V1Usuario del SistemaCN1";}
                case "sup_tel_tel"                     : {return "V1TélefonoCN1";}
                case "sup_tel_cel"                     : {return "V1CelularCN1";}
                case "sup_ede_nya"                     : {return "V1Nom y ApellidoCN1";}

                // ****************************************
                // Tabla: Talonarios          
                case "tal_xcd_codigo"                  : {return "V1CódigoCN1";}
                case "tal_des_descripcion"             : {return "V1DescripciónCN1";}
                case "tal_cd1_tipo"                    : {return "V1TipoCN2";}
                case "tal_nro_valor"                   : {return "V1NúmeroNN3";}
                case "tal_fyh_referencia"              : {return "V1ReferenciaDN2";}
                case "tal_rob_detalle"                 : {return "V1DetalleCN1";}

                // ****************************************
                // Tabla: TipoCont            
                case "tcn_rcd_cod"                     : {return "V1CódigoCN1";}
                case "tcn_des_des"                     : {return "V1DescripciónCN1";}
                case "tcn_cd1_modo"                    : {return "V1Modo VentaCN2";}
                case "tcn_rcd_tcontratoavalon"         : {return "V1Tipo Contrato AvalonCN1";}

                // ****************************************
                // Tabla: TipoInst            
                case "tin_cod_cod"                     : {return "V1CódigoCN1";}
                case "tin_des_des"                     : {return "V1DescripciónCN1";}
                case "tin_rcd_codrubro"                : {return "V1RubroCN1";}
                case "tin_cd1_mayorista"               : {return "V1MayoristaCN2";}
                case "tin_des_rubro"                   : {return "V1RubroCN1";}

                // ****************************************
                // Tabla: TipoVend            
                case "tvn_rcd_cod"                     : {return "V1CodigoCN1";}
                case "tvn_des_des"                     : {return "V1DescripcionCN1";}
                case "tvn_cd1_vemayor"                 : {return "V1Ve MayoristasCN2";}

                // ****************************************
                // Tabla: Vendedores          
                case "vnd_cd6_cod"                     : {return "V1CódigoCN1";}
                case "vnd_des_apellido"                : {return "V1ApellidoCN1";}
                case "vnd_des_nombre"                  : {return "V1NombreCN1";}
                case "vnd_nom_usuario"                 : {return "V1Usuario SistemaCN1";}
                case "vnd_tel_tel1"                    : {return "V1Telefono1CN1";}
                case "vnd_tel_celular"                 : {return "V1CelularCN1";}
                case "vnd_tel_tel2"                    : {return "V1Telefono2CN1";}
                case "vnd_fec_fecnacim"                : {return "V1Fecha NacimientoFN2";}
                case "vnd_ede_direccion"               : {return "V1DirecciónCN1";}
                case "vnd_cd6_codsuperv"               : {return "V1SupervisorCN1";}
                case "vnd_rcd_codtvend"                : {return "V1Tipo VendedorCN1";}
                case "vnd_txt_horarios"                : {return "V1HorariosCN1";}
                case "vnd_cd1_historico"               : {return "V1Es HistoricoCN2";}
                case "vnd_cd1_vemayor"                 : {return "V1Ve MayoristasCN1";}
                case "vnd_des_tipovnd"                 : {return "V1Tipo vendedorCN1";}
                case "vnd_ede_nya"                     : {return "V1Nombre CompletoCN1";}
                case "vnd_nom_superv"                  : {return "V1SupervisorCN1";}

                // ****************************************
                // Tabla: Zonas               
                case "zns_rcd_cod"                     : {return "V1CódigoCN1";}
                case "zns_des_nombre"                  : {return "V1Nombre de la zonaCN1";}
                case "zns_txt_geoloc"                  : {return "V1GeolocalizaciónCN1";}

                // ****************************************
                // Captions Fijos
                case "cle_fcoord"                      : {return "V1Fecha Coordinada EntrevistaFN2";}
                case "mot_tipo"                        : {return "V1TipoCN1";}
                case "sol_ffinres"                     : {return "V1Fecha de Fin de ReservaFN2";}
                case "sol_finires"                     : {return "V1Fecha de Inicio de ReservaFN2";}
                case "vnd_apeynom"                     : {return "V1Nombre y ApellidoCN1";}
            }

            // El campo es desconocido
            return "";
        }

        #endregion
    }
}
