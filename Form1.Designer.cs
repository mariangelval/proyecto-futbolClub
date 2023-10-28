namespace futbol
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblInicio = new Label();
            btnIngresar = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInicio.ForeColor = Color.Indigo;
            lblInicio.Location = new Point(283, 43);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(237, 34);
            lblInicio.TabIndex = 0;
            lblInicio.Text = "Club San Martín";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Plum;
            btnIngresar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.Indigo;
            btnIngresar.Location = new Point(283, 327);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(95, 43);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Plum;
            btnSalir.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Indigo;
            btnSalir.Location = new Point(437, 327);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 43);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(297, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 207);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 371);
            label2.Name = "label2";
            label2.Size = new Size(121, 60);
            label2.TabIndex = 4;
            label2.Text = "Integrantes:\r\nVanina Condorpocco\r\nIliana Duarte\r\nMariangel Valerio";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(141, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(lblInicio);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInicio;
        private Button btnIngresar;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}