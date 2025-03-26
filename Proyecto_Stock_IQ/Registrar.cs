using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Stock_IQ
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void gtxt_Documento_Enter(object sender, EventArgs e)
        {
            if (gtxt_Documento.Text == "Documento de Identidad" || gtxt_Documento.Text == "")
            {
                gtxt_Documento.Text = ""; // Borra el texto solo si está vacío o si es el placeholder
                gtxt_Documento.ForeColor = Color.Black; // Cambia el color del texto a negro 
            }
        }

        private void gtxt_Password_Enter(object sender, EventArgs e)
        {
            if (gtxt_Password.Text == "Contraseña" || gtxt_Password.Text == "")
            {
                gtxt_Password.Text = ""; // Borra el texto solo si está vacío o si es el placeholder
                gtxt_Password.ForeColor = Color.Black; // Cambia el color del texto a negro 
            }
        }
    }
}
