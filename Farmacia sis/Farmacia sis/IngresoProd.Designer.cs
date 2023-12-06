namespace Farmacia_sis
{
    partial class IngresoProd
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Presentacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Caducidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad entrante";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 23);
            this.textBox1.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(113, 212);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(113, 260);
            this.maskedTextBox2.Mask = "99999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox2.TabIndex = 9;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Proveedor";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Frasco",
            "Caja",
            "Sobre 12",
            "Sobre 10",
            "Sobre 5",
            "Sobre 2",
            "Unidad"});
            this.comboBox1.Location = new System.Drawing.Point(115, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 263);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 23);
            this.textBox2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Detalles";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(331, 93);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox3.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Codigo";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(331, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 19);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Producto existente";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(277, 212);
            this.maskedTextBox4.Mask = "99999";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox4.TabIndex = 21;
            this.maskedTextBox4.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Precio compra";
            // 
            // IngresoProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 404);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "IngresoProd";
            this.Text = "IngresoProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox3;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label6;
        private MaskedTextBox maskedTextBox3;
        private Button button3;
        private Label label8;
        private CheckBox checkBox1;
        private MaskedTextBox maskedTextBox4;
        private Label label7;
    }
}