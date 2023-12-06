namespace Farmacia_sis.CRUDs
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxProveedores = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(23)))), ((int)(((byte)(70)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(102, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(23)))), ((int)(((byte)(70)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(200, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(221, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Presentacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(221, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cantidad Disponible";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(35, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Caducidad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(23)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 32);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(380, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(221, 83);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(35, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 23);
            this.txtNombre.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(47, 192);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(308, 23);
            this.txtDescripcion.TabIndex = 13;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(47, 248);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(87, 23);
            this.txtPrecio.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Unidad",
            "Empaque",
            "Empaque 10 tabletas",
            "Empaque 3 tabletas",
            "Frasco",
            "Caja"});
            this.comboBox1.Location = new System.Drawing.Point(221, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 23);
            this.comboBox1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(200, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Proveedor";
            // 
            // comboBoxProveedores
            // 
            this.comboBoxProveedores.FormattingEnabled = true;
            this.comboBoxProveedores.Items.AddRange(new object[] {
            "Empaque, 10 tabletas"});
            this.comboBoxProveedores.Location = new System.Drawing.Point(200, 248);
            this.comboBoxProveedores.Name = "comboBoxProveedores";
            this.comboBoxProveedores.Size = new System.Drawing.Size(196, 23);
            this.comboBoxProveedores.TabIndex = 18;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(41, 130);
            this.txtFecha.Mask = "00/00/00";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(56, 23);
            this.txtFecha.TabIndex = 19;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            this.txtFecha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(102, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "m/d/a";
            // 
            // AgregarProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(417, 406);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.comboBoxProveedores);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProducto";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Button button3;
        private TextBox txtCantidad;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private ComboBox comboBox1;
        private Label label8;
        private ComboBox comboBoxProveedores;
        private MaskedTextBox txtFecha;
        private Label label4;
    }
}