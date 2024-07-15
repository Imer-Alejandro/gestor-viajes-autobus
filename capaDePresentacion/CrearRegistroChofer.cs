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
    public partial class CrearRegistroChofer : Form
    {
        private Form1 mainForm;
        private OperacionesNegocio operacionesNegocio;
        public CrearRegistroChofer(Form1 mainForm)
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
            string nombre = nombreRegistroChofer.Text.Trim();
            string telefono = telefonoRegistroChofer.Text.Trim();
            string cedula = cedulaRegistroChofer.Text.Trim();
            DateTime fechaNacimiento = nacimientoRegistroChofer.Value;

            // Validar que todos los campos estén completos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar al método de la capa de negocio para crear el chofer
            try
            {
                operacionesNegocio.CrearChofer(nombre, telefono, cedula, fechaNacimiento);
                MessageBox.Show("Chofer registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.CargarChoferes();
                this.Close(); // Cerrar el formulario después de registrar el chofer
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el chofer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
