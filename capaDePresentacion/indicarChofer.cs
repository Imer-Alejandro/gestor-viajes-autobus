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
    public partial class indicarChofer : Form
    {
        private OperacionesNegocio operacionesNegocio; // Instancia de la capa de negocio
        public string OperacionDeseada { get; private set; }
        public string nombreChoferSeleccionado { get; private set; }

        public Form1 mainForm;
        public indicarChofer(string operacionDeseada, Form1 mainForm)
        {
            InitializeComponent();
            operacionesNegocio = new OperacionesNegocio(); // Inicializa la instancia de la capa de negocio
            this.OperacionDeseada = operacionDeseada;
            CargarChoferes();
            this.mainForm = mainForm;
        }
        

        private void indicarChofer_Load(object sender, EventArgs e)
        {
            CargarChoferes(); // Llama al método para cargar choferes al cargar el formulario
        }

        public void CargarChoferes()
        {
            DataTable choferes = operacionesNegocio.listadoChoferes();
            selectorChofer.DataSource = choferes;
            selectorChofer.DisplayMember = "nombre"; // Ajusta el nombre de la columna según tu tabla
            selectorChofer.ValueMember = "id"; // Ajusta el nombre de la columna según tu tabla
        }

        private void selectorChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí puedes manejar el evento cuando cambia la selección en el ComboBox de Choferes
            nombreChoferSeleccionado = selectorChofer.SelectedItem.ToString();


        }

        private void indicarChofer_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                // Aquí puedes realizar cualquier acción necesaria con el nombre del chofer seleccionado
                if (OperacionDeseada == "eliminar")
                {
                    try
                    {
                        operacionesNegocio.EliminarChofer(nombreChoferSeleccionado,false);
                        MessageBox.Show("Chofer eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mainForm.CargarChoferes();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el chofer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else if(OperacionDeseada == "editar")
                    {
                // Crear una instancia del formulario indicarElementoOperacion
                editarChofer formEditarChofer = new editarChofer();

                // Mostrar el formulario
                formEditarChofer.Show();
            }

        }
    }
}
