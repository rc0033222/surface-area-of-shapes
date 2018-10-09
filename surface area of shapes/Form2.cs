using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace surface_area_of_shapes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Form1();
            newForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);

            double a = 4 * Math.PI * i * i;

            label2.Text = "The Answer is " + a;
        }
    }
}
