namespace Farmacia_sis
{
    partial class ContenedorReportes
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnCargar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(75)))));
            this.panelSuperior.Controls.Add(this.btnCargar);
            this.panelSuperior.Controls.Add(this.comboBox1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1075, 67);
            this.panelSuperior.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(11)))), ((int)(((byte)(54)))));
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(865, 25);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(151, 25);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar Reporte";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Clientes Registrados",
            "Productos sin existencias",
            "Productos con existencias",
            "Productos mas Vendidos",
            "Proveedores",
            "Monto total Facturado"});
            this.comboBox1.Location = new System.Drawing.Point(653, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 67);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1075, 546);
            this.panelContenedor.TabIndex = 1;
            // 
            // ContenedorReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 613);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContenedorReportes";
            this.Text = "ContenedorReportes";
            this.Load += new System.EventHandler(this.ContenedorReportes_Load);
            this.panelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSuperior;
        private Panel panelContenedor;
        private Button btnCargar;
        private ComboBox comboBox1;
    }
}