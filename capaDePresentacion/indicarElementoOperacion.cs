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
    public partial class indicarElementoOperacion : Form
    {
        // Propiedades para almacenar el elemento seleccionado y la operación deseada
        public string ElementoSeleccionado { get; private set; }
        public string OperacionDeseada { get; private set; }
        public Form1 mainForm;

        public indicarElementoOperacion(string operacionDeseada, Form1 mainForm)
        {
            InitializeComponent();
            this.OperacionDeseada = operacionDeseada;
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //indicar cual es el siguiente form que se debe abrir 

            if (OperacionDeseada == "crear" && ElementoSeleccionado == "Ruta")
            {

                // Crear una instancia del formulario crear nuevo registro de ruta
                crearRuta formCrearRuta = new crearRuta(mainForm);

                // Mostrar el formulario
                formCrearRuta.ShowDialog();

                this.Close();
            }
            else if (OperacionDeseada == "crear" && ElementoSeleccionado == "Chofer")
            {

                CrearRegistroChofer formRegistroChofer = new CrearRegistroChofer(mainForm);

                // Mostrar el formulario
                formRegistroChofer.ShowDialog();

                this.Close();
            }
            else if (OperacionDeseada == "crear" && ElementoSeleccionado == "Guagua")
            {

                crearRegistroGuagua formCrearGuagua = new crearRegistroGuagua(mainForm);

                // Mostrar el formulario
                formCrearGuagua.ShowDialog();

                this.Close();
            }
            // operaciones distintas a las de creacion en la que se debe selecionar el elemento en cuestion
            else if ( ElementoSeleccionado == "Ruta")
            {
                // Crear una instancia del formulario indicarElementoOperacion
                indicarRuta formIndicarRuta = new indicarRuta(OperacionDeseada, mainForm);

                // Mostrar el formulario
                formIndicarRuta.ShowDialog();

                this.Close();
            }
            else if (ElementoSeleccionado == "Chofer")
            {
                // Crear una instancia del formulario indicarElementoOperacion
                indicarChofer formIdicarChofer = new indicarChofer(OperacionDeseada, mainForm);

                // Mostrar el formulario
                formIdicarChofer.ShowDialog();

                this.Close();
            }
            else if (ElementoSeleccionado == "Guagua")
            {
                // Crear una instancia del formulario indicarElementoOperacion
                indicarGuagua formIndicarGuagua = new indicarGuagua(OperacionDeseada);

                // Mostrar el formulario
                formIndicarGuagua.ShowDialog();

                this.Close();
            }

            this.Close();


        }

        private void selectorOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectorOperaciones.SelectedItem != null)
            {
                ElementoSeleccionado = selectorOperaciones.SelectedItem.ToString();
            }
        }
    }
}
