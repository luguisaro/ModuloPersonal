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


namespace tipoMoneda
{
    public partial class Tipo : Form
    {

        //Variables para conexion con Base de Datos
        MySqlCommand cmd;
        MySqlConnection cn;
        DataTable dt;
        MySqlDataAdapter da;

        public Tipo()
        {
            InitializeComponent();
            //Comprueba la conexión y sus parámetros;
            try
            {
                cn = new MySqlConnection("server=localhost; Uid=root; Password=; Database=hotelsancarlos; Port=3306");
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

        private void btnguardar_Click(object sender, EventArgs e)
        {

            object marcado = cmbtipo.SelectedItem;
            object fecha = datepicker.Value.ToString("yyyy/MM/dd");
         try
            {
                //query para insertar datos en la BD
                cmd = new MySqlCommand("INSERT INTO moneda (idMoneda,moneda,valor,Fecha) VALUES ('" + txtid.Text + "', '" + cmbtipo.Text + "' , '" + txtval.Text + "','" + fecha.ToString()+ "'); ", cn);
             cmd.ExecuteNonQuery();
                txtid.Text = "";
                txtval.Text = "";
                MessageBox.Show("Ingresado");
                mostrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

        private void dataconsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //funciones para llenar el GriedView
            txtid.Text = dataconsulta.CurrentRow.Cells[0].Value.ToString();
            cmbtipo.Text = dataconsulta.CurrentRow.Cells[1].Value.ToString();
            txtval.Text = dataconsulta.CurrentRow.Cells[2].Value.ToString();

        }

        public void mostrar()
        {
            //metodo para mostrar y actualizar cada vez el datagriedview
            da = new MySqlDataAdapter("select idMoneda as Id, moneda as Tipo, valor as Valor, Fecha as Fecha from moneda;",cn);
            dt = new DataTable();
            da.Fill(dt);
            dataconsulta.DataSource = dt;
            dataconsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            object fecha = datepicker.Value.ToString("yyyy/MM/dd");

            try
            {
                //funciones para query de actualizar
                cmd = new MySqlCommand("UPDATE moneda set moneda ='" + cmbtipo.Text + "', valor ='" + txtval.Text + "', Fecha='"+ fecha.ToString()+"' where idMoneda= '" + txtid.Text + "' ", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizado");
                mostrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }



        }

        private void cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tipo_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void disponibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void disponibilidadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //llamada al otro form
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
