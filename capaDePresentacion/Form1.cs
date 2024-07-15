using capaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDeNegocio;
namespace capaDePresentacion
{
    public partial class Form1 : Form
    {
        private OperacionesNegocio operacionesNegocio;
        public Form1()
        {
            InitializeComponent();
            operacionesNegocio = new OperacionesNegocio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarChoferes();
            CargarRutas();
            CargarGuaguas();
            CargarViajes();
        }

        public void CargarChoferes()
        {
            DataTable choferes = operacionesNegocio.ObtenerTodosLosChoferes();
            selectRegistroChofer.DataSource = choferes;
            selectRegistroChofer.DisplayMember = "nombre"; // Ajusta el nombre de la columna según tu tabla
            selectRegistroChofer.ValueMember = "id"; // Ajusta el nombre de la columna según tu tabla
        }

        public void CargarRutas()
        {
            DataTable rutas = operacionesNegocio.ObtenerTodasLasRutas();
            selectRegistroRuta.DataSource = rutas;
            selectRegistroRuta.DisplayMember = "nombre"; // Ajusta el nombre de la columna según tu tabla
            selectRegistroRuta.ValueMember = "id"; // Ajusta el nombre de la columna según tu tabla
        }

        public void CargarGuaguas()
        {
            DataTable guaguas = operacionesNegocio.ObtenerTodasLasGuaguas();
            selectRegistroGuagua.DataSource = guaguas;
            selectRegistroGuagua.DisplayMember = "marca"; // Ajusta el nombre de la columna según tu tabla
            selectRegistroGuagua.ValueMember = "id"; // Ajusta el nombre de la columna según tu tabla
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los elementos seleccionados de los ComboBox
                int choferId = Convert.ToInt32(selectRegistroChofer.SelectedValue);
                int rutaId = Convert.ToInt32(selectRegistroRuta.SelectedValue);
                int guaguaId = Convert.ToInt32(selectRegistroGuagua.SelectedValue);

                // Crear una instancia de la capa de negocio
                OperacionesNegocio operacionesNegocio = new OperacionesNegocio();

                // Llamar al método para registrar el viaje
                operacionesNegocio.CrearViaje(choferId, guaguaId, rutaId);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Viaje registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //actualizar los registros de los viajes y los selectores de elemento
                CargarChoferes();
                CargarRutas();
                CargarGuaguas();
                CargarViajes();

            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de excepción
                MessageBox.Show("Ocurrió un error al registrar el viaje: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario indicarElementoOperacion
            indicarElementoOperacion formIndicarElementoOperacion = new indicarElementoOperacion("crear", this);

            // Mostrar el formulario
            formIndicarElementoOperacion.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario indicarElementoOperacion
            indicarElementoOperacion formIndicarElementoOperacion = new indicarElementoOperacion("editar", this);

            // Mostrar el formulario
            formIndicarElementoOperacion.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario indicarElementoOperacion
            indicarElementoOperacion formIndicarElementoOperacion = new indicarElementoOperacion("eliminar", this);

            // Mostrar el formulario
            formIndicarElementoOperacion.Show();
        }

        private void CargarViajes()
        {
            try
            {
                // Limpiar el DataGridView
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Crear una instancia de la capa de negocio
                OperacionesNegocio operacionesNegocio = new OperacionesNegocio();

                // Obtener los datos de los viajes
                DataTable viajes = operacionesNegocio.ObtenerViajes();

                // Configurar las columnas del DataGridView basadas en las columnas del DataTable
                foreach (DataColumn column in viajes.Columns)
                {
                    dataGridView1.Columns.Add(column.ColumnName, column.ColumnName);
                }

                // Añadir filas al DataGridView basadas en las filas del DataTable
                foreach (DataRow row in viajes.Rows)
                {
                    dataGridView1.Rows.Add(row.ItemArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos de los viajes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void selectRegistroGuagua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del viaje desde el TextBox
                int idViaje = Convert.ToInt32(idViajeCompletado.Text);

                // Crear una instancia de la capa de negocio
                OperacionesNegocio operacionesNegocio = new OperacionesNegocio();

                // Llamar al método para marcar el viaje como completado
                operacionesNegocio.ActualizarEstadoViaje(idViaje, true);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Viaje marcado como completado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar los datos en el DataGridView
                CargarChoferes();
                CargarRutas();
                CargarGuaguas();
                CargarViajes();
                //limpiar el input
                idViajeCompletado.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un ID de viaje válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al marcar el viaje como completado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
