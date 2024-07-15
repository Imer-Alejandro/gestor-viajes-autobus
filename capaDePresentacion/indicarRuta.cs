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
    public partial class indicarRuta : Form
    {
        private OperacionesNegocio operacionesNegocio; // Instancia de la capa de negocio
        public string OperacionDeseada { get; private set; }
        public string nombreRutaSeleccionada { get; private set; }

        public Form1 mainForm;

        public indicarRuta(string operacionDeseada, Form1 mainForm)
        {
            InitializeComponent();
            operacionesNegocio = new OperacionesNegocio(); // Inicializa la instancia de la capa de negocio
            this.OperacionDeseada = operacionDeseada;
            CargarRutas(); // Llama al método para cargar rutas al cargar el formulario
            this.mainForm = mainForm;

        }

        private void indicarRuta_Load(object sender, EventArgs e)
        {
            CargarRutas(); // Llama al método para cargar rutas al cargar el formulario
        }


        public void CargarRutas()
        {
            DataTable rutas = operacionesNegocio.listadoRutas();
            selectorRutas.DataSource = rutas;
            selectorRutas.DisplayMember = "nombre"; // Ajusta el nombre de la columna según tu tabla
            selectorRutas.ValueMember = "id"; // Ajusta el nombre de la columna según tu tabla
        }
        private void selectorRutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí puedes manejar el evento cuando cambia la selección en el ComboBox de Rutas
            if (selectorRutas.SelectedItem != null)
            {
                nombreRutaSeleccionada = selectorRutas.SelectedItem.ToString();
                // Aquí puedes realizar cualquier acción necesaria con el nombre de la ruta seleccionada
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OperacionDeseada == "eliminar")
            {
                try
                {
                    operacionesNegocio.EliminarRuta(nombreRutaSeleccionada);
                    MessageBox.Show("Ruta eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mainForm.CargarRutas();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar la ruta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
