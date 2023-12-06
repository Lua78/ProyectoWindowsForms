namespace Farmacia_sis
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnDown = new System.Windows.Forms.PictureBox();
            this.btnUp = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.MenuIzquierdo = new System.Windows.Forms.Panel();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.MenuIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.BarraTitulo.Controls.Add(this.btnMinimize);
            this.BarraTitulo.Controls.Add(this.btnDown);
            this.BarraTitulo.Controls.Add(this.btnUp);
            this.BarraTitulo.Controls.Add(this.btnClose);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 35);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1201, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(1232, 7);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 25);
            this.btnDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDown.TabIndex = 4;
            this.btnDown.TabStop = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            this.btnDown.MouseLeave += new System.EventHandler(this.btnDown_MouseLeave);
            this.btnDown.MouseHover += new System.EventHandler(this.btnDown_MouseHover);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(1232, 7);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 25);
            this.btnUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUp.TabIndex = 3;
            this.btnUp.TabStop = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            this.btnUp.MouseLeave += new System.EventHandler(this.btnUp_MouseLeave);
            this.btnUp.MouseHover += new System.EventHandler(this.btnUp_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1263, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // MenuIzquierdo
            // 
            this.MenuIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(165)))), ((int)(((byte)(190)))));
            this.MenuIzquierdo.Controls.Add(this.btnClientes);
            this.MenuIzquierdo.Controls.Add(this.btnProveedores);
            this.MenuIzquierdo.Controls.Add(this.btnFacturas);
            this.MenuIzquierdo.Controls.Add(this.btnInicio);
            this.MenuIzquierdo.Controls.Add(this.pictureBox1);
            this.MenuIzquierdo.Controls.Add(this.btnProductos);
            this.MenuIzquierdo.Controls.Add(this.button3);
            this.MenuIzquierdo.Controls.Add(this.button2);
            this.MenuIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuIzquierdo.Location = new System.Drawing.Point(0, 35);
            this.MenuIzquierdo.Name = "MenuIzquierdo";
            this.MenuIzquierdo.Size = new System.Drawing.Size(220, 615);
            this.MenuIzquierdo.TabIndex = 1;
            this.MenuIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuIzquierdo_Paint);
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(165)))), ((int)(((byte)(190)))));
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.Location = new System.Drawing.Point(0, 318);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(214, 30);
            this.btnFacturas.TabIndex = 7;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(165)))), ((int)(((byte)(190)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(0, 174);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(214, 30);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(165)))), ((int)(((byte)(190)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(0, 282);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(214, 30);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(165)))), ((int)(((byte)(190)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "Reportes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(165)))), ((int)(((byte)(190)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Facturacion";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(75)))));
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(220, 35);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1080, 615);
            this.Contenedor.TabIndex = 2;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(165)))), ((int)(((byte)(190)))));
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Location = new System.Drawing.Point(0, 246);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(214, 30);
            this.btnProveedores.TabIndex = 8;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(165)))), ((int)(((byte)(190)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(0, 210);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(214, 30);
            this.btnClientes.TabIndex = 9;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.MenuIzquierdo);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.MenuIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel BarraTitulo;
        private Panel MenuIzquierdo;
        private Button button2;
        private Button button3;
        private Panel Contenedor;
        private Button btnProductos;
        private PictureBox btnClose;
        private PictureBox pictureBox1;
        private PictureBox btnUp;
        private PictureBox btnMinimize;
        private PictureBox btnDown;
        private Button btnInicio;
        private Button btnFacturas;
        private Button btnClientes;
        private Button btnProveedores;
    }
}