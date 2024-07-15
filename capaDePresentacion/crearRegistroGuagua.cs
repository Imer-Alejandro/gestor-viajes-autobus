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
    public partial class crearRegistroGuagua : Form
    {
        private OperacionesNegocio operacionesNegocio;
        private Form1 mainForm;
        public crearRegistroGuagua(Form1 mainForm)
        {
            InitializeComponent();
            operacionesNegocio = new OperacionesNegocio();
            this.mainForm = mainForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los datos de los TextBox
            string marca = marcaGuaguaRegistro.Text.Trim();
            string modelo = modeloGuaguaRegistro.Text.Trim();
            string placa = placaGuaguaRegistro.Text.Trim();
            string color = colorGuaguaRegistro.Text.Trim();
            int aro;

            // Validar que todos los campos estén completos
            if (string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(color) || !int.TryParse(aroGuaguaRegistro.Text.Trim(), out aro))
            {
                MessageBox.Show("Todos los campos son obligatorios y el aro debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar al método de la capa de negocio para crear la guagua
            try
            {
                operacionesNegocio.CrearGuagua(marca, modelo, placa, color, aro);
                MessageBox.Show("Guagua registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.CargarGuaguas();
                this.Close(); // Cerrar el formulario después de registrar la guagua
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar la guagua: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
