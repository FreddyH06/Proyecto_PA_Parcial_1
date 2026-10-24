namespace Proyecto_PA_Parcial_1.Entidades
{
    public class Usuario
    {
        private string username;
        private string nombre;
        private string apellidos;
        private string telefono;
        private string claveHash;
        private string tipoUsuario;
        private string codigoSucursal;
        private string ventanilla;
        private bool activo;

        public Usuario() { }

        public Usuario(string username, string nombre, string apellidos, string telefono, string claveHash, string tipoUsuario, string codigoSucursal, string ventanilla, bool activo)
        {
            this.username = username;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.claveHash = claveHash;
            this.tipoUsuario = tipoUsuario;
            this.codigoSucursal = codigoSucursal;
            this.ventanilla = ventanilla;
            this.activo = activo;
        }

        public string Username { get => username; set => username = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string ClaveHash { get => claveHash; set => claveHash = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public string CodigoSucursal { get => codigoSucursal; set => codigoSucursal = value; }
        public string Ventanilla { get => ventanilla; set => ventanilla = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
