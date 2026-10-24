using System.Collections.Generic;

namespace Proyecto_PA_Parcial_1.Entidades
{
    public class Totem
    {
        private string codigo;
        private string codigoSucursal;
        private string ubicacion;
        private List<string> codigosFila;

        public Totem() { }

        public Totem(string codigo, string codigoSucursal, string ubicacion, List<string> codigosFila)
        {
            this.codigo = codigo;
            this.codigoSucursal = codigoSucursal;
            this.ubicacion = ubicacion;
            this.codigosFila = codigosFila;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string CodigoSucursal { get => codigoSucursal; set => codigoSucursal = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public List<string> CodigosFila { get => codigosFila; set => codigosFila = value; }
    }
}
