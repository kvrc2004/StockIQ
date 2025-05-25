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
    public partial class HomePage : Form
    {

        private void CierreVentana(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0); //Cierra toda la ventana
        }
        public HomePage()
        {
            InitializeComponent();
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void listView_stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_stock.BackColor = Color.FromArgb(246, 241, 236);
        }
    }
}
