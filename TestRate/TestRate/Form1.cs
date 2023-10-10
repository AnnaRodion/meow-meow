using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rates;

namespace TestRate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal S = Rates.Rates.SumRate(Convert.ToInt32(txtBt.Text), Convert.ToDecimal(txtBV.Text),
            Convert.ToInt32(txtBx.Text));
            lblS.Text = S.ToString();

        }

        private void lbls_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void txtBx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
