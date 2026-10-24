using System;
using System.Collections.Generic;
using System.Linq;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Controlador
{
    public class TListUsuarios
    {
        public static List<Usuario> Lista { get; } = new List<Usuario>();

        public bool Agregar(Usuario usuario)
        {
            bool agregado = false;
            if (EsValido(usuario) && !Lista.Any(item => string.Equals(item.Username, usuario.Username, StringComparison.OrdinalIgnoreCase)))
            {
                Lista.Add(usuario);
                agregado = true;
            }
            return agregado;
        }

        public bool Modificar(Usuario usuario)
        {
            bool modificado = false;
            Usuario existente = Buscar(usuario == null ? string.Empty : usuario.Username);
            if (EsValido(usuario) && existente != null)
            {
                existente.Nombre = usuario.Nombre;
                existente.Apellidos = usuario.Apellidos;
                existente.Telefono = usuario.Telefono;
                existente.ClaveHash = usuario.ClaveHash;
                existente.TipoUsuario = usuario.TipoUsuario;
                existente.CodigoSucursal = usuario.CodigoSucursal;
                existente.Ventanilla = usuario.Ventanilla;
                existente.Activo = usuario.Activo;
                modificado = true;
            }
            return modificado;
        }

        public bool Eliminar(string username)
        {
            bool eliminado = false;
            Usuario usuario = Buscar(username);
            if (usuario != null)
            {
                Lista.Remove(usuario);
                eliminado = true;
            }
            return eliminado;
        }

        public Usuario Buscar(string username)
        {
            return Lista.FirstOrDefault(item => string.Equals(item.Username, username, StringComparison.OrdinalIgnoreCase));
        }

        public Usuario Get(int indice)
        {
            Usuario resultado = null;
            if (indice >= 0 && indice < Lista.Count)
            {
                resultado = Lista[indice];
            }
            return resultado;
        }

        public List<Usuario> Listar()
        {
            return Lista.ToList();
        }

        public List<Usuario> ListarActivos()
        {
            return Lista.Where(item => item.Activo).ToList();
        }

        private bool EsValido(Usuario usuario)
        {
            bool valido = usuario != null;
            bool sucursalExiste = true;
            bool esTrabajador = false;
            if (valido)
            {
                valido = !string.IsNullOrWhiteSpace(usuario.Username) && !string.IsNullOrWhiteSpace(usuario.Nombre) && !string.IsNullOrWhiteSpace(usuario.ClaveHash);
                esTrabajador = string.Equals(usuario.TipoUsuario, "TRABAJADOR", StringComparison.OrdinalIgnoreCase);
                sucursalExiste = string.IsNullOrWhiteSpace(usuario.CodigoSucursal) || TListSucursales.Lista.Any(item => string.Equals(item.Codigo, usuario.CodigoSucursal, StringComparison.OrdinalIgnoreCase));
            }
            if (valido)
            {
                valido = (string.Equals(usuario.TipoUsuario, "ADMINISTRADOR", StringComparison.OrdinalIgnoreCase) || esTrabajador) && sucursalExiste;
            }
            if (valido && esTrabajador)
            {
                valido = !string.IsNullOrWhiteSpace(usuario.CodigoSucursal) && !string.IsNullOrWhiteSpace(usuario.Ventanilla);
            }
            return valido;
        }
    }
}
