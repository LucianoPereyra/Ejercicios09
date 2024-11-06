using Ejercicio.Datos;
using Ejercicio5.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercio5.Windows
{
    public partial class frmTemperaturasAE : Form
    {
        private Temperatura? tempFormulario;
        private readonly Repositorio repositorio;
        private List<Temperatura>? lista;

        public frmTemperaturasAE()
        {
            InitializeComponent();
            repositorio = new Repositorio();
        }

        private void frmTemperaturasAE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                if (ValidarDatos())
                {
                    // Obtener el valor en Celsius desde el textbox
                    double celsius = double.Parse(txtTemperatura.Text);

                    // Calcular Reaumur y Fahrenheit
                    double reaumur = 0.8 * celsius;
                    double fahrenheit = 1.8 * celsius + 32;

                    // Crear una nueva instancia de Temperatura
                    var nuevaTemperatura = new Temperatura
                    {
                        Celsius = celsius,
                        Reamur = reaumur,
                        Fahrenheit = fahrenheit
                    };

                    // Agregar la temperatura al repositorio
                    repositorio.AgregarTemperatura(nuevaTemperatura);

                    // Actualizar la lista o grilla
                    ActualizarCantidadRegistros();

                    // Limpiar el campo de entrada
                    txtTemperatura.Clear();
                }
            }


        }



        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            double celsius;

            // Validar que el texto ingresado sea un número válido y positivo
            if (!double.TryParse(txtTemperatura.Text, out celsius) || celsius < 0)
            {
                valido = false;
                errorProvider1.SetError(txtTemperatura, "Temperatura no válida!!!");
            }

            // Verificar si ya existe el registro de esa temperatura (opcional)
            if (repositorio.ExisteTemperatura(celsius))
            {
                valido = false;
                errorProvider1.SetError(txtTemperatura, "Temperatura existente!!!");
            }

            return valido;
        }
    

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
