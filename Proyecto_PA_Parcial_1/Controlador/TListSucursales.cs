using System;
using System.Collections.Generic;
using System.Linq;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Controlador
{
    public class TListSucursales
    {
        public static List<Sucursal> Lista { get; } = new List<Sucursal>();

        public bool Agregar(Sucursal sucursal)
        {
            bool agregado = false;
            if (EsValida(sucursal) && !Lista.Any(item => string.Equals(item.Codigo, sucursal.Codigo, StringComparison.OrdinalIgnoreCase)))
            {
                Lista.Add(sucursal);
                agregado = true;
            }
            return agregado;
        }

        public bool Modificar(Sucursal sucursal)
        {
            bool modificado = false;
            Sucursal existente = Buscar(sucursal == null ? string.Empty : sucursal.Codigo);
            if (EsValida(sucursal) && existente != null)
            {
                existente.Direccion = sucursal.Direccion;
                existente.Telefono = sucursal.Telefono;
                existente.InicioAtencion = sucursal.InicioAtencion;
                existente.FinAtencion = sucursal.FinAtencion;
                modificado = true;
            }
            return modificado;
        }

        public bool Eliminar(string codigo)
        {
            bool eliminado = false;
            Sucursal sucursal = Buscar(codigo);
            bool tieneFilas = TListFilas.Lista.Any(item => string.Equals(item.CodigoSucursal, codigo, StringComparison.OrdinalIgnoreCase));
            bool tieneUsuarios = TListUsuarios.Lista.Any(item => string.Equals(item.CodigoSucursal, codigo, StringComparison.OrdinalIgnoreCase));
            bool tieneTotems = TListTotems.Lista.Any(item => string.Equals(item.CodigoSucursal, codigo, StringComparison.OrdinalIgnoreCase));
            if (sucursal != null && !tieneFilas && !tieneUsuarios && !tieneTotems)
            {
                Lista.Remove(sucursal);
                eliminado = true;
            }
            return eliminado;
        }

        public Sucursal Buscar(string codigo)
        {
            return Lista.FirstOrDefault(item => string.Equals(item.Codigo, codigo, StringComparison.OrdinalIgnoreCase));
        }

        public Sucursal Get(int indice)
        {
            Sucursal resultado = null;
            if (indice >= 0 && indice < Lista.Count)
            {
                resultado = Lista[indice];
            }
            return resultado;
        }

        public List<Sucursal> Listar()
        {
            return Lista.ToList();
        }

        private bool EsValida(Sucursal sucursal)
        {
            bool valida = sucursal != null;
            TimeSpan inicio;
            TimeSpan fin;
            if (valida)
            {
                valida = !string.IsNullOrWhiteSpace(sucursal.Codigo) && !string.IsNullOrWhiteSpace(sucursal.Direccion);
            }
            if (valida)
            {
                valida = TimeSpan.TryParse(sucursal.InicioAtencion, out inicio) && TimeSpan.TryParse(sucursal.FinAtencion, out fin) && inicio < fin;
            }
            return valida;
        }
    }
}
