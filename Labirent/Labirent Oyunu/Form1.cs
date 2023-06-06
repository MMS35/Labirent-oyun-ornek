using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Yandınız :(");
        }

        private void btnFinish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Kazandınız :)");
        }
    }
}
