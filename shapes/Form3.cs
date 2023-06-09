using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(sa.Text);
            double y = Convert.ToDouble(sb.Text);
            double z = Convert.ToDouble(sc.Text);
            double sum = x + y + z;
            label4.Text = "Perimeter is: " + sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(sa.Text);
            double y = Convert.ToDouble(sb.Text);
            double z = Convert.ToDouble(sc.Text);
            double s = (x + y + z / 2);
            double sum = Math.Sqrt(s * (s - x + s - y + s - z));
            label4.Text = "Area is: " + sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }
    }
}
