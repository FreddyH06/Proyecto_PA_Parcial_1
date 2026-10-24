using System;
using System.Collections.Generic;
using System.Linq;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Controlador
{
    public class TListTotems
    {
        public static List<Totem> Lista { get; } = new List<Totem>();

        public bool Agregar(Totem totem)
        {
            bool agregado = false;
            if (EsValido(totem) && !Lista.Any(item => string.Equals(item.Codigo, totem.Codigo, StringComparison.OrdinalIgnoreCase)))
            {
                Lista.Add(totem);
                agregado = true;
            }
            return agregado;
        }

        public bool Modificar(Totem totem)
        {
            bool modificado = false;
            Totem existente = Buscar(totem == null ? string.Empty : totem.Codigo);
            if (EsValido(totem) && existente != null)
            {
                existente.CodigoSucursal = totem.CodigoSucursal;
                existente.Ubicacion = totem.Ubicacion;
                existente.CodigosFila = totem.CodigosFila;
                modificado = true;
            }
            return modificado;
        }

        public bool Eliminar(string codigo)
        {
            bool eliminado = false;
            Totem totem = Buscar(codigo);
            if (totem != null)
            {
                Lista.Remove(totem);
                eliminado = true;
            }
            return eliminado;
        }

        public Totem Buscar(string codigo)
        {
            return Lista.FirstOrDefault(item => string.Equals(item.Codigo, codigo, StringComparison.OrdinalIgnoreCase));
        }

        public Totem Get(int indice)
        {
            Totem resultado = null;
            if (indice >= 0 && indice < Lista.Count)
            {
                resultado = Lista[indice];
            }
            return resultado;
        }

        public List<Totem> Listar()
        {
            return Lista.ToList();
        }

        public List<Totem> ListarPorSucursal(string codigoSucursal)
        {
            return Lista.Where(item => string.Equals(item.CodigoSucursal, codigoSucursal, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private bool EsValido(Totem totem)
        {
            bool valido = totem != null;
            bool sucursalExiste = false;
            if (valido)
            {
                sucursalExiste = TListSucursales.Lista.Any(item => string.Equals(item.Codigo, totem.CodigoSucursal, StringComparison.OrdinalIgnoreCase));
                valido = !string.IsNullOrWhiteSpace(totem.Codigo) && !string.IsNullOrWhiteSpace(totem.Ubicacion) && sucursalExiste;
            }
            if (valido)
            {
                valido = totem.CodigosFila != null && totem.CodigosFila.Distinct(StringComparer.OrdinalIgnoreCase).Count() == totem.CodigosFila.Count;
            }
            if (valido)
            {
                valido = totem.CodigosFila.All(codigoFila => TListFilas.Lista.Any(fila => string.Equals(fila.Codigo, codigoFila, StringComparison.OrdinalIgnoreCase) && string.Equals(fila.CodigoSucursal, totem.CodigoSucursal, StringComparison.OrdinalIgnoreCase)));
            }
            return valido;
        }
    }
}
