using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Stock_IQ.IniciarSesion;
using static Proyecto_Stock_IQ.Registrar;

namespace Proyecto_Stock_IQ
{
    public partial class Registrar : Form
    {
        

        private List<Usuario> usuarios = new List<Usuario>(); //Lista que almacena a los objetos usuarios
        public class Usuario //Constructor
        {
            public string Nombre { get; set; }
            public string Documento { get; set; }
            public string Password { get; set; }
            public string Rol { get; set; }
            public Usuario(string nombre, string documento, string password, string rol)
            {
                Nombre = nombre;
                Documento = documento;
                Password = password;
                Rol = rol;
            }
        }
        public Registrar()
        {
            InitializeComponent();
            usuarios.Add(new Usuario("admin", "1010", "1010", "admin"));
        }

        private void gbtn_Ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gtxt_Nombre.Text) || string.IsNullOrWhiteSpace(gtxt_Documento.Text) || string.IsNullOrWhiteSpace(gtxt_Password.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Evita que se agregue un usuario sin datos
            }
            // Verifica si el usuario ya existe
            if (File.Exists(Globales.ArchivoUsuarios))
            {
                string[] lineas = File.ReadAllLines(Globales.ArchivoUsuarios);
                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split(',');
                    if (partes.Length >= 2)
                    {
                        string documentoArchivo = partes[1]; 
                        if (documentoArchivo == gtxt_Documento.Text)
                        {
                            MessageBox.Show("El usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            usuarios.Add(new Usuario(gtxt_Nombre.Text, gtxt_Documento.Text, gtxt_Password.Text, "Usuario")); //Agrega el usuario a la lista}
            //MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            try
            {
                if (usuarios.Count != 0)
                {
                    StreamWriter sw = new StreamWriter(Globales.ArchivoUsuarios, true);
                    for(int i = 0; i < usuarios.Count; i++)
                    {
                        sw.WriteLine($"{usuarios[i].Nombre},{usuarios[i].Documento},{usuarios[i].Password},{usuarios[i].Rol}");
                    }
                    sw.Close(); //Cierra el archivo
                }

                MessageBox.Show("Cuenta creada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gtxt_Nombre.Clear(); //Limpia el campo de nombre
                gtxt_Documento.Clear(); //Limpia el campo de documento
                gtxt_Password.Clear(); //Limpia el campo de contraseña

                HomePage homePage = new HomePage(); 
                homePage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void registrar_Cierre_Ventana(object sender, FormClosingEventArgs e)
        {
           
        }

        private void gtxt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
