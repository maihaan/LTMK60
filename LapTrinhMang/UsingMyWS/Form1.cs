using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingMyWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGPT_Click(object sender, EventArgs e)
        {
            MyService.MyWS ms = new MyService.MyWS();
            float a = float.Parse(tbA.Text);
            float b = float.Parse(tbB.Text);
            float c = float.Parse(tbC.Text);
            MessageBox.Show(ms.GiaiPhuongTrinhBac2(a, b, c));
        }
    }
}
