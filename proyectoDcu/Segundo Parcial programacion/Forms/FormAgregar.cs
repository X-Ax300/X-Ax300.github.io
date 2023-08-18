using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Drawing.Configuration;

namespace Segundo_Parcial_programacion.Forms
{
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paneladd.BackColor = Color.Black;
            Direccion_label.ForeColor = Color.White;
            Nombre_Label.ForeColor = Color.White;
            Apellido_label.ForeColor = Color.White;
            Telefono_label.ForeColor = Color.White;
            FechaNac_Label.ForeColor = Color.White;
        }

        private void Aceptar_add_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas agregar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string connectionString = "server=ALEXANDER\\SQLEXPRESS;Integrated Security=yes;Database=agenda_electronica";
                SqlConnection Connection = new SqlConnection(connectionString);
                Connection.Open();

                string Nombre = Nombre_TextBox.Text;
                string Apellido = Apellido_TextBox.Text;
                string Direccion = Direccion_TextBox.Text;
                DateTime date = dateTimePicker1_Textbox.Value;
                string Celular = Celular_TextBox.Text;

                SqlCommand command = new SqlCommand("insert into agenda_electronicatable (Nombre, Apellido, Direccion, FechaNacimiento, Celular) Values (@Nombre, @Apellido, @Direccion, @FechaNacimiento, @Celular)", Connection);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Apellido", Apellido);
                command.Parameters.AddWithValue("@Direccion", Direccion);
                command.Parameters.AddWithValue("@FechaNacimiento", date);
                command.Parameters.AddWithValue("@Celular", Celular);
                command.ExecuteNonQuery();
                MessageBox.Show("Se agregó satisfactoriamente.");

                Connection.Close();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Personalizar_add_label_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Paneladd.BackColor = Color.White;
            Direccion_label.ForeColor = Color.Black;
            Nombre_Label.ForeColor = Color.Black;
            Apellido_label.ForeColor = Color.Black;
            Telefono_label.ForeColor = Color.Black;
            FechaNac_Label.ForeColor = Color.Black;
        }
    }
}
