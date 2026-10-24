namespace Proyecto_PA_Parcial_1.Entidades
{
    public class Sucursal
    {
        private string codigo;
        private string direccion;
        private string telefono;
        private string inicioAtencion;
        private string finAtencion;

        public Sucursal() { }

        public Sucursal(string codigo, string direccion, string telefono, string inicioAtencion, string finAtencion)
        {
            this.codigo = codigo;
            this.direccion = direccion;
            this.telefono = telefono;
            this.inicioAtencion = inicioAtencion;
            this.finAtencion = finAtencion;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string InicioAtencion { get => inicioAtencion; set => inicioAtencion = value; }
        public string FinAtencion { get => finAtencion; set => finAtencion = value; }
    }
}
