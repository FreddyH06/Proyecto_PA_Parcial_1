using System;
using System.Net.Mail;

namespace Proyecto_PA_Parcial_1.Controlador
{
    public static class CorreoInstitucional
    {
        private const string Remitente = "fherrera3@utmachala.edu.ec";

        public static void Enviar(string destinatario, string asunto, string contenido)
        {
            if (string.IsNullOrWhiteSpace(destinatario))
            {
                throw new InvalidOperationException("Ingrese el correo del cliente.");
            }

            MailAddress direccion = new MailAddress(destinatario.Trim());

            if (!string.Equals(direccion.Address, destinatario.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException("El correo del cliente no es válido.");
            }

            Type tipo = Type.GetTypeFromProgID("Outlook.Application");

            if (tipo == null)
            {
                throw new InvalidOperationException("Abra Outlook clásico en Windows. La versión nueva no permite este tipo de envío.");
            }

            dynamic outlook = Activator.CreateInstance(tipo);
            dynamic cuentas = outlook.Session.Accounts;
            dynamic cuentaRemitente = null;

            for (int i = 1; i <= (int)cuentas.Count; i++)
            {
                dynamic cuenta = cuentas.Item(i);
                string correoCuenta = Convert.ToString(cuenta.SmtpAddress);

                if (string.Equals(correoCuenta, Remitente, StringComparison.OrdinalIgnoreCase))
                {
                    cuentaRemitente = cuenta;
                }
            }

            if (cuentaRemitente == null)
            {
                throw new InvalidOperationException("Configure la cuenta " + Remitente + " en Outlook clásico antes de enviar correos.");
            }

            dynamic mensaje = outlook.CreateItem(0);
            mensaje.SendUsingAccount = cuentaRemitente;
            mensaje.To = direccion.Address;
            mensaje.Subject = asunto;
            mensaje.Body = contenido;
            mensaje.Send();
        }
    }
}
