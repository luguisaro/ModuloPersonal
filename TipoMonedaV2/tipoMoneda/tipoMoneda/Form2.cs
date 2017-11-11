using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tipoMoneda
{
    public partial class Form2 : Form
    {
        string Num_form = "5302";
        public Form2()
        {
            InitializeComponent();
        }

        private void tipoCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamada al form3 del reporte
            Form4 frm4 = new Form4();
            frm4.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
