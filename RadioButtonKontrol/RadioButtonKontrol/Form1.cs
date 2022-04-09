using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control rb in groupBox1.Controls)
            {
                if (((RadioButton)rb).Checked)
                {
                    label1.Text = "Seçiminiz : " + rb.Text;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control rb in groupBox1.Controls)
            {
                if (((RadioButton)rb).Checked)
                {
                    MessageBox.Show( "Seçiminiz : " + rb.Text);
                }
            }
        }
    }
}
