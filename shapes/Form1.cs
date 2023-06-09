namespace shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(rl.Text);
            double y = Convert.ToDouble(rw.Text);
            double sum = x * y;
            label4.Text = "Area is: " + sum.ToString();

        }

        private void rl_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(rl.Text);
            double y = Convert.ToDouble(rw.Text);
            double sum = 2 * x + 2 * y;
            label4.Text = "Perimeter is: " + sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }
    }
}