using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_negocio;
using Capa_entidad;

namespace Demo_proyecto
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            //Primero hacemos una lista
            Usuario usuario = new CN_Usuario().Login(txtdocumento.Text, txtclave.Text);

            
           // Usuario ousuario = new Usuario  /*Listar().FirstOrDefault(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text);*/ //expresiones landa toman acciones respecto a las listas, automatiza la búsqueda de un objeto en la lista de la base de datos. 

            if (usuario.IDUsuario != 0)
            {
                Inicio form = new Inicio(usuario);

                form.Show(); //Muestra el formulario
                this.Hide(); //Luego lo oculta cuando se ingresa

                form.FormClosing += frmclosing;

            }
            else
            {
                MessageBox.Show("No se encontró el usuario", "Mesanje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //boton cancela el ingreso
        }

        private void frmclosing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = ""; //Se limpian las cajas de texto
            txtclave.Text = "";
            this.Show(); //Se muestra el formulario de nuevo
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
