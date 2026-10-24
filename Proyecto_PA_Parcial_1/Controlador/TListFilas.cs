using System;
using System.Collections.Generic;
using System.Linq;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Controlador
{
    public class TListFilas
    {
        public static List<Fila> Lista { get; } = new List<Fila>();

        public bool Agregar(Fila fila)
        {
            bool agregado = false;
            bool sucursalExiste = fila != null && TListSucursales.Lista.Any(item => string.Equals(item.Codigo, fila.CodigoSucursal, StringComparison.OrdinalIgnoreCase));
            if (EsValida(fila) && sucursalExiste && !Lista.Any(item => string.Equals(item.Codigo, fila.Codigo, StringComparison.OrdinalIgnoreCase)))
            {
                Lista.Add(fila);
                agregado = true;
            }
            return agregado;
        }

        public bool Modificar(Fila fila)
        {
            bool modificado = false;
            Fila existente = Buscar(fila == null ? string.Empty : fila.Codigo);
            bool sucursalExiste = fila != null && TListSucursales.Lista.Any(item => string.Equals(item.Codigo, fila.CodigoSucursal, StringComparison.OrdinalIgnoreCase));
            if (EsValida(fila) && sucursalExiste && existente != null)
            {
                existente.CodigoSucursal = fila.CodigoSucursal;
                existente.Descripcion = fila.Descripcion;
                existente.TiempoEstimadoMinutos = fila.TiempoEstimadoMinutos;
                existente.CostoEstimado = fila.CostoEstimado;
                existente.CantidadVentanillas = fila.CantidadVentanillas;
                modificado = true;
            }
            return modificado;
        }

        public bool Eliminar(string codigo)
        {
            bool eliminado = false;
            Fila fila = Buscar(codigo);
            bool tieneTickets = TListTickets.Lista.Any(item => string.Equals(item.CodigoFila, codigo, StringComparison.OrdinalIgnoreCase));
            bool tieneTotems = TListTotems.Lista.Any(item => item.CodigosFila != null && item.CodigosFila.Any(itemFila => string.Equals(itemFila, codigo, StringComparison.OrdinalIgnoreCase)));
            if (fila != null && !tieneTickets && !tieneTotems)
            {
                Lista.Remove(fila);
                eliminado = true;
            }
            return eliminado;
        }

        public Fila Buscar(string codigo)
        {
            return Lista.FirstOrDefault(item => string.Equals(item.Codigo, codigo, StringComparison.OrdinalIgnoreCase));
        }

        public Fila Get(int indice)
        {
            Fila resultado = null;
            if (indice >= 0 && indice < Lista.Count)
            {
                resultado = Lista[indice];
            }
            return resultado;
        }

        public List<Fila> Listar()
        {
            return Lista.ToList();
        }

        public List<Fila> ListarPorSucursal(string codigoSucursal)
        {
            return Lista.Where(item => string.Equals(item.CodigoSucursal, codigoSucursal, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private bool EsValida(Fila fila)
        {
            bool valida = fila != null;
            if (valida)
            {
                valida = !string.IsNullOrWhiteSpace(fila.Codigo) && !string.IsNullOrWhiteSpace(fila.Descripcion) && fila.TiempoEstimadoMinutos > 0 && fila.CostoEstimado >= 0 && fila.CantidadVentanillas > 0;
            }
            return valida;
        }
    }
}
