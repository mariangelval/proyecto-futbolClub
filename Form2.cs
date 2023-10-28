using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futbol
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 nano = new Form3();
            Form2.ActiveForm.Hide();
            nano.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 nano = new Form1();
            Form2.ActiveForm.Hide();
            nano.Show();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
