using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp; //Importar libreria de iconos
using Capa_entidad;
using Capa_negocio;
using Demo_proyecto.Modales;

namespace Demo_proyecto
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private IconMenuItem menucompras;

        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);

        }

        //Structs
        private struct RGBColor
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(218, 247, 166);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(255, 195, 0);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(255, 87, 51);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(199, 0, 57);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(144, 12, 63);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(88, 24, 69);

        }



        //Metodo

        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Panel Izquiero de botón
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.Color.FromArgb(252, 190, 98);
                currentBtn.ForeColor = System.Drawing.Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color2);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color4);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color5);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color6);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {

        }

        private void Abrirformulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = System.Drawing.Color.AliceBlue; //Colo de fondo

            }
           
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill; //Ocupe todo el espacio
            //formulario.BackColor = System.Drawing.Color.DarkOrange;

            btnsalir.Controls.Add(formulario); //Agg el form al contenedor
            formulario.Show(); //Se muestra el formulario

        }

        private void menuusario_Click(object sender, EventArgs e)
        {
            Abrirformulario((IconMenuItem)sender, new Frmusuarios());

        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menumantenedor_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            List<Permiso> listaPermisos = new CN_Permiso().Listar(usuarioActual.IDUsuario);

            foreach (IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = listaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }

            lblusuario.Text = usuarioActual.Nombrecompleto; //Momento en que carga la página

        }

        private void menuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            Abrirformulario((IconMenuItem)sender, new Frmproveedores());
        }


        private void Submenuregistrarventa_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuventas, new Frmventas());
        }

        private void Submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuventas, new FrmdetalleVenta());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            Abrirformulario((IconMenuItem)sender, new Frmclientes());
        }

        private void menuinventario_Click(object sender, EventArgs e)
        {
            Abrirformulario((IconMenuItem)sender, new Frminventario());
        }

        private void Submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            Abrirformulario(menucompras, new Frmcompras(usuarioActual));
        }

        private void submenuverdetallecompras_Click(object sender, EventArgs e)
        {
            Abrirformulario(menucompras, new FrmdetalleCompra());
        }

        private void menuacercade_Click(object sender, EventArgs e)
        {
            mdAcerdade md = new mdAcerdade();
            md.ShowDialog();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?","Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            {

            }
        }
    }
}
