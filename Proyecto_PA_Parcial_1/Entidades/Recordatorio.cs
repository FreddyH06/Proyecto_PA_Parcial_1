using System;

namespace Proyecto_PA_Parcial_1.Entidades
{
    public class Recordatorio
    {
        private int id;
        private int ticketId;
        private string tipoEnvio;
        private string direccionEnvio;
        private string contenido;
        private DateTime fechaHoraEnvio;
        private bool enviado;
        private string resultado;

        public Recordatorio() { }

        public Recordatorio(int id, int ticketId, string tipoEnvio, string direccionEnvio, string contenido, DateTime fechaHoraEnvio, bool enviado, string resultado)
        {
            this.id = id;
            this.ticketId = ticketId;
            this.tipoEnvio = tipoEnvio;
            this.direccionEnvio = direccionEnvio;
            this.contenido = contenido;
            this.fechaHoraEnvio = fechaHoraEnvio;
            this.enviado = enviado;
            this.resultado = resultado;
        }

        public int Id { get => id; set => id = value; }
        public int TicketId { get => ticketId; set => ticketId = value; }
        public string TipoEnvio { get => tipoEnvio; set => tipoEnvio = value; }
        public string DireccionEnvio { get => direccionEnvio; set => direccionEnvio = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public DateTime FechaHoraEnvio { get => fechaHoraEnvio; set => fechaHoraEnvio = value; }
        public bool Enviado { get => enviado; set => enviado = value; }
        public string Resultado { get => resultado; set => resultado = value; }
    }
}
