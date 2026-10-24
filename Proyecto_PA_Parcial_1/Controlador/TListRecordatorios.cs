using System;
using System.Collections.Generic;
using System.Linq;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Controlador
{
    public class TListRecordatorios
    {
        public static List<Recordatorio> Lista { get; } = new List<Recordatorio>();

        public bool Agregar(Recordatorio recordatorio)
        {
            bool agregado = false;
            if (EsValido(recordatorio) && !Lista.Any(item => item.Id == recordatorio.Id))
            {
                Lista.Add(recordatorio);
                agregado = true;
            }
            return agregado;
        }

        public bool Modificar(Recordatorio recordatorio)
        {
            bool modificado = false;
            Recordatorio existente = Buscar(recordatorio == null ? 0 : recordatorio.Id);
            if (EsValido(recordatorio) && existente != null)
            {
                existente.TicketId = recordatorio.TicketId;
                existente.TipoEnvio = recordatorio.TipoEnvio;
                existente.DireccionEnvio = recordatorio.DireccionEnvio;
                existente.Contenido = recordatorio.Contenido;
                existente.FechaHoraEnvio = recordatorio.FechaHoraEnvio;
                existente.Enviado = recordatorio.Enviado;
                existente.Resultado = recordatorio.Resultado;
                modificado = true;
            }
            return modificado;
        }

        public bool Eliminar(int id)
        {
            bool eliminado = false;
            Recordatorio recordatorio = Buscar(id);
            if (recordatorio != null)
            {
                Lista.Remove(recordatorio);
                eliminado = true;
            }
            return eliminado;
        }

        public Recordatorio Buscar(int id)
        {
            return Lista.FirstOrDefault(item => item.Id == id);
        }

        public Recordatorio Get(int indice)
        {
            Recordatorio resultado = null;
            if (indice >= 0 && indice < Lista.Count)
            {
                resultado = Lista[indice];
            }
            return resultado;
        }

        public List<Recordatorio> Listar()
        {
            return Lista.ToList();
        }

        private bool EsValido(Recordatorio recordatorio)
        {
            bool valido = recordatorio != null;
            if (valido)
            {
                valido = recordatorio.Id > 0
                    && recordatorio.TicketId > 0
                    && !string.IsNullOrWhiteSpace(recordatorio.TipoEnvio)
                    && !string.IsNullOrWhiteSpace(recordatorio.DireccionEnvio)
                    && !string.IsNullOrWhiteSpace(recordatorio.Contenido)
                    && recordatorio.FechaHoraEnvio != DateTime.MinValue;
            }
            return valido;
        }
    }
}
