namespace futbol
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            btnSalir2 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Plum;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Indigo;
            button1.Location = new Point(185, 130);
            button1.Name = "button1";
            button1.Size = new Size(114, 47);
            button1.TabIndex = 0;
            button1.Text = "Actividades";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Plum;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Indigo;
            button2.Location = new Point(337, 130);
            button2.Name = "button2";
            button2.Size = new Size(114, 47);
            button2.TabIndex = 1;
            button2.Text = "Socios";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Plum;
            button3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Indigo;
            button3.Location = new Point(496, 130);
            button3.Name = "button3";
            button3.Size = new Size(114, 47);
            button3.TabIndex = 2;
            button3.Text = "Profesores";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(275, 62);
            label1.Name = "label1";
            label1.Size = new Size(222, 34);
            label1.TabIndex = 3;
            label1.Text = "Menú Principal";
            // 
            // btnSalir2
            // 
            btnSalir2.BackColor = Color.Plum;
            btnSalir2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir2.ForeColor = Color.Indigo;
            btnSalir2.Location = new Point(674, 12);
            btnSalir2.Name = "btnSalir2";
            btnSalir2.Size = new Size(95, 43);
            btnSalir2.TabIndex = 4;
            btnSalir2.Text = "Salir";
            btnSalir2.UseVisualStyleBackColor = false;
            btnSalir2.Click += btnSalir2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Plum;
            button5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Indigo;
            button5.Location = new Point(12, 12);
            button5.Name = "button5";
            button5.Size = new Size(95, 43);
            button5.TabIndex = 5;
            button5.Text = "Volver";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(btnSalir2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button btnSalir2;
        private Button button5;
    }
}