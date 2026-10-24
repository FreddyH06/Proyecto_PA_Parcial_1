namespace Proyecto_PA_Parcial_1.Entidades
{
    public class Empresa
    {
        private string ruc;
        private string razonSocial;
        private string correo;
        private bool obligarCedula;
        private bool obligarNombre;
        private bool obligarCorreo;
        private bool obligarTelefono;
        private string smtpServidor;
        private int smtpPuerto;
        private string smtpUsuario;
        private bool smtpSsl;
        private string correo365AppId;
        private string correo365Tenant;

        public Empresa() { }

        public Empresa(string ruc, string razonSocial, string correo, bool obligarCedula, bool obligarNombre, bool obligarCorreo, bool obligarTelefono, string smtpServidor, int smtpPuerto, string smtpUsuario, bool smtpSsl, string correo365AppId, string correo365Tenant)
        {
            this.ruc = ruc;
            this.razonSocial = razonSocial;
            this.correo = correo;
            this.obligarCedula = obligarCedula;
            this.obligarNombre = obligarNombre;
            this.obligarCorreo = obligarCorreo;
            this.obligarTelefono = obligarTelefono;
            this.smtpServidor = smtpServidor;
            this.smtpPuerto = smtpPuerto;
            this.smtpUsuario = smtpUsuario;
            this.smtpSsl = smtpSsl;
            this.correo365AppId = correo365AppId;
            this.correo365Tenant = correo365Tenant;
        }

        public string Ruc { get { return ruc; } set { ruc = value; } }
        public string RazonSocial { get { return razonSocial; } set { razonSocial = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public bool ObligarCedula { get { return obligarCedula; } set { obligarCedula = value; } }
        public bool ObligarNombre { get { return obligarNombre; } set { obligarNombre = value; } }
        public bool ObligarCorreo { get { return obligarCorreo; } set { obligarCorreo = value; } }
        public bool ObligarTelefono { get { return obligarTelefono; } set { obligarTelefono = value; } }
        public string SmtpServidor { get { return smtpServidor; } set { smtpServidor = value; } }
        public int SmtpPuerto { get { return smtpPuerto; } set { smtpPuerto = value; } }
        public string SmtpUsuario { get { return smtpUsuario; } set { smtpUsuario = value; } }
        public bool SmtpSsl { get { return smtpSsl; } set { smtpSsl = value; } }
        public string Correo365AppId { get { return correo365AppId; } set { correo365AppId = value; } }
        public string Correo365Tenant { get { return correo365Tenant; } set { correo365Tenant = value; } }
    }
}
