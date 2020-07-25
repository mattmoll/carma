#region Usings
using System;
using System.Linq;
using TNGS.NetRoutines;
using Carm.Bel;
using System.Data;
#endregion

namespace Carm.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 27/08/2013 21:01
    // Sistema                  : Sima
    // Clase para Administrar   : Vendedores
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Vendedores
    /// </summary>
    public static partial class Vendedores
    {
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        #region Metodos publicos de la clase





        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetCodVend
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static string fGetCodVendAsString(StatMsg p_smResult)
        {
            DBConn l_dbcAccess = null;

            try
            {
                // Llamamos al metodo que nos da un vendedor.
                EVendedor l_eVendedor = Bll.Vendedores.fGetVendedorFromUsu(p_smResult);

                // Validamos que no haya errores.
                if (p_smResult.NOk) return "";

                // Devolvemos el codigo de vendedor
                return l_eVendedor.Cod;
            }
            catch (Exception l_expData)
            {
                // Error en la operacion
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally
            {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

       

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetVendedorFromUsu
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static EVendedor fGetVendedorFromUsu(StatMsg p_smResult)
        {
            DBConn l_dbcAccess = null;

            try
            {
                // Abrimos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                // Obtenemos la lista de vendedores a partir del usuario, filtrmaos los que esten borrados y si no queda solo uno error.
                LEVendedores l_leVendedores = GetVendedorFromUsu(l_dbcAccess, p_smResult);
                if (p_smResult.NOk) return null;

                if(l_leVendedores.Count == 0)
                {
                    p_smResult.BllError("No se encontró un vendedor con su codigo de usuario");
                    return null;
                }

                EVendedor l_eVendedor = (EVendedor)l_leVendedores.Where(unVendedor => !unVendedor.EstaBorrada).ToList()[0];

                if (l_eVendedor == null)
                {
                    p_smResult.BllError("No se encontró un vendedor con su codigo de usuario");
                    return null;
                }

                return l_eVendedor;
            }
            catch (Exception l_expData)
            {
                // Error en la operacion
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally
            {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        #endregion

        #region Metodos para validacion de usuario para la pagina web

        /// <summary>
        /// Recupera los datos de un usuario de la base Idn
        /// </summary>
        /// <param name="p_cnInfo">Codigo para identificar la string de conexion</param>
        /// <param name="p_strUser">Codigo del usuario</param>
        /// <param name="p_bChekSup">Verificar supervisor en Sist/Prog</param>
        /// <param name="p_strSist">Sigla del sistema</param>
        /// <param name="p_strPrg">Sigla del programa</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad con los datos del usuario</returns>
        public static EIdnUsuario UserFullGet(string p_strUser,
                                              StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;

            try
            {
                // Obtenemos una conexion a la base de datos
                l_dbcAccess = DBRuts.GetConection(Connections.Idn);

                // Verificamos si existe el usuario y si esta habilitado
                DataSet l_dsTemp = new DataSet();

                int l_iRet = Vendedores.UserFullSearch(l_dbcAccess, p_strUser, ref l_dsTemp, "Temporal1", p_smResult);
                if (p_smResult.NOk) return null;

                if (l_iRet == 0)
                {
                    p_smResult.BllWarning("Acceso denegado (Internal Error 1)");
                    l_dsTemp.Dispose();
                    return null;
                }

                // Construimos la entidad del usuario
                EIdnUsuario l_entUser = new EIdnUsuario(l_dsTemp.Tables["Temporal1"].Rows[0]);

                if (l_entUser.EstaBorrada)
                {
                    // No puede volver
                    p_smResult.BllWarning("Acceso denegado (Internal Error 2)");
                    l_entUser.Dispose();
                    l_dsTemp.Dispose();
                    return null;
                }


                return l_entUser;
            }
            catch (Exception l_expData)
            {
                // Error al obtener el usuario
                p_smResult.BllError(l_expData);
                return null;
            }
            finally
            {
                // Si logramos abrir la conexion-> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Busca el registro de una clave (Completo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strUsuario">Codigo</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        private static int UserFullSearch(DBConn p_dbcAccess,
                                         string p_strUsuario,
                                         ref DataSet p_dsResult,
                                         string p_strTabla,
                                         StatMsg p_smResult)
        {
            try
            {
                return p_dbcAccess.IdnDal.UserFullSearch(p_dbcAccess, p_strUsuario, ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData)
            {
                // Error en el delete del registro
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        #endregion

        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------


        #region Metodos del Generador
        /// <summary>
        /// Agrega o modifica un registro de la tabla: Vendedores
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entVendedor">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Save_f(DBConn p_dbcAccess,
                                    ref EVendedor p_entVendedor,
                                    StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Vendedores
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Enabled_f(DBConn p_dbcAccess,
                                       bool p_bEnable,
                                       string p_strCod,
                                       ref int p_iFxdVersion,
                                       StatMsg p_smResult)
        {

            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Vendedores
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Código</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Remove_f(DBConn p_dbcAccess,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Vendedor
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entVendedor">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt_f(DBConn p_dbcAccess,
                                    EVendedor p_entVendedor,
                                    StatMsg p_smResult)
        {
        }

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion


    }
}
