using Ejercicio.Datos;
using Ejercicio5.Entidades;
using Ejercio5.Windows;
using static Ejercicio.Datos.Repositorio;

namespace frmTemperaturas
{
    public partial class frmTemperaturas : Form
    {
        private readonly Repositorio repositorio;

        private List<Temperatura>? lista;

      

        public frmTemperaturas()
        {
            InitializeComponent();
            repositorio = new Repositorio();            
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            var cantidad = repositorio.GetCantidad();
            ActualizarCantidadRegistros();
            if (cantidad == 0)
            {
                MessageBox.Show("No hay circunferencias todavía!!!",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lista = repositorio.GetLista();
                MostrarDatosEnGrilla();
            }
        }

        private void AgregarFila(DataGridViewRow fila, DataGridView dgv)
        {
            dgv.Rows.Add(fila);
        }

        private void SetearFila(DataGridViewRow fila, Temperatura temperatura)
        {
            fila.Cells[ColumnaGrados.Index].Value = temperatura.Celsius;
            fila.Cells[ColumnaReaumur.Index].Value = temperatura.Reaumur;
            fila.Cells[ColumnaFahrenheit.Index].Value = temperatura.Fahrenheit;
        }

        private DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            var fila = new DataGridViewRow();
            fila.CreateCells(dgv);
            return fila;
        }

        private void ActualizarCantidadRegistros()
        {
            txtCantidad.Text = repositorio.GetCantidad().ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var TempAgregada in lista!)
            {
                var r = ConstruirFila(dgvDatos);
                SetearFila(r, TempAgregada);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            frmTemperaturasAE frm = new frmTemperaturasAE() { Text = "Agregar Temperatura" };
            DialogResult dr = frm.ShowDialog(this);
        }
    }
}
