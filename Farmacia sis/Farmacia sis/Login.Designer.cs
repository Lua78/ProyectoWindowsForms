namespace Farmacia_sis
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(448, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(34, 40);
            button1.TabIndex = 0;
            button1.Text = " ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(92, 175);
            label1.Name = "label1";
            label1.Size = new Size(86, 27);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(60, 238);
            label2.Name = "label2";
            label2.Size = new Size(120, 27);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(180, 181);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(180, 241);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(208, 29);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 49);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(14, 12);
            label3.Name = "label3";
            label3.Size = new Size(164, 27);
            label3.TabIndex = 7;
            label3.Text = "Inicio de Sesion";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(176, 318);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(212, 57);
            button2.TabIndex = 6;
            button2.Text = "Iniciar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 75);
            ClientSize = new Size(505, 527);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Button button2;
        private Label label3;
    }
}