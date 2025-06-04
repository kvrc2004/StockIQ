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
        public static string TemaActual = "Oscuro"; // modo oscuro como predeterminado

        public static void AplicarTema(Form form)
        {
            Color fondo, texto, boton;

            if (TemaActual == "Oscuro")
            {
                fondo = Color.FromArgb(26, 16, 26);      //(fondo actual)
                texto = Color.FromArgb(234, 229, 223);   // Letras claras
                boton = Color.FromArgb(255, 140, 0);     // Naranja intenso
            }
            else // Claro
            {
                fondo = Color.FromArgb(204, 169, 221);      // Morado clarito
                texto = Color.FromArgb(30, 30, 30);         // Letras oscuras
                boton = Color.FromArgb(240, 160, 40);       // Naranja suave
            }

            // Aplicar fondo general
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
