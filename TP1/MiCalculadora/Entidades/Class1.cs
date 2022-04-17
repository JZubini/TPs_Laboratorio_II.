using System;
using System.Text;
namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando()
        {
            numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.numero = Convert.ToDouble(strNumero);
        }

        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }


        public double ValidarOperando(string strNumero)
        {
            double numeroConvertido;
            double.TryParse(strNumero, out numeroConvertido);
            return numeroConvertido;
        }

        private bool EsBinario(string binario)
        {
            foreach (char item in binario)
            {
                if (item != '0' && item != '1')
                {
                    return false;
                }
            }
            return true;
        }

        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                int potencias;
                double acumuladorOperacion;
                potencias = binario.Length;
                potencias--;
                acumuladorOperacion = 0;
                foreach (char item in binario)
                {
                    acumuladorOperacion = acumuladorOperacion + (Char.GetNumericValue(item) * Math.Pow(2, potencias));
                    potencias--;
                }
                return acumuladorOperacion.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }

        public string DecimalBinario(double numero)
        {
            double valorAbsoluto;
            int valorEntero;
            int operacionDivision;
            int operacionResto;
            StringBuilder retornoFuncion;
            valorAbsoluto = Math.Abs(numero);
            valorEntero = (int)Math.Floor(valorAbsoluto);
            retornoFuncion = new StringBuilder();
            do
            {
                operacionDivision = valorEntero / 2;
                operacionResto = valorEntero % 2;
                retornoFuncion.Append(operacionResto);
                valorEntero = operacionDivision;
            } while (valorEntero > 0);
            return retornoFuncion.ToString();
        }

        public string DecimalBinario(string numero)
        {
            double valorConvertido;
            double valorAbsoluto;
            int valorEntero;
            int operacionDivision;
            int operacionResto;
            StringBuilder retornoFuncion;
            valorConvertido = Convert.ToDouble(numero);
            valorAbsoluto = Math.Abs(valorConvertido);
            valorEntero = (int)Math.Floor(valorAbsoluto);
            retornoFuncion = new StringBuilder();
            do
            {
                operacionDivision = valorEntero / 2;
                operacionResto = valorEntero % 2;
                retornoFuncion.Append(operacionResto);
                valorEntero = operacionDivision;
            } while (valorEntero > 0);
            return retornoFuncion.ToString();
        }

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1,Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }

    }
    public static class Calculadora
    {

        public static double Operar(Operando num1, Operando num2, char operador)
        {
            operador = ValidarOperador(operador);
            switch (operador)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                default:
                    return num1 / num2;
            }
        }

        private static char ValidarOperador(char operando)
        {
            if(operando == '+' || operando == '-' || operando == '*' || operando == '/')
            {
                return operando;
            }
            return '+';
        }
    }
}