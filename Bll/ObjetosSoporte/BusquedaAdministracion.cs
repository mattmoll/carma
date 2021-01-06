using TNGS.NetRoutines;
using TNGS.NetAppBll;

namespace Carm.Bll
{
    public class BusquedaAdministracion
    {
        StatMsg m_smResult = new StatMsg();

        // Definimos las propiedades para los filtros.
        private string m_strNumero;
        private string m_strNumeroAvalon;
        private string m_strAltura;
        private string m_strRubro;
        private string m_strTInst;
        private string m_strZona;
        private string m_strLoc;
        private string m_strMarca;
        private string m_strTipoCliente;
        public string Rsocial { get; set; }
        public string NFant { get; set; }
        public string NombreYApellido { get; set; }
        public string Cargador { get; set; }
        public string CodVend { get; set; }
        public string Dir { get; set; }
        public string Reservado { get; set; }
        public string Vendido { get; set; }
        public string MailCargado { get; set; }
        public string Telefono { get; set; }

        public bool aplicarPermisos = true;

        // Constructor que inicializa los filtros.
        public BusquedaAdministracion()
        {
            limpiarBusqueda();
        }

        // Devuelve true si todos los filtros estan vacios
        public bool busquedaVacia()
        {
            // En los filtros que van a combos usamos el miembro en vez de la property porque sino le agrega
            // padding y no da igual a string vacia.
            return ((Numero == "") && (NumeroAvalon == "") && (Rsocial == "") && (NFant == "") && (CodVend == "")
                    && (Cargador == "") && (NombreYApellido == "") && (m_strRubro == "") && (m_strTInst == "")
                    && (m_strZona == "") && (m_strLoc == "") && (Dir == "") && (Altura == "") && (Telefono == "")
                    && (Marca == "")
                    && ((Reservado == "") || (Reservado == "A"))
                    && ((Vendido == "") || (Vendido == "A")) && ((TipoCliente == "") || (TipoCliente == "A"))
                    && ((MailCargado == "") || (MailCargado == "A")));
        }

        public void limpiarBusqueda()
        {
            // Asignamos string vacia a todos los filtros de la busqueda.
            Numero = NumeroAvalon = Rsocial = NFant = NombreYApellido = CodVend = Cargador = Rubro = TInst = Marca = Telefono = Zona = Loc = Dir = Altura = "";
            Reservado  = Vendido = TipoCliente = MailCargado = "A";
        }

        public string Numero
        {
            get { return m_strNumero; }
            // Set con validacion de que 0 es igual a filtro nulo.
            set {
                m_strNumero = (value == "0") ? "" : value;
            }
        }

        public string NumeroAvalon
        {
            get { return m_strNumeroAvalon; }
            // Set con validacion de que 0 es igual a filtro nulo.
            set
            {
                m_strNumeroAvalon = (value == "0") ? "" : value;
            }
        }

        public string Altura
        {
            get { return m_strAltura; }
            // Set con validacion de que 0 es igual a filtro nulo.
            set {
                m_strAltura = (value == "0") ? "" : value;
            }
        }

        // Properties con logica de padding ya que son las que van a combos.
        public string Rubro { get { return m_strRubro.PadLeft(2, ' '); } set { m_strRubro = value; } }
        public string TInst { get { return m_strTInst.PadLeft(4, ' '); } set { m_strTInst = value; } }
        public string Zona { get { return m_strZona.PadLeft(2, ' '); } set { m_strZona = value; } }
        public string Loc { get { return m_strLoc.PadLeft(8, ' '); } set { m_strLoc = value; } }
        public string Marca { get { return m_strMarca.PadLeft(2, ' '); } set { m_strMarca = value; } }
        public string TipoCliente { get { return m_strTipoCliente.PadLeft(2, ' '); } set { m_strTipoCliente = value; } }

    }
}
