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
    public partial class CrearFactura : Form
    {
        private void CierreVentana(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0); //Cierra toda la ventana
        }
        public CrearFactura()
        {
            InitializeComponent();
        }
    }
}
