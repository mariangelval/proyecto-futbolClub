namespace futbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nano = new Form2();
            Form1.ActiveForm.Hide();
            nano.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}