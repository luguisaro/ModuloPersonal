using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace tipoMoneda
{
    public partial class monedaMaster : Form
    {


        //Variables para conexion con Base de Datos
        OdbcCommand cmd;
        OdbcConnection cn;
        DataTable dt;
        OdbcDataAdapter da;
        string Num_form = "5304";

        public monedaMaster()
        {
            InitializeComponent();
            //Comprueba la conexión y sus parámetros;
            try
            {
                cn = new OdbcConnection("Dsn=SanCarlos;");
                cn.Open();
                mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ingresoMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo frm = new Tipo();
            frm.Show();
            
        }

        private void disponibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disponibilidad frm = new disponibilidad();
            frm.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        public void mostrar()
        {
            //metodo para mostrar y actualizar cada vez el datagriedview
            da = new OdbcDataAdapter(" select moneda as Tipo, valor as Valor from moneda where idMoneda=(select max(idMoneda) from moneda where moneda='Dolares') union all select moneda as Tipo, valor as Valor from moneda where idMoneda=(select max(idMoneda) from moneda where moneda='Pesos') union all select moneda as Tipo, valor as Valor from moneda where idMoneda=(select max(idMoneda) from moneda where moneda='Libras') union all select moneda as Tipo, valor as Valor from moneda where idMoneda=(select max(idMoneda) from moneda where moneda='Euros') union all select moneda as Tipo, valor as Valor from moneda where idMoneda=(select max(idMoneda) from moneda where moneda='Lempiras') union all select moneda as Tipo, valor as Valor from moneda where idMoneda=(select max(idMoneda) from moneda where moneda='Colones');", cn);
            dt = new DataTable();
            da.Fill(dt);

            datadolar.DataSource = dt;
            datadolar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }
        private void datadolar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //funciones para llenar el GriedView
            datadolar.CurrentRow.Cells[0].Value.ToString();
            datadolar.CurrentRow.Cells[1].Value.ToString();
        }

    }
}
