using Entidades;
namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            Limpiar();
            operadores = new Operando();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            
            operandoUno.Clear();
            operandoDos.Clear();
            comboBoxOperadores.SelectedIndex = 0;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonOperar_Click(object sender, EventArgs e)
        {
            double resultadoOperacion;
            char operador;
            Operando primerOperando;
            Operando segundoOperando;
            if (operandoUno.Text is null || operandoDos.Text is null || comboBoxOperadores.Text == "")
            {
                listBoxOperaciones.Items.Add("Falta ingresar operadores");
            }
            else
            {
                operador = Convert.ToChar(comboBoxOperadores.Text);
                primerOperando = new Operando(operandoUno.Text);
                segundoOperando = new Operando(operandoDos.Text);
                resultadoOperacion = Calculadora.Operar(primerOperando, segundoOperando, operador);
                listBoxOperaciones.Items.Add(operandoUno.Text + operador + operandoDos.Text + "=" + resultadoOperacion + "d");
                lblResultado.Text = resultadoOperacion.ToString();
            }
        }

        private void botonBinario_Click(object sender, EventArgs e)
        {
            string resultadoABinario;
            string resultadoAnterior;
            resultadoAnterior = lblResultado.Text.ToString();
            resultadoABinario = operadores.DecimalBinario(resultadoAnterior);
            lblResultado.Text = resultadoABinario;
            listBoxOperaciones.Items.Add(resultadoAnterior + "d = " + resultadoABinario + "b");
        }

        private void botonDecimal_Click(object sender, EventArgs e)
        {
            string resultadoADecimal;
            string resultadoAnterior;
            resultadoAnterior = lblResultado.Text.ToString();
            resultadoADecimal = operadores.BinarioDecimal(resultadoAnterior);
            lblResultado.Text = resultadoADecimal;
            listBoxOperaciones.Items.Add(resultadoAnterior + "b = " + resultadoADecimal + "d");
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea salir?","Salir",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }
    }
}