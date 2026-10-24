using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Controlador
{
    public static class TListDatosIniciales
    {
        public static void CargarDatos()
        {
#if DEBUG
            CargarSucursales();
            CargarFilas();
            CargarUsuarios();
            CargarTotems();
            CargarTickets();
#endif
        }

        private static void CargarSucursales()
        {
            if (!TListSucursales.Lista.Any(x => x.Codigo == "SUC001"))
            {
                TListSucursales.Lista.Add(new Sucursal("SUC001", "Centro - Santa Rosa", "072900001", "08:00", "17:00"));
            }

            if (!TListSucursales.Lista.Any(x => x.Codigo == "SUC002"))
            {
                TListSucursales.Lista.Add(new Sucursal("SUC002", "Sucursal Norte", "072900002", "08:00", "17:00"));
            }
        }

        private static void CargarFilas()
        {
            if (!TListFilas.Lista.Any(x => x.Codigo == "FIL001"))
            {
                TListFilas.Lista.Add(new Fila("FIL001", "SUC001", "Información general", 15, 0m, 2));
            }

            if (!TListFilas.Lista.Any(x => x.Codigo == "FIL002"))
            {
                TListFilas.Lista.Add(new Fila("FIL002", "SUC001", "Trámites y solicitudes", 20, 0m, 2));
            }

            if (!TListFilas.Lista.Any(x => x.Codigo == "FIL003"))
            {
                TListFilas.Lista.Add(new Fila("FIL003", "SUC002", "Atención al cliente", 15, 0m, 2));
            }
        }

        private static void CargarUsuarios()
        {
            if (!TListUsuarios.Lista.Any(x => x.Username.Equals("admin", StringComparison.OrdinalIgnoreCase)))
            {
                TListUsuarios.Lista.Add(new Usuario("admin", "Administrador", "Sistema", "0999999999",
                    HashClave("admin"), "ADMINISTRADOR", "SUC001", "1", true));
            }

            if (!TListUsuarios.Lista.Any(x => x.Username.Equals("empleado1", StringComparison.OrdinalIgnoreCase)))
            {
                TListUsuarios.Lista.Add(new Usuario("empleado1", "María", "López", "0999999998",
                    HashClave("empleado1"), "TRABAJADOR", "SUC001", "1", true));
            }

            if (!TListUsuarios.Lista.Any(x => x.Username.Equals("empleado2", StringComparison.OrdinalIgnoreCase)))
            {
                TListUsuarios.Lista.Add(new Usuario("empleado2", "Carlos", "Vera", "0999999997",
                    HashClave("empleado2"), "TRABAJADOR", "SUC002", "1", true));
            }
        }

        private static void CargarTotems()
        {
            if (!TListTotems.Lista.Any(x => x.Codigo == "TOT001"))
            {
                TListTotems.Lista.Add(new Totem("TOT001", "SUC001", "Entrada principal",
                    new List<string> { "FIL001", "FIL002" }));
            }
        }

        private static void CargarTickets()
        {
            // Solo crea los tickets de demostración cuando todavía no existe ninguno.
            if (TListTickets.Lista.Count == 0 && TListFilas.Lista.Any(x => x.Codigo == "FIL001"))
            {
                TListTickets controlador = new TListTickets();

                for (int i = 1; i <= 5; i++)
                {
                    Ticket ticket = NuevoTicket("FIL001", "DEMO-A-" + i, "Cliente atendido " + i);
                    bool agregado = controlador.AgregarNormal(ticket);
                    if (agregado)
                    {
                        Ticket llamado = controlador.LlamarSiguiente("FIL001", "empleado1", "1");
                        if (llamado != null)
                        {
                            bool iniciado = controlador.IniciarAtencion(llamado.Id, "empleado1", "1");
                            if (iniciado)
                            {
                                controlador.FinalizarAtencion(llamado.Id);
                            }
                        }
                    }
                }

                for (int i = 1; i <= 2; i++)
                {
                    Ticket ticket = NuevoTicket("FIL001", "DEMO-O-" + i, "Cliente omitido " + i);
                    bool agregado = controlador.AgregarNormal(ticket);
                    if (agregado)
                    {
                        Ticket llamado = controlador.LlamarSiguiente("FIL001", "empleado1", "1");
                        if (llamado != null)
                        {
                            controlador.Omitir(llamado.Id);
                        }
                    }
                }

                Ticket turnoLlamado = NuevoTicket("FIL001", "DEMO-L-1", "Cliente llamado");
                if (controlador.AgregarNormal(turnoLlamado))
                {
                    controlador.LlamarSiguiente("FIL001", "empleado1", "1");
                }

                Ticket turnoEnAtencion = NuevoTicket("FIL003", "DEMO-E-1", "Cliente en atención");
                if (controlador.AgregarNormal(turnoEnAtencion))
                {
                    Ticket llamado = controlador.LlamarSiguiente("FIL003", "empleado2", "1");
                    if (llamado != null)
                    {
                        controlador.IniciarAtencion(llamado.Id, "empleado2", "1");
                    }
                }

                controlador.AgregarNormal(NuevoTicket("FIL001", "DEMO-P-1", "Cliente pendiente 1"));
                controlador.AgregarNormal(NuevoTicket("FIL001", "DEMO-P-2", "Cliente pendiente 2"));
                controlador.AgregarNormal(NuevoTicket("FIL002", "DEMO-P-3", "Cliente pendiente 3"));
                controlador.AgregarNormal(NuevoTicket("FIL003", "DEMO-P-4", "Cliente pendiente 4"));

                Ticket cita1 = NuevoTicket("FIL002", "DEMO-C-1", "Cliente con cita 1");
                cita1.FechaCita = DateTime.Today.AddDays(1).AddHours(10);
                controlador.AgregarCita(cita1);

                Ticket cita2 = NuevoTicket("FIL003", "DEMO-C-2", "Cliente con cita 2");
                cita2.FechaCita = DateTime.Today.AddDays(1).AddHours(11);
                controlador.AgregarCita(cita2);
            }
        }

        private static Ticket NuevoTicket(string codigoFila, string cedula, string nombres)
        {
            Ticket ticket = new Ticket();
            ticket.CodigoFila = codigoFila;
            ticket.Cedula = cedula;
            ticket.Nombres = nombres;
            ticket.Email = string.Empty;
            ticket.Telefono = string.Empty;
            ticket.SolicitoRecordatorio = false;
            ticket.SolicitoSms = false;
            ticket.FechaEmision = DateTime.Now;
            ticket.Estado = TListTickets.Pendiente;
            return ticket;
        }

        private static string HashClave(string clave)
        {
            string resultado = string.Empty;
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(clave);
                byte[] hash = sha.ComputeHash(bytes);
                resultado = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
            return resultado;
        }
    }
}
