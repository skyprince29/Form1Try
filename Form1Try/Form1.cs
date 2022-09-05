using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1Try
{
    public partial class Form1 : Form
    {

        public static Form1 form1Instance;
        public TextBox tbx;

        public Form1()
        {
            InitializeComponent();
            form1Instance = this;
            tbx = textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2Try fm2 = new Form2Try();
            fm2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
