namespace Demo_proyecto
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.Submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            this.Submenuverdetalleventa = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuverdetallecompra = new FontAwesome.Sharp.IconMenuItem();
            this.Submenuregistrarcompra = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuverdetallecompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuinventario = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Panel();
            this.usuario = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menuventas,
            this.submenuverdetallecompra,
            this.menuclientes,
            this.menuproveedores,
            this.menuinventario,
            this.menuacercade});
            this.menu.Location = new System.Drawing.Point(0, 75);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1416, 78);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // menuusuarios
            // 
            this.menuusuarios.AutoSize = false;
            this.menuusuarios.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuusuarios.IconColor = System.Drawing.Color.Black;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuarios.IconSize = 50;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Size = new System.Drawing.Size(100, 74);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuusuarios.Click += new System.EventHandler(this.menuusario_Click);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenuregistrarventa,
            this.Submenuverdetalleventa});
            this.menuventas.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 50;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(100, 74);
            this.menuventas.Text = "Ventas";
            this.menuventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Submenuregistrarventa
            // 
            this.Submenuregistrarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Submenuregistrarventa.IconColor = System.Drawing.Color.Black;
            this.Submenuregistrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Submenuregistrarventa.Name = "Submenuregistrarventa";
            this.Submenuregistrarventa.Size = new System.Drawing.Size(158, 26);
            this.Submenuregistrarventa.Text = "Registrar";
            this.Submenuregistrarventa.Click += new System.EventHandler(this.Submenuregistrarventa_Click);
            // 
            // Submenuverdetalleventa
            // 
            this.Submenuverdetalleventa.Name = "Submenuverdetalleventa";
            this.Submenuverdetalleventa.Size = new System.Drawing.Size(158, 26);
            this.Submenuverdetalleventa.Text = "Ver Detalle";
            this.Submenuverdetalleventa.Click += new System.EventHandler(this.Submenuverdetalleventa_Click);
            // 
            // submenuverdetallecompra
            // 
            this.submenuverdetallecompra.AutoSize = false;
            this.submenuverdetallecompra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenuregistrarcompra,
            this.submenuverdetallecompras});
            this.submenuverdetallecompra.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.submenuverdetallecompra.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.submenuverdetallecompra.IconColor = System.Drawing.Color.Black;
            this.submenuverdetallecompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetallecompra.IconSize = 50;
            this.submenuverdetallecompra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuverdetallecompra.Name = "submenuverdetallecompra";
            this.submenuverdetallecompra.Size = new System.Drawing.Size(100, 74);
            this.submenuverdetallecompra.Text = "Compras";
            this.submenuverdetallecompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Submenuregistrarcompra
            // 
            this.Submenuregistrarcompra.Name = "Submenuregistrarcompra";
            this.Submenuregistrarcompra.Size = new System.Drawing.Size(158, 26);
            this.Submenuregistrarcompra.Text = "Registrar";
            this.Submenuregistrarcompra.Click += new System.EventHandler(this.Submenuregistrarcompra_Click);
            // 
            // submenuverdetallecompras
            // 
            this.submenuverdetallecompras.Name = "submenuverdetallecompras";
            this.submenuverdetallecompras.Size = new System.Drawing.Size(158, 26);
            this.submenuverdetallecompras.Text = "Ver Detalle";
            this.submenuverdetallecompras.Click += new System.EventHandler(this.submenuverdetallecompras_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.IconSize = 50;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(100, 74);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menuproveedores
            // 
            this.menuproveedores.AutoSize = false;
            this.menuproveedores.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuproveedores.IconColor = System.Drawing.Color.Black;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedores.IconSize = 50;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(100, 74);
            this.menuproveedores.Text = "Proveedores";
            this.menuproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click);
            // 
            // menuinventario
            // 
            this.menuinventario.AutoSize = false;
            this.menuinventario.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuinventario.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.menuinventario.IconColor = System.Drawing.Color.Black;
            this.menuinventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuinventario.IconSize = 50;
            this.menuinventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuinventario.Name = "menuinventario";
            this.menuinventario.Size = new System.Drawing.Size(100, 74);
            this.menuinventario.Text = "Inventario";
            this.menuinventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuinventario.Click += new System.EventHandler(this.menuinventario_Click);
            // 
            // menuacercade
            // 
            this.menuacercade.AutoSize = false;
            this.menuacercade.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuacercade.IconColor = System.Drawing.Color.Black;
            this.menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuacercade.IconSize = 50;
            this.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(100, 74);
            this.menuacercade.Text = "Acerca de";
            this.menuacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuacercade.Click += new System.EventHandler(this.menuacercade_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(190)))), ((int)(((byte)(98)))));
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1416, 75);
            this.menuTitulo.TabIndex = 2;
            this.menuTitulo.Text = "menuStrip2";
            this.menuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuTitulo_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(190)))), ((int)(((byte)(98)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Happy Waffle Sistema de Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsalir.Location = new System.Drawing.Point(0, 153);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnsalir.Size = new System.Drawing.Size(1416, 773);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.usuario.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.ForeColor = System.Drawing.SystemColors.Control;
            this.usuario.Location = new System.Drawing.Point(919, 23);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(66, 20);
            this.usuario.TabIndex = 5;
            this.usuario.Text = "Usuario:";
            this.usuario.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblusuario.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblusuario.Location = new System.Drawing.Point(991, 23);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(76, 20);
            this.lblusuario.TabIndex = 6;
            this.lblusuario.Text = "lblusuario";
            this.lblusuario.Click += new System.EventHandler(this.lblusuario_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 52;
            this.iconButton1.Location = new System.Drawing.Point(1092, 9);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(1, 4, 1, 1);
            this.iconButton1.Size = new System.Drawing.Size(65, 51);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 926);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menuinventario;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem submenuverdetallecompra;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private System.Windows.Forms.Panel btnsalir;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem Submenuregistrarventa;
        private System.Windows.Forms.ToolStripMenuItem Submenuverdetalleventa;
        private System.Windows.Forms.ToolStripMenuItem Submenuregistrarcompra;
        private System.Windows.Forms.ToolStripMenuItem submenuverdetallecompras;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

