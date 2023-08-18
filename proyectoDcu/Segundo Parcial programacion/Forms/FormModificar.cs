using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial_programacion.Forms
{
    public partial class FormModificar : Form
    {
        public FormModificar()
        {
            InitializeComponent();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel_mod_datagridview.BackColor = Color.White;
            Panel_Mod_info.BackColor = Color.White;

            Buscar_label_mod.ForeColor = Color.Black;
            Nombre_Label_mod.ForeColor = Color.Black;
            Apellido_Label_Mod.ForeColor = Color.Black;
            Telefono_Label_mod.ForeColor = Color.Black;
            Direccion_Label_Mod.ForeColor = Color.Black;
            Fecha_Nac_Label_Mod.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel_mod_datagridview.BackColor = Color.Black;
            Panel_Mod_info.BackColor = Color.Black;

            Buscar_label_mod.ForeColor = Color.White;
            Nombre_Label_mod.ForeColor = Color.White;
            Apellido_Label_Mod.ForeColor = Color.White;
            Telefono_Label_mod.ForeColor = Color.White;
            Direccion_Label_Mod.ForeColor = Color.White;
            Fecha_Nac_Label_Mod.ForeColor = Color.White;
        }

        private void Aceptar_btn_mod_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas modificar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlConnection Connection = new SqlConnection("Server=ALEXANDER\\SQLEXPRESS; database=agenda_electronica; Integrated security=true");
                Connection.Open();
                string Nombre = Nombre_Box_mod.Text;
                string Apellido = Apellido_Box_mod.Text;
                string Direccion = Direccion_Box_mod.Text;
                DateTime date = dateTimePicker_box_mod.Value;
                string Celular = Celular_Box_mod.Text;

                SqlCommand command = new SqlCommand("UPDATE agenda_electronicatable SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, FechaNacimiento = @FechaNacimiento WHERE Celular = @Celular", Connection);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Apellido", Apellido);
                command.Parameters.AddWithValue("@Direccion", Direccion);
                command.Parameters.AddWithValue("@FechaNacimiento", date);
                command.Parameters.AddWithValue("@Celular", Celular);
                command.ExecuteNonQuery();
                MessageBox.Show("Se modificó satisfactoriamente.");
                Connection.Close();
            }
        }

        private void dataGridViewModificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Refrescar_btn_mod_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection("Server=ALEXANDER\\SQLEXPRESS; database=agenda_electronica; Integrated security=true");
            Connection.Open();
            string consulta = "select * from agenda_electronicatable";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, Connection);
            DataTable Data = new DataTable();
            adapter.Fill(Data);
            dataGridViewModificar.DataSource = Data;
            Connection.Close( );

        }

        private void Direccion_Box_mod_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_box_mod_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Celular_Box_mod_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apellido_Box_mod_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_Box_mod_TextChanged(object sender, EventArgs e)
        {

        }

        private void Direccion_Label_Mod_Click(object sender, EventArgs e)
        {

        }

        private void Telefono_Label_mod_Click(object sender, EventArgs e)
        {

        }

        private void Fecha_Nac_Label_Mod_Click(object sender, EventArgs e)
        {

        }

        private void Apellido_Label_Mod_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_Label_mod_Click(object sender, EventArgs e)
        {

        }

        private void Panel_mod_datagridview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Buscar_label_mod_Click(object sender, EventArgs e)
        {

        }
    }
}
