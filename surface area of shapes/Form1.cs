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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Form2();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Cube();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Form3();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Form4();
            newForm.Show();
        }
    }
}
