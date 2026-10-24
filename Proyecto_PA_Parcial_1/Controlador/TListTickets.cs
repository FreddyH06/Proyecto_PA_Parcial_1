using System;
using System.Collections.Generic;
using System.Linq;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Controlador
{
    public class TListTickets
    {
        public const string Pendiente = "PENDIENTE";
        public const string Llamado = "LLAMADO";
        public const string EnAtencion = "EN ATENCION";
        public const string Atendido = "ATENDIDO";
        public const string Omitido = "OMITIDO";
        public const string Anulado = "ANULADO";

        public static List<Ticket> Lista { get; } = new List<Ticket>();

        public bool Agregar(Ticket ticket)
        {
            bool agregado = false;
            if (PrepararTicket(ticket) && EsValido(ticket) && !ExisteDuplicado(ticket) && (!ticket.Programado || HayDisponibilidadCita(ticket.CodigoFila, ticket.FechaCita, 0)))
            {
                Lista.Add(ticket);
                agregado = true;
            }
            return agregado;
        }

        public bool Modificar(Ticket ticket)
        {
            bool modificado = false;
            Ticket existente = Buscar(ticket == null ? 0 : ticket.Id);
            if (EsValido(ticket) && existente != null && !ExisteDuplicado(ticket, ticket.Id) && (!ticket.Programado || HayDisponibilidadCita(ticket.CodigoFila, ticket.FechaCita, ticket.Id)))
            {
                existente.CodigoFila = ticket.CodigoFila;
                existente.Numero = ticket.Numero;
                existente.CodigoTicket = ticket.CodigoTicket;
                existente.Programado = ticket.Programado;
                existente.Cedula = ticket.Cedula;
                existente.Nombres = ticket.Nombres;
                existente.Email = ticket.Email;
                existente.Telefono = ticket.Telefono;
                existente.SolicitoRecordatorio = ticket.SolicitoRecordatorio;
                existente.SolicitoSms = ticket.SolicitoSms;
                existente.FechaEmision = ticket.FechaEmision;
                existente.FechaCita = ticket.FechaCita;
                existente.Estado = ticket.Estado;
                existente.UsuarioAtencion = ticket.UsuarioAtencion;
                existente.Ventanilla = ticket.Ventanilla;
                existente.FechaLlamado = ticket.FechaLlamado;
                existente.InicioAtencion = ticket.InicioAtencion;
                existente.FinAtencion = ticket.FinAtencion;
                modificado = true;
            }
            return modificado;
        }

        public bool Eliminar(int id)
        {
            bool eliminado = false;
            Ticket ticket = Buscar(id);
            if (ticket != null)
            {
                Lista.Remove(ticket);
                eliminado = true;
            }
            return eliminado;
        }

        public Ticket Buscar(int id)
        {
            return Lista.FirstOrDefault(item => item.Id == id);
        }

        public Ticket Buscar(string codigoTicket)
        {
            return Lista.FirstOrDefault(item => string.Equals(item.CodigoTicket, codigoTicket, StringComparison.OrdinalIgnoreCase));
        }

        public Ticket Get(int indice)
        {
            Ticket resultado = null;
            if (indice >= 0 && indice < Lista.Count)
            {
                resultado = Lista[indice];
            }
            return resultado;
        }

        public List<Ticket> Listar()
        {
            return Lista.ToList();
        }

        public List<Ticket> Listar(string codigoFila)
        {
            return Lista.Where(item => string.Equals(item.CodigoFila, codigoFila, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public bool AgregarNormal(Ticket ticket)
        {
            bool agregado = false;
            if (ticket != null)
            {
                ticket.Programado = false;
                agregado = Agregar(ticket);
            }
            return agregado;
        }

        public bool AgregarCita(Ticket ticket)
        {
            bool agregado = false;
            if (ticket != null)
            {
                ticket.Programado = true;
                agregado = Agregar(ticket);
            }
            return agregado;
        }

        public bool HayDisponibilidadCita(string codigoFila, DateTime fechaCita)
        {
            return HayDisponibilidadCita(codigoFila, fechaCita, 0);
        }

        public bool DisponibleCita(string codigoFila, DateTime fechaCita)
        {
            return HayDisponibilidadCita(codigoFila, fechaCita);
        }

        public Ticket LlamarSiguiente(string codigoFila, string usuarioAtencion, string ventanilla)
        {
            return LlamarSiguiente(codigoFila, usuarioAtencion, ventanilla, DateTime.Now);
        }

        public Ticket LlamarSiguiente(string codigoFila, string usuarioAtencion, string ventanilla, DateTime fechaHora)
        {
            Ticket siguiente = ObtenerSiguiente(codigoFila, fechaHora);
            if (siguiente != null)
            {
                siguiente.Estado = Llamado;
                siguiente.UsuarioAtencion = usuarioAtencion;
                siguiente.Ventanilla = ventanilla;
                siguiente.FechaLlamado = fechaHora;
            }
            return siguiente;
        }

        public bool IniciarAtencion(int id, string usuarioAtencion, string ventanilla)
        {
            return IniciarAtencion(id, usuarioAtencion, ventanilla, DateTime.Now);
        }

        public bool IniciarAtencion(int id, string usuarioAtencion, string ventanilla, DateTime fechaHora)
        {
            bool iniciado = false;
            Ticket ticket = Buscar(id);
            if (ticket != null && ticket.Estado == Llamado)
            {
                ticket.Estado = EnAtencion;
                ticket.UsuarioAtencion = usuarioAtencion;
                ticket.Ventanilla = ventanilla;
                ticket.InicioAtencion = fechaHora;
                iniciado = true;
            }
            return iniciado;
        }

        public bool Finalizar(int id)
        {
            return Finalizar(id, DateTime.Now);
        }

        public bool FinalizarAtencion(int id)
        {
            return Finalizar(id);
        }

        public bool Finalizar(int id, DateTime fechaHora)
        {
            bool finalizado = false;
            Ticket ticket = Buscar(id);
            if (ticket != null && ticket.Estado == EnAtencion && ticket.InicioAtencion != DateTime.MinValue)
            {
                ticket.Estado = Atendido;
                ticket.FinAtencion = fechaHora;
                finalizado = true;
            }
            return finalizado;
        }

        public bool Omitir(int id)
        {
            bool omitido = false;
            Ticket ticket = Buscar(id);
            if (ticket != null && (ticket.Estado == Llamado || ticket.Estado == EnAtencion))
            {
                ticket.Estado = Omitido;
                ticket.FinAtencion = DateTime.Now;
                omitido = true;
            }
            return omitido;
        }

        public bool Reabrir(int id)
        {
            bool reabierto = false;
            Ticket ticket = Buscar(id);
            if (ticket != null && (ticket.Estado == Omitido || ticket.Estado == Atendido))
            {
                ticket.Estado = Pendiente;
                ticket.FechaLlamado = DateTime.MinValue;
                ticket.InicioAtencion = DateTime.MinValue;
                ticket.FinAtencion = DateTime.MinValue;
                reabierto = true;
            }
            return reabierto;
        }

        public bool AnularCita(int id)
        {
            bool anulada = false;
            Ticket ticket = Buscar(id);
            if (ticket != null && ticket.Programado && ticket.Estado == Pendiente)
            {
                ticket.Estado = Anulado;
                anulada = true;
            }
            return anulada;
        }

        private bool PrepararTicket(Ticket ticket)
        {
            bool preparado = ticket != null;
            Fila fila = null;
            if (preparado)
            {
                fila = TListFilas.Lista.FirstOrDefault(item => string.Equals(item.Codigo, ticket.CodigoFila, StringComparison.OrdinalIgnoreCase));
                preparado = fila != null;
            }
            if (preparado)
            {
                if (ticket.Id <= 0)
                {
                    ticket.Id = Lista.Count == 0 ? 1 : Lista.Max(item => item.Id) + 1;
                }
                if (ticket.FechaEmision == DateTime.MinValue)
                {
                    ticket.FechaEmision = DateTime.Now;
                }
                if (ticket.FechaCita == DateTime.MinValue)
                {
                    ticket.FechaCita = ticket.FechaEmision;
                }
                DateTime fechaNumeracion = ticket.Programado ? ticket.FechaCita.Date : ticket.FechaEmision.Date;
                ticket.Numero = ObtenerNumero(fila.Codigo, fechaNumeracion, ticket.Programado);
                ticket.CodigoTicket = (ticket.Programado ? "R-" : string.Empty) + fila.Codigo + "-" + fechaNumeracion.ToString("yyyyMMdd") + "-" + ticket.Numero;
                ticket.Estado = string.IsNullOrWhiteSpace(ticket.Estado) ? Pendiente : ticket.Estado;
            }
            return preparado;
        }

        private bool EsValido(Ticket ticket)
        {
            bool valido = ticket != null;
            if (valido)
            {
                valido = ticket.Id > 0
                    && !string.IsNullOrWhiteSpace(ticket.CodigoFila)
                    && ticket.Numero > 0
                    && !string.IsNullOrWhiteSpace(ticket.CodigoTicket)
                    && !string.IsNullOrWhiteSpace(ticket.Estado)
                    && EnumeraEstadoValido(ticket.Estado)
                    && ticket.FechaEmision != DateTime.MinValue;
            }
            if (valido && ticket.Programado)
            {
                valido = ticket.FechaCita != DateTime.MinValue && ticket.FechaCita > DateTime.Now;
            }
            return valido;
        }

        private bool ExisteDuplicado(Ticket ticket)
        {
            return ExisteDuplicado(ticket, 0);
        }

        private bool ExisteDuplicado(Ticket ticket, int idExcluido)
        {
            return Lista.Any(item => item.Id != idExcluido && (item.Id == ticket.Id || string.Equals(item.CodigoTicket, ticket.CodigoTicket, StringComparison.OrdinalIgnoreCase)));
        }

        private int ObtenerNumero(string codigoFila, DateTime fecha, bool programado)
        {
            int numero = Lista.Where(item => string.Equals(item.CodigoFila, codigoFila, StringComparison.OrdinalIgnoreCase)
                && item.Programado == programado
                && (item.Programado ? item.FechaCita.Date : item.FechaEmision.Date) == fecha.Date)
                .Select(item => item.Numero)
                .DefaultIfEmpty(0)
                .Max() + 1;
            return numero;
        }

        private bool HayDisponibilidadCita(string codigoFila, DateTime fechaCita, int idExcluido)
        {
            Fila fila = TListFilas.Lista.FirstOrDefault(item => string.Equals(item.Codigo, codigoFila, StringComparison.OrdinalIgnoreCase));
            Sucursal sucursal = null;
            bool disponible = fila != null;
            if (disponible)
            {
                sucursal = TListSucursales.Lista.FirstOrDefault(item => string.Equals(item.Codigo, fila.CodigoSucursal, StringComparison.OrdinalIgnoreCase));
                disponible = sucursal != null && fila.TiempoEstimadoMinutos > 0 && fila.CantidadVentanillas > 0;
            }
            if (disponible)
            {
                TimeSpan inicioAtencion = TimeSpan.Zero;
                TimeSpan finAtencion = TimeSpan.Zero;
                disponible = TimeSpan.TryParse(sucursal.InicioAtencion, out inicioAtencion) && TimeSpan.TryParse(sucursal.FinAtencion, out finAtencion);
                DateTime inicio = fechaCita;
                DateTime fin = fechaCita.AddMinutes(fila.TiempoEstimadoMinutos);
                disponible = disponible && fechaCita.Date == fin.Date && fechaCita.TimeOfDay >= inicioAtencion && fin.TimeOfDay <= finAtencion;
                if (disponible)
                {
                    int reservas = Lista.Count(item => item.Id != idExcluido
                        && item.Programado
                        && item.Estado != Anulado
                        && string.Equals(item.CodigoFila, codigoFila, StringComparison.OrdinalIgnoreCase)
                        && item.FechaCita < fin
                        && item.FechaCita.AddMinutes(fila.TiempoEstimadoMinutos) > inicio);
                    disponible = reservas < fila.CantidadVentanillas;
                }
            }
            return disponible;
        }

        private Ticket ObtenerSiguiente(string codigoFila, DateTime fechaHora)
        {
            DateTime limiteCita = fechaHora.AddMinutes(15);
            Ticket siguiente = Lista.Where(item => string.Equals(item.CodigoFila, codigoFila, StringComparison.OrdinalIgnoreCase)
                && item.Estado == Pendiente
                && ((!item.Programado) || (item.FechaCita <= limiteCita && item.FechaCita.Date == fechaHora.Date)))
                .OrderByDescending(item => item.Programado && item.FechaCita <= limiteCita)
                .ThenBy(item => item.Programado ? item.FechaCita : item.FechaEmision)
                .ThenBy(item => item.Numero)
                .FirstOrDefault();
            return siguiente;
        }

        private bool EnumeraEstadoValido(string estado)
        {
            return string.Equals(estado, Pendiente, StringComparison.OrdinalIgnoreCase)
                || string.Equals(estado, Llamado, StringComparison.OrdinalIgnoreCase)
                || string.Equals(estado, EnAtencion, StringComparison.OrdinalIgnoreCase)
                || string.Equals(estado, Atendido, StringComparison.OrdinalIgnoreCase)
                || string.Equals(estado, Omitido, StringComparison.OrdinalIgnoreCase)
                || string.Equals(estado, Anulado, StringComparison.OrdinalIgnoreCase);
        }
    }
}
