namespace Proyecto_Stock_IQ
{
    partial class Registrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.glbl_IniciarSesion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gtxt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Registrar = new System.Windows.Forms.Label();
            this.gpb_StockIQ = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gbtn_Ingresar = new Guna.UI2.WinForms.Guna2Button();
            this.gtxt_Documento = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxt_Nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpb_StockIQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(223)))));
            this.guna2Panel1.Controls.Add(this.glbl_IniciarSesion);
            this.guna2Panel1.Controls.Add(this.gtxt_Password);
            this.guna2Panel1.Controls.Add(this.gpb_StockIQ);
            this.guna2Panel1.Controls.Add(this.gbtn_Ingresar);
            this.guna2Panel1.Controls.Add(this.gtxt_Documento);
            this.guna2Panel1.Controls.Add(this.gtxt_Nombre);
            this.guna2Panel1.Controls.Add(this.lbl_Registrar);
            this.guna2Panel1.Location = new System.Drawing.Point(525, 27);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(392, 434);
            this.guna2Panel1.TabIndex = 6;
            // 
            // glbl_IniciarSesion
            // 
            this.glbl_IniciarSesion.AutoSize = false;
            this.glbl_IniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.glbl_IniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glbl_IniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(137)))), ((int)(((byte)(113)))));
            this.glbl_IniciarSesion.Location = new System.Drawing.Point(80, 390);
            this.glbl_IniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.glbl_IniciarSesion.Name = "glbl_IniciarSesion";
            this.glbl_IniciarSesion.Size = new System.Drawing.Size(491, 229);
            this.glbl_IniciarSesion.TabIndex = 10;
            this.glbl_IniciarSesion.Text = "O da click aqui para iniciar sesión";
            this.glbl_IniciarSesion.Click += new System.EventHandler(this.glbl_IniciarSesion_Click);
            // 
            // gtxt_Password
            // 
            this.gtxt_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gtxt_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(89)))), ((int)(((byte)(22)))));
            this.gtxt_Password.BorderRadius = 15;
            this.gtxt_Password.BorderThickness = 2;
            this.gtxt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_Password.DefaultText = "";
            this.gtxt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(214)))), ((int)(((byte)(202)))));
            this.gtxt_Password.FocusedState.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.gtxt_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_Password.ForeColor = System.Drawing.Color.Black;
            this.gtxt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(33)))));
            this.gtxt_Password.Location = new System.Drawing.Point(31, 268);
            this.gtxt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gtxt_Password.Name = "gtxt_Password";
            this.gtxt_Password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(174)))), ((int)(((byte)(147)))));
            this.gtxt_Password.PlaceholderText = "Contraseña";
            this.gtxt_Password.SelectedText = "";
            this.gtxt_Password.Size = new System.Drawing.Size(327, 48);
            this.gtxt_Password.TabIndex = 9;
            // 
            // lbl_Registrar
            // 
            this.lbl_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registrar.ForeColor = System.Drawing.Color.Black;
            this.lbl_Registrar.Location = new System.Drawing.Point(115, 100);
            this.lbl_Registrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Registrar.Name = "lbl_Registrar";
            this.lbl_Registrar.Size = new System.Drawing.Size(243, 158);
            this.lbl_Registrar.TabIndex = 8;
            this.lbl_Registrar.Text = "Registrarse";
            // 
            // gpb_StockIQ
            // 
            this.gpb_StockIQ.BackColor = System.Drawing.Color.Transparent;
            this.gpb_StockIQ.Image = ((System.Drawing.Image)(resources.GetObject("gpb_StockIQ.Image")));
            this.gpb_StockIQ.ImageRotate = 0F;
            this.gpb_StockIQ.Location = new System.Drawing.Point(31, 21);
            this.gpb_StockIQ.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_StockIQ.Name = "gpb_StockIQ";
            this.gpb_StockIQ.Size = new System.Drawing.Size(296, 57);
            this.gpb_StockIQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gpb_StockIQ.TabIndex = 6;
            this.gpb_StockIQ.TabStop = false;
            // 
            // gbtn_Ingresar
            // 
            this.gbtn_Ingresar.BorderColor = System.Drawing.Color.Transparent;
            this.gbtn_Ingresar.BorderRadius = 20;
            this.gbtn_Ingresar.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbtn_Ingresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Ingresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Ingresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Ingresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Ingresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(179)))), ((int)(((byte)(21)))));
            this.gbtn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_Ingresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(20)))), ((int)(((byte)(18)))));
            this.gbtn_Ingresar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(179)))), ((int)(((byte)(21)))));
            this.gbtn_Ingresar.HoverState.ForeColor = System.Drawing.Color.LemonChiffon;
            this.gbtn_Ingresar.Location = new System.Drawing.Point(89, 338);
            this.gbtn_Ingresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbtn_Ingresar.Name = "gbtn_Ingresar";
            this.gbtn_Ingresar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.gbtn_Ingresar.PressedDepth = 45;
            this.gbtn_Ingresar.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.gbtn_Ingresar.Size = new System.Drawing.Size(216, 46);
            this.gbtn_Ingresar.TabIndex = 2;
            this.gbtn_Ingresar.Text = "Crear cuenta";
            this.gbtn_Ingresar.Click += new System.EventHandler(this.gbtn_Ingresar_Click);
            // 
            // gtxt_Documento
            // 
            this.gtxt_Documento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gtxt_Documento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(89)))), ((int)(((byte)(22)))));
            this.gtxt_Documento.BorderRadius = 15;
            this.gtxt_Documento.BorderThickness = 2;
            this.gtxt_Documento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_Documento.DefaultText = "";
            this.gtxt_Documento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_Documento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_Documento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_Documento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_Documento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(214)))), ((int)(((byte)(202)))));
            this.gtxt_Documento.FocusedState.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.gtxt_Documento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_Documento.ForeColor = System.Drawing.Color.Black;
            this.gtxt_Documento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(33)))));
            this.gtxt_Documento.Location = new System.Drawing.Point(31, 210);
            this.gtxt_Documento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gtxt_Documento.Name = "gtxt_Documento";
            this.gtxt_Documento.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(174)))), ((int)(((byte)(147)))));
            this.gtxt_Documento.PlaceholderText = "Documento de Identidad";
            this.gtxt_Documento.SelectedText = "";
            this.gtxt_Documento.Size = new System.Drawing.Size(327, 48);
            this.gtxt_Documento.TabIndex = 4;
            // 
            // gtxt_Nombre
            // 
            this.gtxt_Nombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(89)))), ((int)(((byte)(22)))));
            this.gtxt_Nombre.BorderRadius = 15;
            this.gtxt_Nombre.BorderThickness = 2;
            this.gtxt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_Nombre.DefaultText = "";
            this.gtxt_Nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_Nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_Nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_Nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_Nombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(214)))), ((int)(((byte)(202)))));
            this.gtxt_Nombre.FocusedState.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.gtxt_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_Nombre.ForeColor = System.Drawing.Color.Black;
            this.gtxt_Nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(33)))));
            this.gtxt_Nombre.Location = new System.Drawing.Point(31, 152);
            this.gtxt_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gtxt_Nombre.Name = "gtxt_Nombre";
            this.gtxt_Nombre.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(174)))), ((int)(((byte)(147)))));
            this.gtxt_Nombre.PlaceholderText = "Nombre";
            this.gtxt_Nombre.SelectedText = "";
            this.gtxt_Nombre.Size = new System.Drawing.Size(327, 48);
            this.gtxt_Nombre.TabIndex = 3;
            this.gtxt_Nombre.TextChanged += new System.EventHandler(this.gtxt_Nombre_TextChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(47, 48);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(387, 399);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(19)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(957, 492);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.registrar_Cierre_Ventana);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpb_StockIQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox gpb_StockIQ;
        private Guna.UI2.WinForms.Guna2Button gbtn_Ingresar;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_Documento;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_Nombre;
        private System.Windows.Forms.Label lbl_Registrar;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_Password;
        private Guna.UI2.WinForms.Guna2HtmlLabel glbl_IniciarSesion;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}