namespace Proyecto_PA_Parcial_1.Entidades
{
    public class Fila
    {
        private string codigo;
        private string codigoSucursal;
        private string descripcion;
        private int tiempoEstimadoMinutos;
        private decimal costoEstimado;
        private int cantidadVentanillas;

        public Fila() { }

        public Fila(string codigo, string codigoSucursal, string descripcion, int tiempoEstimadoMinutos, decimal costoEstimado, int cantidadVentanillas)
        {
            this.codigo = codigo;
            this.codigoSucursal = codigoSucursal;
            this.descripcion = descripcion;
            this.tiempoEstimadoMinutos = tiempoEstimadoMinutos;
            this.costoEstimado = costoEstimado;
            this.cantidadVentanillas = cantidadVentanillas;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string CodigoSucursal { get => codigoSucursal; set => codigoSucursal = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int TiempoEstimadoMinutos { get => tiempoEstimadoMinutos; set => tiempoEstimadoMinutos = value; }
        public decimal CostoEstimado { get => costoEstimado; set => costoEstimado = value; }
        public int CantidadVentanillas { get => cantidadVentanillas; set => cantidadVentanillas = value; }
    }
}
