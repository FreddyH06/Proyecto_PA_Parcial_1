using System;

namespace Proyecto_PA_Parcial_1.Entidades
{
    public class Ticket
    {
        private int id;
        private string codigoFila;
        private int numero;
        private string codigoTicket;
        private bool programado;
        private string cedula;
        private string nombres;
        private string email;
        private string telefono;
        private bool solicitoRecordatorio;
        private bool solicitoSms;
        private DateTime fechaEmision;
        private DateTime fechaCita;
        private string estado;
        private string usuarioAtencion;
        private string ventanilla;
        private DateTime fechaLlamado;
        private DateTime inicioAtencion;
        private DateTime finAtencion;

        public Ticket() { }

        public Ticket(int id, string codigoFila, int numero, string codigoTicket, bool programado, string cedula, string nombres, string email, string telefono, bool solicitoRecordatorio, bool solicitoSms, DateTime fechaEmision, DateTime fechaCita, string estado, string usuarioAtencion, string ventanilla, DateTime fechaLlamado, DateTime inicioAtencion, DateTime finAtencion)
        {
            this.id = id;
            this.codigoFila = codigoFila;
            this.numero = numero;
            this.codigoTicket = codigoTicket;
            this.programado = programado;
            this.cedula = cedula;
            this.nombres = nombres;
            this.email = email;
            this.telefono = telefono;
            this.solicitoRecordatorio = solicitoRecordatorio;
            this.solicitoSms = solicitoSms;
            this.fechaEmision = fechaEmision;
            this.fechaCita = fechaCita;
            this.estado = estado;
            this.usuarioAtencion = usuarioAtencion;
            this.ventanilla = ventanilla;
            this.fechaLlamado = fechaLlamado;
            this.inicioAtencion = inicioAtencion;
            this.finAtencion = finAtencion;
        }

        public int Id { get => id; set => id = value; }
        public string CodigoFila { get => codigoFila; set => codigoFila = value; }
        public int Numero { get => numero; set => numero = value; }
        public string CodigoTicket { get => codigoTicket; set => codigoTicket = value; }
        public bool Programado { get => programado; set => programado = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public bool SolicitoRecordatorio { get => solicitoRecordatorio; set => solicitoRecordatorio = value; }
        public bool SolicitoSms { get => solicitoSms; set => solicitoSms = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public string Estado { get => estado; set => estado = value; }
        public string UsuarioAtencion { get => usuarioAtencion; set => usuarioAtencion = value; }
        public string Ventanilla { get => ventanilla; set => ventanilla = value; }
        public DateTime FechaLlamado { get => fechaLlamado; set => fechaLlamado = value; }
        public DateTime InicioAtencion { get => inicioAtencion; set => inicioAtencion = value; }
        public DateTime FinAtencion { get => finAtencion; set => finAtencion = value; }
    }
}
