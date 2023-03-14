using Coche_Windows_Forms_CS.Clases;

namespace Coche_Windows_Forms_CS
{

    public partial class Form1 : Form
    {
        // arreglo de coches o de mi objeto nuevomodelo que es una sub clase de la clase auto
        private NuevoModelo[] coches = new NuevoModelo[1000];
        private int nn;
        public Form1()
        {

            // Esta llamada es exigida por el diseñador.
            InitializeComponent();
            // Agregue cualquier inicialización después de la llamada a InitializeComponent().

            nn = 0;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MessageBox.Show("Eres un emprendedor que adquirio una fabrica de autos y tu deber ahora es proporcionar una lista de tus nuevos modelos de auto", "Contexto", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            // IDENTIFICAMOS EL POSIBLE ERROR INICIAL O PRINCIPAL EN EL PROGRAMA
            if (string.IsNullOrEmpty(txtMarca.Text) || string.IsNullOrEmpty(txtModelo.Text) || string.IsNullOrEmpty(cbMotor.Text))
            {
                MessageBox.Show("Debes llenar todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // hacemos uso de los arreglos de tipo object o arreglos de clases y pasamos los valores a sus propiedades
            coches[nn] = new NuevoModelo()
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Motor = cbMotor.SelectedItem.ToString(),
                Color = cbColor.SelectedItem.ToString()
            };

            // mostramos la peticion recien efectuada o emitida por el usuario y la mostramos ademas de antes usar nuestros metodos 
            // heredados y personalizados dentro de un contexto
            coches[nn].ToString();
            coches[nn].Chocar();
            dgvListaAutos.Rows.Add(coches[nn].Marca, coches[nn].Modelo, coches[nn].Motor, coches[nn].Color);
            // la variable "nn" se usa como indice del arreglo de tipos por lo que aumentamos su valor por 1
            // y asi no sobreescribimos los daatos de la peticion
            nn += 1;

            // limpiando los combobox y textbox dentro del formulario por temas de estetica y comodidad
            txtMarca.Clear();
            txtModelo.Clear();
            cbColor.SelectedIndex = -1;
            cbMotor.SelectedIndex = -1;
        }
    }

}