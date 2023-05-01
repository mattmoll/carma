
using System;
using System.Data;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using Carm.Bel;


namespace Carm.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 27/08/2013 21:01
    // Sistema                  : Sima
    // Clase para Administrar   : Clientes
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Clientes
    /// </summary>
    public static partial class Clientes
    {

        // Eventos
        public static event BllReportEventHandler Advance;

        // Metodos públicos de la clase

        #region Metodos publicos de la clase


        #region Metodos para busqueda de clientes

        /// <summary>
        /// Metodo que trae una lista de todos los clientes mayoristas que cumplan con los parametros.
        /// </summary>
        /// <param name="p_strRSoc">Razon Social</param>
        /// <param name="p_strNFant">Nombre Fantasia</param>
        /// <param name="p_strDir">Direccion</param>
        /// <param name="p_strUrl">Url</param>
        /// <param name="p_strTel">Telefono</param>
        /// <param name="p_smResult">StatMsg</param>
        /// <returns></returns>
        public static ListaEntidades fGetMayoristas(
                                                    string p_strRSoc,
                                                    string p_strNFant,
                                                    string p_strLoc,
                                                    string p_strDir,
                                                    int p_iAltura,
                                                    string p_strTel,
                                                    string p_strCodTInst,
                                                    int p_intNroCliente,
                                                    int p_intNroAvalon,
                                                    string p_strCodVend,
                                                    string p_strCodMarcaUsuario,
                                                    bool p_bBusquedaExistencial,
                                                    StatMsg p_smResult
                                                    )
        {

            try
            {
                // Armamos el where del comando a ejecutar.
                // Pedimos que el cliente sea mayorista y que no este reservado o que el que lo reservo 
                //sea el mismo vendedor (puede pedir extender su reserva)
                string l_strWhere = ETipoInst.MayoristaCmp +"= 'S' " +
                    AppRuts.MakeWhere(ECliente.RsocialCmp, p_strRSoc, StringModes.FullLike) +
                    AppRuts.MakeWhere(ECliente.NombrefantCmp, p_strNFant, StringModes.FullLike) +
                    AppRuts.MakeWhere(ELocalidad.NombreCmp, p_strLoc, StringModes.FullLike) +
                    AppRuts.MakeWhere(ECliente.DireccionCmp, p_strDir, StringModes.FullLike) +
                    AppRuts.MakeWhere(ECliente.AlturaCmp, p_iAltura, NumberModes.Equal) +
                    AppRuts.MakeWhere(ECliente.Telefono1Cmp, p_strTel, StringModes.FullLike) +
                    AppRuts.MakeWhere(ECliente.NumeroCmp, p_intNroCliente, NumberModes.Equal) +
                    AppRuts.MakeWhere(ECliente.NroavalonCmp, p_intNroAvalon, NumberModes.Equal) +
                    AppRuts.MakeWhere(ETipoInst.CodCmp, p_strCodTInst, StringModes.Equal);

                // Si es consulta existencial, tenemos que dejar que busque en todos los clientes, sino solo en los que tiene permisos
                if (!p_bBusquedaExistencial)
                    agregarLimitantesPermisosVendedores(ref l_strWhere, p_strCodMarcaUsuario);
                


                l_strWhere = AppRuts.RemoveRAnd(l_strWhere);

                // Llamamos al metodo generico para las busquedas de clientes pasandole el where.
                ListaEntidades l_leClientes = busquedaClientes(l_strWhere, p_smResult);

                return l_leClientes;
            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
                return null;
            }
        }



        /// <summary>
        /// Metodo que trae una lista de todos los clientes minoristas que cumplan con los parametros.
        /// </summary>
        /// <param name="p_strRSoc">Razon Social</param>
        /// <param name="p_strNFant">Nombre Fantasia</param>
        /// <param name="p_strLoc">Localidad</param>
        /// <param name="p_strFranq">Franquicia</param>
        /// <param name="p_strTInst">Tipo de Institucion</param>
        /// <param name="p_smResult">StatMsg</param>
        /// <returns></returns>
        public static ListaEntidades fGetMinoristas(
                                                    string p_strRSoc,
                                                    string p_strNFant,
                                                    string p_strDireccion,
                                                    string p_strTelefono,
                                                    string p_strLoc,
                                                    string p_strCodTInst,
                                                    int p_intNroCliente,
                                                    int p_intNroAvalon,
                                                    string p_strCodMarcaUsuario,
                                                    bool p_bBusquedaExistencial,
                                                    StatMsg p_smResult
                                                    )
        {

            try
            {
                // Armamos el where del comando a ejecutar. Si es busqueda existencial no lleva el filtro de treservado = 0.
                string l_strWhere = ETipoInst.MayoristaCmp +" = 'N' " +
                    AppRuts.MakeWhere(ECliente.RsocialCmp, p_strRSoc, StringModes.FullLike) +
                    AppRuts.MakeWhere(ECliente.NombrefantCmp, p_strNFant, StringModes.FullLike) +
                    AppRuts.MakeWhere(ECliente.DireccionCmp, p_strDireccion, StringModes.FullLike) +
                    AppRuts.MakeWhere(ECliente.Telefono1Cmp, p_strTelefono, StringModes.FullLike) +
                    AppRuts.MakeWhere(ECliente.NumeroCmp, p_intNroCliente, NumberModes.Equal) +
                    AppRuts.MakeWhere(ECliente.NroavalonCmp, p_intNroAvalon, NumberModes.Equal) +
                    AppRuts.MakeWhere(ELocalidad.NombreCmp, p_strLoc, StringModes.FullLike) +
                    AppRuts.MakeWhere(ETipoInst.CodCmp, p_strCodTInst, StringModes.Equal);

                // Si es consulta existencial, tenemos que dejar que busque en todos los clientes, sino solo en los que tiene permisos
                if (!p_bBusquedaExistencial)
                    agregarLimitantesPermisosVendedores(ref l_strWhere, p_strCodMarcaUsuario);
                
                l_strWhere = AppRuts.RemoveRAnd(l_strWhere);

                // Llamamos al metodo generico para las busquedas de clientes pasandole el where.
                ListaEntidades l_leClientes = busquedaClientes(l_strWhere, p_smResult);

                return l_leClientes;
            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
                return null;
            }
        }


        /// <summary>
        /// Metodo que trae una lista de todos los clientes que cumplan con los parametros.
        /// </summary>
        /// <param name="p_strRSoc">Razon Social</param>
        /// <param name="p_strNFant">Nombre Fantasia</param>
        /// <param name="p_strFranq">Franquicia</param>
        /// <param name="p_strRubro">Rubro</param>
        /// <param name="p_strTInst">Tipo de Institucion</param>
        /// <param name="p_strZona">Zona</param>
        /// <param name="p_strLoc">Localidad</param>
        /// <param name="p_smResult">StatMsg</param>
        /// <returns></returns>
        public static ListaEntidades fGetClientesSecretaria(
                                                            BusquedaAdministracion p_bsBusqueda,
                                                            StatMsg p_smResult
                                                            )
        {
            try
            {

                // Armamos el where del comando a ejecutar.
                string l_strWhere = "";
                l_strWhere += AppRuts.MakeWhere(ECliente.NumeroCmp, p_bsBusqueda.Numero, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere(ECliente.RsocialCmp, p_bsBusqueda.Rsocial, StringModes.FullLike);
                l_strWhere += AppRuts.MakeWhere(ECliente.NombrefantCmp, p_bsBusqueda.NFant, StringModes.FullLike);
                l_strWhere += AppRuts.MakeWhere(ECliente.CodvendCmp, p_bsBusqueda.CodVend, StringModes.FullLike);
                l_strWhere += AppRuts.MakeWhere(ECliente.CargadorCmp, p_bsBusqueda.Cargador, StringModes.FullLike);
                l_strWhere += AppRuts.MakeWhere(ECliente.NombreCmp, p_bsBusqueda.Nombre, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere(ECliente.ApellidoCmp, p_bsBusqueda.Apellido, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere(ERubro.CodCmp, p_bsBusqueda.Rubro, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere(EMarca.CodCmp, p_bsBusqueda.Marca, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere(ETipoInst.CodCmp, p_bsBusqueda.TInst, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere(EZona.CodCmp, p_bsBusqueda.Zona, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere(ELocalidad.CodpostCmp, p_bsBusqueda.Loc, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere(ECliente.DireccionCmp, p_bsBusqueda.Dir, StringModes.FullLike);
                l_strWhere += AppRuts.MakeWhere(ECliente.AlturaCmp, p_bsBusqueda.Altura, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere(ECliente.Telefono1Cmp, p_bsBusqueda.Telefono, StringModes.FullLike);
                l_strWhere += AppRuts.MakeWhere(ECliente.NroavalonCmp, p_bsBusqueda.NumeroAvalon, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere(ECliente.TipoclienteCmp, p_bsBusqueda.TipoCliente, StringModes.Equal);

                if(!string.IsNullOrEmpty(p_bsBusqueda.InicialDesde) || !string.IsNullOrEmpty(p_bsBusqueda.InicialHasta))
                {
                    l_strWhere += " ( ";
                    l_strWhere += AppRuts.MakeWhere($"upper(substring({ECliente.RsocialCmp}, 1, 1))", p_bsBusqueda.InicialDesde, StringModes.GreaterEq);
                    l_strWhere += AppRuts.MakeWhere($"upper(substring({ECliente.RsocialCmp}, 1, 1))", p_bsBusqueda.InicialHasta, StringModes.Less);
                    l_strWhere = AppRuts.RemoveRAnd(l_strWhere);
                    l_strWhere += " or ";
                    l_strWhere += AppRuts.MakeWhere($"upper(substring({ECliente.ApellidoCmp}, 1,1))", p_bsBusqueda.InicialDesde, StringModes.GreaterEq);
                    l_strWhere += AppRuts.MakeWhere($"upper(substring({ECliente.ApellidoCmp}, 1,1))", p_bsBusqueda.InicialHasta, StringModes.Less);
                    l_strWhere = AppRuts.RemoveRAnd(l_strWhere);
                    l_strWhere += " ) and ";
                }
                
                l_strWhere += AppRuts.MakeWhere(ECliente.FechaingresoCmp, p_bsBusqueda.FechaCargaDesde, DateModes.GreaterEq, DateData.Date);
                l_strWhere += AppRuts.MakeWhere(ECliente.FechaingresoCmp, p_bsBusqueda.FechaCargaHasta, DateModes.LessEq, DateData.Date);

                l_strWhere += AppRuts.MakeWhere(ECliente.FechaproxcontactoCmp, p_bsBusqueda.FechaProxContactoDesde, DateModes.GreaterEq, DateData.Date);
                l_strWhere += AppRuts.MakeWhere(ECliente.FechaproxcontactoCmp, p_bsBusqueda.FechaProxContactoHasta, DateModes.LessEq, DateData.Date);


                // Armamos los where de campos que validan Ambos-Si-No con el metodo generico
                makeWhereEvaluandoPropertyStringMode(p_bsBusqueda.Vendido, ECliente.AltaCmp, "N", ref l_strWhere);
                makeWhereEvaluandoPropertyStringMode(p_bsBusqueda.Rellamar, ECliente.RellamarCmp, "N", ref l_strWhere);
                makeWhereEvaluandoPropertyStringMode(p_bsBusqueda.ReintarLlamado, ECliente.ReintentarllamadoCmp, "N", ref l_strWhere);

                if (p_bsBusqueda.SinLlamadas == "S")
                {
                    l_strWhere += $"{ECliente.ResultllamadaCmp} = '' and ";
                }
                else if (p_bsBusqueda.SinLlamadas == "N")
                {
                    l_strWhere += $"{ECliente.ResultllamadaCmp} <> '' and ";
                }

                l_strWhere = AppRuts.RemoveRAnd(l_strWhere);

                bool l_boolEsBusquedaXContacto = false;
                ListaEntidades l_leClientes = busquedaClientesSecretaria(l_strWhere, l_boolEsBusquedaXContacto, p_bsBusqueda.aplicarPermisos, p_smResult);

                return l_leClientes;
            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
                return null;
            }
        }

        private static void makeWhereEvaluandoPropertyStringMode(string p_strValorProperty, string p_strCampo, 
                                                                 string p_strValor,  ref string l_strWhere)
        {
            StringModes l_smModo;
            if (p_strValorProperty != "A")
            {
                l_smModo = (p_strValorProperty.Trim().Equals("S")) ? StringModes.NotEqual : StringModes.Equal;
                l_strWhere += AppRuts.MakeWhere(p_strCampo, p_strValor, l_smModo, true);
            }
        }


        private static void makeWhereEvaluandoPropertyNumberMode(string p_strValorProperty, string p_strCampo,
                                                                 int p_intValor, ref string l_strWhere)
        {
            NumberModes l_nmModo;
            if (p_strValorProperty != "A")
            {
                l_nmModo = (p_strValorProperty == "S") ? NumberModes.NotEqual : NumberModes.Equal;
                l_strWhere += AppRuts.MakeWhere(p_strCampo, p_intValor, l_nmModo, true);
            }
        }

        public static ListaEntidades fGetClientesFromContacto(
                                                              Bel.ECliContacto p_eCliContacto,
                                                              string p_strCodMarcaUsuario,
                                                              StatMsg p_smResult
                                                              )
        {

            // No hay errores aun
            DBConn l_dbcAccess = null;
            

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                // Armamos el where apartir de los datos de la entidad prototipo a buscar.
                string l_strWhere = "";
                l_strWhere += AppRuts.MakeWhere("clc_des_nombre", p_eCliContacto.Nombre, StringModes.FullLike);
                l_strWhere += AppRuts.MakeWhere("clc_des_cargo", p_eCliContacto.Cargo, StringModes.FullLike);
                l_strWhere += AppRuts.MakeWhere("clc_des_titulo", p_eCliContacto.Titulo, StringModes.FullLike);
                l_strWhere += AppRuts.MakeWhere("clc_tel_celular", p_eCliContacto.Celular, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere("clc_tel_telefono1", p_eCliContacto.Telefono1, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere("clc_tel_telefono2", p_eCliContacto.Telefono2, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere("clc_tel_interno", p_eCliContacto.Interno, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere("clc_xld_email", p_eCliContacto.Email, StringModes.Equal);
                l_strWhere += AppRuts.MakeWhere("clc_des_secretaria", p_eCliContacto.Secretaria, StringModes.FullLike);

                l_strWhere = AppRuts.RemoveRAnd(l_strWhere);


                // Obtenemos la lista entidades ejecutando una busqueda de secretaria con el where armado.
                bool l_boolEsBusquedaXContacto = true;
                bool l_boolAplicarPermisos = true;
                ListaEntidades l_leClientes = busquedaClientesSecretaria(l_strWhere, l_boolEsBusquedaXContacto, l_boolAplicarPermisos, p_smResult);

                return l_leClientes;
            }

            catch (Exception l_expData)
            {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                    l_dbcAccess.Close();
            }

        }

        #endregion

        // Estos dos metodos son necesarios porque los invocamos desde una lambda (no aceptan parametros por ref).
        public static LECliEntrevistas fGetEntrevistasPendVendedor(string codVend, StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;
            LECliEntrevistas entrevistas = LECliEntrevistas.NewEmpty();


            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                entrevistas = Clientes.CleGetEntrevPendVend(l_dbcAccess, codVend, p_smResult);
                return entrevistas;

            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
                return null;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                    l_dbcAccess.Close();
            }
        }
        public static LECliLlamadas fGetLlamadasPendVendedor(string codVend, StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;
            LECliLlamadas llamadas = LECliLlamadas.NewEmpty();


            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                llamadas = Clientes.CllGetLlamadProgVend(l_dbcAccess, codVend, p_smResult);
                return llamadas;

            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
                return null;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                    l_dbcAccess.Close();
            }
        }


        /// <summary>
        /// Retorna la fecha y hora del momento (pero sacada del server).
        /// </summary>
        /// <param name="p_smResult">Resultado de las operaciones</param>
        /// <returns></returns>
        public static DateTime fGetDate(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;
            

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                // Conseguimos la fecha de hoy
                DateTime l_dtToday = BllRuts.GetDBNow(l_dbcAccess, false, p_smResult);

                //Corroboramos que no hayan ocurrido errores.
                if (p_smResult.NOk)
                    return DateTimeRuts.Empty;
                else
                    return l_dtToday;


            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
                return DateTimeRuts.Empty;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                    l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Metodo que graba la llamada de recupero de un cliente y le graba su nuevo abono.
        /// </summary>
        /// <param name="p_iNumCliente"></param>
        /// <param name="p_dcNuevoAbono"></param>
        /// <param name="p_bEsCompetencia"></param>
        /// <param name="p_smResult"></param>
        public static void fRecupero(
                                     int p_iNumCliente,
                                     decimal p_dcNuevoAbono,
                                     ECliLlamada p_eCliLlamada,
                                     StatMsg p_smResult
                                    )
        {

            // No hay errores aun
            DBConn l_dbcAccess = null;
            

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                l_dbcAccess.BeginTransaction();

                // Marcamos al cliente como vendido, proque se lo recupero. No sabemos el tipo de contrato en este contexto.
                Clientes.Vendido(l_dbcAccess, p_iNumCliente, p_dcNuevoAbono, "", p_smResult);
                if (p_smResult.NOk) return;

                // Grabamos la llamada que provocó la el recupero.
                Clientes.CllSSav(l_dbcAccess, p_eCliLlamada, p_smResult);
                if (p_smResult.NOk) return;
            }

            catch (Exception l_expData)
            {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_iNumCliente"></param>
        /// <param name="p_leCliServicios"></param>
        /// <param name="p_bEsCompetencia"></param>
        /// <param name="p_smResult"></param>
        public static void fBajaYBorrarServicios(
                                           int p_iNumCliente,
                                           StatMsg p_smResult
                                          )
        {

            // No hay errores aun
            DBConn l_dbcAccess = null;
            

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                l_dbcAccess.BeginTransaction();

                // Llamamos al metodo privado que da de baja al cliente.
                BajaYBorraServicios(l_dbcAccess, p_iNumCliente, 0, "", p_smResult);
                if (p_smResult.NOk) return;

            }

            catch (Exception l_expData)
            {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_iNumCliente"></param>
        /// <param name="p_leCliServicios"></param>
        /// <param name="p_bEsCompetencia"></param>
        /// <param name="p_smResult"></param>
        public static void fBajaYBorrarServiciosFromLlamada(
                                           int p_iNumCliente,
                                           int p_iDiasCancel,
                                           ECliLlamada p_eCliLlamada,
                                           StatMsg p_smResult
                                          )
        {

            // No hay errores aun
            DBConn l_dbcAccess = null;
            

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                l_dbcAccess.BeginTransaction();

                // Llamamos al metodo privado que da de baja al cliente.
                BajaYBorraServicios(l_dbcAccess, p_iNumCliente, p_iDiasCancel, "", p_smResult);
                if (p_smResult.NOk) return;

                // Grabamos la llamada que provocó la baja.
                Clientes.CllSSav(l_dbcAccess, p_eCliLlamada, p_smResult);

            }

            catch (Exception l_expData)
            {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }


        }

        /// <summary>
        /// Metodo para persistir la venta de un cliente (actualiza cliente, graba venta, graba servicios si se los provee y graba historico)
        /// </summary>
        /// <param name="p_eCliVenta"></param>
        /// <param name="p_leCliServicios"></param>
        /// <param name="p_intNroAvalon"></param>
        /// <param name="p_smResult"></param>
        public static void fGrabaVenta(ECliVenta p_eCliVenta, int p_intNroAvalon, StatMsg p_smResult)
        {
             // No hay errores aun
            DBConn l_dbcAccess = null;

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                l_dbcAccess.BeginTransaction();

                // Llamamos al metodo privado que tiene la logica.
                fGrabaVenta(l_dbcAccess, p_eCliVenta, p_intNroAvalon, p_smResult);
                if (p_smResult.NOk) return;

                /*
                // Si nos mandaron una lista de servicios, la grabamos. Sino borramos la actual porque corresponde a servicios que ya no aplican
                if (p_leCliServicios != null)
                    fGrabaServicios(l_dbcAccess, p_eCliVenta.Numcliente, p_leCliServicios, p_smResult);
                else
                    ClsBorraPorCliente(l_dbcAccess, p_eCliVenta.Numcliente, p_smResult);
                */

                // Obtenemos el cliente a actualizar y lo actualizamos con los datos de la venta.
                ECliente l_eClienteAActualizar = Bll.Clientes.Srch(l_dbcAccess, p_eCliVenta.Numcliente, false, p_smResult);
                if (p_smResult.NOk) return;
                l_eClienteAActualizar.Abono = p_eCliVenta.Abono;

                // Marcamos al cliente como vendido.
                Clientes.fVendido(l_dbcAccess, l_eClienteAActualizar, p_smResult);
                if (p_smResult.NOk) return;

            }

            catch (Exception l_expData)
            {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_iNumCliente"></param>
        /// <param name="p_leCliServicios"></param>
        /// <param name="p_bEsCompetencia"></param>
        /// <param name="p_smResult"></param>
        public static void fGrabaServicios(
                                           int p_iNumCliente,
                                           LECliServicios p_leCliServicios,
                                           StatMsg p_smResult
                                          )
        {

            // No hay errores aun
            DBConn l_dbcAccess = null;

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                l_dbcAccess.BeginTransaction();

                // Llamamos al metodo privado que tiene la logica.
                fGrabaServicios(l_dbcAccess, p_iNumCliente, p_leCliServicios, p_smResult);

            }

            catch (Exception l_expData)
            {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }


        }


        /// <summary>
        /// Metodo publico que borra fisicamente a un cliente con todas sus dependecias
        /// </summary>
        /// <param name="p_iNroCliente">Numero de cliente</param>
        /// <param name="p_smResult">Resultado de la operacion</param>
        public static void fBorraCliente(int p_iNroCliente,
                                         StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;
            

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Conseguimos la fecha de hoy
                DateTime l_dtFechaActual = BllRuts.GetDBNow(l_dbcAccess, false, p_smResult);
                if (p_smResult.NOk) return;

                // Traemos el cliente para conseguir la fixed version
                ECliente l_eCliente = Clientes.Srch(l_dbcAccess, p_iNroCliente, false, p_smResult);

                // Borramos el cliente de la tabla maestra y todas las dependencias en las otras tablas
                Clientes.Drop(l_dbcAccess, p_iNroCliente, l_eCliente.FxdVersion, p_smResult);
                if (p_smResult.NOk) return;
                Clientes.ClsBorraPorCliente(l_dbcAccess, p_iNroCliente, p_smResult);
                if (p_smResult.NOk) return;
                Clientes.CleBorraPorCliente(l_dbcAccess, p_iNroCliente, p_smResult);
                if (p_smResult.NOk) return;
                Clientes.CllBorraPorCliente(l_dbcAccess, p_iNroCliente, p_smResult);
                if (p_smResult.NOk) return;
                Clientes.ClcBorraPorCliente(l_dbcAccess, p_iNroCliente, p_smResult);
                if (p_smResult.NOk) return;
                Clientes.ClnBorraPorCliente(l_dbcAccess, p_iNroCliente, p_smResult);
                if (p_smResult.NOk) return;

                // Grabamos la baja en el log.
                ELogCliente l_eLogDeleted = ELogCliente.NewEmpty();
                l_eLogDeleted.fillFromCliente(l_eCliente, ELogCliente.acciones.Delete, l_dtFechaActual);
                Tablas.LgcSSav(l_dbcAccess, l_eLogDeleted, p_smResult);
                if (p_smResult.NOk) return;
            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
                return;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }

        }

        /// <summary>
        /// Metodo que persiste el cliente recibido por parametro y da permiso para ese cliente para la empresa de la que sea el usuario parametro.
        /// </summary>
        /// <param name="p_eCliente"></param>
        /// <param name="p_strUsuario"></param>
        /// <param name="p_smResult"></param>
        public static void fGrabaClienteYPermiso(ECliente p_eCliente,
                                                 string p_strUsuario,
                                                 StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                fGrabaClienteYPermiso(l_dbcAccess, p_eCliente, p_smResult);
                return;
            }
            catch (Exception l_expData)
            {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }

        }

        private static void fGrabaClienteYPermiso(DBConn l_dbcAccess, ECliente p_eCliente, StatMsg p_smResult)
        {
            // Todo el metodo esta usando la conexion por parametro que se supone en transacaccion.

            // Guardamos el cliente.
            Clientes.SSav(l_dbcAccess, p_eCliente, p_smResult);
            if (p_smResult.NOk) return;

            // Conseguimos la fecha de hoy
            DateTime l_dtNow = BllRuts.GetDBNow(l_dbcAccess, false, p_smResult);
            if (p_smResult.NOk) return;

            // Agregamos el cliente al log de acciones de cliente.
            ELogCliente logAlta = ELogCliente.NewEmpty();
            logAlta.fillFromCliente(p_eCliente, ELogCliente.acciones.Create, l_dtNow);
            Bll.Tablas.LgcSSav(l_dbcAccess, logAlta, p_smResult);
            if (p_smResult.NOk) return;
        }


        #region Metodos de la carga de clientes por excel
        /// <summary>
        /// Metodo que tiene toda la logica de la carga de excel y realiza las validaciones correspondientes a cada cliente.
        /// </summary>
        /// <param name="p_leClientes">Lista de Clientes a subir</param>
        /// <param name="p_smResult">Resultado de la operacion</param>
        /// <returns>Lista de clientes erroneos</returns>
        public static ListaEntidades fImportar(
                                               LEClientes p_leClientes,
                                               StatMsg p_smResult
                                               )
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                // Creamos el data table donde vamos a guardar los erroneos.
                DataTable l_dtCliErroneos = new DataTable();

                // Agregamos todas las columnas que nos interesa mostrar.
                l_dtCliErroneos.Columns.Add(Bel.ECliente.RsocialCmp, typeof(string));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.NombrefantCmp, typeof(string));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.Telefono1Cmp, typeof(string));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.CelularCmp, typeof(string));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.Telefono2Cmp, typeof(string));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.FaxCmp, typeof(string));
                l_dtCliErroneos.Columns.Add("cli_des_loc", typeof(string));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.DireccionCmp, typeof(string));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.AlturaCmp, typeof(int));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.CuilCmp, typeof(string));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.UrlCmp, typeof(string));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.CantempleadosCmp,typeof(int));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.NroavalonCmp, typeof(int));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.AbonoCmp, typeof(int));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.EmailCmp, typeof(string));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.CodlocalidadCmp, typeof(string));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.NombreCmp, typeof(string));
                l_dtCliErroneos.Columns.Add(Bel.ECliente.ApellidoCmp, typeof(string));
                l_dtCliErroneos.Columns.Add("Error", typeof(string));


                // Creamos variables locales.
                string l_strCodLoc = "";
                double l_dPercent = 0;
                int l_intCantProcesados = 0;
                int l_intCantTotal = p_leClientes.Count;
                DataRow l_drCliErroneo = l_dtCliErroneos.NewRow();

                // Recorremos la lista entidades de clientes.
                foreach (ECliente l_eCliente in p_leClientes)
                {
                    // Sumamos uno al contador y calculamos el porcentaje de avance.
                    l_intCantProcesados++;
                    l_dPercent = l_intCantTotal / l_intCantProcesados;


                    // Llamamos al metodo que valida los campos obligatorios y si no pasa validacion agrega el cliente al Datatable.
                    if (!fValidacionCamposObligatorios(l_eCliente, ref l_dtCliErroneos))
                        continue;

                    // Llamamos al metodo que valida que haya una unica coincidencia en la base con el nombre de la localidad
                    if (!ValidacionLocalidad(l_dbcAccess, ref l_strCodLoc, l_eCliente, ref l_dtCliErroneos, p_smResult))
                        continue;

                    // Validamos la unicidad del cliente.
                    if (!ValidacionUnicidad(l_dbcAccess, l_dPercent, l_eCliente, ref l_dtCliErroneos, p_smResult))
                        continue;

                    // Validamos la unicidad del cliente.
                    if (!ValidacionUnicidadAvalon(l_dbcAccess, l_dPercent, l_eCliente, ref l_dtCliErroneos, p_smResult))
                        continue;

                    // En este punto el cliente ya paso las 3 validaciones, entonces lo mandamos a completar y grabar.
                    fCargaClienteDelExcel(l_dbcAccess, l_eCliente, l_strCodLoc, p_smResult);
                    if (!ValidacionCargaExitosa(l_eCliente, ref l_dtCliErroneos, p_smResult))
                        continue;
                }

                // Creamos la lista entidad a partir del datatable.
                ListaEntidades l_leCliErroneos = new ListaEntidades(l_dtCliErroneos);

                return l_leCliErroneos;


            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());

                // Devolvemos una listaEntidades vacia.
                return LEClientes.NewEmpty();
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                    l_dbcAccess.Close();
            }
        }

        private static bool ValidacionUnicidadAvalon(DBConn p_dbcAccess, double p_dPercent, ECliente p_eCliente, ref DataTable p_dtCliErroneos, StatMsg p_smResult)
        {
            DataRow l_drCliErroneo = null;

            if ((p_smResult.NOk))
            {
                // Creamos el datarow de cliente erroneo y le cargamos los datos.
                l_drCliErroneo = p_dtCliErroneos.NewRow();
                fCargaDatosCliErroneo(ref l_drCliErroneo,
                                      p_eCliente.Rsocial,
                                      p_eCliente.Nombrefant,
                                      p_eCliente.Telefono1,
                                      p_eCliente.Celular,
                                      p_eCliente.Telefono2,
                                      p_eCliente.Fax,
                                      p_eCliente.Cli_des_loc,
                                      p_eCliente.Direccion,
                                      p_eCliente.Altura,
                                      p_eCliente.Cuil,
                                      p_eCliente.Url,
                                      p_eCliente.Cantempleados,
                                      p_eCliente.Nroavalon,
                                      p_eCliente.Abono,
                                      p_eCliente.Email,
                                      p_eCliente.Codlocalidad,
                                      "");
                                      

                // Agregamos el cliente erroneo a la lista.
                p_dtCliErroneos.Rows.Add(l_drCliErroneo);

                return false;
            }

            return true;
        }

        /// <summary>
        /// Metodo que valida que el StatMsg haya quedado bien despues de la carga del cliente.
        /// </summary>
        /// <param name="p_eCliente">Cliente a validar</param>
        /// <param name="p_dtCliErroneos">Lista de clientes erroneos</param>
        /// <param name="p_smResult">Resultado de la Operacion</param>
        /// <returns></returns>
        private static bool ValidacionCargaExitosa(ECliente p_eCliente, ref DataTable p_dtCliErroneos, StatMsg p_smResult)
        {
            DataRow l_drCliErroneo = null;

            if (p_smResult.NOk) 
                return cargarError(ref l_drCliErroneo, p_dtCliErroneos, p_eCliente, p_smResult.Msg);

            return true;
        }

        /// <summary>
        /// Metodo que carga los datos faltantes al cliente y lo manda a grabar a la base.
        /// </summary>
        /// <param name="p_dbcAccess">Acceso a la base</param>
        /// <param name="p_eCliente">Cliente a grabar</param>
        /// <param name="p_strCodLoc">Codigo de localidad</param>
        /// <param name="p_smResult">Resultado de la operacion</param>
        private static void fCargaClienteDelExcel(DBConn p_dbcAccess, ECliente p_eCliente, string p_strCodLoc, StatMsg p_smResult)
        {
            // En este punto el cliente ya paso las 3 validaciones, entonces le completamos los datos y lo grabamos:
            // El numero va en -1 porque despues en la bll verifica que si es -1 le asigna un valor del talonario.
            p_eCliente.Numero = -1;

            p_eCliente.esCargaExcel = true;

            // Si no tiene codigo de institucion cargado, le ponemos el 1 que es el CargadoExcel.
            p_eCliente.Codtinst = p_eCliente.Codtinst.Trim() != "" ? p_eCliente.Codtinst : "   1";

            // Cargamos el codigo de localidad antes conseguido.
            p_eCliente.Codlocalidad = p_strCodLoc;

            p_eCliente.Fechaingreso = DateTime.Today;
            p_eCliente.Cargador = DBConn.Usuario;
            p_eCliente.Tipocliente = Bel.ECliente.CodigoImportados;

            // Procesamos codigo fijo
            Save_f(p_dbcAccess, ref p_eCliente, p_smResult);
            if (p_smResult.NOk) return;

            // Agregamos el registro
            Insr(p_dbcAccess, p_eCliente, p_smResult);
            if (p_smResult.NOk) return;

            // Agregamos el cliente al log de acciones de cliente.
            // Estamos usando la fecha del cliente para evitar sumar errores y tiempoe xtra a un proceso largo como carga por excel.
            ELogCliente logAlta = ELogCliente.NewEmpty();
            logAlta.fillFromCliente(p_eCliente, ELogCliente.acciones.Create, DateTime.Now);
            Bll.Tablas.LgcSave(logAlta, p_smResult);
            if (p_smResult.NOk) return;

        }

        /// <summary>
        /// Metodo que valida la unicidad del cliente, y si no añade el cliente a erroneos.
        /// </summary>
        /// <param name="p_dbcAccess">Acceso a la base</param>
        /// <param name="p_dPercent">Porcentaje de avance en la carga</param>
        /// <param name="p_eCliente">Cliente a validar</param>
        /// <param name="p_dtCliErroneos">Data table con todos los clientes erroneos</param>
        /// <param name="p_smResult">Resultado de la operacion</param>
        /// <returns></returns>
        private static bool ValidacionUnicidad(
                                               DBConn p_dbcAccess,
                                               double p_dPercent,
                                               ECliente p_eCliente,
                                               ref DataTable p_dtCliErroneos,
                                               StatMsg p_smResult
                                               )
        {
            string l_strError = "";
            DataRow l_drCliErroneo = null;
            // Llamamos a la validacion de unicidad del cliente. 
            Clientes.fValidarCliente(p_dbcAccess,
                                     p_eCliente.Rsocial,
                                     p_eCliente.Telefono1,
                                     p_eCliente.Nombre,
                                     p_eCliente.Apellido,
                                     p_dPercent,
                                     ref l_strError,
                                     p_smResult);
            if (p_smResult.NOk)
            {
                // Creamos el datarow de cliente erroneo y le cargamos los datos.
                l_drCliErroneo = p_dtCliErroneos.NewRow();
                fCargaDatosCliErroneo(ref l_drCliErroneo,
                                      p_eCliente.Rsocial,
                                      p_eCliente.Nombrefant,
                                      p_eCliente.Telefono1,
                                      p_eCliente.Celular,
                                      p_eCliente.Telefono2,
                                      p_eCliente.Fax,
                                      p_eCliente.Cli_des_loc,
                                      p_eCliente.Direccion,
                                      p_eCliente.Altura,
                                      p_eCliente.Cuil,
                                      p_eCliente.Url,
                                      p_eCliente.Cantempleados,
                                      p_eCliente.Nroavalon,
                                      p_eCliente.Abono,
                                      p_eCliente.Email,
                                      p_eCliente.Codlocalidad,
                                      p_smResult.Msg);

                // Agregamos el cliente erroneo a la lista.
                p_dtCliErroneos.Rows.Add(l_drCliErroneo);

                return false;
            }
            // Si hubo algun error con la validacion de la unicidad, entonces es erroneo.
            if (l_strError != "")
                return cargarError(ref l_drCliErroneo, p_dtCliErroneos, p_eCliente, l_strError);

            return true;

        }

        /// <summary>
        /// Metodo que valida que haya una unica coincidencia en la base con la localidad ingresada, y si no añade el cliente a erroneos.
        /// </summary>
        /// <param name="p_dbcAccess"></param>
        /// <param name="p_eCliente"></param>
        /// <param name="p_dtCliErroneos"></param>
        /// <param name="p_smResult"></param>
        /// <returns></returns>
        private static bool ValidacionLocalidad(
                                                DBConn p_dbcAccess,
                                                ref string p_strCodLoc,
                                                ECliente p_eCliente,
                                                ref DataTable p_dtCliErroneos,
                                                StatMsg p_smResult
                                                )
        {
            DataRow l_drCliErroneo = null;
            ListaEntidades l_leCodPostal = null;
            ELocalidad l_eLocalidad;

            // Si ya tenia cargado el codigo de localidad validamos que exista ese codigo.
            if (p_eCliente.Codlocalidad.Trim() != "")
            {
                l_eLocalidad = Tablas.LocSrch(p_dbcAccess, ELocalidad.FrmtCodpost(p_eCliente.Codlocalidad), false, p_smResult);
                if (p_smResult.NOk) 
                    return cargarError(ref l_drCliErroneo, p_dtCliErroneos, p_eCliente, p_smResult.Msg);

                if (l_eLocalidad == null)
                    return cargarError(ref l_drCliErroneo, p_dtCliErroneos, p_eCliente, "No se encontró la localidad ingresada.");
                else
                    p_strCodLoc = l_eLocalidad.Codpost;
            }
            // Si no tenia cargado el codigo, buscamos por descripcion.
            else
            {
                // Validamos el encontrar una unica localidad en la tabla a partir de la descripcion brindada.
                l_leCodPostal = Tablas.LocGetCodPostal(p_dbcAccess, p_eCliente.Cli_des_loc, p_smResult);
                if (p_smResult.NOk) 
                    return cargarError(ref l_drCliErroneo, p_dtCliErroneos, p_eCliente, p_smResult.Msg);

                // Validamos que se haya encontrado un unico registro con ese nombre de localidad.
                if (l_leCodPostal.Count != 1) 
                    return cargarError(ref l_drCliErroneo, p_dtCliErroneos, p_eCliente, "No se encontró la localidad ingresada.");
                else
                    p_strCodLoc = (string)l_leCodPostal.InternalData[0][0];
            }

            return true;
        }

        private static bool cargarError(ref DataRow p_drCliErroneo, DataTable p_dtCliErroneos, ECliente p_eCliente, string mensajeError)
        {
            // Creamos el datarow de cliente erroneo y le cargamos los datos.
            p_drCliErroneo = p_dtCliErroneos.NewRow();
            fCargaDatosCliErroneo(ref p_drCliErroneo,
                                  p_eCliente.Rsocial,
                                  p_eCliente.Nombrefant,
                                  p_eCliente.Telefono1,
                                  p_eCliente.Celular,
                                  p_eCliente.Telefono2,
                                  p_eCliente.Fax,
                                  p_eCliente.Cli_des_loc,
                                  p_eCliente.Direccion,
                                  p_eCliente.Altura,
                                  p_eCliente.Cuil,
                                  p_eCliente.Url,
                                  p_eCliente.Cantempleados,
                                  p_eCliente.Nroavalon,
                                  p_eCliente.Abono,
                                  p_eCliente.Email,
                                  p_eCliente.Codlocalidad,
                                  mensajeError);

            // Agregamos el cliente erroneo a la lista.
            p_dtCliErroneos.Rows.Add(p_drCliErroneo);

            return false;
        }

        /// <summary>
        /// Metodo que valida que esten cargados los campos obligatorios, y si no lo estan añade el cliente a erroneos.
        /// </summary>
        /// <param name="p_eCliente">Cliente a validar</param>
        /// <param name="p_dtCliErroneos">Data table con clientes erroneos</param>
        /// <returns></returns>
        private static bool fValidacionCamposObligatorios(
                                                          ECliente p_eCliente,
                                                          ref DataTable p_dtCliErroneos
                                                          )
        {
            // Si alguno de los campos obligatorios no está cargado, entonces es erroneo
            if ((string.IsNullOrEmpty(p_eCliente.Rsocial) && (string.IsNullOrEmpty(p_eCliente.Nombre) || string.IsNullOrEmpty(p_eCliente.Apellido)) 
                || (string.IsNullOrEmpty(p_eCliente.Direccion)) || (string.IsNullOrEmpty(p_eCliente.Telefono1))))
            {
                string l_strError = "Alguno de los campos obligatorios (Razón Social o Nombre y Apellido, Dirección y Teléfono) no está cargado";

                // Creamos el datarow de cliente erroneo y le cargamos los datos.
                DataRow l_drCliErroneo = null;
                return cargarError(ref l_drCliErroneo, p_dtCliErroneos, p_eCliente, l_strError);
            }

            return true;
        }

        /// <summary>
        /// Metodo que carga los parametros en el datarow.
        /// </summary>
        /// <param name="p_drCliErroneo">Datarow a modificar</param>
        /// <param name="p_strRSoc">Razon Social</param>
        /// <param name="p_strTel">Telefono</param>
        /// <param name="p_strDir">Direccion</param>
        /// <param name="l_strError">Mensaje de error</param>
        private static void fCargaDatosCliErroneo(
                                                  ref DataRow p_drCliErroneo,
                                                  string p_strRSoc,
                                                  string p_strNFant,
                                                  string p_strTel,
                                                  string p_strCel,
                                                  string p_strTel2,
                                                  string p_strFax,
                                                  string p_strLoc,
                                                  string p_strDir,
                                                  int p_iAltura,
                                                  string p_strCuil,
                                                  string p_strUrl,
                                                  int p_iCantEmpleados,
                                                  int p_iNroAvalon,
                                                  decimal p_dAbono,
                                                  string p_strEmail,
                                                  string p_strCodLocalidad,
                                                  string l_strError
                                                  )
        {
            p_drCliErroneo[Bel.ECliente.RsocialCmp] = p_strRSoc;
            p_drCliErroneo[Bel.ECliente.NombrefantCmp] = p_strNFant;
            p_drCliErroneo[Bel.ECliente.Telefono1Cmp] = p_strTel;
            p_drCliErroneo[Bel.ECliente.CelularCmp] = p_strCel;
            p_drCliErroneo[Bel.ECliente.Telefono2Cmp] = p_strTel2;
            p_drCliErroneo[Bel.ECliente.FaxCmp] = p_strFax;
            p_drCliErroneo["cli_des_loc"] = p_strLoc;
            p_drCliErroneo[Bel.ECliente.DireccionCmp] = p_strDir;
            p_drCliErroneo[Bel.ECliente.AlturaCmp] = p_iAltura;
            p_drCliErroneo[Bel.ECliente.CuilCmp] = p_strCuil;
            p_drCliErroneo[Bel.ECliente.UrlCmp] = p_strUrl;
            p_drCliErroneo[Bel.ECliente.CantempleadosCmp] = p_iCantEmpleados;
            p_drCliErroneo[Bel.ECliente.NroavalonCmp] = p_iNroAvalon;
            p_drCliErroneo[Bel.ECliente.AbonoCmp] = p_dAbono;
            p_drCliErroneo[Bel.ECliente.EmailCmp] = p_strEmail;
            p_drCliErroneo[Bel.ECliente.CodlocalidadCmp] = p_strCodLocalidad;
            p_drCliErroneo["Error"] = l_strError;
        }

        #endregion


        #region Metodos para actualizar un cliente por partes

        /// <summary>
        /// Metodo que actualiza la entidad a partir de los parametros
        /// </summary>
        /// <param name="p_iNumero">Numero de cliente</param>
        /// <param name="p_strRSocial">Razon Social</param>
        /// <param name="p_strNomFant">Nombre de Fantasia</param>
        /// <param name="p_strCodTInst">Codigo de Tipo de Institucion</param>
        /// <param name="p_strCodFrq">Codigo de Franquicia</param>
        /// <param name="p_smResult">Resultado de la Operacion</param>
        /// <returns></returns>
        public static Bel.ECliente fUpdateInstData(int p_iNumero,
                                                    string p_strRSocial,
                                                    string p_strNomFant,
                                                    string p_strCodTInst,
                                                    int p_intNroAvalon,
                                                    StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;
            

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                l_dbcAccess.BeginTransaction();

                // Traemos la entidad cliente.
                ECliente l_eCliente = Clientes.Srch(l_dbcAccess, p_iNumero, false, p_smResult);

                // Validamos!
                if (p_smResult.NOk) return null;

                // Cargo los parametros de los datos de la ubicacion.
                l_eCliente.Rsocial = p_strRSocial;
                l_eCliente.Nombrefant = p_strNomFant;
                l_eCliente.Codtinst = p_strCodTInst;
                l_eCliente.Nroavalon = p_intNroAvalon;

                // Actualizamos la entidad cliente.
                Clientes.Updt(l_dbcAccess, l_eCliente, p_smResult);

                // Validamos!
                if (p_smResult.NOk) return null;

                // Nos traemos la entidad cliente actualizada.
                l_eCliente = Clientes.Srch(l_dbcAccess, p_iNumero, false, p_smResult);

                // Validamos!
                if (p_smResult.NOk) return null;

                // Devolvemos la entidad actualizada.
                return l_eCliente;
            }

            catch (Exception l_expData)
            {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }

        }




        /// <summary>
        /// Metodo que actualiza los datos de contacto del cliente
        /// </summary>
        /// <param name="p_iNumero">Numero del cliente</param>
        /// <param name="p_strTel1">Telefono 1</param>
        /// <param name="p_strTel2">Telefono 2</param>
        /// <param name="p_strURL">URL</param>
        /// <param name="p_strFax">Fax</param>
        /// <param name="p_smResult">Resultado de la Operacion</param>
        /// <returns></returns>
        public static Bel.ECliente fUpdateContData(int p_iNumero,
                                                    string p_strCel,
                                                    string p_strTel1,
                                                    string p_strTel2,
                                                    string p_strEmail,
                                                    string p_strFax,
                                                    string p_strURL,
                                                    StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;
            

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                l_dbcAccess.BeginTransaction();

                // Traemos la entidad cliente.
                ECliente l_eCliente = Clientes.Srch(l_dbcAccess, p_iNumero, false, p_smResult);

                // Validamos!
                if (p_smResult.NOk) return null;

                // Cargo los parametros de los datos de la ubicacion.
                l_eCliente.Celular = p_strCel;
                l_eCliente.Telefono1 = p_strTel1;
                l_eCliente.Telefono2 = p_strTel2;
                l_eCliente.Email = p_strEmail;
                l_eCliente.Url = p_strURL;
                l_eCliente.Fax = p_strFax;

                // Actualizamos la entidad cliente.
                Clientes.Updt(l_dbcAccess, l_eCliente, p_smResult);

                // Validamos!
                if (p_smResult.NOk) return null;

                // Nos traemos la entidad cliente actualizada.
                l_eCliente = Clientes.Srch(l_dbcAccess, p_iNumero, false, p_smResult);

                // Validamos!
                if (p_smResult.NOk) return null;

                // Devolvemos la entidad actualizada.
                return l_eCliente;
            }

            catch (Exception l_expData)
            {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }

        }



        /// <summary>
        /// Metodo que actualiza los datos de ubicacion de un cliente
        /// </summary>
        /// <param name="p_iNumero">Numero del cliente</param>
        /// <param name="p_strDir">Direccion</param>
        /// <param name="p_strCodLoc">Codigo de localidad</param>
        /// <param name="p_strPiso">Piso</param>
        /// <param name="p_strOficina">Oficina</param>
        /// <param name="p_smResult">Resultado de la operacion</param>
        /// <returns></returns>
        public static Bel.ECliente fUpdateUbicData(
                                                   int p_iNumero,
                                                   string p_strDir,
                                                   int p_intAltura,
                                                   string p_strCodLoc,
                                                   string p_strPiso,
                                                   string p_strOficina,
                                                   StatMsg p_smResult
                                                  )
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;
            

            try
            {

                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                l_dbcAccess.BeginTransaction();

                // Traemos la entidad cliente.
                ECliente l_eCliente = Clientes.Srch(l_dbcAccess, p_iNumero, false, p_smResult);

                // Validamos!
                if (p_smResult.NOk) return null;

                // Cargo los parametros de los datos de la ubicacion.
                l_eCliente.Direccion = p_strDir;
                l_eCliente.Altura = p_intAltura;
                l_eCliente.Codlocalidad = p_strCodLoc;
                l_eCliente.Piso = p_strPiso;
                l_eCliente.Oficina = p_strOficina;

                // Actualizamos la entidad cliente.
                Clientes.Updt(l_dbcAccess, l_eCliente, p_smResult);

                // Validamos!
                if (p_smResult.NOk) return null;

                // Nos traemos la entidad cliente actualizada.
                l_eCliente = Clientes.Srch(l_dbcAccess, p_iNumero, false, p_smResult);

                // Validamos!
                if (p_smResult.NOk) return null;

                // Devolvemos la entidad actualizada.
                return l_eCliente;
            }

            catch (Exception l_expData)
            {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }

        }

        /// <summary>
        /// Metodo que actualiza el resto de los datos del cliente a partir de los parametros
        /// </summary>
        /// <param name="p_iNumero">Numero del Cliente</param>
        /// <param name="p_intCantEmp">Cantidad de Empleados</param>
        /// <param name="p_strCobertura">Cobertura</param>
        /// <param name="p_dtFFinRes">Fecha Fin de Reserva</param>
        /// <param name="p_strHorarios">Horarios</param>
        /// <param name="p_smResult">Resultado de la Operacion</param>
        /// <returns></returns>
        public static Bel.ECliente fUpdateOtherData(int p_iNumero,
                                                    int p_intCantEmp,
                                                    string p_strCobertura,
                                                    string p_strCuil,
                                                    string p_strHorarios,
                                                    string p_strObservaciones,
                                                    StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                l_dbcAccess.BeginTransaction();

                // Traemos la entidad cliente.
                ECliente l_eCliente = Clientes.Srch(l_dbcAccess, p_iNumero, false, p_smResult);

                // Validamos!
                if (p_smResult.NOk) return null;

                // Cargo los parametros de los datos de la ubicacion.
                l_eCliente.Cantempleados = p_intCantEmp;
                l_eCliente.Cobertura = p_strCobertura;
                l_eCliente.Cuil = p_strCuil;
                l_eCliente.Observacion = p_strObservaciones;

                // Actualizamos la entidad cliente.
                Clientes.Updt(l_dbcAccess, l_eCliente, p_smResult);

                // Validamos!
                if (p_smResult.NOk) return null;

                // Nos traemos la entidad cliente actualizada.
                l_eCliente = Clientes.Srch(l_dbcAccess, p_iNumero, false, p_smResult);

                // Validamos!
                if (p_smResult.NOk) return null;

                // Devolvemos la entidad actualizada.
                return l_eCliente;
            }

            catch (Exception l_expData)
            {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }

        }

        #endregion


        #region Metodos para persistencia y recupero de entrevistas

        /// <summary>
        /// Metodo que graba una entrevista a partir de los parametros.
        /// </summary>
        /// <param name="p_intNumCliente">Número del cliente</param>
        /// <param name="p_intNumEntrev">Número de entrevista</param>
        /// <param name="p_strCodVend">Código del vendedor</param>
        /// <param name="p_dtFechaCoor">Fecha coordinada</param>
        /// <param name="p_strNombre">Nombre del entrevistado</param>
        /// <param name="p_strTelefono">Telefono</param>
        /// <param name="p_strCargo">Cargo en la empresa</param>
        /// <param name="p_strCargo">Título</param>
        /// <param name="p_strCelular">Celular</param>
        /// <param name="p_strEmail">Email</param>
        /// <param name="p_strDireccion">Direccion</param>
        /// <param name="p_strObser">Observacion</param>
        /// <param name="p_smResult">Resultado de la operacion</param>
        public static void fSaveEntrevista(
                                           int p_intNumCliente,
                                           int p_intNumEntrev,
                                           string p_strCodVend,
                                           DateTime p_dtFechaCoor,
                                           ECliContacto p_eCliContacto,
                                           string p_strDireccion,
                                           string p_strObser,
                                           StatMsg p_smResult
                                           )
        {
            
            DBConn l_dbcAccess = null;

            if (p_eCliContacto.Titulo == "")
                p_eCliContacto.Titulo = "Señor";

            try
            {
                // Conseguimos la conexion.
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                // Iniciamos una transaccion, de aca en adelante todos los metodos a los que llamamos reciben la conexion que abrimos.
                l_dbcAccess.BeginTransaction();

                //---Traer entrevista
                ECliEntrevista l_EClEntrevista = Clientes.CleSrch(l_dbcAccess, p_intNumCliente, p_intNumEntrev, true, p_smResult);
                if (p_smResult.NOk) return;

                //---Si no existe, armar nueva
                if (l_EClEntrevista == null)
                    l_EClEntrevista = ECliEntrevista.NewEmpty();

                // Si el número de entrevista es distinto de 0, entonces cargamos el numero. Sino se cambia con el TaloGet en el Save_f
                if (p_intNumEntrev != 0)
                    l_EClEntrevista.Numentrev = p_intNumEntrev;
                else
                    l_EClEntrevista.Numentrev = 0;

                l_EClEntrevista.Numcliente = p_intNumCliente;
                l_EClEntrevista.Codvend = p_strCodVend;
                l_EClEntrevista.Fcoordinada = p_dtFechaCoor;
                l_EClEntrevista.Nombre = p_eCliContacto.Nombre;
                l_EClEntrevista.Telefono = p_eCliContacto.Telefono1;
                l_EClEntrevista.Cargo = p_eCliContacto.Cargo;
                l_EClEntrevista.Titulo = p_eCliContacto.Titulo;
                l_EClEntrevista.Celular = p_eCliContacto.Celular;
                l_EClEntrevista.Email = p_eCliContacto.Email;
                l_EClEntrevista.Direccion = p_strDireccion;
                l_EClEntrevista.Secretaria = p_eCliContacto.Secretaria;
                l_EClEntrevista.Observaciones = p_strObser;

                Clientes.CleSSav(l_dbcAccess, l_EClEntrevista, p_smResult);
                if (p_smResult.NOk) return;

            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }


        /// <summary>
        /// Devuelve si tiene o no entrevistas vencidas (incompletas y reserva vencida)
        /// </summary>
        /// <param name="p_leEntrevistas">Lista Entidad que contenga el campo cli_ent_vencidas</param>
        /// <param name="p_smResult">Mensaje de estado</param>
        /// <returns></returns>
        public static bool fTieneEntrevistasVencidas(
                                                     ListaEntidades p_leEntrevistas,
                                                     StatMsg p_smResult
                                                     )
        {
            try
            {
                p_leEntrevistas.Filter("cli_ent_vencidas = 'S'");
                return (p_leEntrevistas.Count != 0);
            }
            catch (Exception ex)
            {
                p_smResult.BllError(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// Devuelve si tiene o no entrevistas incompletas
        /// </summary>
        /// <param name="p_leCliReservados">Lista Entidad de clientes reservados</param>
        /// <param name="p_smResult">Mensaje de estado</param>
        /// <returns></returns>
        public static bool fTieneEntrevistasIncompletas(
                                                        ListaEntidades p_leCliReservados,
                                                        StatMsg p_smResult
                                                        )
        {
            
            try
            {
                p_leCliReservados.Filter("cli_ent_pendientesvenc > 0");
                return (p_leCliReservados.Count != 0);
            }
            catch (Exception ex)
            {
                p_smResult.BllError(ex.ToString());
                return false;
            }
        }


        /// <summary>
        /// Devuelve el número del cliente con una entrevista vencida
        /// </summary>
        /// <param name="p_strCodVend">Código de vendedor</param>
        /// <param name="p_smResult">Mensaje de estado</param>
        /// <returns></returns>
        public static int fPrimerClienteConEntrevistaVencida(
                                                             string p_strCodVend,
                                                             StatMsg p_smResult
                                                             )
        {
            DBConn l_dbcAccess = null;
            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                //---Traemos todas las entrevistas vencidas
                ListaEntidades l_leEntrevistas = CleGetEntrevistasVenc(l_dbcAccess, p_strCodVend, p_smResult);

                //---Si hubo error, devuelve -1
                if (p_smResult.NOk) return -1;

                //---Si trajo al menos una entrevista
                if (l_leEntrevistas.Count != 0)
                    return (int)l_leEntrevistas.InternalData[0].Row[5];
                else
                    return -1;
            }
            catch (Exception ex)
            {
                //---Si hubo error, devuelve -1
                p_smResult.BllError(ex.ToString());
                return -1;
            }
            finally
            {
                // Si abrimos conexion, la cerramos.
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }





        /// <summary>
        /// Metodo que tiene toda la logica en una transaccion de la generacion de un contrato.
        /// </summary>
        /// <param name="p_eCliServicio">Servicio a grabar</param>
        /// <param name="p_dtFRealizada">Fecha realizada de la entrevista que genero el contrato</param>
        /// <param name="p_intNumEntrev">Numero de la entrev</param>
        /// <param name="p_strMotivo">Motivo cambio de fecha</param>
        /// <param name="p_strInforme">Informe</param>
        /// <param name="p_strCodResultado">Codigo de resultado de la entrev</param>
        /// <param name="p_intNumCliente">NUmero del cliente</param>
        /// <param name="p_smResult">Resultado de la operacion</param>
        public static void fResultadoEntrevistaYBorradoPendientes(
                                                          DateTime p_dtFRealizada,
                                                          int p_intNumEntrev,
                                                          string p_strMotivo,
                                                          string p_strInforme,
                                                          string p_strCodResultado,
                                                          int p_intNumCliente,
                                                          string p_strCodMarca,
                                                          StatMsg p_smResult
                                                        )
        {
            DBConn l_dbcAccess = null;

            try
            {
                // Conseguimos la conexion.
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                // Iniciamos una transaccion, de aca en adelante todos los metodos a los que llamamos reciben la conexion que abrimos.
                l_dbcAccess.BeginTransaction();

                // Grabamos el resultado de la entrevista.
                CleSaveCompletarEntrev(l_dbcAccess,
                                       p_dtFRealizada,
                                       p_intNumEntrev,
                                       p_strMotivo,
                                       p_strInforme,
                                       p_strCodResultado,
                                       p_smResult);
                if (p_smResult.NOk) return;
            
                // Llamamos al metodo que borra las entrevistas pendientes.
                Clientes.BorraEntrevistasPend(l_dbcAccess, p_intNumCliente, p_smResult);
                if (p_smResult.NOk) return;
            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }

            }


        }

        #endregion


        /// <summary>
        /// Metodo que valida la unicidad del cliente a partir de los parametros.
        /// </summary>
        /// <param name="p_strRSocial">Razon social del nuevo cliente</param>
        /// <param name="p_strTelefono">Telefono del nuevo cliente</param>
        /// <param name="p_strError">Para reportar mensaje de error</param> 
        /// <param name="p_smResult">Resultado de la operacion</param>
        public static void fValidarCliente(
                                           string p_strRSocial,
                                           string p_strTelefono,
                                           string p_strNombre,
                                           string p_strApellido,
                                           ref string p_strError,
                                           StatMsg p_smResult
                                           )
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                // Llamamos a la validacion del cliente. (el porcentaje es -1 porque indica que estamos validando un solo cliente.
                fValidarCliente(l_dbcAccess, p_strRSocial, p_strTelefono, p_strNombre, p_strApellido, - 1, ref p_strError, p_smResult);
            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
                return;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                    l_dbcAccess.Close();

            }
        }

        /// <summary>
        /// Metodo que remueve todas las notas que le llegan por parametro
        /// </summary>
        /// <param name="p_leNotas">Lista entidad CliNotas</param>
        /// <param name="p_smResult">Resultado de las operaciones</param>
        public static void fClnRemoverMuchas(
                                             LECliNotas p_leNotas,
                                             StatMsg p_smResult
                                             )
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                l_dbcAccess.BeginTransaction();

                // Conseguimos la fecha de hoy
                DateTime l_dtNow = BllRuts.GetDBNow(l_dbcAccess, false, p_smResult);

                // Recorremos la lista de notas y removemos cada nota.
                foreach (Bel.ECliNota l_eNota in p_leNotas)
                {
                    // Llamamos al metodo interno
                    ClnRemover(l_dbcAccess, DBConn.Usuario, l_dtNow, l_eNota.Numcliente, l_eNota.Fechayhora, p_smResult);
                }


            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        ///  Metodo que convierte una entidad Cli Nota en una entidad Note
        /// </summary>
        /// <param name="p_eCliNota">Entidad CliNota</param>
        /// <returns></returns>
        public static ENote fClnConvertToENote(
                                               ECliNota p_eCliNota
                                               )
        {

            ENote l_eNota = ENote.MakeNew(p_eCliNota.Titulo,
                                          p_eCliNota.Texto,
                                          "T",
                                          p_eCliNota.Tipo,
                                          p_eCliNota.Fechayhora,
                                          p_eCliNota.Escritor);

            return l_eNota;
        }

        // Devuelve si un cliente esta dado de alta.
        public static bool fEsCliente(ECliente l_eCliente)
        {
            return l_eCliente.Alta.Trim().Equals("S");
        }

        public static void fGrabarLlamadaYCliente(ECliente p_eCliente, ECliLlamada p_eCliLlamada, StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                l_dbcAccess.BeginTransaction();

                Clientes.Updt(l_dbcAccess, p_eCliente, p_smResult);
                if (p_smResult.NOk) return;

                Clientes.CllSSav(l_dbcAccess, p_eCliLlamada, p_smResult);
                if (p_smResult.NOk) return;
            }

            catch (Exception l_expData)
            {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null)
                {
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }


        #endregion


        // Metodos privados de la clase

        #region Metodos privados de la clase

        #region Metodos Soporte Busqueda de Vendedores

        // Metodo que realiza la busqueda de clientes dado un where.
        private static ListaEntidades busquedaClientes(string l_strWhere, StatMsg p_smResult)
        {
            // Armamos Los joins.
            string l_strTablas = "Clientes ";
            l_strTablas = armaJoins(l_strTablas);

            //Armamos la lista de campos.
            string l_strCampos = listaCampos();

            // Ejecutamos el select.
            ListaEntidades l_leClientes = AppRuts.DoASelect(l_strCampos,
                                                            l_strTablas,
                                                            l_strWhere,
                                                            "",
                                                            "",
                                                            "",
                                                            p_smResult);
            //Corroboramos que no hayan ocurrido errores.
            if (p_smResult.NOk)
                return null;

            captionamos(l_leClientes);

            return l_leClientes;
        }

        // Metodo que tiene encapsulada la lista de campos para la busqueda de clientes (del vendedor)
        private static string listaCampos()
        {
            string l_strCampos = "cli_nro_treservado," +
                                 "cli_nro_numero," +
                                 "cli_ede_rsocial," +
                                 "cli_des_nombrefant," +
                                 "tin_des_des," +
                                 "frq_des_des," +
                                 "loc_ede_nombre," +
                                 "cli_ede_direccion," +
                                 "cli_nro_altura," +
                                 "TNGS_Carm..Clientes.deleted";
            return l_strCampos;
        }

        // Metodo que tiene encapsulada la logica de los captions.
        private static void captionamos(ListaEntidades l_leClientes)
        {
            // Hacemos los captions necesarios.
            l_leClientes.ClearCaptions();
            l_leClientes.ChangeCaption("cli_nro_treservado", "V1tNN2");
            l_leClientes.ChangeCaption("cli_nro_numero", "V1nNN2");
            l_leClientes.ChangeCaption("cli_ede_rsocial", "V1Razón SocialCN2");
            l_leClientes.ChangeCaption("cli_des_nombrefant", "V1Nombre FantasiaCN2");
            l_leClientes.ChangeCaption("tin_des_des", "V1Tipo InstitucionCN2");
            l_leClientes.ChangeCaption("frq_des_des", "V1FranquiciaCN2");
            l_leClientes.ChangeCaption("loc_ede_nombre", "V1LocalidadCN2");
            l_leClientes.ChangeCaption("cli_ede_direccion", "V1DirecciónCN2");
            l_leClientes.ChangeCaption("cli_nro_altura", "V1AlturaNN2");
            l_leClientes.ChangeCaption("deleted", "V1dCN2");
        }

        // Metodo privado que encapsula el armado de joins generico a las busquedas (del vendedor) de clientes mayoristas y minoristas 
        private static string armaJoins(string p_strTablas)
        {
            AppRuts.AddTable("TipoInst", JoinModes.LeftOuter, condicionJoin(ECliente.CodtinstCmp, ETipoInst.CodCmp), ref p_strTablas);
            AppRuts.AddTable("Franquicias", JoinModes.LeftOuter, condicionJoin(ECliente.CodfrqCmp, EFranquicia.CodCmp), ref p_strTablas);
            AppRuts.AddTable("Localidades", JoinModes.LeftOuter, condicionJoin(ECliente.CodlocalidadCmp, ELocalidad.CodpostCmp), ref p_strTablas);
            return p_strTablas;
        }


        #endregion


        #region Metodos Soporte Busqueda de Secretaria

        // Realiza una busqueda, con el formato de la grilla de la secretaria, dado un where
        private static ListaEntidades busquedaClientesSecretaria(string p_strWhere, bool p_boolEsBusquedaXContacto, 
                                                                 bool p_boolAplicarPermisos, StatMsg p_smResult)
        {
            // Armamos Los joins.
            string l_strTablas = "Clientes ";
            l_strTablas = armaJoinsSecretaria(l_strTablas, p_boolEsBusquedaXContacto, p_boolAplicarPermisos);

            string l_strCampos = listaCamposSecretaria();

            // Ejecutamos el select.
            ListaEntidades l_leClientes = AppRuts.DoASelect(l_strCampos,
                                                            l_strTablas,
                                                            p_strWhere,
                                                            "",
                                                            "",
                                                            "",
                                                            p_smResult);

            //Corroboramos que no hayan ocurrido errores.
            if (p_smResult.NOk)
                return null;

            captionaBusquedaSecretaria(l_leClientes);

            return l_leClientes;
        }

        // Arma los joins necesarios para una busqueda de secretaria
        private static string armaJoinsSecretaria(string p_strTablas, bool p_boolEsBusquedaXContacto, 
                                                  bool p_boolAplicarPermisos)
        {
            // Agregamos los particulares de la busqueda de secretaria
            AppRuts.AddTable("Localidades", JoinModes.LeftOuter, condicionJoin(ECliente.CodlocalidadCmp, ELocalidad.CodpostCmp), ref p_strTablas);
            AppRuts.AddTable("Zonas", JoinModes.LeftOuter, condicionJoin(EZona.CodCmp, ELocalidad.CodzonaCmp), ref p_strTablas);
            AppRuts.AddTable("Marcas", JoinModes.LeftOuter, condicionJoin(ECliente.CodmarcaCmp, EMarca.CodCmp), ref p_strTablas);
            AppRuts.AddTable("Vendedores", JoinModes.LeftOuter, condicionJoin(ECliente.CodvendCmp, EVendedor.CodCmp), ref p_strTablas);
            if (p_boolEsBusquedaXContacto)
                AppRuts.AddTable("CliContactos", JoinModes.Full, "cli_nro_numero = clc_nro_numcliente", ref p_strTablas);
            return p_strTablas;
        }

        // Arma la lista de los campos requeridos.
        private static string listaCamposSecretaria()
        {
            //Armamos la lista de campos.
            string l_strCampos = ECliente.NumeroCmp + ", " +
                                 ECliente.RsocialCmp + ", " +
                                 ECliente.NombrefantCmp + ", " +
                                 ECliente.NombreCmp + ", " +
                                 ECliente.ApellidoCmp + ", " +
                                 ECliente.Telefono1Cmp + ", " +
                                 ECliente.ResultllamadaCmp + ", " +
                                 ECliente.AltaCmp + ", " +
                                 "loc_ede_nombre as cli_ede_loc," +
                                 ECliente.CodvendCmp + ", " +
                                 ECliente.NroavalonCmp + ", " +
                                 ECliente.EmailCmp + ", " +
                                 ECliente.CelularCmp + ", " +
                                 ECliente.ObservacionCmp;
            return l_strCampos;
        }

        // Metodo que captiona una lista entidades con los captions necesarios para la grilla de la secretaria
        private static void captionaBusquedaSecretaria(ListaEntidades l_leClientes)
        {
            // Hacemos los captions necesarios.
            l_leClientes.ClearCaptions();

            l_leClientes.ChangeCaption(ECliente.NumeroCmp, "V1NúmeroNN2");                      /*0*/
            l_leClientes.ChangeCaption(ECliente.RsocialCmp, "V1Razón SocialCN2");               /*1*/
            l_leClientes.ChangeCaption(ECliente.NombrefantCmp, "V1Nombre FantasíaCN2");         /*2*/
            l_leClientes.ChangeCaption(ECliente.NombreCmp, "V1NombreCN2");                      /*3*/
            l_leClientes.ChangeCaption(ECliente.ApellidoCmp, "V1ApellidoCN2");                  /*4*/
            l_leClientes.ChangeCaption(ECliente.Telefono1Cmp, "V1TeléfonoCN2");                 /*5*/
            l_leClientes.ChangeCaption(ECliente.ResultllamadaCmp, "V1Ult. LlamadaCN2");         /*6*/
            l_leClientes.ChangeCaption("cli_ede_loc", "V1LocalidadCN2");                        /*7*/
            l_leClientes.ChangeCaption(ECliente.CodvendCmp, "V1Cod. Vend.CN2");                 /*8*/
            l_leClientes.ChangeCaption(ECliente.EmailCmp, "V1EmailCN1");                        /*9*/
            l_leClientes.ChangeCaption(ECliente.CelularCmp, "V1CelularCN1");                    /*10*/
            l_leClientes.ChangeCaption(ECliente.ObservacionCmp, "V1ObservacionesCN1");          /*11*/
        }

        #endregion



        private static void fGrabaVenta(DBConn p_dbcAccess, 
                                        ECliVenta p_eCliVenta, 
                                        int p_intNroAvalon, 
                                        StatMsg p_smResult)
        {


            try
            {
                // Grabamos la venta y el historico abono para que este actualizado.
                ClvInsr(p_dbcAccess, p_eCliVenta, p_smResult);
                if (p_smResult.NOk) return;
            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
                return;
            }
        }

        /// <summary>
        /// Metodo que graba los servicios nuevos para un cliente, borrando los viejos (segun su tipo)
        /// </summary>
        /// <param name="p_dbcAccess">Acceso a la base</param>
        /// <param name="p_leCliServicios">Lista entidades de servicios a grabar</param>
        /// <param name="p_iNumCliente">Numero de cliente</param>
        /// <param name="p_bEsCompetencia">Si corresponde a servicios de la competencia o nuestros</param>
        /// <param name="p_smResult">Resultado de la operacion</param>
        private static void fGrabaServicios(
                                    DBConn p_dbcAccess,
                                    int p_iNumCliente,
                                    LECliServicios p_leCliServicios,
                                    StatMsg p_smResult
                                   )
        {


            try
            {
                // Llamamos al metodo que borra los servicios de un cliente.
                ClsBorraPorCliente(p_dbcAccess, p_iNumCliente, p_smResult);

                // Hacemos el mismo grabado que hace el ClsSave: Recorremos la lista de entidades
                foreach (ECliServicio l_entCliServicio in p_leCliServicios)
                {
                    // Forzamos la clave foranea
                    l_entCliServicio.Numcliente = p_iNumCliente;

                    // Verificamos si existe
                    ClsVKey(p_dbcAccess,
                            l_entCliServicio.Numcliente,
                            l_entCliServicio.Item,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound))
                    {
                        // Hay que darla de alta
                        ClsInsr(p_dbcAccess, l_entCliServicio, p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    ClsVVer(p_dbcAccess,
                            l_entCliServicio.Numcliente,
                            l_entCliServicio.Item,
                            l_entCliServicio.FxdVersion,
                            p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entCliServicio.EstaBorrada)
                    {
                        ClsUpdt(p_dbcAccess, l_entCliServicio, p_smResult);
                        if (p_smResult.NOk) return;
                    }
                }

            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
                return;
            }
        }

        /// <summary>
        /// Sobrecarga del Metodo que se encarga de marcar a un cliente como vendido
        /// </summary>
        /// <param name="p_intNroCliente">Numero del cliente</param>
        /// <param name="p_strCodVend">Codigo de Vendedor</param>
        /// <param name="p_smResult">Resultado de la operacion</param>
        private static void fVendido(
                                    DBConn p_dbcAccess,
                                    ECliente p_eClienteVendido,
                                    StatMsg p_smResult
                                    )
        {

            try
            {

                // Conseguimos la fecha de hoy
                DateTime l_dtToday = BllRuts.GetDBNow(p_dbcAccess, false, p_smResult);


                //Corroboramos que no hayan ocurrido errores.
                if (p_smResult.NOk)
                    return;

                // Llamamos a la logica de marcar al cliente como vendido.
                Clientes.Vendido(p_dbcAccess,
                                 p_eClienteVendido.Numero,
                                 p_eClienteVendido.Abono,
                                 p_eClienteVendido.Codtipocont,
                                 p_smResult);


                //Corroboramos que no hayan ocurrido errores.
                if (p_smResult.NOk)
                    return;
            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
                return;
            }
        }

        private static void agregarLimitantesPermisosVendedores(ref string p_strWhere, string p_strCodMarcaUsuario)
        {
            // Los vendedores no pueden ver clientes que ya esten vendidos.
            p_strWhere += AppRuts.MakeWhere(Bel.ECliente.AltaCmp, "N", StringModes.Equal);
        }


        /// <summary>
        /// Metodo que valida la unicidad del cliente a partir de los parametros.
        /// </summary>
        /// <param name="p_strRSocial">Razon social del nuevo cliente</param>
        /// <param name="p_strTelefono">Telefono del nuevo cliente</param>
        /// <param name="p_strDir">Direccion del nuevo cliente</param>
        /// <param name="p_dPorcentaje">Porcentaje de avance, en caso de ser un solo cliente debe recibir -1 </param>
        /// <param name="p_strError">Para reportar mensaje de error</param> 
        /// <param name="p_smResult">Resultado de la operacion</param>
        private static void fValidarCliente(DBConn p_dbcAccess,
                                            string p_strRSocial,
                                            string p_strTelefono,
                                            string p_strNombre,
                                            string p_strApellido,
                                            double p_dPorcentaje,
                                            ref string p_strError,
                                            StatMsg p_smResult)
        {

            try
            {
                if (p_dPorcentaje != -1)
                    fReportaAvance("Validando cliente : " + p_strRSocial, p_dPorcentaje);
                else
                    fReportaAvance("Validando Razón Social", 50);

                if(!string.IsNullOrEmpty(p_strRSocial))
                {
                    ListaEntidades l_leValidaRSocial = Clientes.ValidaRSocial(p_dbcAccess, p_strRSocial, p_smResult);
                    if (p_smResult.NOk) return;

                    if (l_leValidaRSocial.Count != 0)
                        // Error de existencia de cliente con esa Razon Social
                        p_strError += "La Razón Social ingresada ya existe en el cliente número: "
                                        + l_leValidaRSocial.InternalData[0][0].ToString().Trim() + " \r\n";
                }

                // TODO: Validar nombre y apellido si lo piden y es necesario.

                // Validamos que este capturado el evento.
                if (p_dPorcentaje == -1)
                    fReportaAvance("Validando Teléfono", 90);

                ListaEntidades l_leValidaTelefono = Clientes.ValidaTelefono(p_dbcAccess, p_strTelefono, p_smResult);
                if (p_smResult.NOk) return;

                if (l_leValidaTelefono.Count != 0)
                    // Error de existencia de cliente con ese Telefono
                    p_strError += "El Telefono ingresado ya existe en el cliente número: "
                                    + l_leValidaTelefono.InternalData[0][0].ToString().Trim() + " \r\n";



                // Validamos que este capturado el evento.
                if (p_dPorcentaje == -1)
                    fReportaAvance("Validación finalizada", 100);


            }
            catch (Exception a)
            {
                p_smResult.BllError(a.ToString());
                return;
            }
        }

        private static string condicionJoin(string p_strPrimerCampo, string p_strSegundoCampo)
        {
            return String.Format("{0} = {1}", p_strPrimerCampo, p_strSegundoCampo);
        }

        // Metodo que reporta el avance a partir de los parametros de mensaje y porcentaje.
        private static void fReportaAvance(string p_strMensaje, double p_dPorcentaje)
        {
            if (Advance != null)
            {
                BllReportEventArgs l_eaAdvance = new BllReportEventArgs();
                l_eaAdvance.Mensaje = p_strMensaje;
                l_eaAdvance.Percent = p_dPorcentaje;
                Advance(null, l_eaAdvance);
            }
        }




        #endregion



        #region Metodos del Generador
        /// <summary>
        /// Agrega o modifica un registro de la tabla: CliContactos
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliContacto">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClcSave_f(DBConn p_dbcAccess,
                                       ref ECliContacto p_entCliContacto,
                                       StatMsg p_smResult)
        {

            // *********
            // Agregar acá los procesos adicionales
            // *********

            if (p_entCliContacto.Numcontacto == -1)
                p_entCliContacto.Numcontacto = AppRuts.TaloGet("nroCliCont", p_smResult).Valor;


        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: CliContactos
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClcEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          int p_iNumcliente,
                                          int p_iNumcontacto,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: CliContactos
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumcontacto">Número</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClcRemove_f(DBConn p_dbcAccess,
                                         int p_iNumcliente,
                                         int p_iNumcontacto,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: CliContacto
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliContacto">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClcTInt_f(DBConn p_dbcAccess,
                                       ECliContacto p_entCliContacto,
                                       StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: CliEntrevistas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliEntrevista">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleSave_f(DBConn p_dbcAccess,
                                       ref ECliEntrevista p_entCliEntrevista,
                                       StatMsg p_smResult)
        {

            // *********
            // Agregar acá los procesos adicionales
            // *********

            if (p_entCliEntrevista.Numentrev == 0)
                p_entCliEntrevista.Numentrev = AppRuts.TaloGet("nroCliEnt", p_smResult).Valor;
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: CliEntrevistas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumentrev">Número</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          int p_iNumcliente,
                                          int p_iNumentrev,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: CliEntrevistas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumentrev">Número</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleRemove_f(DBConn p_dbcAccess,
                                         int p_iNumcliente,
                                         int p_iNumentrev,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: CliEntrevista
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliEntrevista">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CleTInt_f(DBConn p_dbcAccess,
                                       ECliEntrevista p_entCliEntrevista,
                                       StatMsg p_smResult)
        {
        }


        /// <summary>
        /// Agrega o modifica un registro de la tabla: CliGrupoFamiliar
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliGrupoFamiliar">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CgfSave_f(DBConn p_dbcAccess,
                                       ref ECliGrupoFamiliar p_entCliGrupoFamiliar,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: CliGrupoFamiliar
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Nro Cliente</param>
        /// <param name="p_iNumintegrante">Nro Integrante GF</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CgfEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          int p_iNumcliente,
                                          int p_iNumintegrante,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: CliGrupoFamiliar
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Nro Cliente</param>
        /// <param name="p_iNumintegrante">Nro Integrante GF</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CgfRemove_f(DBConn p_dbcAccess,
                                         int p_iNumcliente,
                                         int p_iNumintegrante,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: CliGrupoFamiliar
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliGrupoFamiliar">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CgfTInt_f(DBConn p_dbcAccess,
                                       ECliGrupoFamiliar p_entCliGrupoFamiliar,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }


        /// <summary>
        /// Agrega o modifica un registro de la tabla: CliLlamadas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliLlamada">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CllSave_f(DBConn p_dbcAccess,
                                       ref ECliLlamada p_entCliLlamada,
                                       StatMsg p_smResult)
        {

            // *********
            // Agregar acá los procesos adicionales
            // *********

            if (p_entCliLlamada.Numllamada == -1)
                p_entCliLlamada.Numllamada = AppRuts.TaloGet("nroCliLlam", p_smResult).Valor;

        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: CliLlamadas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CllEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          int p_iNumcliente,
                                          int p_iNumllamada,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {

        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: CliLlamadas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número de cliente</param>
        /// <param name="p_iNumllamada">Número de llamada</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CllRemove_f(DBConn p_dbcAccess,
                                         int p_iNumcliente,
                                         int p_iNumllamada,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: CliLlamada
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliLlamada">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CllTInt_f(DBConn p_dbcAccess,
                                       ECliLlamada p_entCliLlamada,
                                       StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: CliNotas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliNota">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnSave_f(DBConn p_dbcAccess,
                                       ref ECliNota p_entCliNota,
                                       StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: CliNotas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          int p_iNumcliente,
                                          DateTime p_dtFechayhora,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: CliNotas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero del Cliente</param>
        /// <param name="p_dtFechayhora">Fecha y Hora</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnRemove_f(DBConn p_dbcAccess,
                                         int p_iNumcliente,
                                         DateTime p_dtFechayhora,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: CliNota
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliNota">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClnTInt_f(DBConn p_dbcAccess,
                                       ECliNota p_entCliNota,
                                       StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: CliServicios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliServicio">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClsSave_f(DBConn p_dbcAccess,
                                       ref ECliServicio p_entCliServicio,
                                       StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: CliServicios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Número Cliente</param>
        /// <param name="p_iItem">Item</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClsEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          int p_iNumcliente,
                                          int p_iItem,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: CliServicios
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Número Cliente</param>
        /// <param name="p_iItem">Item</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClsRemove_f(DBConn p_dbcAccess,
                                         int p_iNumcliente,
                                         int p_iItem,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: CliServicio
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliServicio">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClsTInt_f(DBConn p_dbcAccess,
                                       ECliServicio p_entCliServicio,
                                       StatMsg p_smResult)
        {
        }


        /// <summary>
        /// Agrega o modifica un registro de la tabla: CliVentas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliVenta">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClvSave_f(DBConn p_dbcAccess,
                                       ref ECliVenta p_entCliVenta,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: CliVentas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClvEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          int p_iNumcliente,
                                          DateTime p_dtFecha,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: CliVentas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumcliente">Numero Cliente</param>
        /// <param name="p_dtFecha">Fecha Venta</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClvRemove_f(DBConn p_dbcAccess,
                                         int p_iNumcliente,
                                         DateTime p_dtFecha,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: CliVenta
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliVenta">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ClvTInt_f(DBConn p_dbcAccess,
                                       ECliVenta p_entCliVenta,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Clientes
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliente">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Save_f(DBConn p_dbcAccess,
                                    ref ECliente p_entCliente,
                                    StatMsg p_smResult)
        {

            // *********
            // Agregar acá los procesos adicionales
            // *********

            if (p_entCliente.Numero == -1)
                p_entCliente.Numero = AppRuts.TaloGet("nroCliente", p_smResult).Valor;

        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Clientes
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Enabled_f(DBConn p_dbcAccess,
                                       bool p_bEnable,
                                       int p_iNumero,
                                       ref int p_iFxdVersion,
                                       StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Clientes
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNumero">Número de cliente</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Remove_f(DBConn p_dbcAccess,
                                      int p_iNumero,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Cliente
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCliente">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt_f(DBConn p_dbcAccess,
                                    ECliente p_entCliente,
                                    StatMsg p_smResult)
        {
        }

        #endregion

        #region Propiedades de la clase

        #endregion

    }
}
