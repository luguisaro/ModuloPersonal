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
    public partial class disponibilidad : Form
    {
        string Num_form = "5302";
        public disponibilidad()
        {
            InitializeComponent();
        }

        private void tipoCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamada al form3 del reporte
            FormReporte frm4 = new FormReporte();
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
