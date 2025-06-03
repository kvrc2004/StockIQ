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
    public partial class HacerPedido : Form
    {
        public HacerPedido()
        {
            InitializeComponent();
        }

		private void guna2HtmlLabel7_Click(object sender, EventArgs e)
		{

		}

		private void btn_guardarCantidad_Click(object sender, EventArgs e)
		{
			ListViewItem lista = new ListViewItem(cmb_cantidad.Text);
			lista.SubItems.Add(cmb_proveedor.Text);
			lista.SubItems.Add(cmb_categoria.Text);
			cmb_cantidad.Text = "";
			cmb_proveedor.Text = "";
			cmb_categoria.Text = "";

		}
	}
}
