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
    public partial class Form4 : Form
    {
        public Form4()
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
            double l = Convert.ToDouble(textBox1.Text);

            double h = Convert.ToDouble(textBox2.Text);

            double w = Convert.ToDouble(textBox3.Text);

            double s = ;

            label3.Text = "The Answer is " + s;
        }
    }
}
