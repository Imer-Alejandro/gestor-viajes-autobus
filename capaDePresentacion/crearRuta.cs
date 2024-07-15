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

namespace capaDePresentacion
{
    public partial class crearRuta : Form
    {
        private OperacionesNegocio operacionesNegocio;
        private Form1 mainForm;

        public crearRuta(Form1 mainForm)
        {
            InitializeComponent();
            operacionesNegocio = new OperacionesNegocio();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de la ruta del TextBox
            string nombreRuta = nombreRutaRegistro.Text;

            // Validar que el nombre de la ruta no esté vacío
            if (string.IsNullOrEmpty(nombreRuta))
            {
                MessageBox.Show("El nombre de la ruta no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar al método de la capa de negocio para crear la ruta
            try
            {
                operacionesNegocio.CrearRuta(nombreRuta);
                MessageBox.Show("Ruta creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.CargarRutas();
                this.Close(); // Cerrar el formulario después de crear la ruta
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear la ruta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
