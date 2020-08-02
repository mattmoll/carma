using TNGS.NetRoutines;
using TNGS.NetAppBll;

namespace Carm.Bll
{
    public class BusquedaSecretaria
    {
        StatMsg m_smResult = new StatMsg();

        // Definimos las propiedades para los filtros.
        private string m_strNumero;
        private string m_strNumeroAvalon;
        private string m_strAltura;
        private string m_strFranq;
        private string m_strRubro;
        private string m_strTInst;
        private string m_strZona;
        private string m_strLoc;
        private string m_strMarca;
        public string Rsocial { get; set; }
        public string NFant { get; set; }
        public string Cargador { get; set; }
        public string CodVend { get; set; }
        public string Dir { get; set; }
        public string Reservado { get; set; }
        public string ConError { get; set; }
        public string Vendido { get; set; }
        public string Deudor { get; set; }
        public string Mayorista { get; set; }
        public string Competencia { get; set; }
        public string MailCargado { get; set; }
        public string Telefono { get; set; }
        public string codMarcaCliente { get; set; }
        public string codMarcaUsuario { get; set; }

        public bool aplicarPermisos = true;

        // Constructor que inicializa los filtros.
        public BusquedaSecretaria()
        {
            limpiarBusqueda();
        }

        // Devuelve true si todos los filtros estan vacios
        public bool busquedaVacia()
        {
            // En los filtros que van a combos usamos el miembro en vez de la property porque sino le agrega
            // padding y no da igual a string vacia.
            return ((Numero == "") && (NumeroAvalon == "") && (Rsocial == "") && (NFant == "") && (CodVend == "")
                    && (Cargador == "") && (m_strFranq == "") && (m_strRubro == "") && (m_strTInst == "")
                    && (m_strZona == "") && (m_strLoc == "") && (Dir == "") && (Altura == "") && (Telefono == "")
                    && (codMarcaCliente == "") && (codMarcaUsuario == "") && (Marca == "") 
                    && ((Reservado == "") || (Reservado == "A")) && ((ConError == "") || (ConError == "A"))
                    && ((Vendido == "") || (Vendido == "A")) && ((Mayorista == "") || (Mayorista == "A"))
                    && ((Competencia == "") || (Competencia == "A")) && ((MailCargado == "") || (MailCargado == "A"))
                    && ((Deudor == "") || (Deudor == "A")));
        }

        public void limpiarBusqueda()
        {
            // Asignamos string vacia a todos los filtros de la busqueda.
            Numero = NumeroAvalon = Rsocial = NFant = CodVend = Cargador = Franq = Rubro = TInst = Marca = Telefono = Zona = Loc = Dir = Altura = "";
            codMarcaCliente = codMarcaUsuario = "";
            Reservado = ConError = Vendido = Mayorista = Competencia = MailCargado = Deudor = "A";
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
        public string Franq { get { return m_strFranq.PadLeft(4, ' '); } set {m_strFranq = value;} }
        public string Rubro { get { return m_strRubro.PadLeft(2, ' '); } set { m_strRubro = value; } }
        public string TInst { get { return m_strTInst.PadLeft(4, ' '); } set { m_strTInst = value; } }
        public string Zona { get { return m_strZona.PadLeft(2, ' '); } set { m_strZona = value; } }
        public string Loc { get { return m_strLoc.PadLeft(8, ' '); } set { m_strLoc = value; } }
        public string Marca { get { return m_strMarca.PadLeft(2, ' '); } set { m_strMarca = value; } }

    }
}
