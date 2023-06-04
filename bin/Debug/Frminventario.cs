using Capa_entidad;
using Capa_negocio;
using Demo_proyecto.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_proyecto
{
    public partial class Frminventario : Form
    {
        public Frminventario()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Frminventario_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new Opcioncombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new Opcioncombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto"; //Lo que muestra en pantalla
            cboestado.ValueMember = "Valor"; //Lo que no muestra para que salga activo y no activo
            cboestado.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "Btnseleccionar")
                {
                    cbobusqueda.Items.Add(new Opcioncombo() { Valor = columna.Name, Texto = columna.HeaderText }); //Si la columna es visible es almacenada en el combo box busqueda
                }
                cbobusqueda.DisplayMember = "Texto"; //Lo que muestra en pantalla
                cbobusqueda.ValueMember = "Valor"; //Lo que no muestra para que salga activo y no activo                   
            }
            //Mostar Categorias

           // List<Categoria> lista = new CN_Categoria().Listar();

            //foreach (Categoria item in lista)
           // {
               // dgvdata.Rows.Add(new object[]{"",item.IDCategoria,
                    //item.Descripcion,
                    //item.Estado == true ? 1 : 0,
                   // item.Estado == true ? "Activo" : "No Activo"}
                    //);                             
           // }
        }

        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Producto objusuario = new Producto();
            {
                

            }
            
            Limpiar();
        }
        private void Limpiar()
        {   //Limpiar Usuarios
            txtname.Text = "0";
            txtdocumento.Text = "";          
            txtclave.Text = "";          
            cboestado.SelectedIndex = 0;
        }

    }
}
    
