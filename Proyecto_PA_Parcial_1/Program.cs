using Proyecto_PA_Parcial_1.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;

namespace Proyecto_PA_Parcial_1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TListDatosIniciales.CargarDatos();
            Application.Run(new Frm_Login());
        }
    }
}
