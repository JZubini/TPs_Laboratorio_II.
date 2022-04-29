using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            Limpiar();
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
                listBoxOperaciones.Items.Add(operandoUno.Text + operador + operandoDos.Text + "=" + resultadoOperacion);
            }
        }

        private void botonBinario_Click(object sender, EventArgs e)
        {
            double resultadoOperacion;
            char operador;
            Operando primerOperando;
            Operando segundoOperando;
            string numeroConvertido;
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
                numeroConvertido = primerOperando.DecimalBinario(resultadoOperacion);
                listBoxOperaciones.Items.Add(resultadoOperacion + "=" + numeroConvertido);
            }
        }

        private void botonDecimal_Click(object sender, EventArgs e)
        {
            double resultadoOperacionDouble;
            string resultadoOperacionString;
            char operador;
            Operando primerOperando;
            Operando segundoOperando;
            string numeroConvertido;
            if (operandoUno.Text is null || operandoDos.Text is null || comboBoxOperadores.Text == "")
            {
                listBoxOperaciones.Items.Add("Falta ingresar operadores");
            }
            else
            {  
                operador = Convert.ToChar(comboBoxOperadores.Text);
                primerOperando = new Operando(operandoUno.Text);
                segundoOperando = new Operando(operandoDos.Text);
                resultadoOperacionDouble = Calculadora.Operar(primerOperando, segundoOperando, operador);
                resultadoOperacionString = resultadoOperacionDouble.ToString();
                numeroConvertido = primerOperando.BinarioDecimal(resultadoOperacionString);
                listBoxOperaciones.Items.Add(resultadoOperacionString + "=" + numeroConvertido);
            }
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