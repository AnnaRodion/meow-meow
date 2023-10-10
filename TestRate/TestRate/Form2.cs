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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal S = Rates.Rates.HardRate(
               Convert.ToDecimal(txtBj.Text),
               Convert.ToDecimal(txtBm.Text),
               Convert.ToDecimal(txtBn.Text), 
               Convert.ToDecimal(txtBP.Text));
            lblS.Text = S.ToString("F2");
        }
    }
}
