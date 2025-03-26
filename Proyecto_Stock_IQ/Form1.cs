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
            guna2TextBox1.Text = "";
            guna2TextBox1.PlaceholderText = "Escribe aquí...";
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDocumento_Enter(object sender, EventArgs e)
        {
            if (textBoxDocumento.Text == "Escribe aquí...") {
                textBoxDocumento.Text = "";
                textBoxDocumento.ForeColor = Color.Black; // Cambia el color al escribir
            }
        }

        private void textBoxDocumento_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxDocumento.Text)) {
                guna2TextBox1.PlaceholderText = "Escribe aquí...";
                guna2TextBox1.PlaceholderForeColor = Color.Gray;
            }
        }
    }
}
