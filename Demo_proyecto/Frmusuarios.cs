using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_entidad;
using Demo_proyecto.Utilidades;
using Capa_negocio;
using System.Drawing.Text;
using System.Windows.Media;


namespace Demo_proyecto
{
    public partial class Frmusuarios : Form
    {
        public Frmusuarios()
        {
            InitializeComponent();
        }

        private void Frmusuarios_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new Opcioncombo(){Valor = 1, Texto = "Activo"});
            cboestado.Items.Add(new Opcioncombo(){ Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto"; //Lo que muestra en pantalla
            cboestado.ValueMember = "Valor"; //Lo que no muestra para que salga activo y no activo
            cboestado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_rol().Listar();
            foreach (Rol item in listaRol)
            {
                //cborol.Items.Add(new Opcioncombo() { Valor = item.IDRol, Texto = item.Descripcion });
            }
          //  cborol.DisplayMember = "Texto"; //Lo que muestra en pantalla
           // cborol.ValueMember = "Valor"; //Lo que no muestra para que salga activo y no activo
            //cborol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "Btnseleccionar")
                {
                    cbobusqueda.Items.Add(new Opcioncombo() { Valor = columna.Name, Texto = columna.HeaderText }); //Si la columna es visible es almacenada en el combo box busqueda
                }
                cbobusqueda.DisplayMember = "Texto"; //Lo que muestra en pantalla
                cbobusqueda.ValueMember = "Valor"; //Lo que no muestra para que salga activo y no activo                   
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //dgvdata.Rows.Add(new object[]
           // {
                //"",txtclave.Text,txtdocumento.Text,txtnombrecompleto.Text,txtcorreo.Text,txtclave.Text,((Opcioncombo)cborol.SelectedItem).Valor.ToString(), //Obtenemos el item y lo colocamos en el combo box
                 // ((Opcioncombo)cborol.SelectedItem).Texto.ToString(),
                 // ((Opcioncombo)cboestado.SelectedItem).Valor.ToString(),
                  //((Opcioncombo)cboestado.SelectedItem).Texto.ToString(),

            }
            //Limpiar();


        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void cboestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtnombrecompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtconfirmarclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void cborol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cbobusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
