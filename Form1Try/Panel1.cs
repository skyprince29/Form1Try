using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1Try
{
    public partial class Panel1 : UserControl
    {
        public static Panel1 form1Instance;
        public TextBox paneltbx;

        public Panel1()
        {
            InitializeComponent();
            form1Instance = this;
            paneltbx = paneltb;

        }

        private void Panel1_Load(object sender, EventArgs e)
        {

        }

        private void panelbtn_Click(object sender, EventArgs e)
        {
            Form2Try fm2 = new Form2Try();
            fm2.Show();
        }

        private void paneltb_TextChanged(object sender, EventArgs e)
        {
            ///changesni
            Form2Try fm2 = new Form2Try();
            fm2.Show();
        }
    }
}
