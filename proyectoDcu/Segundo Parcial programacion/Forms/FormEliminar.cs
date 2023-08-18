using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Segundo_Parcial_programacion.Forms
{
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void FechNac_label_search_delete_Click(object sender, EventArgs e)
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

                Eliminar_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Este código no existe");
            }
            Connection.Close();
            panel_confirma_delete.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormEliminar_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection("Server=ALEXANDER\\SQLEXPRESS; database=agenda_electronica; Integrated security=true");
            Connection.Open();
            string consulta = "select * from agenda_electronicatable";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, Connection);
            DataTable DataT = new DataTable();
            adapter.Fill(DataT);
            dataGridView_delete.DataSource = DataT;
        }

        private void modo_claro_btn_delete_Click(object sender, EventArgs e)
        {
            Panel_Datagried_delete.BackColor = Color.White;
            panel_confirma_delete.BackColor = Color.White;
            panel_ID_delete.BackColor = Color.White;


            Digita_ID_Label_delete.ForeColor = Color.Black;
            Nombre_Label_delete.ForeColor = Color.Black;
            Nombre_label_search_delete.ForeColor = Color.Black;
            Apellido_Label_delete.ForeColor= Color.Black;
            Apellido_Label_delete.ForeColor = Color.Black;
            Celular_Label_delete.ForeColor = Color.Black;
            Celular_label_search_delete.ForeColor = Color.Black;
            Direccion_Label_delete.ForeColor = Color.Black;
            Direccion_label_search_delete.ForeColor = Color.Black;
            FechNac_Label_delete.ForeColor = Color.Black;
            FechNac_label_search_delete.ForeColor = Color.Black;
            Text_Confirma_label_delete.ForeColor = Color.Black;
        }

        private void modo_oscuro_btn_delete_Click(object sender, EventArgs e)
        {
            Panel_Datagried_delete.BackColor = Color.Black;
            panel_confirma_delete.BackColor = Color.Black;
            panel_ID_delete.BackColor = Color.Black;
            

            Digita_ID_Label_delete.ForeColor = Color.White;
            Nombre_Label_delete.ForeColor = Color.White;
            Nombre_label_search_delete.ForeColor = Color.White;
            Apellido_label_search_delete.ForeColor = Color.White;
            Apellido_Label_delete.ForeColor = Color.White;
            Celular_Label_delete.ForeColor = Color.White;
            Celular_label_search_delete.ForeColor = Color.White;
            Direccion_Label_delete.ForeColor = Color.White;
            Direccion_label_search_delete.ForeColor = Color.White;
            FechNac_Label_delete.ForeColor = Color.White;
            FechNac_label_search_delete.ForeColor= Color.White;
            Text_Confirma_label_delete.ForeColor = Color.White;
        }

        private void buscar_box_mod_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_confirma_delete_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
        {

        }

        private void Text_Confirma_label_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
