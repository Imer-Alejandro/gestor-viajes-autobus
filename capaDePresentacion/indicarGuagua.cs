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
    public partial class indicarGuagua : Form
    {
        private OperacionesNegocio operacionesNegocio; // Instancia de la capa de negocio
        public string OperacionDeseada { get; private set; }
        public string descripcionGuaguaSeleccionada { get; private set; }

        public Form1 mainForm;

        public indicarGuagua(string operacionDeseada, Form1 mainForm)
        {
            InitializeComponent();
            operacionesNegocio = new OperacionesNegocio(); // Inicializa la instancia de la capa de negocio
            this.OperacionDeseada = operacionDeseada;
            CargarGuaguas(); // Llama al método para cargar guaguas al cargar el formulario
            this.mainForm = mainForm;

        }

        private void indicarGuagua_Load(object sender, EventArgs e)
        {
            CargarGuaguas(); // Llama al método para cargar guaguas al cargar el formulario
        }

        public void CargarGuaguas()
        {
            DataTable guaguas = operacionesNegocio.listadoGuaguas();
            selectorGuagua.DataSource = guaguas;
            selectorGuagua.DisplayMember = "marca"; // Ajusta el nombre de la columna según tu tabla
            selectorGuagua.ValueMember = "id"; // Ajusta el nombre de la columna según tu tabla
        }
        private void selectorGuagua_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí puedes manejar el evento cuando cambia la selección en el ComboBox de Guaguas
            if (selectorGuagua.SelectedItem != null)
            {
                descripcionGuaguaSeleccionada = selectorGuagua.SelectedItem.ToString();
                // Aquí puedes realizar cualquier acción necesaria con la descripción de la guagua seleccionada
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OperacionDeseada == "eliminar")
            {
                try
                {
                    operacionesNegocio.EliminarGuagua(descripcionGuaguaSeleccionada);
                    MessageBox.Show("Guagua eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mainForm.CargarGuaguas();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar la Guagua: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
