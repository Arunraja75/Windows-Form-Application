using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arun008_Adhiyamaancollege
{
    public partial class Form1 : Form
    {
        Registration rg = new Registration();
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Registration_Click(object sender, EventArgs e)
        {
            rg.show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
