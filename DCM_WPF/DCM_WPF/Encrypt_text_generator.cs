using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCM_WPF
{
    public partial class Encrypt_text_generator : Form
    {
        public Encrypt_text_generator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Text = Cryptography.Encrypt(textBox1.Text);
            }
        }
    }
}
