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
    public partial class FormBuscar : Form
    {
        public FormBuscar()
        {
            InitializeComponent();
        }

        private void Buscar_label_mod_Click(object sender, EventArgs e)
        {

        }

        private void Find_btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection("Server=ALEXANDER\\SQLEXPRESS; database=agenda_electronica; Integrated security=true");
            Connection.Open();
            string b = buscar_box_mod.Text;
            string Find = "SELECT Nombre, Apellido, Direccion, Celular, FechaNacimiento FROM agenda_electronicatable WHERE ID = @codigo";
            SqlCommand command = new SqlCommand(Find, Connection);
            command.Parameters.AddWithValue("@codigo", b);
            SqlDataReader register = command.ExecuteReader();

            if (register.Read())
            {
                Nombre_label_search_delete.Text = register["Nombre"].ToString();
                Apellido_label_search_delete.Text = register["Apellido"].ToString();
                Direccion_label_search_delete.Text = register["Direccion"].ToString();
                Celular_label_search_delete.Text = register["Celular"].ToString();
                FechNac_label_search_delete.Text = register["FechaNacimiento"].ToString();

                
            }
            else
            {
                MessageBox.Show("Este código no existe");
            }
            Connection.Close();
            dataGridView_delete.Visible = true;
        }

        private void dataGridView_delete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Modo_claro_btn_mod_Click(object sender, EventArgs e)
        {
            panel.BackColor = Color.White;
            panelconfirmadelete.BackColor = Color.White;

            Text_Confirma_label_delete.ForeColor = Color.Black;
            Buscar_label_mod.BackColor = Color.Black;
            Digita_ID_Label_delete.ForeColor = Color.Black;
            Nombre_Label_delete.ForeColor = Color.Black;
            Nombre_label_search_delete.ForeColor = Color.Black;
            Celular_label_search_delete.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            Direccion_Label_delete.ForeColor = Color.Black;
            Direccion_label_search_delete.ForeColor = Color.Black;
            FechNac_Label_delete.ForeColor = Color.Black;
            FechNac_label_search_delete.ForeColor = Color.Black;
        }

        private void Modo_oscuro_btn_mod_Click(object sender, EventArgs e)
        {
            panel.BackColor = Color.Black;
            panelconfirmadelete.BackColor = Color.Black;

            Text_Confirma_label_delete.ForeColor = Color.White;
            Buscar_label_mod.BackColor = Color.White;
            Digita_ID_Label_delete.ForeColor = Color.White;
            Nombre_Label_delete.ForeColor = Color.White;
            Nombre_label_search_delete.ForeColor = Color.White;
            Apellido_Label_delete.ForeColor = Color.White;
            Apellido_label_search_delete.ForeColor = Color.White;
            Celular_label_search_delete.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            Direccion_Label_delete.ForeColor = Color.White;
            Direccion_label_search_delete.ForeColor = Color.White;
            FechNac_Label_delete.ForeColor = Color.White;
            FechNac_label_search_delete.ForeColor = Color.White;
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agenda_electronicaDataSet.agenda_electronicatable' table. You can move, or remove it, as needed.
            this.agenda_electronicatableTableAdapter.Fill(this.agenda_electronicaDataSet.agenda_electronicatable);

        }

        private void panelconfirmadelete_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
