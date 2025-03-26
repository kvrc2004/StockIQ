using Guna.UI2.WinForms;
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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gtxt_Password.Text = "";
            gtxt_Password.PlaceholderText = "Escribe aquí...";
        }

        private void gtxt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void glbl_IniciarSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
