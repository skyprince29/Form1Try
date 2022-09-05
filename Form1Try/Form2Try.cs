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
    public partial class Form2Try : Form
    {
        public Form2Try()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel1.form1Instance.paneltbx.Text = textBox2.Text;
            //trylangmani hehehe
            //forda try lang tna ni
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //change ni liwat last
            //try liwat a hehehe
        }
    }
}
