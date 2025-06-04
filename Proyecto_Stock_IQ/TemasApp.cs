using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Stock_IQ
{
    public static class TemasApp
    {
            public static string TemaActual = "Claro";

            public static void AplicarTema(Form form)
            {
                Color fondo, texto, boton;

                if (TemaActual == "Oscuro")
                {
                    fondo = Color.FromArgb(30, 30, 30);
                    texto = Color.White;
                    boton = Color.FromArgb(255, 140, 0);
                }
                else // Claro
                {
                    fondo = Color.FromArgb(240, 235, 225);
                    texto = Color.Black;
                    boton = Color.FromArgb(240, 160, 40);
                }

                // Aplicar colores genéricos
                form.BackColor = fondo;

                foreach (Control control in form.Controls)
                {
                    if (control is Label || control is CheckBox || control is ComboBox || control is TextBox)
                        control.ForeColor = texto;

                    if (control is Button)
                    {
                        control.BackColor = boton;
                        control.ForeColor = texto;
                    }
                }
            }
    }
}
