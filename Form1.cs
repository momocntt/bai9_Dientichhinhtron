using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai9_Dientichhinhtron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblKq_Click(object sender, EventArgs e)
        {
            double bk, chuvi, dientich;

            bk = Convert.ToDouble(txtBk.Text);

            if (rdbCv.Checked)
            {
                chuvi = 2 * Math.PI * bk;
                txtKq.Text = chuvi.ToString();
            }
            if (rdbDt.Checked)
            {
                dientich = (Math.PI * (bk * bk));
                txtKq.Text = dientich.ToString();
            }
        }

        private void txtKq_TextChanged(object sender, EventArgs e)
        {
            double So = double.Parse(txtBk.Text);
            double chuvi, dientich;
            if (rdbCv.Checked)
            {
                chuvi = Math.PI * (So * 2);
                txtKq.Text = chuvi.ToString();
            }
            if (rdbDt.Checked)
            {
                dientich = Math.PI * (So * So);
                txtKq.Text = dientich.ToString();

            }
        }
    }
}
